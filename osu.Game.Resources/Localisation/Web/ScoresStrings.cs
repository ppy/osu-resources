// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class ScoresStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Scores";

        /// <summary>
        /// "This score is marked for deletion and will disappear soon."
        /// </summary>
        public static LocalisableString ShowNonPreserved => new TranslatableString(getKey(@"show.non_preserved"), @"This score is marked for deletion and will disappear soon.");

        /// <summary>
        /// "{0} on {1} [{2}]"
        /// </summary>
        public static LocalisableString ShowTitle(LocalisableString username, LocalisableString title, LocalisableString version) => new TranslatableString(getKey(@"show.title"), @"{0} on {1} [{2}]", username, title, version);

        /// <summary>
        /// "by {0}"
        /// </summary>
        public static LocalisableString ShowBeatmapBy(LocalisableString artist) => new TranslatableString(getKey(@"show.beatmap.by"), @"by {0}", artist);

        /// <summary>
        /// "Played by"
        /// </summary>
        public static LocalisableString ShowPlayerBy => new TranslatableString(getKey(@"show.player.by"), @"Played by");

        /// <summary>
        /// "Submitted on"
        /// </summary>
        public static LocalisableString ShowPlayerSubmittedOn => new TranslatableString(getKey(@"show.player.submitted_on"), @"Submitted on");

        /// <summary>
        /// "Country Rank"
        /// </summary>
        public static LocalisableString ShowPlayerRankCountry => new TranslatableString(getKey(@"show.player.rank.country"), @"Country Rank");

        /// <summary>
        /// "Global Rank"
        /// </summary>
        public static LocalisableString ShowPlayerRankGlobal => new TranslatableString(getKey(@"show.player.rank.global"), @"Global Rank");

        /// <summary>
        /// "Only personal best scores award pp"
        /// </summary>
        public static LocalisableString StatusNonBest => new TranslatableString(getKey(@"status.non_best"), @"Only personal best scores award pp");

        /// <summary>
        /// "pp is not awarded for this score"
        /// </summary>
        public static LocalisableString StatusNoPp => new TranslatableString(getKey(@"status.no_pp"), @"pp is not awarded for this score");

        /// <summary>
        /// "This score is still being calculated and will be displayed soon"
        /// </summary>
        public static LocalisableString StatusProcessing => new TranslatableString(getKey(@"status.processing"), @"This score is still being calculated and will be displayed soon");

        /// <summary>
        /// "This score has no rank as it is unranked or marked for deletion"
        /// </summary>
        public static LocalisableString StatusNoRank => new TranslatableString(getKey(@"status.no_rank"), @"This score has no rank as it is unranked or marked for deletion");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}