namespace ResultScreen
{
    partial class ResultsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsScreen));
            this.pictureBoxMediaPoster = new System.Windows.Forms.PictureBox();
            this.txtAvailableOn = new System.Windows.Forms.TextBox();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.txtMovieSummary = new System.Windows.Forms.TextBox();
            this.btnFavoriteMedia = new System.Windows.Forms.Button();
            this.btnOpenTrailer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMediaPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMediaPoster
            // 
            this.pictureBoxMediaPoster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMediaPoster.Image")));
            this.pictureBoxMediaPoster.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMediaPoster.Name = "pictureBoxMediaPoster";
            this.pictureBoxMediaPoster.Size = new System.Drawing.Size(189, 261);
            this.pictureBoxMediaPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMediaPoster.TabIndex = 0;
            this.pictureBoxMediaPoster.TabStop = false;
            this.pictureBoxMediaPoster.Click += new System.EventHandler(this.pictureBoxMediaPoster_Click);
            // 
            // txtAvailableOn
            // 
            this.txtAvailableOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableOn.Location = new System.Drawing.Point(12, 279);
            this.txtAvailableOn.Multiline = true;
            this.txtAvailableOn.Name = "txtAvailableOn";
            this.txtAvailableOn.Size = new System.Drawing.Size(189, 43);
            this.txtAvailableOn.TabIndex = 1;
            this.txtAvailableOn.Text = "Now Streaming On: Netflix";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.Location = new System.Drawing.Point(233, 12);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(212, 25);
            this.lblMovieTitle.TabIndex = 2;
            this.lblMovieTitle.Text = " Money Heist (2017) ";
            // 
            // txtMovieSummary
            // 
            this.txtMovieSummary.Location = new System.Drawing.Point(219, 49);
            this.txtMovieSummary.Multiline = true;
            this.txtMovieSummary.Name = "txtMovieSummary";
            this.txtMovieSummary.Size = new System.Drawing.Size(237, 209);
            this.txtMovieSummary.TabIndex = 3;
            this.txtMovieSummary.Text = resources.GetString("txtMovieSummary.Text");
            // 
            // btnFavoriteMedia
            // 
            this.btnFavoriteMedia.Location = new System.Drawing.Point(126, 235);
            this.btnFavoriteMedia.Name = "btnFavoriteMedia";
            this.btnFavoriteMedia.Size = new System.Drawing.Size(75, 23);
            this.btnFavoriteMedia.TabIndex = 4;
            this.btnFavoriteMedia.Text = "Favorite";
            this.btnFavoriteMedia.UseVisualStyleBackColor = true;
            // 
            // btnOpenTrailer
            // 
            this.btnOpenTrailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTrailer.Location = new System.Drawing.Point(270, 300);
            this.btnOpenTrailer.Name = "btnOpenTrailer";
            this.btnOpenTrailer.Size = new System.Drawing.Size(125, 44);
            this.btnOpenTrailer.TabIndex = 5;
            this.btnOpenTrailer.Text = "Open Trailer";
            this.btnOpenTrailer.UseVisualStyleBackColor = true;
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 373);
            this.Controls.Add(this.btnOpenTrailer);
            this.Controls.Add(this.btnFavoriteMedia);
            this.Controls.Add(this.txtMovieSummary);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.txtAvailableOn);
            this.Controls.Add(this.pictureBoxMediaPoster);
            this.Name = "ResultsScreen";
            this.Text = "ResultsScreen (w/Placeholders)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMediaPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMediaPoster;
        private System.Windows.Forms.TextBox txtAvailableOn;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.TextBox txtMovieSummary;
        private System.Windows.Forms.Button btnFavoriteMedia;
        private System.Windows.Forms.Button btnOpenTrailer;
    }
}

