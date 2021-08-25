using MediaDataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;
using System.Net;
using Newtonsoft.Json.Linq;
using HtmlAgilityPack;
using TMDbLib.Objects.TvShows;
using MediaDataAccess;

namespace MediaLogicLayer
{
    /// <summary>
    /// This class handles everything to do with the MediaAPI. 
    /// Searching for the media, scraping information about the media,
    /// then taking all that information and making a new Object, to be put in a media List, and then returned to the user.
    /// </summary>
    public class MediaAPI
    {
        static readonly string APIKey = ""; // API Key for TheMovieDB
        TMDbClient client = new TMDbClient(APIKey); // TheMovieDB API Access Object.

        /// <summary>
        /// Scraps the inital listbox results. 
        /// This includes the name, id, and media type.
        /// </summary>
        /// <param name="input"></param>
        public List<Object> MediaSearch(string input) {
                SearchContainer<SearchBase> results = client.SearchMultiAsync(input).Result; // passes the user's query to a MultiAsyncSearch
                foreach (SearchBase result in results.Results) // loops through the results
                {
                    string mediaType = result.MediaType.ToString().ToUpper(); // converts it to upper for the sake of style
                    //if (mediaType == "MOVIE" || mediaType == "PERSON")
                    if (mediaType == "MOVIE")
                    {

                    //TMDbLib.Objects.People.Person person = client.GetPersonAsync(result.Id).Result;
                    //Console.WriteLine(person.Adult + "\n" + person.AlsoKnownAs + "\n" + person.Biography + "\n" + person.Birthday
                     //    + "\n" + person.Changes + "\n" + person.Deathday + "\n" + person.ExternalIds + "\n" + person.Gender
                     //     + "\n" + person.Homepage + "\n" + person.Id + "\n" + person.Images + "\n" + person.ImdbId + "\n" + person.MovieCredits
                     //      + "\n" + person.Name + "\n" + person.PlaceOfBirth + "\n" + person.Popularity + "\n" + person.ProfilePath + "\n" + person.TaggedImages
                     //       + "\n" + person.TvCredits);
                        TMDbLib.Objects.Movies.Movie movie = client.GetMovieAsync(result.Id).Result; // passes the movie ID gained from the SearchMultiAsync result
                    Console.WriteLine(movie.AccountStates + "\n" + 
                        movie.Adult + "\n" + 
                        movie.AlternativeTitles + "\n" + 
                        movie.BackdropPath + "\n" + 
                        movie.BelongsToCollection + "\n" + 
                        movie.Budget + "\n" + 
                        movie.Changes + "\n" + 
                        movie.Credits + "\n" + 
                        movie.ExternalIds + "\n" + 
                        movie.Genres + "\n" + 
                        movie.Homepage + "\n" + 
                        movie.Id + "\n" + 
                        movie.Images + "\n" + 
                        movie.ImdbId + "\n" + 
                        movie.Keywords + "\n" + 
                        movie.Lists +
                        movie.OriginalLanguage + "\n" + 
                        movie.OriginalTitle + "\n" + 
                        movie.Overview + "\n" + 
                        movie.Popularity + "\n" + 
                        movie.PosterPath + "\n" + 
                        movie.ProductionCompanies + "\n" + 
                        movie.ProductionCountries + "\n" +
                        movie.Recommendations + "\n" +
                        movie.ReleaseDate + "\n" +
                        movie.ReleaseDates + "\n" +
                        movie.Releases + "\n" +
                        movie.Revenue + "\n" +
                        movie.Reviews + "\n" +
                        movie.Runtime + "\n" +
                        movie.Similar + "\n" +
                        movie.SpokenLanguages + "\n" +
                        movie.Status + "\n" +
                        movie.Tagline + "\n" +
                        movie.Title + "\n" +
                        movie.Translations + "\n" +
                        movie.Video + "\n" +
                        movie.Videos + "\n" +
                        movie.VoteAverage + "\n" +
                        movie.VoteCount + "\n");

                    if (movie.ReleaseDate != null)                                              // and we pass it to GetMovieAsync methodt that pulls the items for the partial constructor.
                    {
                            MediaDataObjects.Movie movieObj = new MediaDataObjects.Movie(Convert.ToDateTime(movie.ReleaseDate).Year.ToString(), movie.Title, movie.Id, mediaType); // creaing a movie object
                            MediaDataAccessor.AddMedia(movieObj, 0);//Adds the media object to the array in MediaDataAccessor.                                                     // with the results
                    }                                           // Also, passing a 0 to specify we want to add it to the regular List, not favorites.
                }
                    else if (mediaType == "TV") // Same as above, but for the TV Show results.
                {
                        TvShow tvShow = client.GetTvShowAsync(result.Id).Result;
                    Console.WriteLine(tvShow.AccountStates + "\n" +
                        tvShow.AlternativeTitles + "\n" +
                        tvShow.BackdropPath + "\n" + 
                        tvShow.Changes + "\n" + 
                        tvShow.ContentRatings + "\n" + 
                        tvShow.CreatedBy + "\n" + 
                        tvShow.Credits + "\n" + 
                        tvShow.EpisodeRunTime + "\n" + 
                        tvShow.ExternalIds + "\n" + 
                        tvShow.FirstAirDate + "\n" + 
                        tvShow.GenreIds + "\n" + 
                        tvShow.Genres + "\n" + 
                        tvShow.Homepage + "\n" + 
                        tvShow.Id + "\n" + 
                        tvShow.Images + "\n" + 
                        tvShow.InProduction + "\n" + 
                        tvShow.Keywords + "\n" + 
                        tvShow.Languages + "\n" + 
                        tvShow.LastAirDate + "\n" + 
                        tvShow.LastEpisodeToAir + "\n" + 
                        tvShow.Name + "\n" + 
                        tvShow.Networks + "\n" + 
                        tvShow.NextEpisodeToAir + "\n" + 
                        tvShow.NumberOfEpisodes + "\n" + 
                        tvShow.NumberOfSeasons + "\n" + 
                        tvShow.OriginalLanguage + "\n" + 
                        tvShow.OriginalName + "\n" + 
                        tvShow.OriginCountry + "\n" + 
                        tvShow.Overview + "\n" + 
                        tvShow.Popularity + "\n" + 
                        tvShow.PosterPath + "\n" + 
                        tvShow.ProductionCompanies + "\n" + 
                        tvShow.Recommendations + "\n" + 
                        tvShow.Reviews + "\n" + 
                        tvShow.Seasons + "\n" +
                        tvShow.Similar + "\n" + 
                        tvShow.Status + "\n" + 
                        tvShow.Translations + "\n" + 
                        tvShow.Type + "\n" + 
                        tvShow.Videos + "\n" + 
                        tvShow.VoteAverage + "\n" + 
                        tvShow.VoteCount);
                        if (tvShow.FirstAirDate != null)
                        {
                            TVShow tvShowObj = new TVShow(mediaType, tvShow.Name, Convert.ToDateTime(tvShow.FirstAirDate).Year.ToString(), tvShow.Id);
                            MediaDataAccessor.AddMedia(tvShowObj, 0);
                        }
                    }
                }
            return MediaDataAccessor.RetrieveMediaList(0); // since we added the objects to the list over in MediaDataAccessor
                                                           // we retrieve that list and return it back to SearchResults, and again specifying 0 for the regular List, not favorites.
        }

