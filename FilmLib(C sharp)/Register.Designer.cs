namespace FilmLib_C_sharp_
{
    partial class Register
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.usr = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.conPass = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.usrLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.lnameLbl = new System.Windows.Forms.Label();
            this.fnameLbl = new System.Windows.Forms.Label();
            this.regLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(282, 387);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(79, 35);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Back";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.Location = new System.Drawing.Point(12, 387);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(79, 35);
            this.signUpBtn.TabIndex = 7;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // confirmPass
            // 
            this.confirmPass.Location = new System.Drawing.Point(168, 343);
            this.confirmPass.MaxLength = 21;
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.PasswordChar = '*';
            this.confirmPass.Size = new System.Drawing.Size(193, 20);
            this.confirmPass.TabIndex = 6;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(168, 308);
            this.pass.MaxLength = 21;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(193, 20);
            this.pass.TabIndex = 5;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(168, 168);
            this.lName.MaxLength = 21;
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(193, 20);
            this.lName.TabIndex = 2;
            // 
            // usr
            // 
            this.usr.Location = new System.Drawing.Point(168, 273);
            this.usr.MaxLength = 21;
            this.usr.Name = "usr";
            this.usr.Size = new System.Drawing.Size(193, 20);
            this.usr.TabIndex = 4;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(168, 203);
            this.age.MaxLength = 2;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(193, 20);
            this.age.TabIndex = 3;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(168, 133);
            this.fname.MaxLength = 21;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(193, 20);
            this.fname.TabIndex = 1;
            // 
            // conPass
            // 
            this.conPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPass.Location = new System.Drawing.Point(-2, 334);
            this.conPass.Name = "conPass";
            this.conPass.Size = new System.Drawing.Size(135, 35);
            this.conPass.TabIndex = 20;
            this.conPass.Text = "Confirm Password:";
            this.conPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passLbl
            // 
            this.passLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.Location = new System.Drawing.Point(56, 299);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(77, 35);
            this.passLbl.TabIndex = 18;
            this.passLbl.Text = "Password:";
            this.passLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usrLbl
            // 
            this.usrLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrLbl.Location = new System.Drawing.Point(48, 264);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(85, 35);
            this.usrLbl.TabIndex = 16;
            this.usrLbl.Text = "Username:";
            this.usrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ageLbl
            // 
            this.ageLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLbl.Location = new System.Drawing.Point(60, 194);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(73, 35);
            this.ageLbl.TabIndex = 14;
            this.ageLbl.Text = "Age:";
            this.ageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnameLbl
            // 
            this.lnameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLbl.Location = new System.Drawing.Point(18, 159);
            this.lnameLbl.Name = "lnameLbl";
            this.lnameLbl.Size = new System.Drawing.Size(115, 35);
            this.lnameLbl.TabIndex = 12;
            this.lnameLbl.Text = "Last Name:";
            this.lnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fnameLbl
            // 
            this.fnameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLbl.Location = new System.Drawing.Point(22, 124);
            this.fnameLbl.Name = "fnameLbl";
            this.fnameLbl.Size = new System.Drawing.Size(111, 35);
            this.fnameLbl.TabIndex = 10;
            this.fnameLbl.Text = "First Name:";
            this.fnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // regLbl
            // 
            this.regLbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLbl.Location = new System.Drawing.Point(12, 9);
            this.regLbl.Name = "regLbl";
            this.regLbl.Size = new System.Drawing.Size(349, 52);
            this.regLbl.TabIndex = 23;
            this.regLbl.Text = "Register";
            this.regLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genderLbl
            // 
            this.genderLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.Location = new System.Drawing.Point(60, 229);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(73, 35);
            this.genderLbl.TabIndex = 0;
            this.genderLbl.Text = "Gender:";
            this.genderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.Location = new System.Drawing.Point(168, 239);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(222, 239);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 0;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 431);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.regLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.usr);
            this.Controls.Add(this.age);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.conPass);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.usrLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.lnameLbl);
            this.Controls.Add(this.fnameLbl);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button exitBtn;
        internal System.Windows.Forms.Button signUpBtn;
        internal System.Windows.Forms.TextBox confirmPass;
        internal System.Windows.Forms.TextBox pass;
        internal System.Windows.Forms.TextBox lName;
        internal System.Windows.Forms.TextBox usr;
        internal System.Windows.Forms.TextBox age;
        internal System.Windows.Forms.TextBox fname;
        internal System.Windows.Forms.Label conPass;
        internal System.Windows.Forms.Label passLbl;
        internal System.Windows.Forms.Label usrLbl;
        internal System.Windows.Forms.Label ageLbl;
        internal System.Windows.Forms.Label lnameLbl;
        internal System.Windows.Forms.Label fnameLbl;
        internal System.Windows.Forms.Label regLbl;
        internal System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
    }
}