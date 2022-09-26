
namespace Koers
{
    partial class FRM_Koers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Koers));
            this.PB_Dollar = new System.Windows.Forms.PictureBox();
            this.PB_Euro = new System.Windows.Forms.PictureBox();
            this.TB_Euro = new System.Windows.Forms.TextBox();
            this.TB_Dollar = new System.Windows.Forms.TextBox();
            this.BTN_LessThan = new System.Windows.Forms.Button();
            this.BTN_GreaterThan = new System.Windows.Forms.Button();
            this.LBL_Koers = new System.Windows.Forms.Label();
            this.TB_EuroKoers = new System.Windows.Forms.TextBox();
            this.TB_DollarKoers = new System.Windows.Forms.TextBox();
            this.LBL_IsSign = new System.Windows.Forms.Label();
            this.PB_Lira = new System.Windows.Forms.PictureBox();
            this.TB_EuroNaar = new System.Windows.Forms.TextBox();
            this.BTN_ChangeValuta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Dollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Lira)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Dollar
            // 
            this.PB_Dollar.Image = global::Koers.Properties.Resources.Koers___Dollar;
            this.PB_Dollar.Location = new System.Drawing.Point(663, 12);
            this.PB_Dollar.Name = "PB_Dollar";
            this.PB_Dollar.Size = new System.Drawing.Size(125, 125);
            this.PB_Dollar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Dollar.TabIndex = 0;
            this.PB_Dollar.TabStop = false;
            // 
            // PB_Euro
            // 
            this.PB_Euro.Image = global::Koers.Properties.Resources.Koers___Euro;
            this.PB_Euro.Location = new System.Drawing.Point(12, 12);
            this.PB_Euro.Name = "PB_Euro";
            this.PB_Euro.Size = new System.Drawing.Size(125, 125);
            this.PB_Euro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Euro.TabIndex = 1;
            this.PB_Euro.TabStop = false;
            // 
            // TB_Euro
            // 
            this.TB_Euro.Location = new System.Drawing.Point(188, 110);
            this.TB_Euro.Name = "TB_Euro";
            this.TB_Euro.Size = new System.Drawing.Size(125, 27);
            this.TB_Euro.TabIndex = 2;
            this.TB_Euro.Text = "1,00";
            // 
            // TB_Dollar
            // 
            this.TB_Dollar.Location = new System.Drawing.Point(492, 110);
            this.TB_Dollar.Name = "TB_Dollar";
            this.TB_Dollar.Size = new System.Drawing.Size(125, 27);
            this.TB_Dollar.TabIndex = 3;
            this.TB_Dollar.Text = "1,20";
            // 
            // BTN_LessThan
            // 
            this.BTN_LessThan.Location = new System.Drawing.Point(349, 110);
            this.BTN_LessThan.Name = "BTN_LessThan";
            this.BTN_LessThan.Size = new System.Drawing.Size(44, 27);
            this.BTN_LessThan.TabIndex = 4;
            this.BTN_LessThan.Text = "<";
            this.BTN_LessThan.UseVisualStyleBackColor = true;
            this.BTN_LessThan.Click += new System.EventHandler(this.BTN_LessThan_Click);
            // 
            // BTN_GreaterThan
            // 
            this.BTN_GreaterThan.Location = new System.Drawing.Point(419, 110);
            this.BTN_GreaterThan.Name = "BTN_GreaterThan";
            this.BTN_GreaterThan.Size = new System.Drawing.Size(44, 27);
            this.BTN_GreaterThan.TabIndex = 5;
            this.BTN_GreaterThan.Text = ">";
            this.BTN_GreaterThan.UseVisualStyleBackColor = true;
            this.BTN_GreaterThan.Click += new System.EventHandler(this.BTN_GreaterThan_Click);
            // 
            // LBL_Koers
            // 
            this.LBL_Koers.AutoSize = true;
            this.LBL_Koers.Location = new System.Drawing.Point(297, 227);
            this.LBL_Koers.Name = "LBL_Koers";
            this.LBL_Koers.Size = new System.Drawing.Size(49, 20);
            this.LBL_Koers.TabIndex = 6;
            this.LBL_Koers.Text = "Koers:";
            // 
            // TB_EuroKoers
            // 
            this.TB_EuroKoers.Location = new System.Drawing.Point(349, 224);
            this.TB_EuroKoers.Name = "TB_EuroKoers";
            this.TB_EuroKoers.Size = new System.Drawing.Size(44, 27);
            this.TB_EuroKoers.TabIndex = 7;
            this.TB_EuroKoers.Text = "1,00";
            // 
            // TB_DollarKoers
            // 
            this.TB_DollarKoers.Location = new System.Drawing.Point(419, 224);
            this.TB_DollarKoers.Name = "TB_DollarKoers";
            this.TB_DollarKoers.Size = new System.Drawing.Size(44, 27);
            this.TB_DollarKoers.TabIndex = 8;
            this.TB_DollarKoers.Text = "1,20";
            // 
            // LBL_IsSign
            // 
            this.LBL_IsSign.AutoSize = true;
            this.LBL_IsSign.Location = new System.Drawing.Point(396, 227);
            this.LBL_IsSign.Name = "LBL_IsSign";
            this.LBL_IsSign.Size = new System.Drawing.Size(19, 20);
            this.LBL_IsSign.TabIndex = 9;
            this.LBL_IsSign.Text = "=";
            // 
            // PB_Lira
            // 
            this.PB_Lira.Image = ((System.Drawing.Image)(resources.GetObject("PB_Lira.Image")));
            this.PB_Lira.Location = new System.Drawing.Point(663, 12);
            this.PB_Lira.Name = "PB_Lira";
            this.PB_Lira.Size = new System.Drawing.Size(125, 125);
            this.PB_Lira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Lira.TabIndex = 10;
            this.PB_Lira.TabStop = false;
            this.PB_Lira.Visible = false;
            // 
            // TB_EuroNaar
            // 
            this.TB_EuroNaar.Location = new System.Drawing.Point(349, 12);
            this.TB_EuroNaar.Name = "TB_EuroNaar";
            this.TB_EuroNaar.ReadOnly = true;
            this.TB_EuroNaar.Size = new System.Drawing.Size(114, 27);
            this.TB_EuroNaar.TabIndex = 11;
            this.TB_EuroNaar.Text = "Euro naar Dollar";
            // 
            // BTN_ChangeValuta
            // 
            this.BTN_ChangeValuta.Location = new System.Drawing.Point(663, 147);
            this.BTN_ChangeValuta.Name = "BTN_ChangeValuta";
            this.BTN_ChangeValuta.Size = new System.Drawing.Size(125, 29);
            this.BTN_ChangeValuta.TabIndex = 12;
            this.BTN_ChangeValuta.Text = "Verander Valuta";
            this.BTN_ChangeValuta.UseVisualStyleBackColor = true;
            this.BTN_ChangeValuta.Click += new System.EventHandler(this.BTN_ChangeValuta_Click);
            // 
            // FRM_Koers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 284);
            this.Controls.Add(this.BTN_ChangeValuta);
            this.Controls.Add(this.TB_EuroNaar);
            this.Controls.Add(this.PB_Lira);
            this.Controls.Add(this.LBL_IsSign);
            this.Controls.Add(this.TB_DollarKoers);
            this.Controls.Add(this.TB_EuroKoers);
            this.Controls.Add(this.LBL_Koers);
            this.Controls.Add(this.BTN_GreaterThan);
            this.Controls.Add(this.BTN_LessThan);
            this.Controls.Add(this.TB_Dollar);
            this.Controls.Add(this.TB_Euro);
            this.Controls.Add(this.PB_Euro);
            this.Controls.Add(this.PB_Dollar);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "FRM_Koers";
            this.Text = "Koers";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Dollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Lira)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Dollar;
        private System.Windows.Forms.PictureBox PB_Euro;
        private System.Windows.Forms.TextBox TB_Euro;
        private System.Windows.Forms.TextBox TB_Dollar;
        private System.Windows.Forms.Button BTN_LessThan;
        private System.Windows.Forms.Button BTN_GreaterThan;
        private System.Windows.Forms.Label LBL_Koers;
        private System.Windows.Forms.TextBox TB_EuroKoers;
        private System.Windows.Forms.TextBox TB_DollarKoers;
        private System.Windows.Forms.Label LBL_IsSign;
        private System.Windows.Forms.PictureBox PB_Lira;
        private System.Windows.Forms.TextBox TB_EuroNaar;
        private System.Windows.Forms.Button BTN_ChangeValuta;
    }
}

