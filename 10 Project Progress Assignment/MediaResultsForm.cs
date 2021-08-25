using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MediaDataObjects;
using MediaDataAccess;

namespace MediaPresentationViews
{
    /// <summary>
    /// Handles everything related to our results form.
    /// </summary>
    public partial class MediaResultsForm : Form
    {
        /// <summary>
        /// Temporairily holds our trailerURL so it's accessible by our 
        /// BtnOpenTrailer_Click().
        /// </summary>
        public string tempURL;

        /// <summary>
        /// The current media object, static so it can be used in the BtnFavorite_Click() method.
        /// </summary>
        public static Object _currentObject = new Object();

        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public MediaResultsForm()
        {
        }

        /// <summary>
        /// Partial Constructor that takes a Movie Object.
        /// Then sets all the appropriate form elements to their appropriate movie values.
        /// </summary>
        /// <param name="movie"></param>
        public MediaResultsForm(Movie movie)
        {
            InitializeComponent();  // sets all our values.
            this.picBoxMediaPoster.Select(); // takes the focus off the textboxes so the textbox text isn't all highlighted by
            _currentObject = movie;                             // default when we go into the ResultsForm
            string title = movie.Title + " " + "(" + movie.ReleaseDate + ")"; // movie title to be set.
            string titleBar = "WhereToWatch - Result: " + movie.Title + " " + "(" + movie.ReleaseDate + ")"; // our form text to be set later.
            string userScore = (movie.VoteAverage * 10).ToString() + "%";
            SetFormValuesAndText(movie.PosterPath, movie.Overview, title, titleBar, movie.StreamOn, userScore); // passes our variables to set them all.
            if (movie.Runtime == null) // if the media doesn't have any runtime, we pass a 0, which is checked for and it disables  
            {                               // the visability of the Runtime as a result.
                FormElementChecks(movie.TrailerURL, movie.StreamOnLogo, 0, movie.Tagline);
            }
            else {
                FormElementChecks(movie.TrailerURL, movie.StreamOnLogo, (int)movie.Runtime, movie.Tagline);
            }
        }

        /// <summary>
        /// Partial Constructor that takes a TVShow object.
        /// Then sets all the appropriate form elements to their appropriate movie values.
        /// </summary>
        /// <param name="tvShow"></param>
        public MediaResultsForm(TVShow tvShow)
        {
            InitializeComponent();
            picBoxMediaPoster.Select(); // takes the focus off the textboxes so the textbox text isn't all highlighted by
            _currentObject = tvShow;                                            // default when we go into the ResultsFor
            string title = tvShow.Name + " " + "(" + tvShow.FirstAirDate + ")"; // the media title.
            string titleBar = "WhereToWatch - Result: " + tvShow.Name + " " + "(" + tvShow.FirstAirDate + ")"; // the form text.
            string userScore = (tvShow.VoteAverage * 10).ToString() + "%"; // the average user score on 1-10 scale, *10.
            SetFormValuesAndText(tvShow.PosterPath, tvShow.Overview, title, titleBar, tvShow.StreamOn, userScore); // sets our values and text.
            FormElementChecks(tvShow.TrailerURL, tvShow.StreamOnLogo, 0); // runs various checks on the items passed before setting them.
        }

        /// <summary>
        /// Sets all the form elements for both a Movie Object and a TV Object.
        /// </summary>
        /// <param name="Poster"></param>
        /// <param name="Summary"></param>
        /// <param name="Title"></param>
        /// <param name="TitleBar"></param>
        /// <param name="StreamOn"></param>
        /// <param name="trailerURL"></param>
        private void SetFormValuesAndText(string Poster, string Summary, string Title, string TitleBar, string StreamOn, string UserScore) {
            this.picBoxMediaPoster.ImageLocation = Poster;
            this.txtMediaSummary.Text = Summary;
            this.lblMediaTitle.Text = Title;
            this.Text = TitleBar;
            this.txtMediaAvailableOn.Text = StreamOn;
            this.lblMediaUserScore.Text = UserScore;
            this.txtMediaAvailableOn.ReadOnly = true;
            this.txtMediaSummary.ReadOnly = true;
        }

        /// <summary>
        /// Runs our values through some null and value checks and sets values
        /// according to the results.
        /// </summary>
        /// <param name="TrailerURL"></param>
        /// <param name="StreamOnLogo"></param>
        /// <param name="Runtime"></param>
        /// <param name="Tagline"></param>
        private void FormElementChecks(string TrailerURL, string StreamOnLogo, int Runtime, string Tagline = null) {
            if (TrailerURL == null) // if there's no trailer because it's null, we set the text and disable the button.
            {
                this.btnOpenTrailer.Text = "No Trailer Available";
                this.btnOpenTrailer.Enabled = false;
            }
            else
            {
                tempURL = TrailerURL; // else allow the tempURL to become the trailerURL.
            }
            if (StreamOnLogo == null || StreamOnLogo == "")
            {       // if the logo is null or empty, we disable it's visability and move textbox location and size.
                this.picMediaStreamOnLogo.Visible = false;
                this.txtMediaAvailableOn.Location = new Point(12, 279);
                this.txtMediaAvailableOn.Size = new Size(189, 50);
            }
            else
            {
                this.picMediaStreamOnLogo.ImageLocation = StreamOnLogo; // else set the stream logo url.
            }
            if (Tagline == null || Tagline == "") // if our tagline is null or empty, then we hide it and move the media title
            {                                     // slightly down. (TV Shows almost never have taglines, but movies usually do)
                this.lblMediaTagline.Visible = false;
                this.lblMediaTitle.Location = new Point(204, 18);
            }
            else
            {
                this.lblMediaTagline.Text = Tagline;    // else set it.
            }
            if (Runtime == 0 || Runtime == null) // if our runtime is empty or null, we hide the runtime label.
            {
                this.lblMediaRuntime.Visible = false;
            }
            else {
                int hours = (Runtime / 60); // set the hours of runtime.
                int minutes = (Runtime - (60 * hours)); // sets our minutes of runtime.
                if (hours < 1) // if hours is <1, then we only use minutes.
                {
                    this.lblMediaRuntime.Text = minutes + "m";
                }
                else // else then we use both.
                {
                    this.lblMediaRuntime.Text = hours + "h" + " " + minutes + "m";
                }
            }
        } 
        
        /// <summary>
        /// Opens the trailer associated with the piece of media.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpenTrailer_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(tempURL); // Opens the youtube link for the trailer 
            }                                              // in the user's default browser.
            catch (Win32Exception w)
            {
                Console.WriteLine(w.Message);
            }
            catch (InvalidOperationException ie)
            {
                Console.WriteLine(ie.Message);
                MessageBox.Show("No Trailer Available!", "No Trailer");
            }

        }

        /// <summary>
        /// Adds the piece of media to the user's favorites list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFavorite_Click(object sender, EventArgs e)
        {
            MediaDataAccessor.AddMedia(_currentObject, 1);          // adds the object that was passed over to the results form, then assigned to _currentObject
            MediaDataAccessor.WriteFavoriteToXML(_currentObject);   // over to AddMedia(), specifying 1 for the favorites array. Then passses it to the WriteFavoriteXML()
            MessageBox.Show("Media added to favorites!", "Item Favorited");             // method to be written to an XML file.
            btnFavorite.Enabled = false; // disables button after one use.
        }
    }
}
