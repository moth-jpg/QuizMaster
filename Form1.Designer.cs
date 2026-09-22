namespace QuizMaster
{
    partial class Form1
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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbpLogin = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegisterHere = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxLoginPassword = new System.Windows.Forms.TextBox();
            this.tbxLoginName = new System.Windows.Forms.TextBox();
            this.tbpRegister = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoginHere = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbxRegisterPassword = new System.Windows.Forms.TextBox();
            this.tbxRegisterName = new System.Windows.Forms.TextBox();
            this.tbpGame = new System.Windows.Forms.TabPage();
            this.pnlChooseGameMode = new System.Windows.Forms.Panel();
            this.btnGameModeThree = new System.Windows.Forms.Button();
            this.btnGameModeTwo = new System.Windows.Forms.Button();
            this.btnGameModeOne = new System.Windows.Forms.Button();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.tbControl.SuspendLayout();
            this.tbpLogin.SuspendLayout();
            this.tbpRegister.SuspendLayout();
            this.tbpGame.SuspendLayout();
            this.pnlChooseGameMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbpLogin);
            this.tbControl.Controls.Add(this.tbpRegister);
            this.tbControl.Controls.Add(this.tbpGame);
            this.tbControl.Location = new System.Drawing.Point(12, 25);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(776, 413);
            this.tbControl.TabIndex = 0;
            // 
            // tbpLogin
            // 
            this.tbpLogin.Controls.Add(this.label2);
            this.tbpLogin.Controls.Add(this.label1);
            this.tbpLogin.Controls.Add(this.btnRegisterHere);
            this.tbpLogin.Controls.Add(this.btnLogin);
            this.tbpLogin.Controls.Add(this.tbxLoginPassword);
            this.tbpLogin.Controls.Add(this.tbxLoginName);
            this.tbpLogin.Location = new System.Drawing.Point(4, 25);
            this.tbpLogin.Name = "tbpLogin";
            this.tbpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLogin.Size = new System.Drawing.Size(768, 384);
            this.tbpLogin.TabIndex = 0;
            this.tbpLogin.Text = "Login";
            this.tbpLogin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player Name";
            // 
            // btnRegisterHere
            // 
            this.btnRegisterHere.Location = new System.Drawing.Point(76, 255);
            this.btnRegisterHere.Name = "btnRegisterHere";
            this.btnRegisterHere.Size = new System.Drawing.Size(127, 28);
            this.btnRegisterHere.TabIndex = 3;
            this.btnRegisterHere.Text = "Register Here";
            this.btnRegisterHere.UseVisualStyleBackColor = true;
            this.btnRegisterHere.Click += new System.EventHandler(this.btnRegisterHere_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(100, 205);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login\r\n";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxLoginPassword
            // 
            this.tbxLoginPassword.Location = new System.Drawing.Point(65, 134);
            this.tbxLoginPassword.Name = "tbxLoginPassword";
            this.tbxLoginPassword.Size = new System.Drawing.Size(162, 22);
            this.tbxLoginPassword.TabIndex = 1;
            // 
            // tbxLoginName
            // 
            this.tbxLoginName.Location = new System.Drawing.Point(65, 62);
            this.tbxLoginName.Name = "tbxLoginName";
            this.tbxLoginName.Size = new System.Drawing.Size(162, 22);
            this.tbxLoginName.TabIndex = 0;
            // 
            // tbpRegister
            // 
            this.tbpRegister.Controls.Add(this.label4);
            this.tbpRegister.Controls.Add(this.label3);
            this.tbpRegister.Controls.Add(this.btnLoginHere);
            this.tbpRegister.Controls.Add(this.btnRegister);
            this.tbpRegister.Controls.Add(this.tbxRegisterPassword);
            this.tbpRegister.Controls.Add(this.tbxRegisterName);
            this.tbpRegister.Location = new System.Drawing.Point(4, 25);
            this.tbpRegister.Name = "tbpRegister";
            this.tbpRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegister.Size = new System.Drawing.Size(768, 384);
            this.tbpRegister.TabIndex = 1;
            this.tbpRegister.Text = "Register";
            this.tbpRegister.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player Name";
            // 
            // btnLoginHere
            // 
            this.btnLoginHere.Location = new System.Drawing.Point(106, 239);
            this.btnLoginHere.Name = "btnLoginHere";
            this.btnLoginHere.Size = new System.Drawing.Size(109, 23);
            this.btnLoginHere.TabIndex = 3;
            this.btnLoginHere.Text = "Login Here";
            this.btnLoginHere.UseVisualStyleBackColor = true;
            this.btnLoginHere.Click += new System.EventHandler(this.btnLoginHere_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(123, 187);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbxRegisterPassword
            // 
            this.tbxRegisterPassword.Location = new System.Drawing.Point(106, 119);
            this.tbxRegisterPassword.Name = "tbxRegisterPassword";
            this.tbxRegisterPassword.Size = new System.Drawing.Size(129, 22);
            this.tbxRegisterPassword.TabIndex = 1;
            // 
            // tbxRegisterName
            // 
            this.tbxRegisterName.Location = new System.Drawing.Point(106, 61);
            this.tbxRegisterName.Name = "tbxRegisterName";
            this.tbxRegisterName.Size = new System.Drawing.Size(129, 22);
            this.tbxRegisterName.TabIndex = 0;
            // 
            // tbpGame
            // 
            this.tbpGame.Controls.Add(this.pnlChooseGameMode);
            this.tbpGame.Location = new System.Drawing.Point(4, 25);
            this.tbpGame.Name = "tbpGame";
            this.tbpGame.Size = new System.Drawing.Size(768, 384);
            this.tbpGame.TabIndex = 2;
            this.tbpGame.Text = "Game";
            this.tbpGame.UseVisualStyleBackColor = true;
            // 
            // pnlChooseGameMode
            // 
            this.pnlChooseGameMode.Controls.Add(this.btnGameModeThree);
            this.pnlChooseGameMode.Controls.Add(this.btnGameModeTwo);
            this.pnlChooseGameMode.Controls.Add(this.btnGameModeOne);
            this.pnlChooseGameMode.Location = new System.Drawing.Point(418, 2);
            this.pnlChooseGameMode.Name = "pnlChooseGameMode";
            this.pnlChooseGameMode.Size = new System.Drawing.Size(349, 381);
            this.pnlChooseGameMode.TabIndex = 0;
            // 
            // btnGameModeThree
            // 
            this.btnGameModeThree.Location = new System.Drawing.Point(120, 181);
            this.btnGameModeThree.Name = "btnGameModeThree";
            this.btnGameModeThree.Size = new System.Drawing.Size(75, 23);
            this.btnGameModeThree.TabIndex = 2;
            this.btnGameModeThree.Text = "button3";
            this.btnGameModeThree.UseVisualStyleBackColor = true;
            this.btnGameModeThree.Click += new System.EventHandler(this.btnGameModeThree_Click);
            // 
            // btnGameModeTwo
            // 
            this.btnGameModeTwo.Location = new System.Drawing.Point(120, 120);
            this.btnGameModeTwo.Name = "btnGameModeTwo";
            this.btnGameModeTwo.Size = new System.Drawing.Size(75, 23);
            this.btnGameModeTwo.TabIndex = 1;
            this.btnGameModeTwo.Text = "button2";
            this.btnGameModeTwo.UseVisualStyleBackColor = true;
            this.btnGameModeTwo.Click += new System.EventHandler(this.btnGameModeTwo_Click);
            // 
            // btnGameModeOne
            // 
            this.btnGameModeOne.Location = new System.Drawing.Point(120, 71);
            this.btnGameModeOne.Name = "btnGameModeOne";
            this.btnGameModeOne.Size = new System.Drawing.Size(75, 23);
            this.btnGameModeOne.TabIndex = 0;
            this.btnGameModeOne.Text = "button1";
            this.btnGameModeOne.UseVisualStyleBackColor = true;
            this.btnGameModeOne.Click += new System.EventHandler(this.btnGameModeOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbControl.ResumeLayout(false);
            this.tbpLogin.ResumeLayout(false);
            this.tbpLogin.PerformLayout();
            this.tbpRegister.ResumeLayout(false);
            this.tbpRegister.PerformLayout();
            this.tbpGame.ResumeLayout(false);
            this.pnlChooseGameMode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbpLogin;
        private System.Windows.Forms.TabPage tbpRegister;
        private System.Windows.Forms.TabPage tbpGame;
        private System.Windows.Forms.TextBox tbxLoginPassword;
        private System.Windows.Forms.TextBox tbxLoginName;
        private System.Windows.Forms.Button btnRegisterHere;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoginHere;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbxRegisterPassword;
        private System.Windows.Forms.TextBox tbxRegisterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlChooseGameMode;
        private System.Windows.Forms.Button btnGameModeThree;
        private System.Windows.Forms.Button btnGameModeTwo;
        private System.Windows.Forms.Button btnGameModeOne;
        private System.Windows.Forms.Timer tmrGame;
    }
}

