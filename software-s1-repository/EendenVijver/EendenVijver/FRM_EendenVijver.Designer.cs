
namespace EendenVijver
{
    partial class FRM_EendenVijver
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
            this.BTN_Spawn = new System.Windows.Forms.Button();
            this.LB_Eenden = new System.Windows.Forms.ListBox();
            this.LB_Kikkers = new System.Windows.Forms.ListBox();
            this.LB_Ooievaar = new System.Windows.Forms.ListBox();
            this.GB_Setup = new System.Windows.Forms.GroupBox();
            this.TB_Ooievaar = new System.Windows.Forms.TextBox();
            this.TB_Kikker = new System.Windows.Forms.TextBox();
            this.TB_Eend = new System.Windows.Forms.TextBox();
            this.BTN_NormaalSpeed = new System.Windows.Forms.Button();
            this.BTN_LangzaamSpeed = new System.Windows.Forms.Button();
            this.BTN_SnelSpeed = new System.Windows.Forms.Button();
            this.TMR_Movement = new System.Windows.Forms.Timer(this.components);
            this.PB_Player = new System.Windows.Forms.PictureBox();
            this.GB_Setup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Spawn
            // 
            this.BTN_Spawn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Spawn.Location = new System.Drawing.Point(6, 21);
            this.BTN_Spawn.Name = "BTN_Spawn";
            this.BTN_Spawn.Size = new System.Drawing.Size(258, 35);
            this.BTN_Spawn.TabIndex = 0;
            this.BTN_Spawn.Text = "Spawn Fauna";
            this.BTN_Spawn.UseVisualStyleBackColor = true;
            this.BTN_Spawn.Click += new System.EventHandler(this.BTN_Spawn_Click);
            // 
            // LB_Eenden
            // 
            this.LB_Eenden.FormattingEnabled = true;
            this.LB_Eenden.ItemHeight = 16;
            this.LB_Eenden.Location = new System.Drawing.Point(6, 93);
            this.LB_Eenden.Name = "LB_Eenden";
            this.LB_Eenden.Size = new System.Drawing.Size(82, 292);
            this.LB_Eenden.TabIndex = 1;
            // 
            // LB_Kikkers
            // 
            this.LB_Kikkers.FormattingEnabled = true;
            this.LB_Kikkers.ItemHeight = 16;
            this.LB_Kikkers.Location = new System.Drawing.Point(94, 93);
            this.LB_Kikkers.Name = "LB_Kikkers";
            this.LB_Kikkers.Size = new System.Drawing.Size(72, 292);
            this.LB_Kikkers.TabIndex = 2;
            // 
            // LB_Ooievaar
            // 
            this.LB_Ooievaar.FormattingEnabled = true;
            this.LB_Ooievaar.ItemHeight = 16;
            this.LB_Ooievaar.Location = new System.Drawing.Point(174, 93);
            this.LB_Ooievaar.Name = "LB_Ooievaar";
            this.LB_Ooievaar.Size = new System.Drawing.Size(90, 292);
            this.LB_Ooievaar.TabIndex = 3;
            // 
            // GB_Setup
            // 
            this.GB_Setup.Controls.Add(this.TB_Ooievaar);
            this.GB_Setup.Controls.Add(this.TB_Kikker);
            this.GB_Setup.Controls.Add(this.TB_Eend);
            this.GB_Setup.Controls.Add(this.BTN_NormaalSpeed);
            this.GB_Setup.Controls.Add(this.BTN_LangzaamSpeed);
            this.GB_Setup.Controls.Add(this.BTN_SnelSpeed);
            this.GB_Setup.Controls.Add(this.BTN_Spawn);
            this.GB_Setup.Controls.Add(this.LB_Eenden);
            this.GB_Setup.Controls.Add(this.LB_Kikkers);
            this.GB_Setup.Controls.Add(this.LB_Ooievaar);
            this.GB_Setup.Location = new System.Drawing.Point(1054, 12);
            this.GB_Setup.Name = "GB_Setup";
            this.GB_Setup.Size = new System.Drawing.Size(271, 429);
            this.GB_Setup.TabIndex = 4;
            this.GB_Setup.TabStop = false;
            this.GB_Setup.Text = "Setup";
            // 
            // TB_Ooievaar
            // 
            this.TB_Ooievaar.Location = new System.Drawing.Point(174, 62);
            this.TB_Ooievaar.Name = "TB_Ooievaar";
            this.TB_Ooievaar.ReadOnly = true;
            this.TB_Ooievaar.Size = new System.Drawing.Size(90, 22);
            this.TB_Ooievaar.TabIndex = 10;
            // 
            // TB_Kikker
            // 
            this.TB_Kikker.Location = new System.Drawing.Point(94, 62);
            this.TB_Kikker.Name = "TB_Kikker";
            this.TB_Kikker.ReadOnly = true;
            this.TB_Kikker.Size = new System.Drawing.Size(72, 22);
            this.TB_Kikker.TabIndex = 9;
            // 
            // TB_Eend
            // 
            this.TB_Eend.Location = new System.Drawing.Point(6, 62);
            this.TB_Eend.Name = "TB_Eend";
            this.TB_Eend.ReadOnly = true;
            this.TB_Eend.Size = new System.Drawing.Size(82, 22);
            this.TB_Eend.TabIndex = 6;
            // 
            // BTN_NormaalSpeed
            // 
            this.BTN_NormaalSpeed.Location = new System.Drawing.Point(94, 391);
            this.BTN_NormaalSpeed.Name = "BTN_NormaalSpeed";
            this.BTN_NormaalSpeed.Size = new System.Drawing.Size(72, 29);
            this.BTN_NormaalSpeed.TabIndex = 7;
            this.BTN_NormaalSpeed.Text = "Normaal";
            this.BTN_NormaalSpeed.UseVisualStyleBackColor = true;
            this.BTN_NormaalSpeed.Click += new System.EventHandler(this.BTN_NormaalSpeed_Click);
            // 
            // BTN_LangzaamSpeed
            // 
            this.BTN_LangzaamSpeed.Location = new System.Drawing.Point(6, 391);
            this.BTN_LangzaamSpeed.Name = "BTN_LangzaamSpeed";
            this.BTN_LangzaamSpeed.Size = new System.Drawing.Size(82, 29);
            this.BTN_LangzaamSpeed.TabIndex = 8;
            this.BTN_LangzaamSpeed.Text = "Langzaam";
            this.BTN_LangzaamSpeed.UseVisualStyleBackColor = true;
            this.BTN_LangzaamSpeed.Click += new System.EventHandler(this.BTN_LangzaamSpeed_Click);
            // 
            // BTN_SnelSpeed
            // 
            this.BTN_SnelSpeed.Location = new System.Drawing.Point(172, 391);
            this.BTN_SnelSpeed.Name = "BTN_SnelSpeed";
            this.BTN_SnelSpeed.Size = new System.Drawing.Size(92, 29);
            this.BTN_SnelSpeed.TabIndex = 6;
            this.BTN_SnelSpeed.Text = "Snel";
            this.BTN_SnelSpeed.UseVisualStyleBackColor = true;
            this.BTN_SnelSpeed.Click += new System.EventHandler(this.BTN_SnelSpeed_Click);
            // 
            // TMR_Movement
            // 
            this.TMR_Movement.Tick += new System.EventHandler(this.TMR_Movement_Tick);
            // 
            // PB_Player
            // 
            this.PB_Player.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PB_Player.Location = new System.Drawing.Point(961, 800);
            this.PB_Player.Name = "PB_Player";
            this.PB_Player.Size = new System.Drawing.Size(50, 50);
            this.PB_Player.TabIndex = 5;
            this.PB_Player.TabStop = false;
            // 
            // FRM_EendenVijver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 453);
            this.Controls.Add(this.PB_Player);
            this.Controls.Add(this.GB_Setup);
            this.Name = "FRM_EendenVijver";
            this.Text = "EendenVijver";
            this.GB_Setup.ResumeLayout(false);
            this.GB_Setup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Spawn;
        private System.Windows.Forms.ListBox LB_Eenden;
        private System.Windows.Forms.ListBox LB_Kikkers;
        private System.Windows.Forms.ListBox LB_Ooievaar;
        private System.Windows.Forms.GroupBox GB_Setup;
        private System.Windows.Forms.Timer TMR_Movement;
        private System.Windows.Forms.PictureBox PB_Player;
        private System.Windows.Forms.Button BTN_SnelSpeed;
        private System.Windows.Forms.Button BTN_NormaalSpeed;
        private System.Windows.Forms.Button BTN_LangzaamSpeed;
        private System.Windows.Forms.TextBox TB_Eend;
        private System.Windows.Forms.TextBox TB_Ooievaar;
        private System.Windows.Forms.TextBox TB_Kikker;
    }
}

