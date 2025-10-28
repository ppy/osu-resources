// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class MatchesStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Matches";

        /// <summary>
        /// "deleted beatmap"
        /// </summary>
        public static LocalisableString MatchBeatmapDeleted => new TranslatableString(getKey(@"match.beatmap-deleted"), @"deleted beatmap");

        /// <summary>
        /// "FAILED"
        /// </summary>
        public static LocalisableString MatchFailed => new TranslatableString(getKey(@"match.failed"), @"FAILED");

        /// <summary>
        /// "Multi Matches"
        /// </summary>
        public static LocalisableString MatchHeader => new TranslatableString(getKey(@"match.header"), @"Multi Matches");

        /// <summary>
        /// "(match in progress)"
        /// </summary>
        public static LocalisableString MatchInProgress => new TranslatableString(getKey(@"match.in-progress"), @"(match in progress)");

        /// <summary>
        /// "match in progress"
        /// </summary>
        public static LocalisableString MatchInProgressSpinnerLabel => new TranslatableString(getKey(@"match.in_progress_spinner_label"), @"match in progress");

        /// <summary>
        /// "Loading events..."
        /// </summary>
        public static LocalisableString MatchLoadingEvents => new TranslatableString(getKey(@"match.loading-events"), @"Loading events...");

        /// <summary>
        /// "{0} wins"
        /// </summary>
        public static LocalisableString MatchWinner(LocalisableString team) => new TranslatableString(getKey(@"match.winner"), @"{0} wins", team);

        /// <summary>
        /// "{0} by {1}"
        /// </summary>
        public static LocalisableString MatchWinnerBy(LocalisableString winner, LocalisableString difference) => new TranslatableString(getKey(@"match.winner_by"), @"{0} by {1}", winner, difference);

        /// <summary>
        /// "the game was canceled"
        /// </summary>
        public static LocalisableString MatchEventsGameAborted => new TranslatableString(getKey(@"match.events.game_aborted"), @"the game was canceled");

        /// <summary>
        /// "the game was canceled"
        /// </summary>
        public static LocalisableString MatchEventsGameAbortedNoUser => new TranslatableString(getKey(@"match.events.game_aborted_no_user"), @"the game was canceled");

        /// <summary>
        /// "the game has ended"
        /// </summary>
        public static LocalisableString MatchEventsGameCompleted => new TranslatableString(getKey(@"match.events.game_completed"), @"the game has ended");

        /// <summary>
        /// "the game has ended"
        /// </summary>
        public static LocalisableString MatchEventsGameCompletedNoUser => new TranslatableString(getKey(@"match.events.game_completed_no_user"), @"the game has ended");

        /// <summary>
        /// "{0} became the host"
        /// </summary>
        public static LocalisableString MatchEventsHostChanged(LocalisableString user) => new TranslatableString(getKey(@"match.events.host_changed"), @"{0} became the host", user);

        /// <summary>
        /// "the host was changed"
        /// </summary>
        public static LocalisableString MatchEventsHostChangedNoUser => new TranslatableString(getKey(@"match.events.host_changed_no_user"), @"the host was changed");

        /// <summary>
        /// "{0} joined the match"
        /// </summary>
        public static LocalisableString MatchEventsPlayerJoined(LocalisableString user) => new TranslatableString(getKey(@"match.events.player_joined"), @"{0} joined the match", user);

        /// <summary>
        /// "a player joined the match"
        /// </summary>
        public static LocalisableString MatchEventsPlayerJoinedNoUser => new TranslatableString(getKey(@"match.events.player_joined_no_user"), @"a player joined the match");

        /// <summary>
        /// "{0} has been kicked from the match"
        /// </summary>
        public static LocalisableString MatchEventsPlayerKicked(LocalisableString user) => new TranslatableString(getKey(@"match.events.player_kicked"), @"{0} has been kicked from the match", user);

        /// <summary>
        /// "a player has been kicked from the match"
        /// </summary>
        public static LocalisableString MatchEventsPlayerKickedNoUser => new TranslatableString(getKey(@"match.events.player_kicked_no_user"), @"a player has been kicked from the match");

        /// <summary>
        /// "{0} left the match"
        /// </summary>
        public static LocalisableString MatchEventsPlayerLeft(LocalisableString user) => new TranslatableString(getKey(@"match.events.player_left"), @"{0} left the match", user);

        /// <summary>
        /// "a player left the match"
        /// </summary>
        public static LocalisableString MatchEventsPlayerLeftNoUser => new TranslatableString(getKey(@"match.events.player_left_no_user"), @"a player left the match");

        /// <summary>
        /// "{0} created the match"
        /// </summary>
        public static LocalisableString MatchEventsRoomCreated(LocalisableString user) => new TranslatableString(getKey(@"match.events.room_created"), @"{0} created the match", user);

        /// <summary>
        /// "the match was created"
        /// </summary>
        public static LocalisableString MatchEventsRoomCreatedNoUser => new TranslatableString(getKey(@"match.events.room_created_no_user"), @"the match was created");

        /// <summary>
        /// "the match was disbanded"
        /// </summary>
        public static LocalisableString MatchEventsRoomDisbanded => new TranslatableString(getKey(@"match.events.room_disbanded"), @"the match was disbanded");

        /// <summary>
        /// "the match was disbanded"
        /// </summary>
        public static LocalisableString MatchEventsRoomDisbandedNoUser => new TranslatableString(getKey(@"match.events.room_disbanded_no_user"), @"the match was disbanded");

        /// <summary>
        /// "Accuracy"
        /// </summary>
        public static LocalisableString MatchScoreStatsAccuracy => new TranslatableString(getKey(@"match.score.stats.accuracy"), @"Accuracy");

        /// <summary>
        /// "Combo"
        /// </summary>
        public static LocalisableString MatchScoreStatsCombo => new TranslatableString(getKey(@"match.score.stats.combo"), @"Combo");

        /// <summary>
        /// "Score"
        /// </summary>
        public static LocalisableString MatchScoreStatsScore => new TranslatableString(getKey(@"match.score.stats.score"), @"Score");

        /// <summary>
        /// "Head-to-head"
        /// </summary>
        public static LocalisableString MatchTeamTypesHeadToHead => new TranslatableString(getKey(@"match.team_types.head_to_head"), @"Head-to-head");

        /// <summary>
        /// "Tag Co-op"
        /// </summary>
        public static LocalisableString MatchTeamTypesTagCoop => new TranslatableString(getKey(@"match.team_types.tag_coop"), @"Tag Co-op");

        /// <summary>
        /// "Tag Team VS"
        /// </summary>
        public static LocalisableString MatchTeamTypesTagTeamVersus => new TranslatableString(getKey(@"match.team_types.tag_team_versus"), @"Tag Team VS");

        /// <summary>
        /// "Team VS"
        /// </summary>
        public static LocalisableString MatchTeamTypesTeamVersus => new TranslatableString(getKey(@"match.team_types.team_versus"), @"Team VS");

        /// <summary>
        /// "Blue Team"
        /// </summary>
        public static LocalisableString MatchTeamsBlue => new TranslatableString(getKey(@"match.teams.blue"), @"Blue Team");

        /// <summary>
        /// "Red Team"
        /// </summary>
        public static LocalisableString MatchTeamsRed => new TranslatableString(getKey(@"match.teams.red"), @"Red Team");

        /// <summary>
        /// "Freestyle"
        /// </summary>
        public static LocalisableString GameFreestyle => new TranslatableString(getKey(@"game.freestyle"), @"Freestyle");

        /// <summary>
        /// "Highest Score"
        /// </summary>
        public static LocalisableString GameScoringTypeScore => new TranslatableString(getKey(@"game.scoring-type.score"), @"Highest Score");

        /// <summary>
        /// "Highest Accuracy"
        /// </summary>
        public static LocalisableString GameScoringTypeAccuracy => new TranslatableString(getKey(@"game.scoring-type.accuracy"), @"Highest Accuracy");

        /// <summary>
        /// "Highest Combo"
        /// </summary>
        public static LocalisableString GameScoringTypeCombo => new TranslatableString(getKey(@"game.scoring-type.combo"), @"Highest Combo");

        /// <summary>
        /// "Score V2"
        /// </summary>
        public static LocalisableString GameScoringTypeScorev2 => new TranslatableString(getKey(@"game.scoring-type.scorev2"), @"Score V2");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}