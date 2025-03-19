namespace LV1_2_RSSV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_vrijeme = new Label();
            btn_start_stop = new Button();
            txt_readNumber = new TextBox();
            txt_threshold = new TextBox();
            btn_setThreshold = new Button();
            txt_alarm = new Label();
            SuspendLayout();
            // 
            // lbl_vrijeme
            // 
            lbl_vrijeme.AutoSize = true;
            lbl_vrijeme.Location = new Point(64, 76);
            lbl_vrijeme.Name = "lbl_vrijeme";
            lbl_vrijeme.Size = new Size(47, 15);
            lbl_vrijeme.TabIndex = 0;
            lbl_vrijeme.Text = "Vrijeme";
            // 
            // btn_start_stop
            // 
            btn_start_stop.Location = new Point(678, 384);
            btn_start_stop.Name = "btn_start_stop";
            btn_start_stop.Size = new Size(75, 23);
            btn_start_stop.TabIndex = 1;
            btn_start_stop.Text = "Pokreni";
            btn_start_stop.UseVisualStyleBackColor = true;
            btn_start_stop.Click += btn_start_stop_Click;
            // 
            // txt_readNumber
            // 
            txt_readNumber.Location = new Point(481, 30);
            txt_readNumber.Multiline = true;
            txt_readNumber.Name = "txt_readNumber";
            txt_readNumber.Size = new Size(204, 308);
            txt_readNumber.TabIndex = 2;
            // 
            // txt_threshold
            // 
            txt_threshold.Location = new Point(62, 220);
            txt_threshold.Name = "txt_threshold";
            txt_threshold.Size = new Size(100, 23);
            txt_threshold.TabIndex = 3;
            // 
            // btn_setThreshold
            // 
            btn_setThreshold.Location = new Point(68, 282);
            btn_setThreshold.Name = "btn_setThreshold";
            btn_setThreshold.Size = new Size(75, 23);
            btn_setThreshold.TabIndex = 4;
            btn_setThreshold.Text = "SetTreshold";
            btn_setThreshold.UseVisualStyleBackColor = true;
            btn_setThreshold.Click += btn_setThreshold_Click;
            // 
            // txt_alarm
            // 
            txt_alarm.AutoSize = true;
            txt_alarm.Location = new Point(288, 345);
            txt_alarm.Name = "txt_alarm";
            txt_alarm.Size = new Size(53, 15);
            txt_alarm.TabIndex = 5;
            txt_alarm.Text = "Message";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_alarm);
            Controls.Add(btn_setThreshold);
            Controls.Add(txt_threshold);
            Controls.Add(txt_readNumber);
            Controls.Add(btn_start_stop);
            Controls.Add(lbl_vrijeme);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_vrijeme;
        private Button btn_start_stop;
        private TextBox txt_readNumber;
        private TextBox txt_threshold;
        private Button btn_setThreshold;
        private Label txt_alarm;
    }
}
