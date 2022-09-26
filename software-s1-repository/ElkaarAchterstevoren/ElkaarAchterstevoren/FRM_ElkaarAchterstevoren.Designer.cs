
namespace ElkaarAchterstevoren
{
    partial class FRM_ElkaarAchterstevoren
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
            this.TB_Woord = new System.Windows.Forms.TextBox();
            this.GB_Group = new System.Windows.Forms.GroupBox();
            this.TB_Achterstevoren = new System.Windows.Forms.TextBox();
            this.LBL_Achterstevoren = new System.Windows.Forms.Label();
            this.LBL_Woord = new System.Windows.Forms.Label();
            this.GB_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Woord
            // 
            this.TB_Woord.Location = new System.Drawing.Point(125, 42);
            this.TB_Woord.Name = "TB_Woord";
            this.TB_Woord.Size = new System.Drawing.Size(155, 27);
            this.TB_Woord.TabIndex = 0;
            this.TB_Woord.TextChanged += new System.EventHandler(this.TB_Woord_TextChanged);
            // 
            // GB_Group
            // 
            this.GB_Group.Controls.Add(this.TB_Achterstevoren);
            this.GB_Group.Controls.Add(this.LBL_Achterstevoren);
            this.GB_Group.Controls.Add(this.LBL_Woord);
            this.GB_Group.Controls.Add(this.TB_Woord);
            this.GB_Group.Location = new System.Drawing.Point(12, 12);
            this.GB_Group.Name = "GB_Group";
            this.GB_Group.Size = new System.Drawing.Size(286, 107);
            this.GB_Group.TabIndex = 1;
            this.GB_Group.TabStop = false;
            this.GB_Group.Text = "Group";
            // 
            // TB_Achterstevoren
            // 
            this.TB_Achterstevoren.Location = new System.Drawing.Point(125, 73);
            this.TB_Achterstevoren.Name = "TB_Achterstevoren";
            this.TB_Achterstevoren.Size = new System.Drawing.Size(155, 27);
            this.TB_Achterstevoren.TabIndex = 3;
            this.TB_Achterstevoren.TextChanged += new System.EventHandler(this.TB_Achterstevoren_TextChanged);
            // 
            // LBL_Achterstevoren
            // 
            this.LBL_Achterstevoren.AutoSize = true;
            this.LBL_Achterstevoren.Location = new System.Drawing.Point(6, 76);
            this.LBL_Achterstevoren.Name = "LBL_Achterstevoren";
            this.LBL_Achterstevoren.Size = new System.Drawing.Size(111, 20);
            this.LBL_Achterstevoren.TabIndex = 2;
            this.LBL_Achterstevoren.Text = "Achterstevoren:";
            // 
            // LBL_Woord
            // 
            this.LBL_Woord.AutoSize = true;
            this.LBL_Woord.Location = new System.Drawing.Point(6, 45);
            this.LBL_Woord.Name = "LBL_Woord";
            this.LBL_Woord.Size = new System.Drawing.Size(57, 20);
            this.LBL_Woord.TabIndex = 1;
            this.LBL_Woord.Text = "Woord:";
            // 
            // FRM_EA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(310, 130);
            this.Controls.Add(this.GB_Group);
            this.Name = "FRM_EA";
            this.Text = "Elkaar Achterstevoren";
            this.GB_Group.ResumeLayout(false);
            this.GB_Group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Woord;
        private System.Windows.Forms.GroupBox GB_Group;
        private System.Windows.Forms.Label LBL_Woord;
        private System.Windows.Forms.TextBox TB_Achterstevoren;
        private System.Windows.Forms.Label LBL_Achterstevoren;
    }
}