        /// <summary>
        /// Scrapes the meta data for the Movie Object passed to it, creates a Movie Object with it, and returns it.
        /// </summary>
        /// <param name="passedMovie"></param>
        /// <param name="id"></param>
        /// <param name="mediaType"></param>
        /// <returns></returns>
        public MediaDataObjects.Movie ScrapeMetaData(MediaDataObjects.Movie passedMovie ,int id, string mediaType)
        {
            TMDbLib.Objects.Movies.Movie movie = client.GetMovieAsync(id).Result; // we pass the id over to movie results to scrape all the meta information about the movie.
            string movieTrailerURL = TrailerKeyEmptyCheck(ScrapJsonPage(mediaType, id, APIKey)); // This assigns the Scrapped JSON to the movie trailerURL, while also checking it for empty.
            string[] movieScrappedHtml = ScrapHtmlPage("https://www.themoviedb.org/movie/" + id); // holds the Scrapped html, being the service the movie is available on, and the logo for it.
            MediaDataObjects.Movie movieObj = new MediaDataObjects.Movie(Convert.ToDateTime(movie.ReleaseDate).Year.ToString(), movie.Runtime,
               movie.Tagline, movie.Title, movie.VoteAverage, "http://image.tmdb.org/t/p/w500/" + movie.PosterPath, movie.Overview,
                "https://image.tmdb.org/t/p/w780/" + movie.BackdropPath, movie.Id, movie.ImdbId,
                movie.OriginalTitle, movie.VoteCount, mediaType.ToUpper(), movieScrappedHtml[1], movieScrappedHtml[0], movieTrailerURL); // We feed all that meta data into a Movie Object.
            return movieObj; // and return it back to the Search Form so the Search Form can pass it to the Results Form.
        }

