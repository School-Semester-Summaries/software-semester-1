
namespace Worpen_Generator
{
    partial class FRM_WorpenGenerator
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
            this.GB_Instellingen = new System.Windows.Forms.GroupBox();
            this.BTN_GooiDobbelstenen = new System.Windows.Forms.Button();
            this.NUD_AantalOgen = new System.Windows.Forms.NumericUpDown();
            this.NUD_AantalWorpen = new System.Windows.Forms.NumericUpDown();
            this.LBL_AantalOgen = new System.Windows.Forms.Label();
            this.LBL_AantalWorpen = new System.Windows.Forms.Label();
            this.LB_Worpen = new System.Windows.Forms.ListBox();
            this.GB_Resultaat = new System.Windows.Forms.GroupBox();
            this.TB_TotaalAantalOgen = new System.Windows.Forms.TextBox();
            this.LBL_TotaalAantalOgen = new System.Windows.Forms.Label();
            this.LBL_WorpenResultaat = new System.Windows.Forms.Label();
            this.GB_Instellingen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AantalOgen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AantalWorpen)).BeginInit();
            this.GB_Resultaat.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Instellingen
            // 
            this.GB_Instellingen.Controls.Add(this.BTN_GooiDobbelstenen);
            this.GB_Instellingen.Controls.Add(this.NUD_AantalOgen);
            this.GB_Instellingen.Controls.Add(this.NUD_AantalWorpen);
            this.GB_Instellingen.Controls.Add(this.LBL_AantalOgen);
            this.GB_Instellingen.Controls.Add(this.LBL_AantalWorpen);
            this.GB_Instellingen.Location = new System.Drawing.Point(12, 12);
            this.GB_Instellingen.Name = "GB_Instellingen";
            this.GB_Instellingen.Size = new System.Drawing.Size(211, 141);
            this.GB_Instellingen.TabIndex = 0;
            this.GB_Instellingen.TabStop = false;
            this.GB_Instellingen.Text = "Instellingen";
            // 
            // BTN_GooiDobbelstenen
            // 
            this.BTN_GooiDobbelstenen.Location = new System.Drawing.Point(6, 106);
            this.BTN_GooiDobbelstenen.Name = "BTN_GooiDobbelstenen";
            this.BTN_GooiDobbelstenen.Size = new System.Drawing.Size(198, 29);
            this.BTN_GooiDobbelstenen.TabIndex = 6;
            this.BTN_GooiDobbelstenen.Text = "Gooi Dobbelstenen!";
            this.BTN_GooiDobbelstenen.UseVisualStyleBackColor = true;
            this.BTN_GooiDobbelstenen.Click += new System.EventHandler(this.BTN_GooiDobbelstenen_Click);
            // 
            // NUD_AantalOgen
            // 
            this.NUD_AantalOgen.Location = new System.Drawing.Point(118, 66);
            this.NUD_AantalOgen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_AantalOgen.Name = "NUD_AantalOgen";
            this.NUD_AantalOgen.Size = new System.Drawing.Size(86, 27);
            this.NUD_AantalOgen.TabIndex = 5;
            this.NUD_AantalOgen.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // NUD_AantalWorpen
            // 
            this.NUD_AantalWorpen.Location = new System.Drawing.Point(118, 33);
            this.NUD_AantalWorpen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_AantalWorpen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_AantalWorpen.Name = "NUD_AantalWorpen";
            this.NUD_AantalWorpen.Size = new System.Drawing.Size(86, 27);
            this.NUD_AantalWorpen.TabIndex = 4;
            this.NUD_AantalWorpen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LBL_AantalOgen
            // 
            this.LBL_AantalOgen.AutoSize = true;
            this.LBL_AantalOgen.Location = new System.Drawing.Point(6, 68);
            this.LBL_AantalOgen.Name = "LBL_AantalOgen";
            this.LBL_AantalOgen.Size = new System.Drawing.Size(93, 20);
            this.LBL_AantalOgen.TabIndex = 3;
            this.LBL_AantalOgen.Text = "Aantal ogen:";
            // 
            // LBL_AantalWorpen
            // 
            this.LBL_AantalWorpen.AutoSize = true;
            this.LBL_AantalWorpen.Location = new System.Drawing.Point(6, 35);
            this.LBL_AantalWorpen.Name = "LBL_AantalWorpen";
            this.LBL_AantalWorpen.Size = new System.Drawing.Size(109, 20);
            this.LBL_AantalWorpen.TabIndex = 2;
            this.LBL_AantalWorpen.Text = "Aantal worpen:";
            // 
            // LB_Worpen
            // 
            this.LB_Worpen.FormattingEnabled = true;
            this.LB_Worpen.ItemHeight = 20;
            this.LB_Worpen.Location = new System.Drawing.Point(6, 50);
            this.LB_Worpen.Name = "LB_Worpen";
            this.LB_Worpen.Size = new System.Drawing.Size(209, 104);
            this.LB_Worpen.TabIndex = 1;
            // 
            // GB_Resultaat
            // 
            this.GB_Resultaat.Controls.Add(this.TB_TotaalAantalOgen);
            this.GB_Resultaat.Controls.Add(this.LBL_TotaalAantalOgen);
            this.GB_Resultaat.Controls.Add(this.LBL_WorpenResultaat);
            this.GB_Resultaat.Controls.Add(this.LB_Worpen);
            this.GB_Resultaat.Location = new System.Drawing.Point(229, 12);
            this.GB_Resultaat.Name = "GB_Resultaat";
            this.GB_Resultaat.Size = new System.Drawing.Size(221, 193);
            this.GB_Resultaat.TabIndex = 2;
            this.GB_Resultaat.TabStop = false;
            this.GB_Resultaat.Text = "Resultaat";
            // 
            // TB_TotaalAantalOgen
            // 
            this.TB_TotaalAantalOgen.Location = new System.Drawing.Point(148, 160);
            this.TB_TotaalAantalOgen.Name = "TB_TotaalAantalOgen";
            this.TB_TotaalAantalOgen.ReadOnly = true;
            this.TB_TotaalAantalOgen.Size = new System.Drawing.Size(67, 27);
            this.TB_TotaalAantalOgen.TabIndex = 3;
            // 
            // LBL_TotaalAantalOgen
            // 
            this.LBL_TotaalAantalOgen.AutoSize = true;
            this.LBL_TotaalAantalOgen.Location = new System.Drawing.Point(6, 163);
            this.LBL_TotaalAantalOgen.Name = "LBL_TotaalAantalOgen";
            this.LBL_TotaalAantalOgen.Size = new System.Drawing.Size(136, 20);
            this.LBL_TotaalAantalOgen.TabIndex = 8;
            this.LBL_TotaalAantalOgen.Text = "Totaal aantal ogen:";
            // 
            // LBL_WorpenResultaat
            // 
            this.LBL_WorpenResultaat.AutoSize = true;
            this.LBL_WorpenResultaat.Location = new System.Drawing.Point(6, 27);
            this.LBL_WorpenResultaat.Name = "LBL_WorpenResultaat";
            this.LBL_WorpenResultaat.Size = new System.Drawing.Size(64, 20);
            this.LBL_WorpenResultaat.TabIndex = 7;
            this.LBL_WorpenResultaat.Text = "Worpen:";
            // 
            // FRM_WorpenGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 218);
            this.Controls.Add(this.GB_Resultaat);
            this.Controls.Add(this.GB_Instellingen);
            this.Name = "FRM_WorpenGenerator";
            this.Text = "Worpen Generator";
            this.GB_Instellingen.ResumeLayout(false);
            this.GB_Instellingen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AantalOgen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AantalWorpen)).EndInit();
            this.GB_Resultaat.ResumeLayout(false);
            this.GB_Resultaat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Instellingen;
        private System.Windows.Forms.Label LBL_AantalWorpen;
        private System.Windows.Forms.Label LBL_AantalOgen;
        private System.Windows.Forms.NumericUpDown NUD_AantalWorpen;
        private System.Windows.Forms.Button BTN_GooiDobbelstenen;
        private System.Windows.Forms.NumericUpDown NUD_AantalOgen;
        private System.Windows.Forms.ListBox LB_Worpen;
        private System.Windows.Forms.GroupBox GB_Resultaat;
        private System.Windows.Forms.Label LBL_WorpenResultaat;
        private System.Windows.Forms.TextBox TB_TotaalAantalOgen;
        private System.Windows.Forms.Label LBL_TotaalAantalOgen;
    }
}

