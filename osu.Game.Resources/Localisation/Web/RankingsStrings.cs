// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class RankingsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Rankings";

        /// <summary>
        /// "All"
        /// </summary>
        public static LocalisableString CountriesAll => new TranslatableString(getKey(@"countries.all"), @"All");

        /// <summary>
        /// "Country"
        /// </summary>
        public static LocalisableString CountriesTitle => new TranslatableString(getKey(@"countries.title"), @"Country");

        /// <summary>
        /// "Difficulty"
        /// </summary>
        public static LocalisableString DailyChallengeBeatmap => new TranslatableString(getKey(@"daily_challenge.beatmap"), @"Difficulty");

        /// <summary>
        /// "Top 10% Score"
        /// </summary>
        public static LocalisableString DailyChallengeTop10p => new TranslatableString(getKey(@"daily_challenge.top_10p"), @"Top 10% Score");

        /// <summary>
        /// "Top 50% Score"
        /// </summary>
        public static LocalisableString DailyChallengeTop50p => new TranslatableString(getKey(@"daily_challenge.top_50p"), @"Top 50% Score");

        /// <summary>
        /// "No daily challenge at the specified date yet!"
        /// </summary>
        public static LocalisableString DailyChallengeUnavailableFuture => new TranslatableString(getKey(@"daily_challenge.unavailable.future"), @"No daily challenge at the specified date yet!");

        /// <summary>
        /// "No daily challenge at the specified date!"
        /// </summary>
        public static LocalisableString DailyChallengeUnavailablePast => new TranslatableString(getKey(@"daily_challenge.unavailable.past"), @"No daily challenge at the specified date!");

        /// <summary>
        /// "Show"
        /// </summary>
        public static LocalisableString FilterTitle => new TranslatableString(getKey(@"filter.title"), @"Show");

        /// <summary>
        /// "Variant"
        /// </summary>
        public static LocalisableString FilterVariantTitle => new TranslatableString(getKey(@"filter.variant.title"), @"Variant");

        /// <summary>
        /// "Earned"
        /// </summary>
        public static LocalisableString KudosuTotal => new TranslatableString(getKey(@"kudosu.total"), @"Earned");

        /// <summary>
        /// "Available"
        /// </summary>
        public static LocalisableString KudosuAvailable => new TranslatableString(getKey(@"kudosu.available"), @"Available");

        /// <summary>
        /// "Spent"
        /// </summary>
        public static LocalisableString KudosuUsed => new TranslatableString(getKey(@"kudosu.used"), @"Spent");

        /// <summary>
        /// "Plays"
        /// </summary>
        public static LocalisableString MatchmakingPlays => new TranslatableString(getKey(@"matchmaking.plays"), @"Plays");

        /// <summary>
        /// "Points"
        /// </summary>
        public static LocalisableString MatchmakingPoints => new TranslatableString(getKey(@"matchmaking.points"), @"Points");

        /// <summary>
        /// "Not enough matches played to accurately determine rating"
        /// </summary>
        public static LocalisableString MatchmakingProvisional => new TranslatableString(getKey(@"matchmaking.provisional"), @"Not enough matches played to accurately determine rating");

        /// <summary>
        /// "Rating"
        /// </summary>
        public static LocalisableString MatchmakingRating => new TranslatableString(getKey(@"matchmaking.rating"), @"Rating");

        /// <summary>
        /// "Wins"
        /// </summary>
        public static LocalisableString MatchmakingWins => new TranslatableString(getKey(@"matchmaking.wins"), @"Wins");

        /// <summary>
        /// "Room Name"
        /// </summary>
        public static LocalisableString MultiplayerRoomName => new TranslatableString(getKey(@"multiplayer.room_name"), @"Room Name");

        /// <summary>
        /// "This user has less than 30 days of recent ranking history."
        /// </summary>
        public static LocalisableString PerformanceInsufficientHistory => new TranslatableString(getKey(@"performance.insufficient_history"), @"This user has less than 30 days of recent ranking history.");

        /// <summary>
        /// "The data is being calculated..."
        /// </summary>
        public static LocalisableString TopPlaysEmpty => new TranslatableString(getKey(@"top_plays.empty"), @"The data is being calculated...");

        /// <summary>
        /// "Last updated"
        /// </summary>
        public static LocalisableString TopPlaysLastUpdated => new TranslatableString(getKey(@"top_plays.last_updated"), @"Last updated");

        /// <summary>
        /// "spotlights (old)"
        /// </summary>
        public static LocalisableString PlaylistsCharts => new TranslatableString(getKey(@"playlists.charts"), @"spotlights (old)");

        /// <summary>
        /// "featured"
        /// </summary>
        public static LocalisableString PlaylistsFeatured => new TranslatableString(getKey(@"playlists.featured"), @"featured");

        /// <summary>
        /// "season room"
        /// </summary>
        public static LocalisableString PlaylistsSeasonRoom => new TranslatableString(getKey(@"playlists.season_room"), @"season room");

        /// <summary>
        /// "seasons"
        /// </summary>
        public static LocalisableString PlaylistsSeasons => new TranslatableString(getKey(@"playlists.seasons"), @"seasons");

        /// <summary>
        /// "country"
        /// </summary>
        public static LocalisableString TypeCountry => new TranslatableString(getKey(@"type.country"), @"country");

        /// <summary>
        /// "daily challenge"
        /// </summary>
        public static LocalisableString TypeDailyChallenge => new TranslatableString(getKey(@"type.daily_challenge"), @"daily challenge");

        /// <summary>
        /// "global"
        /// </summary>
        public static LocalisableString TypeGlobal => new TranslatableString(getKey(@"type.global"), @"global");

        /// <summary>
        /// "kudosu"
        /// </summary>
        public static LocalisableString TypeKudosu => new TranslatableString(getKey(@"type.kudosu"), @"kudosu");

        /// <summary>
        /// "quick play"
        /// </summary>
        public static LocalisableString TypeMatchmaking => new TranslatableString(getKey(@"type.matchmaking"), @"quick play");

        /// <summary>
        /// "playlists"
        /// </summary>
        public static LocalisableString TypePlaylists => new TranslatableString(getKey(@"type.playlists"), @"playlists");

        /// <summary>
        /// "team"
        /// </summary>
        public static LocalisableString TypeTeam => new TranslatableString(getKey(@"type.team"), @"team");

        /// <summary>
        /// "top plays"
        /// </summary>
        public static LocalisableString TypeTopPlays => new TranslatableString(getKey(@"type.top_plays"), @"top plays");

        /// <summary>
        /// "There are no rooms in this season yet."
        /// </summary>
        public static LocalisableString SeasonsEmpty => new TranslatableString(getKey(@"seasons.empty"), @"There are no rooms in this season yet.");

        /// <summary>
        /// "This season is still ongoing (there will be more playlists added)."
        /// </summary>
        public static LocalisableString SeasonsOngoing => new TranslatableString(getKey(@"seasons.ongoing"), @"This season is still ongoing (there will be more playlists added).");

        /// <summary>
        /// "Playlist count"
        /// </summary>
        public static LocalisableString SeasonsRoomCount => new TranslatableString(getKey(@"seasons.room_count"), @"Playlist count");

        /// <summary>
        /// "View Season Summary"
        /// </summary>
        public static LocalisableString SeasonsSummary => new TranslatableString(getKey(@"seasons.summary"), @"View Season Summary");

        /// <summary>
        /// "Display more informations on that season."
        /// </summary>
        public static LocalisableString SeasonsUrl => new TranslatableString(getKey(@"seasons.url"), @"Display more informations on that season.");

        /// <summary>
        /// "there is not enough score factors for proper calculation"
        /// </summary>
        public static LocalisableString SeasonsValidationNotEnoughFactors => new TranslatableString(getKey(@"seasons.validation.not_enough_factors"), @"there is not enough score factors for proper calculation");

        /// <summary>
        /// "End Date"
        /// </summary>
        public static LocalisableString SpotlightEndDate => new TranslatableString(getKey(@"spotlight.end_date"), @"End Date");

        /// <summary>
        /// "Map Count"
        /// </summary>
        public static LocalisableString SpotlightMapCount => new TranslatableString(getKey(@"spotlight.map_count"), @"Map Count");

        /// <summary>
        /// "Participants"
        /// </summary>
        public static LocalisableString SpotlightParticipants => new TranslatableString(getKey(@"spotlight.participants"), @"Participants");

        /// <summary>
        /// "Start Date"
        /// </summary>
        public static LocalisableString SpotlightStartDate => new TranslatableString(getKey(@"spotlight.start_date"), @"Start Date");

        /// <summary>
        /// "Accuracy"
        /// </summary>
        public static LocalisableString StatAccuracy => new TranslatableString(getKey(@"stat.accuracy"), @"Accuracy");

        /// <summary>
        /// "Active Users"
        /// </summary>
        public static LocalisableString StatActiveUsers => new TranslatableString(getKey(@"stat.active_users"), @"Active Users");

        /// <summary>
        /// "Country"
        /// </summary>
        public static LocalisableString StatCountry => new TranslatableString(getKey(@"stat.country"), @"Country");

        /// <summary>
        /// "Division"
        /// </summary>
        public static LocalisableString StatDivision => new TranslatableString(getKey(@"stat.division"), @"Division");

        /// <summary>
        /// "Members"
        /// </summary>
        public static LocalisableString StatMembers => new TranslatableString(getKey(@"stat.members"), @"Members");

        /// <summary>
        /// "Play Count"
        /// </summary>
        public static LocalisableString StatPlayCount => new TranslatableString(getKey(@"stat.play_count"), @"Play Count");

        /// <summary>
        /// "Performance"
        /// </summary>
        public static LocalisableString StatPerformance => new TranslatableString(getKey(@"stat.performance"), @"Performance");

        /// <summary>
        /// "Total Score"
        /// </summary>
        public static LocalisableString StatTotalScore => new TranslatableString(getKey(@"stat.total_score"), @"Total Score");

        /// <summary>
        /// "Ranked Score"
        /// </summary>
        public static LocalisableString StatRankedScore => new TranslatableString(getKey(@"stat.ranked_score"), @"Ranked Score");

        /// <summary>
        /// "Avg. Score"
        /// </summary>
        public static LocalisableString StatAverageScore => new TranslatableString(getKey(@"stat.average_score"), @"Avg. Score");

        /// <summary>
        /// "Avg. Perf."
        /// </summary>
        public static LocalisableString StatAveragePerformance => new TranslatableString(getKey(@"stat.average_performance"), @"Avg. Perf.");

        /// <summary>
        /// "SS"
        /// </summary>
        public static LocalisableString Statss => new TranslatableString(getKey(@"stat.ss"), @"SS");

        /// <summary>
        /// "S"
        /// </summary>
        public static LocalisableString Stats => new TranslatableString(getKey(@"stat.s"), @"S");

        /// <summary>
        /// "A"
        /// </summary>
        public static LocalisableString Stata => new TranslatableString(getKey(@"stat.a"), @"A");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}