        /// <summary>
        /// Scrapes the meta data for the TVShow Object passed to it, creates a TVShow Object with it, and returns it.
        /// </summary>
        /// <param name="passedTv"></param>
        /// <param name="id"></param>
        /// <param name="mediaType"></param>
        /// <returns></returns>
        public TVShow ScrapeMetaData(MediaDataObjects.TVShow passedTv, int id, string mediaType) // all the same as the movie object above, 
        {                                                                                       //just for tv object.
            TvShow tvShow = client.GetTvShowAsync(id).Result; // GetTVShowAsync instead of GetMovieAsync
            string tvTrailerURL = TrailerKeyEmptyCheck(ScrapJsonPage(mediaType, id, APIKey)); //trailer empty check and scrapping the json page.
            string[] tvScrappedHtml = ScrapHtmlPage("https://www.themoviedb.org/tv/" + id); // scraping the html page and assigning it to an array.
            TVShow tvObj = new TVShow(tvShow.NumberOfSeasons, tvShow.OriginalName, tvShow.Overview,
                "http://image.tmdb.org/t/p/w500/" + tvShow.PosterPath, mediaType.ToUpper(), tvShow.VoteAverage, tvShow.Name,
                 "https://image.tmdb.org/t/p/w780/" + tvShow.BackdropPath, 
                tvShow.Id, Convert.ToDateTime(tvShow.FirstAirDate).Year.ToString(), tvShow.VoteCount, tvScrappedHtml[1], tvScrappedHtml[0], tvTrailerURL); // making a tv object with all the meta data.
            return tvObj; // returning it back to the MediaSearchForm so it can pass it to the MediaResultsForm
        }

        /// <summary>
        /// Takes a trailer URL and checks if the url has a KEY appended
        /// on the end of it, if it does, it's returned, if it doesn't, then we return set it's value to
        /// null and return it.
        /// </summary>
        /// <param name="trailerURL"></param>
        /// <returns></returns>
        private string TrailerKeyEmptyCheck(string trailerURL) {
            if (trailerURL == "https://www.youtube.com/watch?v=") // if the youtube link URL doesn't have the key on the end.
            {                                                      //then set null, which I have a check for in the MediaResultsForm
                return null;                                       // otherwise return the URL as-is.
            }
            else {
                return trailerURL;
            }
        }

        /// <summary>
        /// Scraps the JSON page for the variable KEY, 
        /// KEY is the value that we append to the end of a youtube link, which links to the trailer.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string ScrapJsonPage(string mediaType, int id, string APIKey)
        {
            string url = "https://api.themoviedb.org/3/" + mediaType.ToLower() + "/" + id +
            "/videos?api_key=" + APIKey + "&language=en-us"; // the API page to parse the JSON from.
            using (WebClient wc = new WebClient())  // use WebClient to download it, and the using to automatically close it.
            {
                string rawJson = wc.DownloadString(url); // the JSON downloaded and put into a string variable.
                JObject o = JObject.Parse(rawJson); // Parses it into a JObject.
                JToken token = o.SelectToken("$..results[0].key"); // Parses the JSON and gets the KEY attribute.
                return "https://www.youtube.com/watch?v=" + token; //the reutrned youtube link with the token/key appended
            }
        }

        /// <summary>
        /// Scraps the HTML page for the stremaing service text that the media is available on,
        /// and the matching logo for the streaming service.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string[] ScrapHtmlPage(string url)
        {
            var html = @url; // the url to scrape.
            HtmlWeb web = new HtmlWeb();    
            var htmlDoc = web.Load(html); // we load the html and put it into a HtmlDocument
            htmlDoc.OptionEmptyCollection = true; // gets rid of error.
            var availableOn = htmlDoc?.DocumentNode?.SelectNodes("//div[contains(@class, 'provider')]")?.Descendants("img")
                ?.FirstOrDefault()?.GetAttributeValue("alt", null); // the text for what streaming service it's available on.
            var logo = htmlDoc?.DocumentNode?.SelectNodes("//div[contains(@class, 'provider')]")
                ?.Descendants("img")?.FirstOrDefault()?.GetAttributeValue("src", null); // the corresponding logo image url for the service.
            if (availableOn == null) // if we can't find a service to stream/purchase from, we set that string.
            {
                availableOn = "No Available Streaming Service/Purchase Option Found.";
            }
            if (logo == null) // if there's no logo, we set the url for the logo to an empty string, which is checked for in the
            {                       // Results Form.
                logo = "";
            }
            string[] scrappedhtml = { availableOn, logo }; // we put the two in an arry so I can return both values from the method.
            return scrappedhtml; // we return the array for use above in the ScrapMetaData method's.
        }
    }
}