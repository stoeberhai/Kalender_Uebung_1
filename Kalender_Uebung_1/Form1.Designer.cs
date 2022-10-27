namespace Kalender_Uebung_1
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
            this.BtnCalenderWeekOfToday = new System.Windows.Forms.Button();
            this.LblCalenderWeek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalenderWeekOfToday
            // 
            this.BtnCalenderWeekOfToday.Location = new System.Drawing.Point(25, 25);
            this.BtnCalenderWeekOfToday.Name = "BtnCalenderWeekOfToday";
            this.BtnCalenderWeekOfToday.Size = new System.Drawing.Size(282, 34);
            this.BtnCalenderWeekOfToday.TabIndex = 0;
            this.BtnCalenderWeekOfToday.Text = "Kalenderwoche von heute";
            this.BtnCalenderWeekOfToday.UseVisualStyleBackColor = true;
            this.BtnCalenderWeekOfToday.Click += new System.EventHandler(this.BtnCalenderWeekOfToday_Click);
            // 
            // LblCalenderWeek
            // 
            this.LblCalenderWeek.AutoSize = true;
            this.LblCalenderWeek.Location = new System.Drawing.Point(338, 30);
            this.LblCalenderWeek.Name = "LblCalenderWeek";
            this.LblCalenderWeek.Size = new System.Drawing.Size(135, 25);
            this.LblCalenderWeek.TabIndex = 1;
            this.LblCalenderWeek.Text = "Kalenderwoche:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 114);
            this.Controls.Add(this.LblCalenderWeek);
            this.Controls.Add(this.BtnCalenderWeekOfToday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCalenderWeekOfToday;
        private Label LblCalenderWeek;
    }
}