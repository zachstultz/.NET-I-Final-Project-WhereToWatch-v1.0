using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaDataObjects;
using MediaLogicLayer;
using MediaDataAccess;
using System.Net.Http;
using System.Net;

namespace MediaPresentationViews
{
    public partial class MediaSearchForm : Form
    {
        /// <summary>
        /// Default Empty Constructor.
        /// </summary>
        public MediaSearchForm()
        {
            InitializeComponent();
            txtSearchBox.Select(); // selects the searchbox so the user can immediately start typing.
            //MediaDataAccessor.ReadFavoritesFromXML();
            this.lblResults.BackColor = System.Drawing.Color.Transparent; // gets rid of the background on the results label.
        }

        /// <summary>
        /// Sends the user's query off to the MediaSearch method in the MediaAPI class
        /// to scrape search results for the user. It then adds that to the ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.txtSearchResults.Items.Clear(); // clears out the Search Results so future searches aren't piling ontop of eachother.
            if (this.txtSearchBox.TextLength != 0)  // check if the user entered anything.
            {                                         // if they haven't we throw a MessageBox at them.
                MediaDataAccessor.ClearMediaList(0);    // Clears the default array in the MediaDataAccessor.
                this.txtSearchResults.Items.Clear();    // We pass 0 to specify the regular array, not the favorites.
                MediaAPI test = new MediaAPI();
                try
                {
                    int count = test.MediaSearch(this.txtSearchBox.Text).Count; // goes through once to get the amount of results to be
                    for (int i = 0; i < count; i++)                                         // looped through
                    {
                        this.txtSearchResults.Items.Add(test.MediaSearch(txtSearchBox.Text)[i]); // adds each result from the MediaSearch
                        this.lblResults.Text = "Loading " + count + " Results...";                      // to the ListBox
                                    // User friendly loading text while it pulls results.
                    }
                    if (this.txtSearchResults.Items.Count > 0) // check to see if there's any results, otherwise
                    {                                                   // we set the no results found below.
                        this.lblResults.Text = "Loaded: " + count + " Results";
                        this.cbSortOptions.Enabled = true; // if we have results, then we enable the sort options for them.
                    }
                    else
                    {
                        this.lblResults.Text = "No Results Found.";
                    }
                }
                catch (Exception ex) { // this catches Exception when the exceptions that occur when there's no active internet connection. 
                    if (ex is HttpRequestException || ex is WebException || ex is AggregateException) {     // when searching or opening a result.
                        MessageBox.Show("Search Functionality Requires An Active Internet Connection.", "No Internet Connection");
                    }
                }
            }
            else // if the user tries to leave the search box empty and search.
            {
                MessageBox.Show("Search cannot be empty!", "Empty Search Box");
            }

        }

