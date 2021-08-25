using System.Xml.Serialization;

namespace MediaDataObjects
{
    /// <summary>
    /// The Movie object class to store everything related to a movie.
    /// </summary>
    [XmlRoot(ElementName = "Movie")]
    public class Movie
    {
        /// <summary>
        /// When the movie released.
        /// </summary>
        [XmlElement(ElementName = "ReleaseDate")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// The length of the movie.
        /// </summary>
        [XmlElement(ElementName = "Runtime")]
        public int? Runtime { get; set; }

        /// <summary>
        /// The catchphrase/tagline for the movie.
        /// </summary>
        [XmlElement(ElementName = "Tagline")]
        public string Tagline { get; set; }

        /// <summary>
        /// The name/title of the movie.
        /// </summary>
        [XmlElement(ElementName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// The voter's average rating on a 1-10 scale.
        /// </summary>
        [XmlElement(ElementName = "VoteAverage")]
        public double VoteAverage { get; set; }

        /// <summary>
        /// The poster art url path.
        /// </summary>
        [XmlElement(ElementName = "PosterPath")]
        public string PosterPath { get; set; }

        /// <summary>
        /// The general summary of the movie.
        /// </summary>
        [XmlElement(ElementName = "Overview")]
        public string Overview { get; set; }

        /// <summary>
        /// The back drop poster art url path.
        /// </summary>
        [XmlElement(ElementName = "BackdropPath")]
        public string BackdropPath { get; set; }

        /// <summary>
        /// The movie ID.
        /// </summary>
        [XmlElement(ElementName = "Id")]
        public int Id { get; set; }

        /// <summary>
        /// The IMDB.com page ID.
        /// </summary>
        [XmlElement(ElementName = "ImdbId")]
        public string ImdbId { get; set; }

        /// <summary>
        /// The original title of the movie, unchanged.
        /// </summary>
        [XmlElement(ElementName = "OriginalTitle")]
        public string OriginalTitle { get; set; }

        /// <summary>
        /// The total vote count for the user score.
        /// </summary>
        [XmlElement(ElementName = "VoteCount")]
        public int VoteCount { get; set; }

        /// <summary>
        /// The media type. EX: MOVIE
        /// </summary>
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// The logo scrapped from the web of the streaming service available to stream/purchase the media on.
        /// </summary>
        [XmlElement(ElementName = "StreamOnLogo")]
        public string StreamOnLogo { get; set; }

        /// <summary>
        /// The available platform that the media can be streamed/purchased from.
        /// </summary>
        [XmlElement(ElementName = "StreamOn")]
        public string StreamOn { get; set; }

        /// <summary>
        /// The YouTube URL link for the trailer.
        /// </summary>
        [XmlElement(ElementName = "TrailerURL")]
        public string TrailerURL { get; set; }

        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public Movie()
        {
        }

        /// <summary>
        /// Full Constructor.
        /// </summary>
        /// <param name="releaseDate"></param>
        /// <param name="runtime"></param>
        /// <param name="tagline"></param>
        /// <param name="title"></param>
        /// <param name="voteAverage"></param>
        /// <param name="posterPath"></param>
        /// <param name="overview"></param>
        /// <param name="backdropPath"></param>
        /// <param name="id"></param>
        /// <param name="imdbId"></param>
        /// <param name="originalTitle"></param>
        /// <param name="voteCount"></param>
        /// <param name="type"></param>
        /// <param name="streamOnLogo"></param>
        /// <param name="streamOn"></param>
        /// <param name="trailerURL"></param>
        public Movie(string releaseDate, int? runtime, string tagline, string title, double voteAverage, string posterPath, string overview, string backdropPath, int id, string imdbId, string originalTitle, int voteCount, string type, string streamOnLogo, string streamOn, string trailerURL)
        {
            ReleaseDate = releaseDate;
            Runtime = runtime;
            Tagline = tagline;
            Title = title;
            VoteAverage = voteAverage;
            PosterPath = posterPath;
            Overview = overview;
            BackdropPath = backdropPath;
            Id = id;
            ImdbId = imdbId;
            OriginalTitle = originalTitle;
            VoteCount = voteCount;
            Type = type;
            StreamOnLogo = streamOnLogo;
            StreamOn = streamOn;
            TrailerURL = trailerURL;
        }

        /// <summary>
        /// Partial Constructor for ListBox Results.
        /// </summary>
        /// <param name="releaseDate"></param>
        /// <param name="title"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        public Movie(string releaseDate, string title, int id, string type)
        {
            ReleaseDate = releaseDate;
            Title = title;
            Id = id;
            Type = type;
        }

        /// <summary>
        /// Overrides the toString() method so results in the Interface are
        /// readable and not repeat Class Paths.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[" + Type + "] " + Title + " (" + ReleaseDate + ")";
        }
    }
}
