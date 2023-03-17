// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class SortStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Sort";

        /// <summary>
        /// "Sort by"
        /// </summary>
        public static LocalisableString Default => new TranslatableString(getKey(@"_"), @"Sort by");

        /// <summary>
        /// "All"
        /// </summary>
        public static LocalisableString All => new TranslatableString(getKey(@"all"), @"All");

        /// <summary>
        /// "Friends"
        /// </summary>
        public static LocalisableString Friends => new TranslatableString(getKey(@"friends"), @"Friends");

        /// <summary>
        /// "Recently active"
        /// </summary>
        public static LocalisableString LastVisit => new TranslatableString(getKey(@"last_visit"), @"Recently active");

        /// <summary>
        /// "Recent"
        /// </summary>
        public static LocalisableString New => new TranslatableString(getKey(@"new"), @"Recent");

        /// <summary>
        /// "Old"
        /// </summary>
        public static LocalisableString Old => new TranslatableString(getKey(@"old"), @"Old");

        /// <summary>
        /// "Rank"
        /// </summary>
        public static LocalisableString Rank => new TranslatableString(getKey(@"rank"), @"Rank");

        /// <summary>
        /// "Top"
        /// </summary>
        public static LocalisableString Top => new TranslatableString(getKey(@"top"), @"Top");

        /// <summary>
        /// "Username"
        /// </summary>
        public static LocalisableString Username => new TranslatableString(getKey(@"username"), @"Username");

        /// <summary>
        /// "Album"
        /// </summary>
        public static LocalisableString ArtistTracksAlbum => new TranslatableString(getKey(@"artist_tracks.album"), @"Album");

        /// <summary>
        /// "Artist"
        /// </summary>
        public static LocalisableString ArtistTracksArtist => new TranslatableString(getKey(@"artist_tracks.artist"), @"Artist");

        /// <summary>
        /// "BPM"
        /// </summary>
        public static LocalisableString ArtistTracksBpm => new TranslatableString(getKey(@"artist_tracks.bpm"), @"BPM");

        /// <summary>
        /// "Genre"
        /// </summary>
        public static LocalisableString ArtistTracksGenre => new TranslatableString(getKey(@"artist_tracks.genre"), @"Genre");

        /// <summary>
        /// "Length"
        /// </summary>
        public static LocalisableString ArtistTracksLength => new TranslatableString(getKey(@"artist_tracks.length"), @"Length");

        /// <summary>
        /// "Relevance"
        /// </summary>
        public static LocalisableString ArtistTracksRelevance => new TranslatableString(getKey(@"artist_tracks.relevance"), @"Relevance");

        /// <summary>
        /// "Title"
        /// </summary>
        public static LocalisableString ArtistTracksTitle => new TranslatableString(getKey(@"artist_tracks.title"), @"Title");

        /// <summary>
        /// "Update"
        /// </summary>
        public static LocalisableString ArtistTracksUpdate => new TranslatableString(getKey(@"artist_tracks.update"), @"Update");

        /// <summary>
        /// "Post time"
        /// </summary>
        public static LocalisableString ForumPostsCreated => new TranslatableString(getKey(@"forum_posts.created"), @"Post time");

        /// <summary>
        /// "Relevance"
        /// </summary>
        public static LocalisableString ForumPostsRelevance => new TranslatableString(getKey(@"forum_posts.relevance"), @"Relevance");

        /// <summary>
        /// "Created"
        /// </summary>
        public static LocalisableString ForumTopicsCreated => new TranslatableString(getKey(@"forum_topics.created"), @"Created");

        /// <summary>
        /// "Star priority"
        /// </summary>
        public static LocalisableString ForumTopicsFeatureVotes => new TranslatableString(getKey(@"forum_topics.feature_votes"), @"Star priority");

        /// <summary>
        /// "Last reply"
        /// </summary>
        public static LocalisableString ForumTopicsNew => new TranslatableString(getKey(@"forum_topics.new"), @"Last reply");

        /// <summary>
        /// "Relevance"
        /// </summary>
        public static LocalisableString UsersRelevance => new TranslatableString(getKey(@"users.relevance"), @"Relevance");

        /// <summary>
        /// "Name"
        /// </summary>
        public static LocalisableString UsersUsername => new TranslatableString(getKey(@"users.username"), @"Name");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}