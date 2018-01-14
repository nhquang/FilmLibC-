namespace FilmLib_C_sharp_
{
    partial class Form5
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
            this.detailsBtn = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.ListView();
            this.name1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(241, 352);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(151, 29);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Back to Dashboard";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // detailsBtn
            // 
            this.detailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsBtn.Location = new System.Drawing.Point(294, 317);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(98, 29);
            this.detailsBtn.TabIndex = 1;
            this.detailsBtn.Text = "Details";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // results
            // 
            this.results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name1,
            this.genre,
            this.rating});
            this.results.Location = new System.Drawing.Point(12, 79);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(380, 232);
            this.results.TabIndex = 0;
            this.results.UseCompatibleStateImageBehavior = false;
            this.results.View = System.Windows.Forms.View.Details;
            // 
            // name1
            // 
            this.name1.Text = "Name";
            this.name1.Width = 167;
            // 
            // genre
            // 
            this.genre.Text = "Genre";
            this.genre.Width = 130;
            // 
            // rating
            // 
            this.rating.Text = "Rating";
            this.rating.Width = 77;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(380, 66);
            this.title.TabIndex = 0;
            this.title.Text = "Search Result";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 391);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.detailsBtn);
            this.Controls.Add(this.results);
            this.Controls.Add(this.title);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button exitBtn;
        internal System.Windows.Forms.Button detailsBtn;
        internal System.Windows.Forms.ListView results;
        internal System.Windows.Forms.ColumnHeader name1;
        internal System.Windows.Forms.ColumnHeader genre;
        internal System.Windows.Forms.ColumnHeader rating;
        internal System.Windows.Forms.Label title;
    }
}