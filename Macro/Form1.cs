using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macro
{
    public partial class Form1 : Form
    {
        private MacroManager manager;
        private BindingSource bs;
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(Directory.GetCurrentDirectory() + "\\macro.dat")) manager = SaveDataManager.ReadFromBinaryFile<MacroManager>(Directory.GetCurrentDirectory() + "\\macro.dat");
            else manager = new MacroManager();
            trackBar1.Value = manager.startDelay;
            updateDelayText();
            bs = new BindingSource();
            bs.DataSource = manager.macros;
            listBoxEvents.DataSource = bs;
        }

        private void buttonAddKey_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text.Length < 1)
            {
                MessageBox.Show("Aucune touche n'a été enregistrée dans le champs");
                return;
            }
            manager.addEvent(new KeyboardMacroEvent(textBoxKey.Text, (int)(((float)numericKeyWait.Value) * 1000)));
            bs.ResetBindings(false);
        }

        private void buttonAddWait_Click(object sender, EventArgs e)
        {
            manager.addEvent(new WaitMacroEvent((int)(((float)numericWaitTime.Value) * 1000)));
            bs.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager.start(checkBoxRepeat.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manager.stop();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MacroEvent macroEvent = (MacroEvent)listBoxEvents.SelectedItem;
            manager.removeEvent(macroEvent);
            bs.ResetBindings(false);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            manager.startDelay = trackBar1.Value;
            updateDelayText();
        }

        private void updateDelayText()
        {
            labelStartDelay.Text = trackBar1.Value + " " + (trackBar1.Value < 2 ? "seconde" : "secondes");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (manager.isWorking()) MessageBox.Show("Il faut arrêter le bot pour pouvoir sauvegarder");
            else SaveDataManager.WriteToBinaryFile(Directory.GetCurrentDirectory() + "\\macro.dat", manager);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(manager.isWorking())
            {
                buttonStart.BackColor = Color.Green;
                buttonStop.BackColor = Color.Red;
                listBoxEvents.SelectedIndex = manager.currentWorkIndex;
            } else
            {
                buttonStart.BackColor = SystemColors.ButtonFace;
                buttonStart.UseVisualStyleBackColor = true;
                buttonStop.BackColor = SystemColors.ButtonFace;
                buttonStop.UseVisualStyleBackColor = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            manager.removeLastevent();
            bs.ResetBindings(false);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBoxTextInput.Text.Length < 1)
            {
                MessageBox.Show("Aucune touche n'a été enregistrée dans le champs");
                return;
            }
            foreach (char c in textBoxTextInput.Text.ToUpper())
            {
                manager.addEvent(new KeyboardMacroEvent(c, (int)(((float)numericKeyWait.Value) * 1000)));
            }
            bs.ResetBindings(false);
        }
    }
}
