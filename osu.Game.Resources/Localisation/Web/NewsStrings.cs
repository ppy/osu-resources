// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class NewsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.News";

        /// <summary>
        /// "osu!news"
        /// </summary>
        public static LocalisableString IndexTitlePage => new TranslatableString(getKey(@"index.title_page"), @"osu!news");

        /// <summary>
        /// "Newer posts"
        /// </summary>
        public static LocalisableString IndexNavNewer => new TranslatableString(getKey(@"index.nav.newer"), @"Newer posts");

        /// <summary>
        /// "Older posts"
        /// </summary>
        public static LocalisableString IndexNavOlder => new TranslatableString(getKey(@"index.nav.older"), @"Older posts");

        /// <summary>
        /// "news"
        /// </summary>
        public static LocalisableString IndexTitleDefault => new TranslatableString(getKey(@"index.title._"), @"news");

        /// <summary>
        /// "frontpage"
        /// </summary>
        public static LocalisableString IndexTitleInfo => new TranslatableString(getKey(@"index.title.info"), @"frontpage");

        /// <summary>
        /// "Beatmap Spotlights"
        /// </summary>
        public static LocalisableString SeriesBeatmapSpotlights => new TranslatableString(getKey(@"series.beatmap_spotlights"), @"Beatmap Spotlights");

        /// <summary>
        /// "community contests"
        /// </summary>
        public static LocalisableString SeriesCommunityContests => new TranslatableString(getKey(@"series.community_contests"), @"community contests");

        /// <summary>
        /// "community tournaments"
        /// </summary>
        public static LocalisableString SeriesCommunityTournaments => new TranslatableString(getKey(@"series.community_tournaments"), @"community tournaments");

        /// <summary>
        /// "art contests"
        /// </summary>
        public static LocalisableString SeriesFanartContests => new TranslatableString(getKey(@"series.fanart_contests"), @"art contests");

        /// <summary>
        /// "Featured Artist announcements"
        /// </summary>
        public static LocalisableString SeriesFeaturedArtists => new TranslatableString(getKey(@"series.featured_artists"), @"Featured Artist announcements");

        /// <summary>
        /// "client and website updates"
        /// </summary>
        public static LocalisableString SeriesGameUpdates => new TranslatableString(getKey(@"series.game_updates"), @"client and website updates");

        /// <summary>
        /// "Mappers&#39; Guild"
        /// </summary>
        public static LocalisableString SeriesMappersGuild => new TranslatableString(getKey(@"series.mappers_guild"), @"Mappers' Guild");

        /// <summary>
        /// "Monthly Beatmapping Contest"
        /// </summary>
        public static LocalisableString SeriesMonthlyBeatmappingContest => new TranslatableString(getKey(@"series.monthly_beatmapping_contest"), @"Monthly Beatmapping Contest");

        /// <summary>
        /// "osu! merchandise"
        /// </summary>
        public static LocalisableString SeriesMerchRuns => new TranslatableString(getKey(@"series.merch_runs"), @"osu! merchandise");

        /// <summary>
        /// "miscellaneous announcements"
        /// </summary>
        public static LocalisableString SeriesMiscellaneous => new TranslatableString(getKey(@"series.miscellaneous"), @"miscellaneous announcements");

        /// <summary>
        /// "official contests"
        /// </summary>
        public static LocalisableString SeriesOfficialContests => new TranslatableString(getKey(@"series.official_contests"), @"official contests");

        /// <summary>
        /// "offline events"
        /// </summary>
        public static LocalisableString SeriesOfflineEvents => new TranslatableString(getKey(@"series.offline_events"), @"offline events");

        /// <summary>
        /// "online events"
        /// </summary>
        public static LocalisableString SeriesOnlineEvents => new TranslatableString(getKey(@"series.online_events"), @"online events");

        /// <summary>
        /// "Project Loved"
        /// </summary>
        public static LocalisableString SeriesProjectLoved => new TranslatableString(getKey(@"series.project_loved"), @"Project Loved");

        /// <summary>
        /// "ranking system updates"
        /// </summary>
        public static LocalisableString SeriesRankingSystemUpdates => new TranslatableString(getKey(@"series.ranking_system_updates"), @"ranking system updates");

        /// <summary>
        /// "osu! World Cups"
        /// </summary>
        public static LocalisableString SeriesWorldCups => new TranslatableString(getKey(@"series.world_cups"), @"osu! World Cups");

        /// <summary>
        /// "by {0}"
        /// </summary>
        public static LocalisableString ShowBy(LocalisableString user) => new TranslatableString(getKey(@"show.by"), @"by {0}", user);

        /// <summary>
        /// "Newer post"
        /// </summary>
        public static LocalisableString ShowNavNewer => new TranslatableString(getKey(@"show.nav.newer"), @"Newer post");

        /// <summary>
        /// "Older post"
        /// </summary>
        public static LocalisableString ShowNavOlder => new TranslatableString(getKey(@"show.nav.older"), @"Older post");

        /// <summary>
        /// "news"
        /// </summary>
        public static LocalisableString ShowTitleDefault => new TranslatableString(getKey(@"show.title._"), @"news");

        /// <summary>
        /// "post"
        /// </summary>
        public static LocalisableString ShowTitleInfo => new TranslatableString(getKey(@"show.title.info"), @"post");

        /// <summary>
        /// "News Archive"
        /// </summary>
        public static LocalisableString SidebarArchive => new TranslatableString(getKey(@"sidebar.archive"), @"News Archive");

        /// <summary>
        /// "Update"
        /// </summary>
        public static LocalisableString StoreButton => new TranslatableString(getKey(@"store.button"), @"Update");

        /// <summary>
        /// "Listing updated."
        /// </summary>
        public static LocalisableString StoreOk => new TranslatableString(getKey(@"store.ok"), @"Listing updated.");

        /// <summary>
        /// "Update"
        /// </summary>
        public static LocalisableString UpdateButton => new TranslatableString(getKey(@"update.button"), @"Update");

        /// <summary>
        /// "Post updated."
        /// </summary>
        public static LocalisableString UpdateOk => new TranslatableString(getKey(@"update.ok"), @"Post updated.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}