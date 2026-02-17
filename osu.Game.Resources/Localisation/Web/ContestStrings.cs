// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class ContestStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Contest";

        /// <summary>
        /// "Compete in more ways than just clicking circles."
        /// </summary>
        public static LocalisableString HeaderSmall => new TranslatableString(getKey(@"header.small"), @"Compete in more ways than just clicking circles.");

        /// <summary>
        /// "Community Contests"
        /// </summary>
        public static LocalisableString HeaderLarge => new TranslatableString(getKey(@"header.large"), @"Community Contests");

        /// <summary>
        /// "listing"
        /// </summary>
        public static LocalisableString IndexNavTitle => new TranslatableString(getKey(@"index.nav_title"), @"listing");

        /// <summary>
        /// "comments"
        /// </summary>
        public static LocalisableString JudgeComments => new TranslatableString(getKey(@"judge.comments"), @"comments");

        /// <summary>
        /// "hide judged entries"
        /// </summary>
        public static LocalisableString JudgeHideJudged => new TranslatableString(getKey(@"judge.hide_judged"), @"hide judged entries");

        /// <summary>
        /// "judge"
        /// </summary>
        public static LocalisableString JudgeNavTitle => new TranslatableString(getKey(@"judge.nav_title"), @"judge");

        /// <summary>
        /// "you didn&#39;t vote yet."
        /// </summary>
        public static LocalisableString JudgeNoCurrentVote => new TranslatableString(getKey(@"judge.no_current_vote"), @"you didn't vote yet.");

        /// <summary>
        /// "update"
        /// </summary>
        public static LocalisableString JudgeUpdate => new TranslatableString(getKey(@"judge.update"), @"update");

        /// <summary>
        /// "missing score"
        /// </summary>
        public static LocalisableString JudgeValidationMissingScore => new TranslatableString(getKey(@"judge.validation.missing_score"), @"missing score");

        /// <summary>
        /// "can&#39;t vote in judged contests"
        /// </summary>
        public static LocalisableString JudgeValidationContestVoteJudged => new TranslatableString(getKey(@"judge.validation.contest_vote_judged"), @"can't vote in judged contests");

        /// <summary>
        /// "You already submitted a vote on this entry."
        /// </summary>
        public static LocalisableString JudgeVoted => new TranslatableString(getKey(@"judge.voted"), @"You already submitted a vote on this entry.");

        /// <summary>
        /// "Judging results"
        /// </summary>
        public static LocalisableString JudgeResultsDefault => new TranslatableString(getKey(@"judge_results._"), @"Judging results");

        /// <summary>
        /// "creator"
        /// </summary>
        public static LocalisableString JudgeResultsCreator => new TranslatableString(getKey(@"judge_results.creator"), @"creator");

        /// <summary>
        /// "Score"
        /// </summary>
        public static LocalisableString JudgeResultsScore => new TranslatableString(getKey(@"judge_results.score"), @"Score");

        /// <summary>
        /// "Standardised Score"
        /// </summary>
        public static LocalisableString JudgeResultsScoreStd => new TranslatableString(getKey(@"judge_results.score_std"), @"Standardised Score");

        /// <summary>
        /// "total score"
        /// </summary>
        public static LocalisableString JudgeResultsTotalScore => new TranslatableString(getKey(@"judge_results.total_score"), @"total score");

        /// <summary>
        /// "total standardised score"
        /// </summary>
        public static LocalisableString JudgeResultsTotalScoreStd => new TranslatableString(getKey(@"judge_results.total_score_std"), @"total standardised score");

        /// <summary>
        /// "You are a judge of this contest. Judge the entries here!"
        /// </summary>
        public static LocalisableString VotingJudgeLink => new TranslatableString(getKey(@"voting.judge_link"), @"You are a judge of this contest. Judge the entries here!");

        /// <summary>
        /// "This contest is using the judging system, the judges are currently processing the entries."
        /// </summary>
        public static LocalisableString VotingJudgedNotice => new TranslatableString(getKey(@"voting.judged_notice"), @"This contest is using the judging system, the judges are currently processing the entries.");

        /// <summary>
        /// "Please sign in to vote."
        /// </summary>
        public static LocalisableString VotingLoginRequired => new TranslatableString(getKey(@"voting.login_required"), @"Please sign in to vote.");

        /// <summary>
        /// "Voting for this contest has ended"
        /// </summary>
        public static LocalisableString VotingOver => new TranslatableString(getKey(@"voting.over"), @"Voting for this contest has ended");

        /// <summary>
        /// "Show voted"
        /// </summary>
        public static LocalisableString VotingShowVotedOnly => new TranslatableString(getKey(@"voting.show_voted_only"), @"Show voted");

        /// <summary>
        /// "It doesn&#39;t look like you played any beatmaps that qualify for this contest!"
        /// </summary>
        public static LocalisableString VotingBestOfNonePlayed => new TranslatableString(getKey(@"voting.best_of.none_played"), @"It doesn't look like you played any beatmaps that qualify for this contest!");

        /// <summary>
        /// "Vote"
        /// </summary>
        public static LocalisableString VotingButtonAdd => new TranslatableString(getKey(@"voting.button.add"), @"Vote");

        /// <summary>
        /// "Remove vote"
        /// </summary>
        public static LocalisableString VotingButtonRemove => new TranslatableString(getKey(@"voting.button.remove"), @"Remove vote");

        /// <summary>
        /// "You have used up all your votes"
        /// </summary>
        public static LocalisableString VotingButtonUsedUp => new TranslatableString(getKey(@"voting.button.used_up"), @"You have used up all your votes");

        /// <summary>
        /// "{0} / {1} votes used"
        /// </summary>
        public static LocalisableString VotingProgressDefault(LocalisableString used, LocalisableString max) => new TranslatableString(getKey(@"voting.progress._"), @"{0} / {1} votes used", used, max);

        /// <summary>
        /// "Must play all beatmaps in the specified playlists before voting"
        /// </summary>
        public static LocalisableString VotingRequirementPlaylistBeatmapsetsIncompletePlay => new TranslatableString(getKey(@"voting.requirement.playlist_beatmapsets.incomplete_play"), @"Must play all beatmaps in the specified playlists before voting");

        /// <summary>
        /// "entry"
        /// </summary>
        public static LocalisableString EntryDefault => new TranslatableString(getKey(@"entry._"), @"entry");

        /// <summary>
        /// "Please sign in to enter the contest."
        /// </summary>
        public static LocalisableString EntryLoginRequired => new TranslatableString(getKey(@"entry.login_required"), @"Please sign in to enter the contest.");

        /// <summary>
        /// "You cannot enter contests while restricted or silenced."
        /// </summary>
        public static LocalisableString EntrySilencedOrRestricted => new TranslatableString(getKey(@"entry.silenced_or_restricted"), @"You cannot enter contests while restricted or silenced.");

        /// <summary>
        /// "We are currently preparing this contest. Please wait patiently!"
        /// </summary>
        public static LocalisableString EntryPreparation => new TranslatableString(getKey(@"entry.preparation"), @"We are currently preparing this contest. Please wait patiently!");

        /// <summary>
        /// "Drop your entry here"
        /// </summary>
        public static LocalisableString EntryDropHere => new TranslatableString(getKey(@"entry.drop_here"), @"Drop your entry here");

        /// <summary>
        /// "{0} files are accepted"
        /// </summary>
        public static LocalisableString EntryAllowedExtensions(LocalisableString types) => new TranslatableString(getKey(@"entry.allowed_extensions"), @"{0} files are accepted", types);

        /// <summary>
        /// "Max size: {0}"
        /// </summary>
        public static LocalisableString EntryMaxSize(LocalisableString limit) => new TranslatableString(getKey(@"entry.max_size"), @"Max size: {0}", limit);

        /// <summary>
        /// "Dimensions must be {0}{1}"
        /// </summary>
        public static LocalisableString EntryRequiredDimensions(LocalisableString widthx, LocalisableString height) => new TranslatableString(getKey(@"entry.required_dimensions"), @"Dimensions must be {0}{1}", widthx, height);

        /// <summary>
        /// "Download .osz"
        /// </summary>
        public static LocalisableString EntryDownload => new TranslatableString(getKey(@"entry.download"), @"Download .osz");

        /// <summary>
        /// "Only {0} files are accepted for this contest."
        /// </summary>
        public static LocalisableString EntryWrongFileType(LocalisableString types) => new TranslatableString(getKey(@"entry.wrong_file_type"), @"Only {0} files are accepted for this contest.", types);

        /// <summary>
        /// "Entries for this contest must be {0}{1}"
        /// </summary>
        public static LocalisableString EntryWrongDimensions(LocalisableString widthx, LocalisableString height) => new TranslatableString(getKey(@"entry.wrong_dimensions"), @"Entries for this contest must be {0}{1}", widthx, height);

        /// <summary>
        /// "Entries for this contest can only be up to {0}."
        /// </summary>
        public static LocalisableString EntryTooBig(LocalisableString limit) => new TranslatableString(getKey(@"entry.too_big"), @"Entries for this contest can only be up to {0}.", limit);

        /// <summary>
        /// "Download Entry"
        /// </summary>
        public static LocalisableString BeatmapsDownload => new TranslatableString(getKey(@"beatmaps.download"), @"Download Entry");

        /// <summary>
        /// "votes"
        /// </summary>
        public static LocalisableString VoteList => new TranslatableString(getKey(@"vote.list"), @"votes");

        /// <summary>
        /// "{0} vote|{0} votes"
        /// </summary>
        public static LocalisableString VoteCount(LocalisableString countDelimited) => new TranslatableString(getKey(@"vote.count"), @"{0} vote|{0} votes", countDelimited);

        /// <summary>
        /// "{0} point|{0} points"
        /// </summary>
        public static LocalisableString VotePoints(LocalisableString countDelimited) => new TranslatableString(getKey(@"vote.points"), @"{0} point|{0} points", countDelimited);

        /// <summary>
        /// "{0} points"
        /// </summary>
        public static LocalisableString VotePointsFloat(LocalisableString points) => new TranslatableString(getKey(@"vote.points_float"), @"{0} points", points);

        /// <summary>
        /// "Ended {0}"
        /// </summary>
        public static LocalisableString DatesEnded(LocalisableString date) => new TranslatableString(getKey(@"dates.ended"), @"Ended {0}", date);

        /// <summary>
        /// "Ended"
        /// </summary>
        public static LocalisableString DatesEndedNoDate => new TranslatableString(getKey(@"dates.ended_no_date"), @"Ended");

        /// <summary>
        /// "Starts {0}"
        /// </summary>
        public static LocalisableString DatesStartsDefault(LocalisableString date) => new TranslatableString(getKey(@"dates.starts._"), @"Starts {0}", date);

        /// <summary>
        /// "soon™"
        /// </summary>
        public static LocalisableString DatesStartsSoon => new TranslatableString(getKey(@"dates.starts.soon"), @"soon™");

        /// <summary>
        /// "Entry Open"
        /// </summary>
        public static LocalisableString StatesEntry => new TranslatableString(getKey(@"states.entry"), @"Entry Open");

        /// <summary>
        /// "Voting Started"
        /// </summary>
        public static LocalisableString StatesVoting => new TranslatableString(getKey(@"states.voting"), @"Voting Started");

        /// <summary>
        /// "Results Out"
        /// </summary>
        public static LocalisableString StatesResults => new TranslatableString(getKey(@"states.results"), @"Results Out");

        /// <summary>
        /// "View info and entries"
        /// </summary>
        public static LocalisableString ShowAdminPage => new TranslatableString(getKey(@"show.admin.page"), @"View info and entries");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}