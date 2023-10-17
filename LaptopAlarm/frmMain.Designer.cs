namespace LaptopAlarm
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            btnPlay = new Button();
            btnStop = new Button();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            txtEvents = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1688, 84);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(1404, 40);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(182, 63);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(1398, 141);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(188, 58);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(1398, 238);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(188, 58);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 58);
            label2.Name = "label2";
            label2.Size = new Size(145, 41);
            label2.TabIndex = 4;
            label2.Text = "Alarm on:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(82, 144);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(286, 45);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Loss of AC power";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(82, 216);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(344, 45);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Unplug of USB device";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(82, 291);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(298, 45);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Mouse movement";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(82, 374);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(261, 45);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Keyboard press";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(82, 457);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(217, 45);
            checkBox5.TabIndex = 9;
            checkBox5.Text = "Lid is closed";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // txtEvents
            // 
            txtEvents.Enabled = false;
            txtEvents.Location = new Point(82, 538);
            txtEvents.Multiline = true;
            txtEvents.Name = "txtEvents";
            txtEvents.ScrollBars = ScrollBars.Both;
            txtEvents.Size = new Size(1574, 560);
            txtEvents.TabIndex = 10;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1943, 1230);
            Controls.Add(txtEvents);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(7, 8, 7, 8);
            Name = "frmMain";
            Text = "Laptop Alarm";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnPlay;
        private Button btnStop;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private TextBox txtEvents;
    }
}