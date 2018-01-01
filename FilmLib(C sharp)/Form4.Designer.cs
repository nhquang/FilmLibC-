namespace FilmLib_C_sharp_
{
    partial class Form4
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
            this.signOutBtn = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.rmBtn = new System.Windows.Forms.Button();
            this.addMovBtn = new System.Windows.Forms.Button();
            this.filmList = new System.Windows.Forms.ListBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.editProfileBtn = new System.Windows.Forms.Button();
            this.ageLbl = new System.Windows.Forms.Label();
            this.rateLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signOutBtn
            // 
            this.signOutBtn.Location = new System.Drawing.Point(497, 431);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(78, 26);
            this.signOutBtn.TabIndex = 7;
            this.signOutBtn.Text = "Sign out";
            this.signOutBtn.UseVisualStyleBackColor = true;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.searchBtn);
            this.Panel2.Controls.Add(this.search);
            this.Panel2.Controls.Add(this.rmBtn);
            this.Panel2.Controls.Add(this.addMovBtn);
            this.Panel2.Controls.Add(this.filmList);
            this.Panel2.Location = new System.Drawing.Point(303, 98);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(275, 320);
            this.Panel2.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(200, 171);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(72, 23);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(6, 173);
            this.search.MaxLength = 15;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(184, 20);
            this.search.TabIndex = 4;
            // 
            // rmBtn
            // 
            this.rmBtn.Location = new System.Drawing.Point(150, 101);
            this.rmBtn.Name = "rmBtn";
            this.rmBtn.Size = new System.Drawing.Size(122, 23);
            this.rmBtn.TabIndex = 3;
            this.rmBtn.Text = "Remove from favourite";
            this.rmBtn.UseVisualStyleBackColor = true;
            // 
            // addMovBtn
            // 
            this.addMovBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovBtn.Location = new System.Drawing.Point(6, 256);
            this.addMovBtn.Name = "addMovBtn";
            this.addMovBtn.Size = new System.Drawing.Size(266, 64);
            this.addMovBtn.TabIndex = 6;
            this.addMovBtn.Text = "Add a movie";
            this.addMovBtn.UseVisualStyleBackColor = true;
            // 
            // filmList
            // 
            this.filmList.FormattingEnabled = true;
            this.filmList.Location = new System.Drawing.Point(6, 13);
            this.filmList.Name = "filmList";
            this.filmList.Size = new System.Drawing.Size(266, 82);
            this.filmList.TabIndex = 2;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.editProfileBtn);
            this.Panel1.Controls.Add(this.ageLbl);
            this.Panel1.Controls.Add(this.rateLbl);
            this.Panel1.Controls.Add(this.nameLbl);
            this.Panel1.Location = new System.Drawing.Point(21, 98);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(275, 320);
            this.Panel1.TabIndex = 10;
            // 
            // editProfileBtn
            // 
            this.editProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfileBtn.Location = new System.Drawing.Point(3, 256);
            this.editProfileBtn.Name = "editProfileBtn";
            this.editProfileBtn.Size = new System.Drawing.Size(266, 64);
            this.editProfileBtn.TabIndex = 1;
            this.editProfileBtn.Text = "Edit Profile";
            this.editProfileBtn.UseVisualStyleBackColor = true;
            // 
            // ageLbl
            // 
            this.ageLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLbl.Location = new System.Drawing.Point(3, 72);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(76, 23);
            this.ageLbl.TabIndex = 0;
            this.ageLbl.Text = "Age:";
            this.ageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rateLbl
            // 
            this.rateLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLbl.Location = new System.Drawing.Point(3, 170);
            this.rateLbl.Name = "rateLbl";
            this.rateLbl.Size = new System.Drawing.Size(224, 23);
            this.rateLbl.TabIndex = 0;
            this.rateLbl.Text = "Movies\' Rating contributed: ";
            this.rateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(3, 13);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(266, 34);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Location = new System.Drawing.Point(21, 9);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(557, 68);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 469);
            this.Controls.Add(this.signOutBtn);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dashboard);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button signOutBtn;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button searchBtn;
        internal System.Windows.Forms.TextBox search;
        internal System.Windows.Forms.Button rmBtn;
        internal System.Windows.Forms.Button addMovBtn;
        internal System.Windows.Forms.ListBox filmList;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button editProfileBtn;
        internal System.Windows.Forms.Label ageLbl;
        internal System.Windows.Forms.Label rateLbl;
        internal System.Windows.Forms.Label nameLbl;
        internal System.Windows.Forms.Label dashboard;
    }
}