
namespace AstroBlastr_Side_Program
{
    partial class FRM_AstroBlastrSideProgram
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
            this.BTN_NieuweSom = new System.Windows.Forms.Button();
            this.TB_answer = new System.Windows.Forms.TextBox();
            this.LBL_som = new System.Windows.Forms.Label();
            this.BTN_checkAnswer = new System.Windows.Forms.Button();
            this.GB_game = new System.Windows.Forms.GroupBox();
            this.LBL_score = new System.Windows.Forms.Label();
            this.GB_account = new System.Windows.Forms.GroupBox();
            this.BTN_createAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.TB_firstName = new System.Windows.Forms.TextBox();
            this.GB_Login = new System.Windows.Forms.GroupBox();
            this.BTN_login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_lastNameLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_passwordLogin = new System.Windows.Forms.TextBox();
            this.TB_firstNameLogin = new System.Windows.Forms.TextBox();
            this.GB_game.SuspendLayout();
            this.GB_account.SuspendLayout();
            this.GB_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_NieuweSom
            // 
            this.BTN_NieuweSom.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_NieuweSom.Location = new System.Drawing.Point(6, 112);
            this.BTN_NieuweSom.Name = "BTN_NieuweSom";
            this.BTN_NieuweSom.Size = new System.Drawing.Size(375, 85);
            this.BTN_NieuweSom.TabIndex = 0;
            this.BTN_NieuweSom.Text = "Nieuwe Som";
            this.BTN_NieuweSom.UseVisualStyleBackColor = true;
            this.BTN_NieuweSom.Click += new System.EventHandler(this.BTN_NieuweSom_Click);
            // 
            // TB_answer
            // 
            this.TB_answer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_answer.Location = new System.Drawing.Point(387, 54);
            this.TB_answer.Name = "TB_answer";
            this.TB_answer.Size = new System.Drawing.Size(125, 52);
            this.TB_answer.TabIndex = 1;
            // 
            // LBL_som
            // 
            this.LBL_som.AutoSize = true;
            this.LBL_som.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_som.Location = new System.Drawing.Point(6, 41);
            this.LBL_som.Name = "LBL_som";
            this.LBL_som.Size = new System.Drawing.Size(83, 46);
            this.LBL_som.TabIndex = 2;
            this.LBL_som.Text = "som";
            // 
            // BTN_checkAnswer
            // 
            this.BTN_checkAnswer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_checkAnswer.Location = new System.Drawing.Point(387, 112);
            this.BTN_checkAnswer.Name = "BTN_checkAnswer";
            this.BTN_checkAnswer.Size = new System.Drawing.Size(387, 85);
            this.BTN_checkAnswer.TabIndex = 3;
            this.BTN_checkAnswer.Text = "Controleer";
            this.BTN_checkAnswer.UseVisualStyleBackColor = true;
            this.BTN_checkAnswer.Click += new System.EventHandler(this.BTN_checkAnswer_Click);
            // 
            // GB_game
            // 
            this.GB_game.Controls.Add(this.LBL_score);
            this.GB_game.Controls.Add(this.LBL_som);
            this.GB_game.Controls.Add(this.TB_answer);
            this.GB_game.Controls.Add(this.BTN_checkAnswer);
            this.GB_game.Controls.Add(this.BTN_NieuweSom);
            this.GB_game.Enabled = false;
            this.GB_game.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GB_game.Location = new System.Drawing.Point(12, 235);
            this.GB_game.Name = "GB_game";
            this.GB_game.Size = new System.Drawing.Size(780, 203);
            this.GB_game.TabIndex = 4;
            this.GB_game.TabStop = false;
            this.GB_game.Text = "Game";
            // 
            // LBL_score
            // 
            this.LBL_score.AutoSize = true;
            this.LBL_score.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_score.Location = new System.Drawing.Point(590, 23);
            this.LBL_score.Name = "LBL_score";
            this.LBL_score.Size = new System.Drawing.Size(135, 19);
            this.LBL_score.TabIndex = 4;
            this.LBL_score.Text = "Score: + speler.Score";
            // 
            // GB_account
            // 
            this.GB_account.Controls.Add(this.BTN_createAccount);
            this.GB_account.Controls.Add(this.label3);
            this.GB_account.Controls.Add(this.label2);
            this.GB_account.Controls.Add(this.TB_lastName);
            this.GB_account.Controls.Add(this.label1);
            this.GB_account.Controls.Add(this.TB_password);
            this.GB_account.Controls.Add(this.TB_firstName);
            this.GB_account.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GB_account.Location = new System.Drawing.Point(12, 12);
            this.GB_account.Name = "GB_account";
            this.GB_account.Size = new System.Drawing.Size(381, 226);
            this.GB_account.TabIndex = 5;
            this.GB_account.TabStop = false;
            this.GB_account.Text = "Account";
            // 
            // BTN_createAccount
            // 
            this.BTN_createAccount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_createAccount.Location = new System.Drawing.Point(9, 135);
            this.BTN_createAccount.Name = "BTN_createAccount";
            this.BTN_createAccount.Size = new System.Drawing.Size(366, 82);
            this.BTN_createAccount.TabIndex = 7;
            this.BTN_createAccount.Text = "Account maken";
            this.BTN_createAccount.UseVisualStyleBackColor = true;
            this.BTN_createAccount.Click += new System.EventHandler(this.BTN_createAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wachtwoord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Achternaam";
            // 
            // TB_lastName
            // 
            this.TB_lastName.Location = new System.Drawing.Point(104, 69);
            this.TB_lastName.Name = "TB_lastName";
            this.TB_lastName.Size = new System.Drawing.Size(271, 27);
            this.TB_lastName.TabIndex = 3;
            this.TB_lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_lastName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voornaam";
            // 
            // TB_password
            // 
            this.TB_password.Location = new System.Drawing.Point(104, 102);
            this.TB_password.Name = "TB_password";
            this.TB_password.PasswordChar = '•';
            this.TB_password.Size = new System.Drawing.Size(271, 27);
            this.TB_password.TabIndex = 1;
            // 
            // TB_firstName
            // 
            this.TB_firstName.Location = new System.Drawing.Point(104, 36);
            this.TB_firstName.Name = "TB_firstName";
            this.TB_firstName.Size = new System.Drawing.Size(271, 27);
            this.TB_firstName.TabIndex = 0;
            this.TB_firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_firstName_KeyPress);
            // 
            // GB_Login
            // 
            this.GB_Login.Controls.Add(this.BTN_login);
            this.GB_Login.Controls.Add(this.label4);
            this.GB_Login.Controls.Add(this.label5);
            this.GB_Login.Controls.Add(this.TB_lastNameLogin);
            this.GB_Login.Controls.Add(this.label6);
            this.GB_Login.Controls.Add(this.TB_passwordLogin);
            this.GB_Login.Controls.Add(this.TB_firstNameLogin);
            this.GB_Login.Enabled = false;
            this.GB_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GB_Login.Location = new System.Drawing.Point(399, 12);
            this.GB_Login.Name = "GB_Login";
            this.GB_Login.Size = new System.Drawing.Size(387, 226);
            this.GB_Login.TabIndex = 8;
            this.GB_Login.TabStop = false;
            this.GB_Login.Text = "Login";
            // 
            // BTN_login
            // 
            this.BTN_login.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_login.Location = new System.Drawing.Point(9, 135);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(372, 82);
            this.BTN_login.TabIndex = 7;
            this.BTN_login.Text = "Inloggen";
            this.BTN_login.UseVisualStyleBackColor = true;
            this.BTN_login.Click += new System.EventHandler(this.BTN_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wachtwoord";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Achternaam";
            // 
            // TB_lastNameLogin
            // 
            this.TB_lastNameLogin.Location = new System.Drawing.Point(104, 69);
            this.TB_lastNameLogin.Name = "TB_lastNameLogin";
            this.TB_lastNameLogin.Size = new System.Drawing.Size(277, 27);
            this.TB_lastNameLogin.TabIndex = 3;
            this.TB_lastNameLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_lastNameLogin_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Voornaam";
            // 
            // TB_passwordLogin
            // 
            this.TB_passwordLogin.Location = new System.Drawing.Point(104, 102);
            this.TB_passwordLogin.Name = "TB_passwordLogin";
            this.TB_passwordLogin.PasswordChar = '•';
            this.TB_passwordLogin.Size = new System.Drawing.Size(277, 27);
            this.TB_passwordLogin.TabIndex = 1;
            // 
            // TB_firstNameLogin
            // 
            this.TB_firstNameLogin.Location = new System.Drawing.Point(104, 36);
            this.TB_firstNameLogin.Name = "TB_firstNameLogin";
            this.TB_firstNameLogin.Size = new System.Drawing.Size(277, 27);
            this.TB_firstNameLogin.TabIndex = 0;
            this.TB_firstNameLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_firstNameLogin_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.GB_Login);
            this.Controls.Add(this.GB_account);
            this.Controls.Add(this.GB_game);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "AstroBlastr Side Program";
            this.GB_game.ResumeLayout(false);
            this.GB_game.PerformLayout();
            this.GB_account.ResumeLayout(false);
            this.GB_account.PerformLayout();
            this.GB_Login.ResumeLayout(false);
            this.GB_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_NieuweSom;
        private System.Windows.Forms.TextBox TB_answer;
        private System.Windows.Forms.Label LBL_som;
        private System.Windows.Forms.Button BTN_checkAnswer;
        private System.Windows.Forms.GroupBox GB_game;
        private System.Windows.Forms.GroupBox GB_account;
        private System.Windows.Forms.Button BTN_createAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_lastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.TextBox TB_firstName;
        private System.Windows.Forms.GroupBox GB_Login;
        private System.Windows.Forms.Button BTN_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_lastNameLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_passwordLogin;
        private System.Windows.Forms.TextBox TB_firstNameLogin;
        private System.Windows.Forms.Label LBL_score;
    }
}

