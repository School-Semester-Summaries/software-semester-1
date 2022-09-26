
namespace Galgje
{
    partial class FRM_Galgje
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
            this.BTN_Start = new System.Windows.Forms.Button();
            this.NUD_Letters = new System.Windows.Forms.NumericUpDown();
            this.GB_Setup = new System.Windows.Forms.GroupBox();
            this.TB_Gok = new System.Windows.Forms.TextBox();
            this.LBL_Woord = new System.Windows.Forms.Label();
            this.LB_Letters = new System.Windows.Forms.ListBox();
            this.GB_Game = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Letters)).BeginInit();
            this.GB_Setup.SuspendLayout();
            this.GB_Game.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(6, 59);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(215, 27);
            this.BTN_Start.TabIndex = 0;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // NUD_Letters
            // 
            this.NUD_Letters.Location = new System.Drawing.Point(6, 26);
            this.NUD_Letters.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NUD_Letters.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NUD_Letters.Name = "NUD_Letters";
            this.NUD_Letters.Size = new System.Drawing.Size(215, 27);
            this.NUD_Letters.TabIndex = 2;
            this.NUD_Letters.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // GB_Setup
            // 
            this.GB_Setup.Controls.Add(this.NUD_Letters);
            this.GB_Setup.Controls.Add(this.BTN_Start);
            this.GB_Setup.Location = new System.Drawing.Point(12, 12);
            this.GB_Setup.Name = "GB_Setup";
            this.GB_Setup.Size = new System.Drawing.Size(227, 97);
            this.GB_Setup.TabIndex = 3;
            this.GB_Setup.TabStop = false;
            this.GB_Setup.Text = "Setup";
            // 
            // TB_Gok
            // 
            this.TB_Gok.Location = new System.Drawing.Point(15, 51);
            this.TB_Gok.MaxLength = 1;
            this.TB_Gok.Name = "TB_Gok";
            this.TB_Gok.PlaceholderText = "Vul hier een letter in";
            this.TB_Gok.Size = new System.Drawing.Size(149, 27);
            this.TB_Gok.TabIndex = 4;
            // 
            // LBL_Woord
            // 
            this.LBL_Woord.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Woord.Location = new System.Drawing.Point(0, 224);
            this.LBL_Woord.Name = "LBL_Woord";
            this.LBL_Woord.Size = new System.Drawing.Size(221, 86);
            this.LBL_Woord.TabIndex = 5;
            // 
            // LB_Letters
            // 
            this.LB_Letters.FormattingEnabled = true;
            this.LB_Letters.ItemHeight = 20;
            this.LB_Letters.Location = new System.Drawing.Point(245, 11);
            this.LB_Letters.Name = "LB_Letters";
            this.LB_Letters.Size = new System.Drawing.Size(78, 424);
            this.LB_Letters.TabIndex = 6;
            // 
            // GB_Game
            // 
            this.GB_Game.Controls.Add(this.LBL_Woord);
            this.GB_Game.Controls.Add(this.TB_Gok);
            this.GB_Game.Location = new System.Drawing.Point(12, 125);
            this.GB_Game.Name = "GB_Game";
            this.GB_Game.Size = new System.Drawing.Size(227, 313);
            this.GB_Game.TabIndex = 4;
            this.GB_Game.TabStop = false;
            this.GB_Game.Text = "Game";
            // 
            // FRM_Galgje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.LB_Letters);
            this.Controls.Add(this.GB_Game);
            this.Controls.Add(this.GB_Setup);
            this.Name = "FRM_Galgje";
            this.Text = "Galgje";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Letters)).EndInit();
            this.GB_Setup.ResumeLayout(false);
            this.GB_Game.ResumeLayout(false);
            this.GB_Game.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.NumericUpDown NUD_Letters;
        private System.Windows.Forms.GroupBox GB_Setup;
        private System.Windows.Forms.TextBox TB_Gok;
        private System.Windows.Forms.Label LBL_Woord;
        private System.Windows.Forms.ListBox LB_Letters;
        private System.Windows.Forms.GroupBox GB_Game;
    }
}

