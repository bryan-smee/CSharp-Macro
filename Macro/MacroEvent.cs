using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WindowsInput.Native;
using WindowsInput;
using System.Runtime.InteropServices;

namespace Macro
{
    [Serializable]
    abstract class MacroEvent
    {
        public abstract void doAction(ref bool work);
    }

    [Serializable]
    class WaitMacroEvent : MacroEvent
    {
        private int time = 0;
        public WaitMacroEvent(int time)
        {
            this.time = time;
        }

        public override void doAction(ref bool work)
        {
            long startedTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            while((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) < startedTime + time && work) Thread.Sleep(50);
        }

        public override string ToString()
        {
            return "Attendre " + ((float)time) / 1000 + " secondes";
        }
    }

    [Serializable]
    class KeyboardMacroEvent : MacroEvent
    {
        [DllImport("user32.dll")] static extern short VkKeyScan(char ch);
        [NonSerialized]
        private InputSimulator sim;

        private char key;
        private int time;

        public KeyboardMacroEvent(string key, int time)
        {
            this.key = key.ToUpper().ToCharArray()[0];
            this.time = time;
            this.sim = new InputSimulator();
        }

        public KeyboardMacroEvent(char key, int time)
        {
            this.key = key;
            this.time = time;
            this.sim = new InputSimulator();
        }

        public override void doAction(ref bool work)
        {
            if (this.sim == null) this.sim = new InputSimulator();
            sim.Keyboard.KeyDown((VirtualKeyCode)key);
            long startedTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            while ((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) < startedTime + time && work) Thread.Sleep(50);
            sim.Keyboard.KeyUp((VirtualKeyCode)key);
        }

        public override string ToString()
        {
            return "Appuyer sur " + key + " pendant " + ((float)time) / 1000 + " secondes";
        }
    }

    [Serializable]
    class MacroManager
    {
        private bool working = false;
        public List<MacroEvent> macros { get; }

        public int startDelay = 2;

        public int currentWorkIndex = 0;

        [NonSerialized]
        private Thread worker = null;

        public MacroManager() {
            macros = new List<MacroEvent>();
        }

        public void addEvent(MacroEvent e)
        {
            macros.Add(e);
        }

        public void removeEvent(MacroEvent e)
        {
            macros.Remove(e);
        }

        public void removeLastevent()
        {
            if (macros.Count == 0) return;
            macros.RemoveAt(macros.Count - 1);
        }

        public void start(bool repeat)
        {
            if (working) return;
            working = true;
            Thread startThread = new Thread(() => delayedStart(repeat, startDelay * 1000));
            startThread.Start();
            
        }

        private void delayedStart(bool repeat, long time)
        {
            long startedTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            while ((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) < startedTime + time && working) Thread.Sleep(50);
            worker = new Thread(() => this.work(repeat));
            worker.Start();
        }

        private void work(bool repeat)
        {
            if(macros.Count == 0)
            {
                working = false;
                Thread.CurrentThread.Abort();
            }
            int currentEvent = 0;
            while (working)
            {
                MacroEvent e = macros[currentEvent];
                currentWorkIndex = currentEvent;
                e.doAction(ref working);
                currentEvent++;
                if (currentEvent >= macros.Count)
                {
                    currentEvent = 0;
                    if(!repeat)
                    {
                        working = false;
                        Thread.CurrentThread.Abort();
                    }
                }
            }
        }

        public void stop()
        {
            if (!working) return;
            working = false;
            if (worker != null) worker.Join();
            worker = null;
        }

        public bool isWorking()
        {
            return working;
        }

    }
}
