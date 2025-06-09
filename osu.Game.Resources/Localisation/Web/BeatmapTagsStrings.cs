// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class BeatmapTagsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.BeatmapTags";

        /// <summary>
        /// "This tag is not valid with this Beatmap."
        /// </summary>
        public static LocalisableString UpdateInvalidRuleset => new TranslatableString(getKey(@"update.invalid_ruleset"), @"This tag is not valid with this Beatmap.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}