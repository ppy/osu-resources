// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class ModelsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Models";

        /// <summary>
        /// "Specified {0} couldn&#39;t be found."
        /// </summary>
        public static LocalisableString NotFound(LocalisableString model) => new TranslatableString(getKey(@"not_found"), @"Specified {0} couldn't be found.", model);

        /// <summary>
        /// "beatmap difficulty"
        /// </summary>
        public static LocalisableString NameAppModelsBeatmap => new TranslatableString(getKey(@"name.appmodelsbeatmap"), @"beatmap difficulty");

        /// <summary>
        /// "beatmap"
        /// </summary>
        public static LocalisableString NameAppModelsBeatmapset => new TranslatableString(getKey(@"name.appmodelsbeatmapset"), @"beatmap");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}