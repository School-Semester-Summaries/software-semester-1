
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
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            this.SuspendLayout();
            // 
            // SpaceShip
            // 
            this.SpaceShip.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SpaceShip.Image = ((System.Drawing.Image)(resources.GetObject("SpaceShip.Image")));
            this.SpaceShip.Location = new System.Drawing.Point(12, 12);
            this.SpaceShip.Name = "SpaceShip";
            this.SpaceShip.Size = new System.Drawing.Size(120, 82);
            this.SpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SpaceShip.TabIndex = 0;
            this.SpaceShip.TabStop = false;
            // 
            // Meteor
            // 
            this.Meteor.BackColor = System.Drawing.Color.Transparent;
            this.Meteor.Image = global::AstroBlaster.Properties.Resources.Meteor;
            this.Meteor.Location = new System.Drawing.Point(823, 112);
            this.Meteor.Name = "Meteor";
            this.Meteor.Size = new System.Drawing.Size(98, 79);
            this.Meteor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Meteor.TabIndex = 1;
            this.Meteor.TabStop = false;
            // 
            // lbl_Vraag
            // 
            this.lbl_Vraag.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Vraag.Font = new System.Drawing.Font("Eras Medium ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vraag.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_Vraag.Location = new System.Drawing.Point(144, 272);
            this.lbl_Vraag.Name = "lbl_Vraag";
            this.lbl_Vraag.Size = new System.Drawing.Size(541, 74);
            this.lbl_Vraag.TabIndex = 3;
            this.lbl_Vraag.Text = "Som 0123456789";
            this.lbl_Vraag.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_Vraag.Visible = false;
            // 
            // btn_AntwoordL
            // 
            this.btn_AntwoordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AntwoordL.Location = new System.Drawing.Point(148, 373);
            this.btn_AntwoordL.Name = "btn_AntwoordL";
            this.btn_AntwoordL.Size = new System.Drawing.Size(166, 141);
            this.btn_AntwoordL.TabIndex = 4;
            this.btn_AntwoordL.UseVisualStyleBackColor = true;
            this.btn_AntwoordL.Visible = false;
            this.btn_AntwoordL.Click += new System.EventHandler(this.btn_AntwoordL_Click);
            // 
            // btn_AntwoordM
            // 
            this.btn_AntwoordM.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AntwoordM.Location = new System.Drawing.Point(320, 373);
            this.btn_AntwoordM.Name = "btn_AntwoordM";
            this.btn_AntwoordM.Size = new System.Drawing.Size(166, 141);
            this.btn_AntwoordM.TabIndex = 5;
            this.btn_AntwoordM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AntwoordM.UseVisualStyleBackColor = true;
            this.btn_AntwoordM.Visible = false;
            this.btn_AntwoordM.Click += new System.EventHandler(this.btn_AntwoordM_Click);
            // 
            // btn_AntwoordR
            // 
            this.btn_AntwoordR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AntwoordR.Location = new System.Drawing.Point(492, 373);
            this.btn_AntwoordR.Name = "btn_AntwoordR";
            this.btn_AntwoordR.Size = new System.Drawing.Size(166, 141);
            this.btn_AntwoordR.TabIndex = 6;
            this.btn_AntwoordR.UseVisualStyleBackColor = true;
            this.btn_AntwoordR.Visible = false;
            this.btn_AntwoordR.Click += new System.EventHandler(this.btn_AntwoordR_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(288, 160);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(245, 105);
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
            this.Explosion.Location = new System.Drawing.Point(1116, 242);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(58, 62);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Explosion.TabIndex = 8;
            this.Explosion.TabStop = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Score.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_Score.Location = new System.Drawing.Point(264, 2);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(269, 17);
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
            this.Restart.Location = new System.Drawing.Point(288, 160);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(245, 105);
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
            this.txb_Username.Location = new System.Drawing.Point(247, 86);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.Size = new System.Drawing.Size(320, 31);
            this.txb_Username.TabIndex = 12;
            this.txb_Username.Text = "Voer uw naam in. (Geen spaties)";
            this.txb_Username.Visible = false;
            this.txb_Username.Click += new System.EventHandler(this.txb_Username_Click);
            // 
            // btn_Background
            // 
            this.btn_Background.BackColor = System.Drawing.Color.Transparent;
            this.btn_Background.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Background.Enabled = false;
            this.btn_Background.Location = new System.Drawing.Point(134, 360);
            this.btn_Background.Name = "btn_Background";
            this.btn_Background.Size = new System.Drawing.Size(537, 165);
            this.btn_Background.TabIndex = 13;
            this.btn_Background.Text = "button1";
            this.btn_Background.UseVisualStyleBackColor = false;
            this.btn_Background.Visible = false;
            // 
            // AstroBlastr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(818, 635);
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
            this.Name = "AstroBlastr";
            this.Text = "AstroBlastr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AstroBlastr_FormClosing);
            this.Load += new System.EventHandler(this.AstroBlastr_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AstroBlastr_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
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
    }
}

