﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
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
        /// "No results for {0}"
        /// </summary>
        public static LocalisableString ResultEmptyFor(LocalisableString modes) => new TranslatableString(getKey(@"result.empty_for"), @"No results for {0}", modes);

        /// <summary>
        /// "More {0} Search Results"
        /// </summary>
        public static LocalisableString ResultMore(LocalisableString mode) => new TranslatableString(getKey(@"result.more"), @"More {0} Search Results", mode);

        /// <summary>
        /// "{0} Search Results"
        /// </summary>
        public static LocalisableString ResultTitle(LocalisableString mode) => new TranslatableString(getKey(@"result.title"), @"{0} Search Results", mode);

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}