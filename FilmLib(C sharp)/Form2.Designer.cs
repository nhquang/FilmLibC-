namespace FilmLib_C_sharp_
{
    partial class Form2
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
            this.logInLbl = new System.Windows.Forms.Label();
            this.usrLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.usr = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logInLbl
            // 
            this.logInLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLbl.Location = new System.Drawing.Point(12, 9);
            this.logInLbl.Name = "logInLbl";
            this.logInLbl.Size = new System.Drawing.Size(371, 49);
            this.logInLbl.TabIndex = 0;
            this.logInLbl.Text = "Log In";
            this.logInLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usrLbl
            // 
            this.usrLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrLbl.Location = new System.Drawing.Point(17, 79);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(122, 23);
            this.usrLbl.TabIndex = 1;
            this.usrLbl.Text = "Username:";
            this.usrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passLbl
            // 
            this.passLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.Location = new System.Drawing.Point(17, 119);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(122, 19);
            this.passLbl.TabIndex = 2;
            this.passLbl.Text = "Password:";
            this.passLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usr
            // 
            this.usr.Location = new System.Drawing.Point(145, 82);
            this.usr.Name = "usr";
            this.usr.Size = new System.Drawing.Size(198, 20);
            this.usr.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(145, 120);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(198, 20);
            this.pass.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(13, 179);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(81, 35);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(302, 179);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(81, 35);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 226);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.usr);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.usrLbl);
            this.Controls.Add(this.logInLbl);
            this.Name = "Form2";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logInLbl;
        private System.Windows.Forms.Label usrLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox usr;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}