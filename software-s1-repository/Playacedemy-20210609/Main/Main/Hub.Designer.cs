
namespace Main
{
    partial class Hub
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hub));
            this.SummonAstroBlastr = new System.Windows.Forms.Button();
            this.HubTimer = new System.Windows.Forms.Timer(this.components);
            this.SummonHistoryBlastr = new System.Windows.Forms.Button();
            this.lbx_Highscores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SummonAstroBlastr
            // 
            this.SummonAstroBlastr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SummonAstroBlastr.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummonAstroBlastr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SummonAstroBlastr.Location = new System.Drawing.Point(491, 76);
            this.SummonAstroBlastr.Name = "SummonAstroBlastr";
            this.SummonAstroBlastr.Size = new System.Drawing.Size(167, 76);
            this.SummonAstroBlastr.TabIndex = 0;
            this.SummonAstroBlastr.Text = "Astroblastr";
            this.SummonAstroBlastr.UseVisualStyleBackColor = false;
            this.SummonAstroBlastr.Click += new System.EventHandler(this.SummonAstroBlastr_Click);
            // 
            // HubTimer
            // 
            this.HubTimer.Tick += new System.EventHandler(this.HubTimer_Tick);
            // 
            // SummonHistoryBlastr
            // 
            this.SummonHistoryBlastr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SummonHistoryBlastr.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummonHistoryBlastr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SummonHistoryBlastr.Location = new System.Drawing.Point(145, 76);
            this.SummonHistoryBlastr.Name = "SummonHistoryBlastr";
            this.SummonHistoryBlastr.Size = new System.Drawing.Size(167, 76);
            this.SummonHistoryBlastr.TabIndex = 1;
            this.SummonHistoryBlastr.Text = "HistoryBlastr";
            this.SummonHistoryBlastr.UseVisualStyleBackColor = false;
            this.SummonHistoryBlastr.Click += new System.EventHandler(this.SummonHistoryBlastr_Click);
            // 
            // lbx_Highscores
            // 
            this.lbx_Highscores.FormattingEnabled = true;
            this.lbx_Highscores.Location = new System.Drawing.Point(491, 167);
            this.lbx_Highscores.Name = "lbx_Highscores";
            this.lbx_Highscores.Size = new System.Drawing.Size(167, 225);
            this.lbx_Highscores.TabIndex = 2;
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbx_Highscores);
            this.Controls.Add(this.SummonHistoryBlastr);
            this.Controls.Add(this.SummonAstroBlastr);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(43)))));
            this.Name = "Hub";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SummonAstroBlastr;
        private System.Windows.Forms.Timer HubTimer;
        private System.Windows.Forms.Button SummonHistoryBlastr;
        private System.Windows.Forms.ListBox lbx_Highscores;
    }
}

