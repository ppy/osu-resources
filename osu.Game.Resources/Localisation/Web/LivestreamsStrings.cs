// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class LivestreamsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Livestreams";

        /// <summary>
        /// "Are you sure you want to promote this livestream?"
        /// </summary>
        public static LocalisableString PromotePin => new TranslatableString(getKey(@"promote.pin"), @"Are you sure you want to promote this livestream?");

        /// <summary>
        /// "Are you sure you want to remove this livestream&#39;s promotion?"
        /// </summary>
        public static LocalisableString PromoteUnpin => new TranslatableString(getKey(@"promote.unpin"), @"Are you sure you want to remove this livestream's promotion?");

        /// <summary>
        /// "Live Streams"
        /// </summary>
        public static LocalisableString TopHeadersHeadline => new TranslatableString(getKey(@"top-headers.headline"), @"Live Streams");

        /// <summary>
        /// "Data is fetched from twitch.tv every five minutes based on the directory listing. Feel free to start streaming and get yourself listed! For more information on how to get setup, please check out {0}."
        /// </summary>
        public static LocalisableString TopHeadersDescription(LocalisableString link) => new TranslatableString(getKey(@"top-headers.description"), @"Data is fetched from twitch.tv every five minutes based on the directory listing. Feel free to start streaming and get yourself listed! For more information on how to get setup, please check out {0}.", link);

        /// <summary>
        /// "the wiki page on live streaming"
        /// </summary>
        public static LocalisableString TopHeadersLink => new TranslatableString(getKey(@"top-headers.link"), @"the wiki page on live streaming");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}