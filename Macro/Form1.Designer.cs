
namespace Macro
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddKey = new System.Windows.Forms.Button();
            this.buttonAddWait = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericWaitTime = new System.Windows.Forms.NumericUpDown();
            this.numericKeyWait = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStartDelay = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.numericTextDelay = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTextInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKeyWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTextDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBoxEvents);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 559);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commandes";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(288, 23);
            this.textBoxKey.MaxLength = 1;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(59, 20);
            this.textBoxKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Touche";
            // 
            // buttonAddKey
            // 
            this.buttonAddKey.Location = new System.Drawing.Point(648, 19);
            this.buttonAddKey.Name = "buttonAddKey";
            this.buttonAddKey.Size = new System.Drawing.Size(75, 23);
            this.buttonAddKey.TabIndex = 3;
            this.buttonAddKey.Text = "Ajouter";
            this.buttonAddKey.UseVisualStyleBackColor = true;
            this.buttonAddKey.Click += new System.EventHandler(this.buttonAddKey_Click);
            // 
            // buttonAddWait
            // 
            this.buttonAddWait.Location = new System.Drawing.Point(648, 76);
            this.buttonAddWait.Name = "buttonAddWait";
            this.buttonAddWait.Size = new System.Drawing.Size(75, 23);
            this.buttonAddWait.TabIndex = 6;
            this.buttonAddWait.Text = "Ajouter";
            this.buttonAddWait.UseVisualStyleBackColor = true;
            this.buttonAddWait.Click += new System.EventHandler(this.buttonAddWait_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Attendre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "secondes";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Supprimer l\'action selectionnée";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "pendant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "secondes";
            // 
            // numericWaitTime
            // 
            this.numericWaitTime.DecimalPlaces = 1;
            this.numericWaitTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericWaitTime.Location = new System.Drawing.Point(286, 76);
            this.numericWaitTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericWaitTime.Name = "numericWaitTime";
            this.numericWaitTime.Size = new System.Drawing.Size(60, 20);
            this.numericWaitTime.TabIndex = 12;
            this.numericWaitTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // numericKeyWait
            // 
            this.numericKeyWait.DecimalPlaces = 1;
            this.numericKeyWait.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericKeyWait.Location = new System.Drawing.Point(405, 23);
            this.numericKeyWait.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericKeyWait.Name = "numericKeyWait";
            this.numericKeyWait.Size = new System.Drawing.Size(60, 20);
            this.numericKeyWait.TabIndex = 13;
            this.numericKeyWait.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(236, 254);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(139, 23);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Démarrer";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(416, 254);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(139, 23);
            this.buttonStop.TabIndex = 15;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(16, 19);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(178, 498);
            this.listBoxEvents.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(236, 217);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(139, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Délai avant démarrage:";
            // 
            // labelStartDelay
            // 
            this.labelStartDelay.AutoSize = true;
            this.labelStartDelay.Location = new System.Drawing.Point(504, 217);
            this.labelStartDelay.Name = "labelStartDelay";
            this.labelStartDelay.Size = new System.Drawing.Size(62, 13);
            this.labelStartDelay.TabIndex = 18;
            this.labelStartDelay.Text = "2 secondes";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(236, 327);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 23);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Sauvegarder";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Checked = true;
            this.checkBoxRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRepeat.Location = new System.Drawing.Point(236, 194);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(101, 17);
            this.checkBoxRepeat.TabIndex = 20;
            this.checkBoxRepeat.Text = "Répéter à l\'infini";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Supprimer la dernière action";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numericTextDelay
            // 
            this.numericTextDelay.DecimalPlaces = 1;
            this.numericTextDelay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericTextDelay.Location = new System.Drawing.Point(405, 51);
            this.numericTextDelay.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericTextDelay.Name = "numericTextDelay";
            this.numericTextDelay.Size = new System.Drawing.Size(60, 20);
            this.numericTextDelay.TabIndex = 26;
            this.numericTextDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "secondes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "pendant";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Texte";
            // 
            // textBoxTextInput
            // 
            this.textBoxTextInput.Location = new System.Drawing.Point(288, 51);
            this.textBoxTextInput.MaxLength = 35000;
            this.textBoxTextInput.Name = "textBoxTextInput";
            this.textBoxTextInput.Size = new System.Drawing.Size(59, 20);
            this.textBoxTextInput.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 584);
            this.Controls.Add(this.numericTextDelay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxTextInput);
            this.Controls.Add(this.checkBoxRepeat);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelStartDelay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericKeyWait);
            this.Controls.Add(this.numericWaitTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddWait);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Macro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericWaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKeyWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTextDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddKey;
        private System.Windows.Forms.Button buttonAddWait;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericWaitTime;
        private System.Windows.Forms.NumericUpDown numericKeyWait;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStartDelay;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericTextDelay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTextInput;
    }
}

