// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class ScoreTokensStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.ScoreTokens";

        /// <summary>
        /// "invalid or missing beatmap_hash"
        /// </summary>
        public static LocalisableString CreateBeatmapHashInvalid => new TranslatableString(getKey(@"create.beatmap_hash_invalid"), @"invalid or missing beatmap_hash");

        /// <summary>
        /// "score submission is disabled"
        /// </summary>
        public static LocalisableString CreateSubmissionDisabled => new TranslatableString(getKey(@"create.submission_disabled"), @"score submission is disabled");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}