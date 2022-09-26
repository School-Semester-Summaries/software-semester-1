
namespace TetrisAttack
{
    partial class FRM_TetrisAttack
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
            this.TMR_GameTime = new System.Windows.Forms.Timer(this.components);
            this.TMR_RiseFloor = new System.Windows.Forms.Timer(this.components);
            this.TMR_CreateLine = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GB_DebugInfo = new System.Windows.Forms.GroupBox();
            this.LBL_Bs = new System.Windows.Forms.Label();
            this.LBL_PBs = new System.Windows.Forms.Label();
            this.TMR_Gravity = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LBL_Score = new System.Windows.Forms.Label();
            this.LBL_Time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GB_DebugInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TMR_GameTime
            // 
            this.TMR_GameTime.Interval = 1;
            this.TMR_GameTime.Tick += new System.EventHandler(this.TMR_GameTime_Tick);
            // 
            // TMR_RiseFloor
            // 
            this.TMR_RiseFloor.Interval = 500;
            this.TMR_RiseFloor.Tick += new System.EventHandler(this.TMR_RiseFloor_Tick);
            // 
            // TMR_CreateLine
            // 
            this.TMR_CreateLine.Interval = 2500;
            this.TMR_CreateLine.Tick += new System.EventHandler(this.TMR_CreateLine_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(400, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 487);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // GB_DebugInfo
            // 
            this.GB_DebugInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GB_DebugInfo.Controls.Add(this.LBL_Bs);
            this.GB_DebugInfo.Controls.Add(this.LBL_PBs);
            this.GB_DebugInfo.Location = new System.Drawing.Point(410, 12);
            this.GB_DebugInfo.Name = "GB_DebugInfo";
            this.GB_DebugInfo.Size = new System.Drawing.Size(146, 58);
            this.GB_DebugInfo.TabIndex = 2;
            this.GB_DebugInfo.TabStop = false;
            this.GB_DebugInfo.Text = "Debug info";
            // 
            // LBL_Bs
            // 
            this.LBL_Bs.AutoSize = true;
            this.LBL_Bs.Location = new System.Drawing.Point(6, 35);
            this.LBL_Bs.Name = "LBL_Bs";
            this.LBL_Bs.Size = new System.Drawing.Size(53, 17);
            this.LBL_Bs.TabIndex = 1;
            this.LBL_Bs.Text = "Blocks:";
            // 
            // LBL_PBs
            // 
            this.LBL_PBs.AutoSize = true;
            this.LBL_PBs.Location = new System.Drawing.Point(6, 18);
            this.LBL_PBs.Name = "LBL_PBs";
            this.LBL_PBs.Size = new System.Drawing.Size(94, 17);
            this.LBL_PBs.TabIndex = 0;
            this.LBL_PBs.Text = "PictureBoxes:";
            // 
            // TMR_Gravity
            // 
            this.TMR_Gravity.Interval = 1;
            this.TMR_Gravity.Tick += new System.EventHandler(this.TMR_Gravity_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(410, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blockstyle";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.LBL_Time);
            this.groupBox3.Controls.Add(this.LBL_Score);
            this.groupBox3.Location = new System.Drawing.Point(410, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 62);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // LBL_Score
            // 
            this.LBL_Score.AutoSize = true;
            this.LBL_Score.Location = new System.Drawing.Point(6, 18);
            this.LBL_Score.Name = "LBL_Score";
            this.LBL_Score.Size = new System.Drawing.Size(61, 17);
            this.LBL_Score.TabIndex = 0;
            this.LBL_Score.Text = "Score: 0";
            // 
            // LBL_Time
            // 
            this.LBL_Time.AutoSize = true;
            this.LBL_Time.Location = new System.Drawing.Point(6, 35);
            this.LBL_Time.Name = "LBL_Time";
            this.LBL_Time.Size = new System.Drawing.Size(55, 17);
            this.LBL_Time.TabIndex = 2;
            this.LBL_Time.Text = "Time: 0";
            // 
            // FRM_TetrisAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(568, 487);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GB_DebugInfo);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FRM_TetrisAttack";
            this.Text = "Tetris Attack ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GB_DebugInfo.ResumeLayout(false);
            this.GB_DebugInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TMR_GameTime;
        private System.Windows.Forms.Timer TMR_RiseFloor;
        private System.Windows.Forms.Timer TMR_CreateLine;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox GB_DebugInfo;
        private System.Windows.Forms.Timer TMR_Gravity;
        private System.Windows.Forms.Label LBL_Bs;
        private System.Windows.Forms.Label LBL_PBs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LBL_Score;
        private System.Windows.Forms.Label LBL_Time;
    }
}