        /// <summary>
        /// Opens the current selected item in the index and passes it to the Results Form, and
        /// then shows it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (this.txtSearchResults.Items.Count > 0) // checks the results to prevent empty searches.
            {
                MediaAPI mediaAPI = new MediaAPI();
                try
                {
                    if (this.txtSearchResults.SelectedItem.ToString().Contains("[MOVIE]")) // checks for [MOVIE] and
                    {                                                                   // then creates a movie object with the item
                                                                                        // then passes it to ScrapeMetaData(), and the result of that
                        Movie movie = this.txtSearchResults.SelectedItem as Movie;      // method gets sent to the MediaResultsForm.
                        MediaResultsForm mediaResultsForm = new MediaResultsForm(mediaAPI.ScrapeMetaData(movie, movie.Id, movie.Type));
                        mediaResultsForm.Show(); // shows the results form to the user.
                    }
                    else if (this.txtSearchResults.SelectedItem.ToString().Contains("[TV]")) // same as above, but for the TV Object.
                    {
                        TVShow tv = this.txtSearchResults.SelectedItem as TVShow;
                        MediaResultsForm mediaResultsForm = new MediaResultsForm(mediaAPI.ScrapeMetaData(tv, tv.Id, tv.Type));
                        mediaResultsForm.Show();
                    }
                }
                catch (Exception ex) // catches Exception if the no internet exceptions get thrown.
                {
                    if (ex is HttpRequestException || ex is WebException || ex is AggregateException)
                    {
                        MessageBox.Show("Results Functionality Requires An Active Internet Connection.", "No Internet Connection");
                    }
                    if (ex is NullReferenceException) { // catches a NullReferenceException when the user tries to double click randomly
                    }                                   // on the results list, but no result is selected and the area they're double clicking
                }                                       // is empty.
            }
            else
            {
                MessageBox.Show("Nothing selected!", "Empty List"); // if the user tries to press select when there's no results
            }
        }

        /// <summary>
        /// Calls the BtnSearch_Click() method, allowing the user to submit their query by clicking Search
        /// or pressing Enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSearchBox_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter)        // if the key they press is enter, then it activates the Search, so they don't
            {                                                       // have to drag the mouse and click it.
                BtnSearch_Click(this, new EventArgs());
            }
        }

        /// <summary>
        /// Quality Of Life Feature: Allows the user to double click the result instead pressing the Select Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSearchResults_DoubleClick(object sender, EventArgs e) // as talked about in the summary above it
        {                                                                      // allows the user to double click a result to open.
            BtnSelect_Click(this, new EventArgs()); // activates the select button.
        }

        /// <summary>
        /// Handles all the sort options offered.
        /// Which includes default, alphabetical, movies only, and tv shows only.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSortOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberOfMovies = GetMediaCount()[1]; // calls GetMediaCount and sets the value for movies
            int numberOfTvShows = GetMediaCount()[0];       // and tv shows, later to be used to check for uncessessary filters of reuslts.
            switch (this.cbSortOptions.SelectedIndex) // we pass in what sort options the user picked.
            {
                case (0):
                    // calls the SortAlphabetically() method.
                    SortAlphabetically();
                    break;
                case (1):
                    // calls the SortByMoviesOnly() method, pessing it the number of movies so it can perform some checks.
                    SortByMoviesOnly(numberOfMovies);
                    break;
                case (2):
                    // calls the SortByTVShowsOnly() method, pessing it the number of tv shows so it can perform some checks.
                    SortByTVShowsOnly(numberOfTvShows);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Sorts the List Box Alphabetically.
        /// </summary>
        private void SortAlphabetically()
        {
            this.txtSearchResults.Sorted = true;
        }

        /// <summary>
        /// Sorts the List Box by movies only, thus removing all objects that aren't a movie object.
        /// </summary>
        /// <param name="numberOfMovies"></param>
        private void SortByMoviesOnly(int numberOfMovies)
        {
            if (numberOfMovies > 0) // checks the number of movies so the user can't use this option when there aren't any.
            {
                for (int i = this.txtSearchResults.Items.Count - 1; i >= 0; i--) // loops the array in reverse, checking and removing
                {                                                                   // the tv show types so only movies are remaining.
                    if (this.txtSearchResults.Items[i].GetType().ToString().Contains("TVShow")) // Checks for TVShow string in the type.
                    {
                        this.txtSearchResults.Items.RemoveAt(i); // removes the item at the current count index, which is set to i.
                    }
                }
            }
            else
            {
                MessageBox.Show("There Are No Movies To Sort By.", "No Movies");
            }
        }

        /// <summary>
        /// Sorts the List Box by TV Shows only, thus removing any object that isn't a TV Object.
        /// </summary>
        /// <param name="numberOfTvShows"></param>
        private void SortByTVShowsOnly(int numberOfTvShows)
        {
            if (numberOfTvShows > 0)
            {
                for (int i = this.txtSearchResults.Items.Count - 1; i >= 0; i--) // loops the array in reverse, checking and removing
                {                                                                // the movie types so only tv shows are remaining.
                    if (this.txtSearchResults.Items[i].GetType().ToString().Contains("Movie")) // Checks for Movie string in the type.
                    {
                        this.txtSearchResults.Items.RemoveAt(i); // removes the item at the current count index, which is set to i.
                    }
                }
            }
            else
            {
                MessageBox.Show("There Are No TV Shows To Sort By.", "No TV Shows");
            }
        }

        /// <summary>
        /// Goes through the List box and makes note of how many movies
        /// and tv objects there are for later use in the search filter options.
        /// </summary>
        private int[] GetMediaCount()
        {
            int numberOfMovies = 0;
            int numberOfTvShows = 0;
            for (int i = 0; i < this.txtSearchResults.Items.Count; i++) //loops through the search results.
            {
                string indexString = this.txtSearchResults.Items[i].GetType().ToString(); // assigns the current item's type to a string.
                if (indexString.Contains("TVShow")) // checks if the current index is a tv show object.
                {
                    numberOfTvShows++;      // adds +1 to the number of tv shows.
                }
                else if (indexString.Contains("Movie")) // checks if the current index is a movie object.
                {
                    numberOfMovies++;       // adds +1 to the number of movies.
                }
            }
            int[] mediaCount = { numberOfTvShows, numberOfMovies }; // puts them in an array to return, so we can return both values.
            return mediaCount; // returns the array.
        }

        /// <summary>
        /// Adds the user's item to the favorites list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowFavorites_Click(object sender, EventArgs e)
        {
            if (MediaDataAccessor.RetrieveMediaList(1) == null || MediaDataAccessor.RetrieveMediaList(1).Count <= 0) // Checks if the favorites list
            {                                                                                                        // has anything.
                MessageBox.Show("There Are No Items In Your Favorite List.", "Empty Favorites List");
            }
            else {
                MediaDataAccessor.ClearMediaList(0); // Clears the default media results list, incase the user clicks Show Favorites
                this.txtSearchResults.Items.Clear();    // when they already have regular results.
                List<Object> _usersFavorites = MediaDataAccessor.RetrieveMediaList(1); // Retrives the user's favorites list and assigns it
                int count = _usersFavorites.Count;           //  to a new object list to be looped through here.
                for (int i = 0; i < count; i++)         // loops through the list and adds them to the listbox.
                {
                    this.txtSearchResults.Items.Add(_usersFavorites[i]);
                    this.lblResults.Text = "Loading " + count + " Results..."; // flavor text for the user.
                }
                this.lblResults.Text = "Loaded: " + count + " Results"; // flavor text for the user.
            }
        }
    }
}
