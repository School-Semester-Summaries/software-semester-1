
namespace Goeroe_Calculator
{
    partial class FRM_GoeroeCalculator
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
            this.LBL_Getal1 = new System.Windows.Forms.Label();
            this.LBL_Getal2 = new System.Windows.Forms.Label();
            this.TB_Getal1 = new System.Windows.Forms.TextBox();
            this.TB_Getal2 = new System.Windows.Forms.TextBox();
            this.BTN_Plus = new System.Windows.Forms.Button();
            this.LBL_Uitkomst = new System.Windows.Forms.Label();
            this.TB_Uitkomst = new System.Windows.Forms.TextBox();
            this.BTN_Keer = new System.Windows.Forms.Button();
            this.BTN_Min = new System.Windows.Forms.Button();
            this.BTN_Delen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Getal1
            // 
            this.LBL_Getal1.AutoSize = true;
            this.LBL_Getal1.Location = new System.Drawing.Point(23, 27);
            this.LBL_Getal1.Name = "LBL_Getal1";
            this.LBL_Getal1.Size = new System.Drawing.Size(56, 20);
            this.LBL_Getal1.TabIndex = 0;
            this.LBL_Getal1.Text = "Getal 1";
            // 
            // LBL_Getal2
            // 
            this.LBL_Getal2.AutoSize = true;
            this.LBL_Getal2.Location = new System.Drawing.Point(23, 80);
            this.LBL_Getal2.Name = "LBL_Getal2";
            this.LBL_Getal2.Size = new System.Drawing.Size(56, 20);
            this.LBL_Getal2.TabIndex = 1;
            this.LBL_Getal2.Text = "Getal 2";
            // 
            // TB_Getal1
            // 
            this.TB_Getal1.Location = new System.Drawing.Point(23, 50);
            this.TB_Getal1.Name = "TB_Getal1";
            this.TB_Getal1.Size = new System.Drawing.Size(125, 27);
            this.TB_Getal1.TabIndex = 2;
            // 
            // TB_Getal2
            // 
            this.TB_Getal2.Location = new System.Drawing.Point(23, 103);
            this.TB_Getal2.Name = "TB_Getal2";
            this.TB_Getal2.Size = new System.Drawing.Size(125, 27);
            this.TB_Getal2.TabIndex = 3;
            // 
            // BTN_Plus
            // 
            this.BTN_Plus.Location = new System.Drawing.Point(232, 50);
            this.BTN_Plus.Name = "BTN_Plus";
            this.BTN_Plus.Size = new System.Drawing.Size(27, 27);
            this.BTN_Plus.TabIndex = 4;
            this.BTN_Plus.Text = "+";
            this.BTN_Plus.UseVisualStyleBackColor = true;
            this.BTN_Plus.Click += new System.EventHandler(this.BTN_Plus_Click);
            // 
            // LBL_Uitkomst
            // 
            this.LBL_Uitkomst.AutoSize = true;
            this.LBL_Uitkomst.Location = new System.Drawing.Point(309, 27);
            this.LBL_Uitkomst.Name = "LBL_Uitkomst";
            this.LBL_Uitkomst.Size = new System.Drawing.Size(68, 20);
            this.LBL_Uitkomst.TabIndex = 5;
            this.LBL_Uitkomst.Text = "Uitkomst";
            // 
            // TB_Uitkomst
            // 
            this.TB_Uitkomst.Location = new System.Drawing.Point(309, 50);
            this.TB_Uitkomst.Name = "TB_Uitkomst";
            this.TB_Uitkomst.ReadOnly = true;
            this.TB_Uitkomst.Size = new System.Drawing.Size(125, 27);
            this.TB_Uitkomst.TabIndex = 6;
            // 
            // BTN_Keer
            // 
            this.BTN_Keer.Location = new System.Drawing.Point(189, 50);
            this.BTN_Keer.Name = "BTN_Keer";
            this.BTN_Keer.Size = new System.Drawing.Size(27, 27);
            this.BTN_Keer.TabIndex = 7;
            this.BTN_Keer.Text = "x";
            this.BTN_Keer.UseVisualStyleBackColor = true;
            this.BTN_Keer.Click += new System.EventHandler(this.BTN_Keer_Click);
            // 
            // BTN_Min
            // 
            this.BTN_Min.Location = new System.Drawing.Point(189, 103);
            this.BTN_Min.Name = "BTN_Min";
            this.BTN_Min.Size = new System.Drawing.Size(27, 27);
            this.BTN_Min.TabIndex = 8;
            this.BTN_Min.Text = "-";
            this.BTN_Min.UseVisualStyleBackColor = true;
            this.BTN_Min.Click += new System.EventHandler(this.BTN_Min_Click);
            // 
            // BTN_Delen
            // 
            this.BTN_Delen.Location = new System.Drawing.Point(232, 103);
            this.BTN_Delen.Name = "BTN_Delen";
            this.BTN_Delen.Size = new System.Drawing.Size(27, 27);
            this.BTN_Delen.TabIndex = 9;
            this.BTN_Delen.Text = ":";
            this.BTN_Delen.UseVisualStyleBackColor = true;
            this.BTN_Delen.Click += new System.EventHandler(this.BTN_Delen_Click);
            // 
            // FRM_GoeroeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 189);
            this.Controls.Add(this.BTN_Delen);
            this.Controls.Add(this.BTN_Min);
            this.Controls.Add(this.BTN_Keer);
            this.Controls.Add(this.TB_Uitkomst);
            this.Controls.Add(this.LBL_Uitkomst);
            this.Controls.Add(this.BTN_Plus);
            this.Controls.Add(this.TB_Getal2);
            this.Controls.Add(this.TB_Getal1);
            this.Controls.Add(this.LBL_Getal2);
            this.Controls.Add(this.LBL_Getal1);
            this.Name = "FRM_GoeroeCalculator";
            this.Text = "Goeroe Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Getal1;
        private System.Windows.Forms.Label LBL_Getal2;
        private System.Windows.Forms.TextBox TB_Getal1;
        private System.Windows.Forms.TextBox TB_Getal2;
        private System.Windows.Forms.Button BTN_Plus;
        private System.Windows.Forms.Label LBL_Uitkomst;
        private System.Windows.Forms.TextBox TB_Uitkomst;
        private System.Windows.Forms.Button BTN_Keer;
        private System.Windows.Forms.Button BTN_Min;
        private System.Windows.Forms.Button BTN_Delen;
    }
}

