namespace MediaPresentationViews
{
    partial class MediaSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaSearchForm));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.txtSearchResults = new System.Windows.Forms.ListBox();
            this.lblSearchPageTitle = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblResultsCount = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnShowFavorites = new System.Windows.Forms.Button();
            this.cbSortOptions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Open Sans Extrabold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(111)))));
            this.btnSearch.Location = new System.Drawing.Point(97, 422);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseMnemonic = false;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(93)))), ((int)(((byte)(141)))));
            this.txtSearchBox.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSearchBox.Location = new System.Drawing.Point(97, 394);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(278, 22);
            this.txtSearchBox.TabIndex = 2;
            this.txtSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchBox_KeyDown);
            // 
            // txtSearchResults
            // 
            this.txtSearchResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(93)))), ((int)(((byte)(141)))));
            this.txtSearchResults.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchResults.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSearchResults.FormattingEnabled = true;
            this.txtSearchResults.ItemHeight = 15;
            this.txtSearchResults.Location = new System.Drawing.Point(12, 37);
            this.txtSearchResults.Name = "txtSearchResults";
            this.txtSearchResults.Size = new System.Drawing.Size(439, 319);
            this.txtSearchResults.TabIndex = 5;
            this.txtSearchResults.DoubleClick += new System.EventHandler(this.TxtSearchResults_DoubleClick);
            // 
            // lblSearchPageTitle
            // 
            this.lblSearchPageTitle.AutoSize = true;
            this.lblSearchPageTitle.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblSearchPageTitle.Location = new System.Drawing.Point(104, 9);
            this.lblSearchPageTitle.Name = "lblSearchPageTitle";
            this.lblSearchPageTitle.Size = new System.Drawing.Size(274, 22);
            this.lblSearchPageTitle.TabIndex = 6;
            this.lblSearchPageTitle.Text = "Search for any Movie or TV Show!";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Open Sans Extrabold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(111)))));
            this.btnSelect.Location = new System.Drawing.Point(178, 422);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 27);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseMnemonic = false;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // lblResultsCount
            // 
            this.lblResultsCount.AutoSize = true;
            this.lblResultsCount.Location = new System.Drawing.Point(333, 37);
            this.lblResultsCount.Name = "lblResultsCount";
            this.lblResultsCount.Size = new System.Drawing.Size(0, 15);
            this.lblResultsCount.TabIndex = 8;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(93)))), ((int)(((byte)(141)))));
            this.lblResults.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.White;
            this.lblResults.Location = new System.Drawing.Point(178, 357);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 17);
            this.lblResults.TabIndex = 9;
            // 
            // btnShowFavorites
            // 
            this.btnShowFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.btnShowFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFavorites.Font = new System.Drawing.Font("Open Sans Extrabold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFavorites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(111)))));
            this.btnShowFavorites.Location = new System.Drawing.Point(259, 422);
            this.btnShowFavorites.Name = "btnShowFavorites";
            this.btnShowFavorites.Size = new System.Drawing.Size(113, 27);
            this.btnShowFavorites.TabIndex = 10;
            this.btnShowFavorites.Text = "Show Favorites";
            this.btnShowFavorites.UseMnemonic = false;
            this.btnShowFavorites.UseVisualStyleBackColor = false;
            this.btnShowFavorites.Click += new System.EventHandler(this.BtnShowFavorites_Click);
            // 
            // cbSortOptions
            // 
            this.cbSortOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(93)))), ((int)(((byte)(141)))));
            this.cbSortOptions.Enabled = false;
            this.cbSortOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSortOptions.ForeColor = System.Drawing.SystemColors.Window;
            this.cbSortOptions.FormattingEnabled = true;
            this.cbSortOptions.Items.AddRange(new object[] {
            "alphabetically",
            "movies only",
            "tv shows only"});
            this.cbSortOptions.Location = new System.Drawing.Point(336, 355);
            this.cbSortOptions.Name = "cbSortOptions";
            this.cbSortOptions.Size = new System.Drawing.Size(115, 23);
            this.cbSortOptions.TabIndex = 12;
            this.cbSortOptions.Text = "Sort Options";
            this.cbSortOptions.SelectedIndexChanged += new System.EventHandler(this.CbSortOptions_SelectedIndexChanged);
            // 
            // MediaSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(463, 480);
            this.Controls.Add(this.cbSortOptions);
            this.Controls.Add(this.btnShowFavorites);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblResultsCount);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblSearchPageTitle);
            this.Controls.Add(this.txtSearchResults);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaSearchForm";
            this.Text = "WhereToWatch - Search Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ListBox txtSearchResults;
        private System.Windows.Forms.Label lblSearchPageTitle;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblResultsCount;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnShowFavorites;
        private System.Windows.Forms.ComboBox cbSortOptions;
    }
}

