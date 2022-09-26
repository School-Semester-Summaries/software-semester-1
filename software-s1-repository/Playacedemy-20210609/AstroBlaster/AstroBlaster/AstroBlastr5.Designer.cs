
namespace AstroBlaster
{
    partial class AstroBlastr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroBlastr));
            this.SpaceShip = new System.Windows.Forms.PictureBox();
            this.Meteor = new System.Windows.Forms.PictureBox();
            this.lbl_Vraag = new System.Windows.Forms.Label();
            this.btn_AntwoordL = new System.Windows.Forms.Button();
            this.btn_AntwoordM = new System.Windows.Forms.Button();
            this.btn_AntwoordR = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.MovementTimer = new System.Windows.Forms.Timer(this.components);
            this.Explosion = new System.Windows.Forms.PictureBox();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.btn_Background = new System.Windows.Forms.Button();
            this.DataBaseConnection = new System.Windows.Forms.Button();
            this.GB_Setup = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RB_AstroBlastr = new System.Windows.Forms.RadioButton();
            this.RB_HistoryBlastr = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Ruimte = new System.Windows.Forms.RadioButton();
            this.RB_Abstract = new System.Windows.Forms.RadioButton();
            this.RB_LaserKitty = new System.Windows.Forms.RadioButton();
            this.RB_Raket = new System.Windows.Forms.RadioButton();
            this.RB_Ufo = new System.Windows.Forms.RadioButton();
            this.RB_Dababy = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            this.GB_Setup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpaceShip
            // 
            this.SpaceShip.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SpaceShip.Image = ((System.Drawing.Image)(resources.GetObject("SpaceShip.Image")));
            this.SpaceShip.Location = new System.Drawing.Point(16, 15);
            this.SpaceShip.Margin = new System.Windows.Forms.Padding(4);
            this.SpaceShip.Name = "SpaceShip";
            this.SpaceShip.Size = new System.Drawing.Size(160, 101);
            this.SpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SpaceShip.TabIndex = 0;
            this.SpaceShip.TabStop = false;
            // 
            // Meteor
            // 
            this.Meteor.BackColor = System.Drawing.Color.Transparent;
            this.Meteor.Image = global::AstroBlaster.Properties.Resources.Meteor;
            this.Meteor.Location = new System.Drawing.Point(1097, 138);
            this.Meteor.Margin = new System.Windows.Forms.Padding(4);
            this.Meteor.Name = "Meteor";
            this.Meteor.Size = new System.Drawing.Size(131, 97);
            this.Meteor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Meteor.TabIndex = 1;
            this.Meteor.TabStop = false;
            // 
            // lbl_Vraag
            // 
            this.lbl_Vraag.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Vraag.Font = new System.Drawing.Font("Eras Medium ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vraag.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_Vraag.Location = new System.Drawing.Point(192, 335);
            this.lbl_Vraag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Vraag.Name = "lbl_Vraag";
            this.lbl_Vraag.Size = new System.Drawing.Size(721, 91);
            this.lbl_Vraag.TabIndex = 3;
            this.lbl_Vraag.Text = "Som 0123456789";
            this.lbl_Vraag.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_Vraag.Visible = false;
            // 
            // btn_AntwoordL
            // 
            this.btn_AntwoordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AntwoordL.Location = new System.Drawing.Point(197, 459);
            this.btn_AntwoordL.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AntwoordL.Name = "btn_AntwoordL";
            this.btn_AntwoordL.Size = new System.Drawing.Size(221, 174);
            this.btn_AntwoordL.TabIndex = 4;
            this.btn_AntwoordL.UseVisualStyleBackColor = true;
            this.btn_AntwoordL.Visible = false;
            this.btn_AntwoordL.Click += new System.EventHandler(this.btn_AntwoordL_Click);
            // 
            // btn_AntwoordM
            // 
            this.btn_AntwoordM.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AntwoordM.Location = new System.Drawing.Point(427, 459);
            this.btn_AntwoordM.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AntwoordM.Name = "btn_AntwoordM";
            this.btn_AntwoordM.Size = new System.Drawing.Size(221, 174);
            this.btn_AntwoordM.TabIndex = 5;
            this.btn_AntwoordM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AntwoordM.UseVisualStyleBackColor = true;
            this.btn_AntwoordM.Visible = false;
            this.btn_AntwoordM.Click += new System.EventHandler(this.btn_AntwoordM_Click);
            // 
            // btn_AntwoordR
            // 
            this.btn_AntwoordR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AntwoordR.Location = new System.Drawing.Point(656, 459);
            this.btn_AntwoordR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AntwoordR.Name = "btn_AntwoordR";
            this.btn_AntwoordR.Size = new System.Drawing.Size(221, 174);
            this.btn_AntwoordR.TabIndex = 6;
            this.btn_AntwoordR.UseVisualStyleBackColor = true;
            this.btn_AntwoordR.Visible = false;
            this.btn_AntwoordR.Click += new System.EventHandler(this.btn_AntwoordR_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(384, 197);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(327, 129);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // MovementTimer
            // 
            this.MovementTimer.Tick += new System.EventHandler(this.MovementTimer_Tick);
            // 
            // Explosion
            // 
            this.Explosion.BackColor = System.Drawing.Color.Transparent;
            this.Explosion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Explosion.Image = global::AstroBlaster.Properties.Resources.Explosion;
            this.Explosion.Location = new System.Drawing.Point(1488, 298);
            this.Explosion.Margin = new System.Windows.Forms.Padding(4);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(77, 76);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Explosion.TabIndex = 8;
            this.Explosion.TabStop = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Score.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_Score.Location = new System.Drawing.Point(352, 2);
            this.lbl_Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(359, 21);
            this.lbl_Score.TabIndex = 9;
            this.lbl_Score.Text = "Score = 0";
            this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_Score.Visible = false;
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.Red;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Restart.Location = new System.Drawing.Point(384, 197);
            this.Restart.Margin = new System.Windows.Forms.Padding(4);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(327, 129);
            this.Restart.TabIndex = 10;
            this.Restart.Text = "RESTART";
            this.Restart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // txb_Username
            // 
            this.txb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Username.Location = new System.Drawing.Point(329, 106);
            this.txb_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.Size = new System.Drawing.Size(425, 37);
            this.txb_Username.TabIndex = 12;
            this.txb_Username.Text = "Voer uw naam in. (Geen spaties)";
            this.txb_Username.Visible = false;
            this.txb_Username.Click += new System.EventHandler(this.txb_Username_Click);
            this.txb_Username.TextChanged += new System.EventHandler(this.txb_Username_TextChanged);
            // 
            // btn_Background
            // 
            this.btn_Background.BackColor = System.Drawing.Color.Transparent;
            this.btn_Background.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Background.Enabled = false;
            this.btn_Background.Location = new System.Drawing.Point(179, 443);
            this.btn_Background.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Background.Name = "btn_Background";
            this.btn_Background.Size = new System.Drawing.Size(716, 203);
            this.btn_Background.TabIndex = 13;
            this.btn_Background.Text = "button1";
            this.btn_Background.UseVisualStyleBackColor = false;
            this.btn_Background.Visible = false;
            // 
            // DataBaseConnection
            // 
            this.DataBaseConnection.Location = new System.Drawing.Point(925, 15);
            this.DataBaseConnection.Margin = new System.Windows.Forms.Padding(4);
            this.DataBaseConnection.Name = "DataBaseConnection";
            this.DataBaseConnection.Size = new System.Drawing.Size(149, 28);
            this.DataBaseConnection.TabIndex = 14;
            this.DataBaseConnection.Text = "DataBaseConnetion";
            this.DataBaseConnection.UseVisualStyleBackColor = true;
            this.DataBaseConnection.Click += new System.EventHandler(this.DataBaseConnection_Click);
            // 
            // GB_Setup
            // 
            this.GB_Setup.Controls.Add(this.groupBox3);
            this.GB_Setup.Controls.Add(this.groupBox2);
            this.GB_Setup.Controls.Add(this.groupBox1);
            this.GB_Setup.Location = new System.Drawing.Point(16, 641);
            this.GB_Setup.Name = "GB_Setup";
            this.GB_Setup.Size = new System.Drawing.Size(1058, 129);
            this.GB_Setup.TabIndex = 15;
            this.GB_Setup.TabStop = false;
            this.GB_Setup.Text = "Setup";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RB_AstroBlastr);
            this.groupBox3.Controls.Add(this.RB_HistoryBlastr);
            this.groupBox3.Location = new System.Drawing.Point(723, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 102);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Muziek";
            // 
            // RB_AstroBlastr
            // 
            this.RB_AstroBlastr.AutoSize = true;
            this.RB_AstroBlastr.Checked = true;
            this.RB_AstroBlastr.Location = new System.Drawing.Point(6, 21);
            this.RB_AstroBlastr.Name = "RB_AstroBlastr";
            this.RB_AstroBlastr.Size = new System.Drawing.Size(98, 21);
            this.RB_AstroBlastr.TabIndex = 1;
            this.RB_AstroBlastr.TabStop = true;
            this.RB_AstroBlastr.Text = "AstroBlastr";
            this.RB_AstroBlastr.UseVisualStyleBackColor = true;
            // 
            // RB_HistoryBlastr
            // 
            this.RB_HistoryBlastr.AutoSize = true;
            this.RB_HistoryBlastr.Location = new System.Drawing.Point(6, 48);
            this.RB_HistoryBlastr.Name = "RB_HistoryBlastr";
            this.RB_HistoryBlastr.Size = new System.Drawing.Size(109, 21);
            this.RB_HistoryBlastr.TabIndex = 0;
            this.RB_HistoryBlastr.Text = "HistoryBlastr";
            this.RB_HistoryBlastr.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_LaserKitty);
            this.groupBox2.Controls.Add(this.RB_Abstract);
            this.groupBox2.Controls.Add(this.RB_Ruimte);
            this.groupBox2.Location = new System.Drawing.Point(394, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 102);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Achtergrond";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Dababy);
            this.groupBox1.Controls.Add(this.RB_Ufo);
            this.groupBox1.Controls.Add(this.RB_Raket);
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 102);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skin";
            // 
            // RB_Ruimte
            // 
            this.RB_Ruimte.AutoSize = true;
            this.RB_Ruimte.Checked = true;
            this.RB_Ruimte.Location = new System.Drawing.Point(6, 21);
            this.RB_Ruimte.Name = "RB_Ruimte";
            this.RB_Ruimte.Size = new System.Drawing.Size(73, 21);
            this.RB_Ruimte.TabIndex = 2;
            this.RB_Ruimte.Text = "Ruimte";
            this.RB_Ruimte.UseVisualStyleBackColor = true;
            // 
            // RB_Abstract
            // 
            this.RB_Abstract.AutoSize = true;
            this.RB_Abstract.Location = new System.Drawing.Point(6, 48);
            this.RB_Abstract.Name = "RB_Abstract";
            this.RB_Abstract.Size = new System.Drawing.Size(81, 21);
            this.RB_Abstract.TabIndex = 3;
            this.RB_Abstract.Text = "Abstract";
            this.RB_Abstract.UseVisualStyleBackColor = true;
            // 
            // RB_LaserKitty
            // 
            this.RB_LaserKitty.AutoSize = true;
            this.RB_LaserKitty.Location = new System.Drawing.Point(6, 75);
            this.RB_LaserKitty.Name = "RB_LaserKitty";
            this.RB_LaserKitty.Size = new System.Drawing.Size(96, 21);
            this.RB_LaserKitty.TabIndex = 4;
            this.RB_LaserKitty.Text = "Laser Kitty";
            this.RB_LaserKitty.UseVisualStyleBackColor = true;
            // 
            // RB_Raket
            // 
            this.RB_Raket.AutoSize = true;
            this.RB_Raket.Checked = true;
            this.RB_Raket.Location = new System.Drawing.Point(6, 21);
            this.RB_Raket.Name = "RB_Raket";
            this.RB_Raket.Size = new System.Drawing.Size(66, 21);
            this.RB_Raket.TabIndex = 5;
            this.RB_Raket.Text = "Raket";
            this.RB_Raket.UseVisualStyleBackColor = true;
            // 
            // RB_Ufo
            // 
            this.RB_Ufo.AutoSize = true;
            this.RB_Ufo.Location = new System.Drawing.Point(6, 48);
            this.RB_Ufo.Name = "RB_Ufo";
            this.RB_Ufo.Size = new System.Drawing.Size(51, 21);
            this.RB_Ufo.TabIndex = 5;
            this.RB_Ufo.Text = "Ufo";
            this.RB_Ufo.UseVisualStyleBackColor = true;
            // 
            // RB_Dababy
            // 
            this.RB_Dababy.AutoSize = true;
            this.RB_Dababy.Location = new System.Drawing.Point(6, 75);
            this.RB_Dababy.Name = "RB_Dababy";
            this.RB_Dababy.Size = new System.Drawing.Size(78, 21);
            this.RB_Dababy.TabIndex = 6;
            this.RB_Dababy.Text = "Dababy";
            this.RB_Dababy.UseVisualStyleBackColor = true;
            // 
            // AstroBlastr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1091, 782);
            this.Controls.Add(this.GB_Setup);
            this.Controls.Add(this.DataBaseConnection);
            this.Controls.Add(this.txb_Username);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.Explosion);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_AntwoordR);
            this.Controls.Add(this.btn_AntwoordM);
            this.Controls.Add(this.btn_AntwoordL);
            this.Controls.Add(this.lbl_Vraag);
            this.Controls.Add(this.Meteor);
            this.Controls.Add(this.SpaceShip);
            this.Controls.Add(this.btn_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AstroBlastr";
            this.Text = "AstroBlastr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AstroBlastr_FormClosing);
            this.Load += new System.EventHandler(this.AstroBlastr_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AstroBlastr_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
            this.GB_Setup.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SpaceShip;
        private System.Windows.Forms.PictureBox Meteor;
        private System.Windows.Forms.Label lbl_Vraag;
        private System.Windows.Forms.Button btn_AntwoordL;
        private System.Windows.Forms.Button btn_AntwoordM;
        private System.Windows.Forms.Button btn_AntwoordR;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Timer MovementTimer;
        private System.Windows.Forms.PictureBox Explosion;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.Button btn_Background;
        private System.Windows.Forms.Button DataBaseConnection;
        private System.Windows.Forms.GroupBox GB_Setup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_AstroBlastr;
        private System.Windows.Forms.RadioButton RB_HistoryBlastr;
        private System.Windows.Forms.RadioButton RB_LaserKitty;
        private System.Windows.Forms.RadioButton RB_Abstract;
        private System.Windows.Forms.RadioButton RB_Ruimte;
        private System.Windows.Forms.RadioButton RB_Dababy;
        private System.Windows.Forms.RadioButton RB_Ufo;
        private System.Windows.Forms.RadioButton RB_Raket;
    }
}

