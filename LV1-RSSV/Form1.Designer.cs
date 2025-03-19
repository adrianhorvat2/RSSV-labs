namespace LV1_RSSV
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
            btn_start_stop = new Button();
            lbl_vrijeme = new Label();
            txt_inputTime = new TextBox();
            txt_alarm = new Label();
            SuspendLayout();
            // 
            // btn_start_stop
            // 
            btn_start_stop.Location = new Point(663, 351);
            btn_start_stop.Name = "btn_start_stop";
            btn_start_stop.Size = new Size(75, 23);
            btn_start_stop.TabIndex = 0;
            btn_start_stop.Text = "Postavi alarm";
            btn_start_stop.UseVisualStyleBackColor = true;
            btn_start_stop.Click += btn_start_alarm_Click;
            // 
            // lbl_vrijeme
            // 
            lbl_vrijeme.AutoSize = true;
            lbl_vrijeme.Location = new Point(315, 133);
            lbl_vrijeme.Name = "lbl_vrijeme";
            lbl_vrijeme.Size = new Size(47, 15);
            lbl_vrijeme.TabIndex = 1;
            lbl_vrijeme.Text = "Vrijeme";
            lbl_vrijeme.Click += vrijeme;
            // 
            // txt_inputTime
            // 
            txt_inputTime.Location = new Point(316, 178);
            txt_inputTime.Name = "txt_inputTime";
            txt_inputTime.Size = new Size(100, 23);
            txt_inputTime.TabIndex = 2;
            // 
            // txt_alarm
            // 
            txt_alarm.AutoSize = true;
            txt_alarm.Location = new Point(350, 244);
            txt_alarm.Name = "txt_alarm";
            txt_alarm.Size = new Size(0, 15);
            txt_alarm.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_alarm);
            Controls.Add(txt_inputTime);
            Controls.Add(lbl_vrijeme);
            Controls.Add(btn_start_stop);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_start_stop;
        private Label lbl_vrijeme;
        private TextBox txt_inputTime;
        private Label txt_alarm;
    }
}
