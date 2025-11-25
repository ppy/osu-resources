// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class QuickSearchStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.QuickSearch";

        /// <summary>
        /// "Featured Artist Track"
        /// </summary>
        public static LocalisableString ModeArtistTrack => new TranslatableString(getKey(@"mode.artist_track"), @"Featured Artist Track");

        /// <summary>
        /// "Beatmap"
        /// </summary>
        public static LocalisableString ModeBeatmapset => new TranslatableString(getKey(@"mode.beatmapset"), @"Beatmap");

        /// <summary>
        /// "Forum"
        /// </summary>
        public static LocalisableString ModeForumPost => new TranslatableString(getKey(@"mode.forum_post"), @"Forum");

        /// <summary>
        /// "Other"
        /// </summary>
        public static LocalisableString ModeOther => new TranslatableString(getKey(@"mode.other"), @"Other");

        /// <summary>
        /// "Team"
        /// </summary>
        public static LocalisableString ModeTeam => new TranslatableString(getKey(@"mode.team"), @"Team");

        /// <summary>
        /// "Player"
        /// </summary>
        public static LocalisableString ModeUser => new TranslatableString(getKey(@"mode.user"), @"Player");

        /// <summary>
        /// "Wiki"
        /// </summary>
        public static LocalisableString ModeWikiPage => new TranslatableString(getKey(@"mode.wiki_page"), @"Wiki");

        /// <summary>
        /// "More {0} Search Results"
        /// </summary>
        public static LocalisableString ResultMore(LocalisableString mode) => new TranslatableString(getKey(@"result.more"), @"More {0} Search Results", mode);

        /// <summary>
        /// "{0} Search Results"
        /// </summary>
        public static LocalisableString ResultTitle(LocalisableString mode) => new TranslatableString(getKey(@"result.title"), @"{0} Search Results", mode);

        /// <summary>
        /// "No results for {0}"
        /// </summary>
        public static LocalisableString ResultNoResultsDefault(LocalisableString mode) => new TranslatableString(getKey(@"result.no_results._"), @"No results for {0}", mode);

        /// <summary>
        /// "Featured Artist Tracks"
        /// </summary>
        public static LocalisableString ResultNoResultsArtistTrack => new TranslatableString(getKey(@"result.no_results.artist_track"), @"Featured Artist Tracks");

        /// <summary>
        /// "Beatmaps"
        /// </summary>
        public static LocalisableString ResultNoResultsBeatmapset => new TranslatableString(getKey(@"result.no_results.beatmapset"), @"Beatmaps");

        /// <summary>
        /// "Forums"
        /// </summary>
        public static LocalisableString ResultNoResultsForumPost => new TranslatableString(getKey(@"result.no_results.forum_post"), @"Forums");

        /// <summary>
        /// "Others"
        /// </summary>
        public static LocalisableString ResultNoResultsOther => new TranslatableString(getKey(@"result.no_results.other"), @"Others");

        /// <summary>
        /// "Teams"
        /// </summary>
        public static LocalisableString ResultNoResultsTeam => new TranslatableString(getKey(@"result.no_results.team"), @"Teams");

        /// <summary>
        /// "Players"
        /// </summary>
        public static LocalisableString ResultNoResultsUser => new TranslatableString(getKey(@"result.no_results.user"), @"Players");

        /// <summary>
        /// "Wiki"
        /// </summary>
        public static LocalisableString ResultNoResultsWikiPage => new TranslatableString(getKey(@"result.no_results.wiki_page"), @"Wiki");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}