namespace FilmLib_C_sharp_
{
    partial class Form6
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
            this.ratingText = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.Label();
            this.trailer = new System.Windows.Forms.LinkLabel();
            this.castText = new System.Windows.Forms.TextBox();
            this.genreLbl = new System.Windows.Forms.Label();
            this.descriptText = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.castLbl = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.filmName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // ratingText
            // 
            this.ratingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingText.Location = new System.Drawing.Point(365, 258);
            this.ratingText.Name = "ratingText";
            this.ratingText.Size = new System.Drawing.Size(208, 21);
            this.ratingText.TabIndex = 0;
            this.ratingText.Text = "Rate:";
            this.ratingText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genreText
            // 
            this.genreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreText.Location = new System.Drawing.Point(365, 222);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(208, 21);
            this.genreText.TabIndex = 0;
            this.genreText.Text = "Genre:";
            this.genreText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trailer
            // 
            this.trailer.AutoSize = true;
            this.trailer.Location = new System.Drawing.Point(302, 394);
            this.trailer.Name = "trailer";
            this.trailer.Size = new System.Drawing.Size(85, 13);
            this.trailer.TabIndex = 0;
            this.trailer.TabStop = true;
            this.trailer.Text = "Watch the trailer";
            this.trailer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.trailer_LinkClicked);
            // 
            // castText
            // 
            this.castText.Location = new System.Drawing.Point(302, 319);
            this.castText.Multiline = true;
            this.castText.Name = "castText";
            this.castText.ReadOnly = true;
            this.castText.Size = new System.Drawing.Size(271, 48);
            this.castText.TabIndex = 0;
            // 
            // genreLbl
            // 
            this.genreLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLbl.Location = new System.Drawing.Point(298, 222);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(61, 21);
            this.genreLbl.TabIndex = 0;
            this.genreLbl.Text = "Genre:";
            // 
            // descriptText
            // 
            this.descriptText.Location = new System.Drawing.Point(302, 132);
            this.descriptText.Multiline = true;
            this.descriptText.Name = "descriptText";
            this.descriptText.ReadOnly = true;
            this.descriptText.Size = new System.Drawing.Size(271, 71);
            this.descriptText.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(466, 448);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(107, 45);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(353, 448);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(107, 45);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add to Favourites";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // castLbl
            // 
            this.castLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castLbl.Location = new System.Drawing.Point(298, 295);
            this.castLbl.Name = "castLbl";
            this.castLbl.Size = new System.Drawing.Size(54, 21);
            this.castLbl.TabIndex = 0;
            this.castLbl.Text = "Casts: ";
            // 
            // rate
            // 
            this.rate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.Location = new System.Drawing.Point(298, 258);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(61, 21);
            this.rate.TabIndex = 0;
            this.rate.Text = "Rating:";
            // 
            // descLbl
            // 
            this.descLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.Location = new System.Drawing.Point(298, 103);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(93, 26);
            this.descLbl.TabIndex = 0;
            this.descLbl.Text = "Description:";
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(12, 103);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(280, 390);
            this.image.TabIndex = 14;
            this.image.TabStop = false;
            // 
            // filmName
            // 
            this.filmName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmName.Location = new System.Drawing.Point(12, 9);
            this.filmName.Name = "filmName";
            this.filmName.Size = new System.Drawing.Size(561, 86);
            this.filmName.TabIndex = 0;
            this.filmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 505);
            this.Controls.Add(this.ratingText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.trailer);
            this.Controls.Add(this.castText);
            this.Controls.Add(this.genreLbl);
            this.Controls.Add(this.descriptText);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.castLbl);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.image);
            this.Controls.Add(this.filmName);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label ratingText;
        internal System.Windows.Forms.Label genreText;
        internal System.Windows.Forms.LinkLabel trailer;
        internal System.Windows.Forms.TextBox castText;
        internal System.Windows.Forms.Label genreLbl;
        internal System.Windows.Forms.TextBox descriptText;
        internal System.Windows.Forms.Button exitBtn;
        internal System.Windows.Forms.Button addBtn;
        internal System.Windows.Forms.Label castLbl;
        internal System.Windows.Forms.Label rate;
        internal System.Windows.Forms.Label descLbl;
        internal System.Windows.Forms.PictureBox image;
        internal System.Windows.Forms.Label filmName;
    }
}