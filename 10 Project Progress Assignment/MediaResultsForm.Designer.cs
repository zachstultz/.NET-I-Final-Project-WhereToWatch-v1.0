namespace MediaPresentationViews
{
    partial class MediaResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaResultsForm));
            this.lblMediaTitle = new System.Windows.Forms.Label();
            this.txtMediaSummary = new System.Windows.Forms.TextBox();
            this.btnOpenTrailer = new System.Windows.Forms.Button();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.txtMediaAvailableOn = new System.Windows.Forms.TextBox();
            this.lblMediaRuntime = new System.Windows.Forms.Label();
            this.picMediaStreamOnLogo = new System.Windows.Forms.PictureBox();
            this.picBoxMediaPoster = new System.Windows.Forms.PictureBox();
            this.lblMediaUserScore = new System.Windows.Forms.Label();
            this.lblMediaTagline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMediaStreamOnLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMediaPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMediaTitle
            // 
            this.lblMediaTitle.AutoSize = true;
            this.lblMediaTitle.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMediaTitle.Location = new System.Drawing.Point(207, 9);
            this.lblMediaTitle.Name = "lblMediaTitle";
            this.lblMediaTitle.Size = new System.Drawing.Size(218, 28);
            this.lblMediaTitle.TabIndex = 2;
            this.lblMediaTitle.Text = " Money Heist (2017) ";
            // 
            // txtMediaSummary
            // 
            this.txtMediaSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(93)))), ((int)(((byte)(141)))));
            this.txtMediaSummary.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaSummary.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMediaSummary.Location = new System.Drawing.Point(212, 53);
            this.txtMediaSummary.Multiline = true;
            this.txtMediaSummary.Name = "txtMediaSummary";
            this.txtMediaSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMediaSummary.Size = new System.Drawing.Size(255, 220);
            this.txtMediaSummary.TabIndex = 3;
            this.txtMediaSummary.Text = resources.GetString("txtMediaSummary.Text");
            // 
            // btnOpenTrailer
            // 
            this.btnOpenTrailer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.btnOpenTrailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenTrailer.Font = new System.Drawing.Font("Open Sans Extrabold", 9F, System.Drawing.FontStyle.Bold);
            this.btnOpenTrailer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(111)))));
            this.btnOpenTrailer.Location = new System.Drawing.Point(212, 283);
            this.btnOpenTrailer.Name = "btnOpenTrailer";
            this.btnOpenTrailer.Size = new System.Drawing.Size(125, 50);
            this.btnOpenTrailer.TabIndex = 5;
            this.btnOpenTrailer.Text = "Open Trailer";
            this.btnOpenTrailer.UseVisualStyleBackColor = false;
            this.btnOpenTrailer.Click += new System.EventHandler(this.BtnOpenTrailer_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Font = new System.Drawing.Font("Open Sans Extrabold", 9F, System.Drawing.FontStyle.Bold);
            this.btnFavorite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(111)))));
            this.btnFavorite.Location = new System.Drawing.Point(343, 284);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(124, 49);
            this.btnFavorite.TabIndex = 7;
            this.btnFavorite.Text = "Favorite";
            this.btnFavorite.UseVisualStyleBackColor = false;
            this.btnFavorite.Click += new System.EventHandler(this.BtnFavorite_Click);
            // 
            // txtMediaAvailableOn
            // 
            this.txtMediaAvailableOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(93)))), ((int)(((byte)(141)))));
            this.txtMediaAvailableOn.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaAvailableOn.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMediaAvailableOn.Location = new System.Drawing.Point(70, 283);
            this.txtMediaAvailableOn.Multiline = true;
            this.txtMediaAvailableOn.Name = "txtMediaAvailableOn";
            this.txtMediaAvailableOn.Size = new System.Drawing.Size(131, 50);
            this.txtMediaAvailableOn.TabIndex = 1;
            this.txtMediaAvailableOn.Text = "Now Streaming On: Netflix";
            // 
            // lblMediaRuntime
            // 
            this.lblMediaRuntime.AutoSize = true;
            this.lblMediaRuntime.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaRuntime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMediaRuntime.Location = new System.Drawing.Point(9, 244);
            this.lblMediaRuntime.Name = "lblMediaRuntime";
            this.lblMediaRuntime.Size = new System.Drawing.Size(50, 17);
            this.lblMediaRuntime.TabIndex = 10;
            this.lblMediaRuntime.Text = "0h 00m";
            // 
            // picMediaStreamOnLogo
            // 
            this.picMediaStreamOnLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picMediaStreamOnLogo.Location = new System.Drawing.Point(4, 279);
            this.picMediaStreamOnLogo.Name = "picMediaStreamOnLogo";
            this.picMediaStreamOnLogo.Size = new System.Drawing.Size(61, 61);
            this.picMediaStreamOnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMediaStreamOnLogo.TabIndex = 8;
            this.picMediaStreamOnLogo.TabStop = false;
            // 
            // picBoxMediaPoster
            // 
            this.picBoxMediaPoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(93)))), ((int)(((byte)(141)))));
            this.picBoxMediaPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxMediaPoster.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBoxMediaPoster.ErrorImage")));
            this.picBoxMediaPoster.Location = new System.Drawing.Point(12, 12);
            this.picBoxMediaPoster.MaximumSize = new System.Drawing.Size(189, 261);
            this.picBoxMediaPoster.Name = "picBoxMediaPoster";
            this.picBoxMediaPoster.Size = new System.Drawing.Size(189, 261);
            this.picBoxMediaPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMediaPoster.TabIndex = 0;
            this.picBoxMediaPoster.TabStop = false;
            // 
            // lblMediaUserScore
            // 
            this.lblMediaUserScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMediaUserScore.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaUserScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMediaUserScore.Location = new System.Drawing.Point(167, 241);
            this.lblMediaUserScore.Name = "lblMediaUserScore";
            this.lblMediaUserScore.Size = new System.Drawing.Size(34, 20);
            this.lblMediaUserScore.TabIndex = 14;
            this.lblMediaUserScore.Text = "56%";
            // 
            // lblMediaTagline
            // 
            this.lblMediaTagline.AutoSize = true;
            this.lblMediaTagline.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaTagline.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMediaTagline.Location = new System.Drawing.Point(215, 33);
            this.lblMediaTagline.Name = "lblMediaTagline";
            this.lblMediaTagline.Size = new System.Drawing.Size(112, 15);
            this.lblMediaTagline.TabIndex = 9;
            this.lblMediaTagline.Text = "The perfect robbery.";
            // 
            // MediaResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(483, 346);
            this.Controls.Add(this.lblMediaUserScore);
            this.Controls.Add(this.lblMediaRuntime);
            this.Controls.Add(this.lblMediaTagline);
            this.Controls.Add(this.picMediaStreamOnLogo);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnOpenTrailer);
            this.Controls.Add(this.txtMediaSummary);
            this.Controls.Add(this.lblMediaTitle);
            this.Controls.Add(this.txtMediaAvailableOn);
            this.Controls.Add(this.picBoxMediaPoster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaResultsForm";
            this.Text = "Results Page";
            ((System.ComponentModel.ISupportInitialize)(this.picMediaStreamOnLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMediaPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxMediaPoster;
        private System.Windows.Forms.Label lblMediaTitle;
        private System.Windows.Forms.TextBox txtMediaSummary;
        private System.Windows.Forms.Button btnOpenTrailer;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.TextBox txtMediaAvailableOn;
        private System.Windows.Forms.PictureBox picMediaStreamOnLogo;
        private System.Windows.Forms.Label lblMediaRuntime;
        private System.Windows.Forms.Label lblMediaUserScore;
        private System.Windows.Forms.Label lblMediaTagline;
    }
}

