namespace MediaDataObjects
{
    /// <summary>
    /// The TVShow Object class to store everything related to a tv show.
    /// </summary>
    public class TVShow
    {
        /// <summary>
        /// The number of seasons for the tv show.
        /// </summary>
        public int NumberOfSeasons { get; set; }

        /// <summary>
        /// The original name of the tv show, unchanged.
        /// </summary>
        public string OriginalName { get; set; }

        /// <summary>
        /// A general summary of the tv show.
        /// </summary>
        public string Overview { get; set; }

        /// <summary>
        /// The poster art url path.
        /// </summary>
        public string PosterPath { get; set; }

        /// <summary>
        /// The media type. EX: TVSHOW
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The the voter's average score of the tv show on a 1-10 scale.
        /// </summary>
        public double VoteAverage { get; set; }

        /// <summary>
        /// The name of the tv show.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The backdrop artwork url path.
        /// </summary>
        public string BackdropPath { get; set; }
        
        /// <summary>
        /// The TV Show ID.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// The first date the tv show aired.
        /// </summary>
        public string FirstAirDate { get; set; }
        
        /// <summary>
        /// The amount of votes collected to make-up the user score.
        /// </summary>
        public int VoteCount { get; set; }

        /// <summary>
        /// The logo scrapped from the web of the streaming service available to stream on.
        /// </summary>
        public string StreamOnLogo { get; set; }

        /// <summary>
        /// The available platforms that the media can be streamed from.
        /// </summary>
        public string StreamOn { get; set; }

        /// <summary>
        /// The Trailer URL for the piece of media.
        /// </summary>
        public string TrailerURL { get; set; }

        /// <summary>
        /// Partial Constructor for listbox results list.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="firstAirDate"></param>
        /// <param name="id"></param>
        public TVShow(string type, string name, string firstAirDate, int id)
        {
            Type = type;
            Name = name;
            FirstAirDate = firstAirDate;
            Id = id;
        }

        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public TVShow()
        {
        }

        /// <summary>
        /// Full Constructor.
        /// </summary>
        /// <param name="numberOfSeasons"></param>
        /// <param name="originalName"></param>
        /// <param name="overview"></param>
        /// <param name="posterPath"></param>
        /// <param name="type"></param>
        /// <param name="voteAverage"></param>
        /// <param name="name"></param>
        /// <param name="backdropPath"></param>
        /// <param name="id"></param>
        /// <param name="firstAirDate"></param>
        /// <param name="voteCount"></param>
        /// <param name="streamOnLogo"></param>
        /// <param name="streamOn"></param>
        /// <param name="trailerURL"></param>
        public TVShow(int numberOfSeasons, string originalName, string overview, string posterPath, string type, double voteAverage, string name, string backdropPath, int id, string firstAirDate, int voteCount, string streamOnLogo, string streamOn, string trailerURL)
        {
            NumberOfSeasons = numberOfSeasons;
            OriginalName = originalName;
            Overview = overview;
            PosterPath = posterPath;
            Type = type;
            VoteAverage = voteAverage;
            Name = name;
            BackdropPath = backdropPath;
            Id = id;
            FirstAirDate = firstAirDate;
            VoteCount = voteCount;
            StreamOnLogo = streamOnLogo;
            StreamOn = streamOn;
            TrailerURL = trailerURL;
        }

        /// <summary>
        /// Overrides the toString() method so results in the Interface are
        /// readable and not repeat Class Paths.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[" + Type + "] " + Name + " (" + FirstAirDate + ")";
        }
    }
}
