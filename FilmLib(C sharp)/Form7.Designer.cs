namespace FilmLib_C_sharp_
{
    partial class Form7
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
            this.addLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.TextBox();
            this.trailer = new System.Windows.Forms.TextBox();
            this.casts = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.TextBox();
            this.nameT = new System.Windows.Forms.TextBox();
            this.imageLbl = new System.Windows.Forms.Label();
            this.trailerLbl = new System.Windows.Forms.Label();
            this.castLbl = new System.Windows.Forms.Label();
            this.genreLbl = new System.Windows.Forms.Label();
            this.desLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.descript = new System.Windows.Forms.RichTextBox();
            this.ratingVal = new System.Windows.Forms.NumericUpDown();
            this.rateLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ratingVal)).BeginInit();
            this.SuspendLayout();
            // 
            // addLbl
            // 
            this.addLbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLbl.Location = new System.Drawing.Point(12, 11);
            this.addLbl.Name = "addLbl";
            this.addLbl.Size = new System.Drawing.Size(353, 52);
            this.addLbl.TabIndex = 0;
            this.addLbl.Text = "Add Movie";
            this.addLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(260, 459);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(79, 35);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Back";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(16, 459);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(79, 35);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(146, 400);
            this.image.MaxLength = 100;
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(193, 20);
            this.image.TabIndex = 7;
            // 
            // trailer
            // 
            this.trailer.Location = new System.Drawing.Point(146, 365);
            this.trailer.MaxLength = 100;
            this.trailer.Name = "trailer";
            this.trailer.Size = new System.Drawing.Size(193, 20);
            this.trailer.TabIndex = 6;
            // 
            // casts
            // 
            this.casts.Location = new System.Drawing.Point(146, 330);
            this.casts.MaxLength = 100;
            this.casts.Name = "casts";
            this.casts.Size = new System.Drawing.Size(193, 20);
            this.casts.TabIndex = 5;
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(146, 295);
            this.genre.MaxLength = 11;
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(193, 20);
            this.genre.TabIndex = 4;
            // 
            // nameT
            // 
            this.nameT.Location = new System.Drawing.Point(146, 135);
            this.nameT.MaxLength = 50;
            this.nameT.Name = "nameT";
            this.nameT.Size = new System.Drawing.Size(193, 20);
            this.nameT.TabIndex = 1;
            // 
            // imageLbl
            // 
            this.imageLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLbl.Location = new System.Drawing.Point(12, 391);
            this.imageLbl.Name = "imageLbl";
            this.imageLbl.Size = new System.Drawing.Size(108, 35);
            this.imageLbl.TabIndex = 0;
            this.imageLbl.Text = "Image URL:";
            this.imageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trailerLbl
            // 
            this.trailerLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trailerLbl.Location = new System.Drawing.Point(11, 356);
            this.trailerLbl.Name = "trailerLbl";
            this.trailerLbl.Size = new System.Drawing.Size(109, 35);
            this.trailerLbl.TabIndex = 0;
            this.trailerLbl.Text = "Trailer link:";
            this.trailerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // castLbl
            // 
            this.castLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castLbl.Location = new System.Drawing.Point(43, 321);
            this.castLbl.Name = "castLbl";
            this.castLbl.Size = new System.Drawing.Size(77, 35);
            this.castLbl.TabIndex = 0;
            this.castLbl.Text = "Casts:";
            this.castLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genreLbl
            // 
            this.genreLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLbl.Location = new System.Drawing.Point(39, 286);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(81, 35);
            this.genreLbl.TabIndex = 0;
            this.genreLbl.Text = "Genre:";
            this.genreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // desLbl
            // 
            this.desLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desLbl.Location = new System.Drawing.Point(35, 161);
            this.desLbl.Name = "desLbl";
            this.desLbl.Size = new System.Drawing.Size(85, 35);
            this.desLbl.TabIndex = 0;
            this.desLbl.Text = "Descript:";
            this.desLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(31, 126);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(89, 35);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name:";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descript
            // 
            this.descript.Location = new System.Drawing.Point(146, 167);
            this.descript.Name = "descript";
            this.descript.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.descript.Size = new System.Drawing.Size(193, 77);
            this.descript.TabIndex = 2;
            this.descript.Text = "";
            // 
            // ratingVal
            // 
            this.ratingVal.Location = new System.Drawing.Point(146, 261);
            this.ratingVal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ratingVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratingVal.Name = "ratingVal";
            this.ratingVal.Size = new System.Drawing.Size(120, 20);
            this.ratingVal.TabIndex = 3;
            this.ratingVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rateLbl
            // 
            this.rateLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLbl.Location = new System.Drawing.Point(39, 251);
            this.rateLbl.Name = "rateLbl";
            this.rateLbl.Size = new System.Drawing.Size(81, 35);
            this.rateLbl.TabIndex = 10;
            this.rateLbl.Text = "Rating:";
            this.rateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 506);
            this.Controls.Add(this.rateLbl);
            this.Controls.Add(this.ratingVal);
            this.Controls.Add(this.descript);
            this.Controls.Add(this.addLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.image);
            this.Controls.Add(this.trailer);
            this.Controls.Add(this.casts);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.imageLbl);
            this.Controls.Add(this.trailerLbl);
            this.Controls.Add(this.castLbl);
            this.Controls.Add(this.genreLbl);
            this.Controls.Add(this.desLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.ratingVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label addLbl;
        internal System.Windows.Forms.Button exitBtn;
        internal System.Windows.Forms.Button addBtn;
        internal System.Windows.Forms.TextBox image;
        internal System.Windows.Forms.TextBox trailer;
        internal System.Windows.Forms.TextBox casts;
        internal System.Windows.Forms.TextBox genre;
        internal System.Windows.Forms.TextBox nameT;
        internal System.Windows.Forms.Label imageLbl;
        internal System.Windows.Forms.Label trailerLbl;
        internal System.Windows.Forms.Label castLbl;
        internal System.Windows.Forms.Label genreLbl;
        internal System.Windows.Forms.Label desLbl;
        internal System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.RichTextBox descript;
        private System.Windows.Forms.NumericUpDown ratingVal;
        internal System.Windows.Forms.Label rateLbl;
    }
}