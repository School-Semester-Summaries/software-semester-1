
namespace Sirted
{
    partial class FRM_sirted
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
            this.components = new System.ComponentModel.Container();
            this.TMR_Timer = new System.Windows.Forms.Timer(this.components);
            this.BTN_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TMR_Timer
            // 
            this.TMR_Timer.Interval = 1000;
            this.TMR_Timer.Tick += new System.EventHandler(this.TMR_Timer_Tick);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(12, 12);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(426, 376);
            this.BTN_Start.TabIndex = 2;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // FRM_sirted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.BTN_Start);
            this.Name = "FRM_sirted";
            this.Text = "Sirted";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TMR_Timer;
        private System.Windows.Forms.Button BTN_Start;
    }
}

