
namespace Create_Blocks
{
    partial class FRM_CreateBlocks
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
            this.BTN_CreateBlock = new System.Windows.Forms.Button();
            this.GB_Settings = new System.Windows.Forms.GroupBox();
            this.RB_Green = new System.Windows.Forms.RadioButton();
            this.RB_Blue = new System.Windows.Forms.RadioButton();
            this.RB_Red = new System.Windows.Forms.RadioButton();
            this.GB_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_CreateBlock
            // 
            this.BTN_CreateBlock.Location = new System.Drawing.Point(332, 16);
            this.BTN_CreateBlock.Name = "BTN_CreateBlock";
            this.BTN_CreateBlock.Size = new System.Drawing.Size(108, 102);
            this.BTN_CreateBlock.TabIndex = 0;
            this.BTN_CreateBlock.Text = "Create Block";
            this.BTN_CreateBlock.UseVisualStyleBackColor = true;
            this.BTN_CreateBlock.Click += new System.EventHandler(this.BTN_CreateBlock_Click);
            // 
            // GB_Settings
            // 
            this.GB_Settings.Controls.Add(this.RB_Green);
            this.GB_Settings.Controls.Add(this.RB_Blue);
            this.GB_Settings.Controls.Add(this.RB_Red);
            this.GB_Settings.Controls.Add(this.BTN_CreateBlock);
            this.GB_Settings.Location = new System.Drawing.Point(10, 316);
            this.GB_Settings.Name = "GB_Settings";
            this.GB_Settings.Size = new System.Drawing.Size(448, 125);
            this.GB_Settings.TabIndex = 1;
            this.GB_Settings.TabStop = false;
            this.GB_Settings.Text = "Settings";
            // 
            // RB_Green
            // 
            this.RB_Green.AutoSize = true;
            this.RB_Green.Location = new System.Drawing.Point(16, 85);
            this.RB_Green.Name = "RB_Green";
            this.RB_Green.Size = new System.Drawing.Size(69, 24);
            this.RB_Green.TabIndex = 4;
            this.RB_Green.TabStop = true;
            this.RB_Green.Text = "Green";
            this.RB_Green.UseVisualStyleBackColor = true;
            // 
            // RB_Blue
            // 
            this.RB_Blue.AutoSize = true;
            this.RB_Blue.Location = new System.Drawing.Point(16, 55);
            this.RB_Blue.Name = "RB_Blue";
            this.RB_Blue.Size = new System.Drawing.Size(59, 24);
            this.RB_Blue.TabIndex = 3;
            this.RB_Blue.TabStop = true;
            this.RB_Blue.Text = "Blue";
            this.RB_Blue.UseVisualStyleBackColor = true;
            // 
            // RB_Red
            // 
            this.RB_Red.AutoSize = true;
            this.RB_Red.Location = new System.Drawing.Point(16, 26);
            this.RB_Red.Name = "RB_Red";
            this.RB_Red.Size = new System.Drawing.Size(56, 24);
            this.RB_Red.TabIndex = 2;
            this.RB_Red.TabStop = true;
            this.RB_Red.Text = "Red";
            this.RB_Red.UseVisualStyleBackColor = true;
            // 
            // FRM_CreateBlocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(468, 453);
            this.Controls.Add(this.GB_Settings);
            this.Name = "FRM_CreateBlocks";
            this.Text = "Create Blocks";
            this.GB_Settings.ResumeLayout(false);
            this.GB_Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_CreateBlock;
        private System.Windows.Forms.GroupBox GB_Settings;
        private System.Windows.Forms.RadioButton RB_Green;
        private System.Windows.Forms.RadioButton RB_Blue;
        private System.Windows.Forms.RadioButton RB_Red;
    }
}

