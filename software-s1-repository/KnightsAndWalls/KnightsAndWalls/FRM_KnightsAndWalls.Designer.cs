
namespace KnightsAndWalls
{
    partial class FRM_KnightsAndWalls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_KnightsAndWalls));
            this.GB_Mode = new System.Windows.Forms.GroupBox();
            this.RB_Attack = new System.Windows.Forms.RadioButton();
            this.RB_Build = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GB_BuildMode = new System.Windows.Forms.GroupBox();
            this.RB_Townhall = new System.Windows.Forms.RadioButton();
            this.PB_Undo = new System.Windows.Forms.PictureBox();
            this.RB_Cannon = new System.Windows.Forms.RadioButton();
            this.RB_Wall = new System.Windows.Forms.RadioButton();
            this.GB_AttackMode = new System.Windows.Forms.GroupBox();
            this.RB_Bodyguard = new System.Windows.Forms.RadioButton();
            this.RB_Swordsman = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_MouseLocation = new System.Windows.Forms.Label();
            this.TB_MouseLocation = new System.Windows.Forms.TextBox();
            this.TMR_GameTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.GB_Debug = new System.Windows.Forms.GroupBox();
            this.LBL_SwordsmanHealth = new System.Windows.Forms.Label();
            this.LBL_Townhall = new System.Windows.Forms.Label();
            this.LBL_Wall = new System.Windows.Forms.Label();
            this.LBL_CannonHealth = new System.Windows.Forms.Label();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBL_Bodyguard = new System.Windows.Forms.Label();
            this.GB_Mode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GB_BuildMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Undo)).BeginInit();
            this.GB_AttackMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.GB_Debug.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Mode
            // 
            this.GB_Mode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_Mode.Controls.Add(this.RB_Attack);
            this.GB_Mode.Controls.Add(this.RB_Build);
            this.GB_Mode.Location = new System.Drawing.Point(6, 12);
            this.GB_Mode.Name = "GB_Mode";
            this.GB_Mode.Size = new System.Drawing.Size(137, 77);
            this.GB_Mode.TabIndex = 0;
            this.GB_Mode.TabStop = false;
            this.GB_Mode.Text = "Mode";
            // 
            // RB_Attack
            // 
            this.RB_Attack.AutoSize = true;
            this.RB_Attack.Location = new System.Drawing.Point(6, 48);
            this.RB_Attack.Name = "RB_Attack";
            this.RB_Attack.Size = new System.Drawing.Size(68, 21);
            this.RB_Attack.TabIndex = 1;
            this.RB_Attack.TabStop = true;
            this.RB_Attack.Text = "Attack";
            this.RB_Attack.UseVisualStyleBackColor = true;
            // 
            // RB_Build
            // 
            this.RB_Build.AutoSize = true;
            this.RB_Build.Location = new System.Drawing.Point(6, 21);
            this.RB_Build.Name = "RB_Build";
            this.RB_Build.Size = new System.Drawing.Size(60, 21);
            this.RB_Build.TabIndex = 0;
            this.RB_Build.TabStop = true;
            this.RB_Build.Text = "Build";
            this.RB_Build.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(0, 369);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(904, 95);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // GB_BuildMode
            // 
            this.GB_BuildMode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_BuildMode.Controls.Add(this.RB_Townhall);
            this.GB_BuildMode.Controls.Add(this.PB_Undo);
            this.GB_BuildMode.Controls.Add(this.RB_Cannon);
            this.GB_BuildMode.Controls.Add(this.RB_Wall);
            this.GB_BuildMode.Location = new System.Drawing.Point(12, 378);
            this.GB_BuildMode.Name = "GB_BuildMode";
            this.GB_BuildMode.Size = new System.Drawing.Size(872, 77);
            this.GB_BuildMode.TabIndex = 2;
            this.GB_BuildMode.TabStop = false;
            this.GB_BuildMode.Text = "Build mode";
            // 
            // RB_Townhall
            // 
            this.RB_Townhall.AutoSize = true;
            this.RB_Townhall.Location = new System.Drawing.Point(82, 21);
            this.RB_Townhall.Name = "RB_Townhall";
            this.RB_Townhall.Size = new System.Drawing.Size(85, 21);
            this.RB_Townhall.TabIndex = 7;
            this.RB_Townhall.TabStop = true;
            this.RB_Townhall.Text = "Townhall";
            this.RB_Townhall.UseVisualStyleBackColor = true;
            // 
            // PB_Undo
            // 
            this.PB_Undo.Image = global::KnightsAndWalls.Properties.Resources.undo;
            this.PB_Undo.Location = new System.Drawing.Point(811, 16);
            this.PB_Undo.Name = "PB_Undo";
            this.PB_Undo.Size = new System.Drawing.Size(50, 50);
            this.PB_Undo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Undo.TabIndex = 5;
            this.PB_Undo.TabStop = false;
            this.PB_Undo.Click += new System.EventHandler(this.PB_Undo_Click);
            // 
            // RB_Cannon
            // 
            this.RB_Cannon.AutoSize = true;
            this.RB_Cannon.Location = new System.Drawing.Point(6, 48);
            this.RB_Cannon.Name = "RB_Cannon";
            this.RB_Cannon.Size = new System.Drawing.Size(78, 21);
            this.RB_Cannon.TabIndex = 1;
            this.RB_Cannon.TabStop = true;
            this.RB_Cannon.Text = "Cannon";
            this.RB_Cannon.UseVisualStyleBackColor = true;
            // 
            // RB_Wall
            // 
            this.RB_Wall.AutoSize = true;
            this.RB_Wall.Location = new System.Drawing.Point(6, 21);
            this.RB_Wall.Name = "RB_Wall";
            this.RB_Wall.Size = new System.Drawing.Size(56, 21);
            this.RB_Wall.TabIndex = 0;
            this.RB_Wall.TabStop = true;
            this.RB_Wall.Text = "Wall";
            this.RB_Wall.UseVisualStyleBackColor = true;
            // 
            // GB_AttackMode
            // 
            this.GB_AttackMode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_AttackMode.Controls.Add(this.RB_Bodyguard);
            this.GB_AttackMode.Controls.Add(this.RB_Swordsman);
            this.GB_AttackMode.Enabled = false;
            this.GB_AttackMode.Location = new System.Drawing.Point(12, 467);
            this.GB_AttackMode.Name = "GB_AttackMode";
            this.GB_AttackMode.Size = new System.Drawing.Size(872, 77);
            this.GB_AttackMode.TabIndex = 3;
            this.GB_AttackMode.TabStop = false;
            this.GB_AttackMode.Text = "Attack Mode";
            // 
            // RB_Bodyguard
            // 
            this.RB_Bodyguard.AutoSize = true;
            this.RB_Bodyguard.Location = new System.Drawing.Point(6, 48);
            this.RB_Bodyguard.Name = "RB_Bodyguard";
            this.RB_Bodyguard.Size = new System.Drawing.Size(98, 21);
            this.RB_Bodyguard.TabIndex = 1;
            this.RB_Bodyguard.TabStop = true;
            this.RB_Bodyguard.Text = "Bodyguard";
            this.RB_Bodyguard.UseVisualStyleBackColor = true;
            // 
            // RB_Swordsman
            // 
            this.RB_Swordsman.AutoSize = true;
            this.RB_Swordsman.Location = new System.Drawing.Point(6, 21);
            this.RB_Swordsman.Name = "RB_Swordsman";
            this.RB_Swordsman.Size = new System.Drawing.Size(102, 21);
            this.RB_Swordsman.TabIndex = 0;
            this.RB_Swordsman.TabStop = true;
            this.RB_Swordsman.Text = "Swordsman";
            this.RB_Swordsman.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 462);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(905, 95);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.LBL_MouseLocation);
            this.groupBox1.Controls.Add(this.TB_MouseLocation);
            this.groupBox1.Location = new System.Drawing.Point(6, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // LBL_MouseLocation
            // 
            this.LBL_MouseLocation.AutoSize = true;
            this.LBL_MouseLocation.Location = new System.Drawing.Point(6, 23);
            this.LBL_MouseLocation.Name = "LBL_MouseLocation";
            this.LBL_MouseLocation.Size = new System.Drawing.Size(112, 17);
            this.LBL_MouseLocation.TabIndex = 1;
            this.LBL_MouseLocation.Text = "Mouse Location:";
            // 
            // TB_MouseLocation
            // 
            this.TB_MouseLocation.Location = new System.Drawing.Point(6, 43);
            this.TB_MouseLocation.Name = "TB_MouseLocation";
            this.TB_MouseLocation.Size = new System.Drawing.Size(125, 22);
            this.TB_MouseLocation.TabIndex = 0;
            // 
            // TMR_GameTime
            // 
            this.TMR_GameTime.Enabled = true;
            this.TMR_GameTime.Interval = 1;
            this.TMR_GameTime.Tick += new System.EventHandler(this.TMR_GameTime_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox4.Location = new System.Drawing.Point(1030, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(193, 557);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // GB_Debug
            // 
            this.GB_Debug.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_Debug.Controls.Add(this.LBL_Bodyguard);
            this.GB_Debug.Controls.Add(this.LBL_SwordsmanHealth);
            this.GB_Debug.Controls.Add(this.LBL_Townhall);
            this.GB_Debug.Controls.Add(this.LBL_Wall);
            this.GB_Debug.Controls.Add(this.LBL_CannonHealth);
            this.GB_Debug.Location = new System.Drawing.Point(1046, 12);
            this.GB_Debug.Name = "GB_Debug";
            this.GB_Debug.Size = new System.Drawing.Size(166, 123);
            this.GB_Debug.TabIndex = 2;
            this.GB_Debug.TabStop = false;
            this.GB_Debug.Text = "Debug Menu";
            // 
            // LBL_SwordsmanHealth
            // 
            this.LBL_SwordsmanHealth.AutoSize = true;
            this.LBL_SwordsmanHealth.Location = new System.Drawing.Point(6, 77);
            this.LBL_SwordsmanHealth.Name = "LBL_SwordsmanHealth";
            this.LBL_SwordsmanHealth.Size = new System.Drawing.Size(128, 17);
            this.LBL_SwordsmanHealth.TabIndex = 5;
            this.LBL_SwordsmanHealth.Text = "Swordsman health:";
            // 
            // LBL_Townhall
            // 
            this.LBL_Townhall.AutoSize = true;
            this.LBL_Townhall.Location = new System.Drawing.Point(6, 60);
            this.LBL_Townhall.Name = "LBL_Townhall";
            this.LBL_Townhall.Size = new System.Drawing.Size(111, 17);
            this.LBL_Townhall.TabIndex = 4;
            this.LBL_Townhall.Text = "Townhall health:";
            // 
            // LBL_Wall
            // 
            this.LBL_Wall.AutoSize = true;
            this.LBL_Wall.Location = new System.Drawing.Point(6, 42);
            this.LBL_Wall.Name = "LBL_Wall";
            this.LBL_Wall.Size = new System.Drawing.Size(82, 17);
            this.LBL_Wall.TabIndex = 3;
            this.LBL_Wall.Text = "Wall health:";
            // 
            // LBL_CannonHealth
            // 
            this.LBL_CannonHealth.AutoSize = true;
            this.LBL_CannonHealth.Location = new System.Drawing.Point(6, 25);
            this.LBL_CannonHealth.Name = "LBL_CannonHealth";
            this.LBL_CannonHealth.Size = new System.Drawing.Size(104, 17);
            this.LBL_CannonHealth.TabIndex = 2;
            this.LBL_CannonHealth.Text = "Cannon health:";
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(6, 307);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(142, 50);
            this.BTN_Clear.TabIndex = 6;
            this.BTN_Clear.Text = "Clear";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GB_Mode);
            this.groupBox2.Controls.Add(this.BTN_Clear);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(869, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 363);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // LBL_Bodyguard
            // 
            this.LBL_Bodyguard.AutoSize = true;
            this.LBL_Bodyguard.Location = new System.Drawing.Point(6, 94);
            this.LBL_Bodyguard.Name = "LBL_Bodyguard";
            this.LBL_Bodyguard.Size = new System.Drawing.Size(124, 17);
            this.LBL_Bodyguard.TabIndex = 6;
            this.LBL_Bodyguard.Text = "Bodyguard health:";
            // 
            // FRM_KnightsAndWalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1262, 705);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GB_Debug);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.GB_AttackMode);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.GB_BuildMode);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "FRM_KnightsAndWalls";
            this.Text = "Knights and Walls";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FRM_KnightsAndWalls_MouseClick);
            this.GB_Mode.ResumeLayout(false);
            this.GB_Mode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GB_BuildMode.ResumeLayout(false);
            this.GB_BuildMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Undo)).EndInit();
            this.GB_AttackMode.ResumeLayout(false);
            this.GB_AttackMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.GB_Debug.ResumeLayout(false);
            this.GB_Debug.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Mode;
        private System.Windows.Forms.RadioButton RB_Attack;
        private System.Windows.Forms.RadioButton RB_Build;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox GB_BuildMode;
        private System.Windows.Forms.RadioButton RB_Cannon;
        private System.Windows.Forms.RadioButton RB_Wall;
        private System.Windows.Forms.GroupBox GB_AttackMode;
        private System.Windows.Forms.RadioButton RB_Bodyguard;
        private System.Windows.Forms.RadioButton RB_Swordsman;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_MouseLocation;
        private System.Windows.Forms.TextBox TB_MouseLocation;
        private System.Windows.Forms.Timer TMR_GameTime;
        private System.Windows.Forms.PictureBox PB_Undo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox GB_Debug;
        private System.Windows.Forms.Label LBL_CannonHealth;
        private System.Windows.Forms.Label LBL_Wall;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.RadioButton RB_Townhall;
        private System.Windows.Forms.Label LBL_Townhall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBL_SwordsmanHealth;
        private System.Windows.Forms.Label LBL_Bodyguard;
    }
}

