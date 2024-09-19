// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class BeatmapsetsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Beatmapsets";

        /// <summary>
        /// "This beatmap is currently not available for download."
        /// </summary>
        public static LocalisableString AvailabilityDisabled => new TranslatableString(getKey(@"availability.disabled"), @"This beatmap is currently not available for download.");

        /// <summary>
        /// "Portions of this beatmap have been removed at the request of the creator or a third-party rights holder."
        /// </summary>
        public static LocalisableString AvailabilityPartsRemoved => new TranslatableString(getKey(@"availability.parts-removed"), @"Portions of this beatmap have been removed at the request of the creator or a third-party rights holder.");

        /// <summary>
        /// "Check here for more information."
        /// </summary>
        public static LocalisableString AvailabilityMoreInfo => new TranslatableString(getKey(@"availability.more-info"), @"Check here for more information.");

        /// <summary>
        /// "Some assets contained within this map have been removed after being judged as not being suitable for use in osu!."
        /// </summary>
        public static LocalisableString AvailabilityRuleViolation => new TranslatableString(getKey(@"availability.rule_violation"), @"Some assets contained within this map have been removed after being judged as not being suitable for use in osu!.");

        /// <summary>
        /// "Deleted beatmap"
        /// </summary>
        public static LocalisableString CoverDeleted => new TranslatableString(getKey(@"cover.deleted"), @"Deleted beatmap");

        /// <summary>
        /// "Slow down, play more."
        /// </summary>
        public static LocalisableString DownloadLimitExceeded => new TranslatableString(getKey(@"download.limit_exceeded"), @"Slow down, play more.");

        /// <summary>
        /// "No download servers available."
        /// </summary>
        public static LocalisableString DownloadNoMirrors => new TranslatableString(getKey(@"download.no_mirrors"), @"No download servers available.");

        /// <summary>
        /// "Featured Artist"
        /// </summary>
        public static LocalisableString FeaturedArtistBadgeLabel => new TranslatableString(getKey(@"featured_artist_badge.label"), @"Featured Artist");

        /// <summary>
        /// "Beatmaps Listing"
        /// </summary>
        public static LocalisableString IndexTitle => new TranslatableString(getKey(@"index.title"), @"Beatmaps Listing");

        /// <summary>
        /// "Beatmaps"
        /// </summary>
        public static LocalisableString IndexGuestTitle => new TranslatableString(getKey(@"index.guest_title"), @"Beatmaps");

        /// <summary>
        /// "no beatmaps"
        /// </summary>
        public static LocalisableString PanelEmpty => new TranslatableString(getKey(@"panel.empty"), @"no beatmaps");

        /// <summary>
        /// "download"
        /// </summary>
        public static LocalisableString PanelDownloadAll => new TranslatableString(getKey(@"panel.download.all"), @"download");

        /// <summary>
        /// "download with video"
        /// </summary>
        public static LocalisableString PanelDownloadVideo => new TranslatableString(getKey(@"panel.download.video"), @"download with video");

        /// <summary>
        /// "download without video"
        /// </summary>
        public static LocalisableString PanelDownloadNoVideo => new TranslatableString(getKey(@"panel.download.no_video"), @"download without video");

        /// <summary>
        /// "open in osu!direct"
        /// </summary>
        public static LocalisableString PanelDownloadDirect => new TranslatableString(getKey(@"panel.download.direct"), @"open in osu!direct");

        /// <summary>
        /// "Probationary nominators cannot nominate multiple rulesets."
        /// </summary>
        public static LocalisableString NominateBngLimitedTooManyRulesets => new TranslatableString(getKey(@"nominate.bng_limited_too_many_rulesets"), @"Probationary nominators cannot nominate multiple rulesets.");

        /// <summary>
        /// "You must be a full nominator to perform the final nomination of a ruleset."
        /// </summary>
        public static LocalisableString NominateFullNominationRequired => new TranslatableString(getKey(@"nominate.full_nomination_required"), @"You must be a full nominator to perform the final nomination of a ruleset.");

        /// <summary>
        /// "A hybrid beatmap requires you to select at least one playmode to nominate for."
        /// </summary>
        public static LocalisableString NominateHybridRequiresModes => new TranslatableString(getKey(@"nominate.hybrid_requires_modes"), @"A hybrid beatmap requires you to select at least one playmode to nominate for.");

        /// <summary>
        /// "You do not have permission to nominate for mode: {0}"
        /// </summary>
        public static LocalisableString NominateIncorrectMode(LocalisableString mode) => new TranslatableString(getKey(@"nominate.incorrect_mode"), @"You do not have permission to nominate for mode: {0}", mode);

        /// <summary>
        /// "This beatmap has invalid nominations and cannot be qualified in this state."
        /// </summary>
        public static LocalisableString NominateInvalidLimitedNomination => new TranslatableString(getKey(@"nominate.invalid_limited_nomination"), @"This beatmap has invalid nominations and cannot be qualified in this state.");

        /// <summary>
        /// "This nomination has invalid rulesets."
        /// </summary>
        public static LocalisableString NominateInvalidRuleset => new TranslatableString(getKey(@"nominate.invalid_ruleset"), @"This nomination has invalid rulesets.");

        /// <summary>
        /// "Nomination requirement already fulfilled."
        /// </summary>
        public static LocalisableString NominateTooMany => new TranslatableString(getKey(@"nominate.too_many"), @"Nomination requirement already fulfilled.");

        /// <summary>
        /// "Nomination requirement for non-main ruleset already fulfilled."
        /// </summary>
        public static LocalisableString NominateTooManyNonMainRuleset => new TranslatableString(getKey(@"nominate.too_many_non_main_ruleset"), @"Nomination requirement for non-main ruleset already fulfilled.");

        /// <summary>
        /// "Are you sure you want to nominate this beatmap?"
        /// </summary>
        public static LocalisableString NominateDialogConfirmation => new TranslatableString(getKey(@"nominate.dialog.confirmation"), @"Are you sure you want to nominate this beatmap?");

        /// <summary>
        /// "Qualifying this beatmap with different nominators will reset its qualification queue position."
        /// </summary>
        public static LocalisableString NominateDialogDifferentNominatorWarning => new TranslatableString(getKey(@"nominate.dialog.different_nominator_warning"), @"Qualifying this beatmap with different nominators will reset its qualification queue position.");

        /// <summary>
        /// "Nominate Beatmap"
        /// </summary>
        public static LocalisableString NominateDialogHeader => new TranslatableString(getKey(@"nominate.dialog.header"), @"Nominate Beatmap");

        /// <summary>
        /// "note: you may only nominate once, so please ensure that you are nominating for all game modes you intend to"
        /// </summary>
        public static LocalisableString NominateDialogHybridWarning => new TranslatableString(getKey(@"nominate.dialog.hybrid_warning"), @"note: you may only nominate once, so please ensure that you are nominating for all game modes you intend to");

        /// <summary>
        /// "The main ruleset is currently: {0}"
        /// </summary>
        public static LocalisableString NominateDialogCurrentMainRuleset(LocalisableString ruleset) => new TranslatableString(getKey(@"nominate.dialog.current_main_ruleset"), @"The main ruleset is currently: {0}", ruleset);

        /// <summary>
        /// "Nominate for which modes?"
        /// </summary>
        public static LocalisableString NominateDialogWhichModes => new TranslatableString(getKey(@"nominate.dialog.which_modes"), @"Nominate for which modes?");

        /// <summary>
        /// "Explicit"
        /// </summary>
        public static LocalisableString NsfwBadgeLabel => new TranslatableString(getKey(@"nsfw_badge.label"), @"Explicit");

        /// <summary>
        /// "Discussion"
        /// </summary>
        public static LocalisableString ShowDiscussion => new TranslatableString(getKey(@"show.discussion"), @"Discussion");

        /// <summary>
        /// "View full size cover image"
        /// </summary>
        public static LocalisableString ShowAdminFullSizeCover => new TranslatableString(getKey(@"show.admin.full_size_cover"), @"View full size cover image");

        /// <summary>
        /// "This beatmap has been deleted."
        /// </summary>
        public static LocalisableString ShowDeletedBannerTitle => new TranslatableString(getKey(@"show.deleted_banner.title"), @"This beatmap has been deleted.");

        /// <summary>
        /// "(only moderators can see this)"
        /// </summary>
        public static LocalisableString ShowDeletedBannerMessage => new TranslatableString(getKey(@"show.deleted_banner.message"), @"(only moderators can see this)");

        /// <summary>
        /// "by {0}"
        /// </summary>
        public static LocalisableString ShowDetailsByArtist(LocalisableString artist) => new TranslatableString(getKey(@"show.details.by_artist"), @"by {0}", artist);

        /// <summary>
        /// "favourite this beatmap"
        /// </summary>
        public static LocalisableString ShowDetailsFavourite => new TranslatableString(getKey(@"show.details.favourite"), @"favourite this beatmap");

        /// <summary>
        /// "sign in to favourite this beatmap"
        /// </summary>
        public static LocalisableString ShowDetailsFavouriteLogin => new TranslatableString(getKey(@"show.details.favourite_login"), @"sign in to favourite this beatmap");

        /// <summary>
        /// "you need to sign in before downloading any beatmaps!"
        /// </summary>
        public static LocalisableString ShowDetailsLoggedOut => new TranslatableString(getKey(@"show.details.logged-out"), @"you need to sign in before downloading any beatmaps!");

        /// <summary>
        /// "mapped by {0}"
        /// </summary>
        public static LocalisableString ShowDetailsMappedBy(LocalisableString mapper) => new TranslatableString(getKey(@"show.details.mapped_by"), @"mapped by {0}", mapper);

        /// <summary>
        /// "guest difficulty by {0}"
        /// </summary>
        public static LocalisableString ShowDetailsMappedByGuest(LocalisableString mapper) => new TranslatableString(getKey(@"show.details.mapped_by_guest"), @"guest difficulty by {0}", mapper);

        /// <summary>
        /// "unfavourite this beatmap"
        /// </summary>
        public static LocalisableString ShowDetailsUnfavourite => new TranslatableString(getKey(@"show.details.unfavourite"), @"unfavourite this beatmap");

        /// <summary>
        /// "last updated {0}"
        /// </summary>
        public static LocalisableString ShowDetailsUpdatedTimeago(LocalisableString timeago) => new TranslatableString(getKey(@"show.details.updated_timeago"), @"last updated {0}", timeago);

        /// <summary>
        /// "Download"
        /// </summary>
        public static LocalisableString ShowDetailsDownloadDefault => new TranslatableString(getKey(@"show.details.download._"), @"Download");

        /// <summary>
        /// "osu!direct"
        /// </summary>
        public static LocalisableString ShowDetailsDownloadDirect => new TranslatableString(getKey(@"show.details.download.direct"), @"osu!direct");

        /// <summary>
        /// "without Video"
        /// </summary>
        public static LocalisableString ShowDetailsDownloadNoVideo => new TranslatableString(getKey(@"show.details.download.no-video"), @"without Video");

        /// <summary>
        /// "with Video"
        /// </summary>
        public static LocalisableString ShowDetailsDownloadVideo => new TranslatableString(getKey(@"show.details.download.video"), @"with Video");

        /// <summary>
        /// "to access more features"
        /// </summary>
        public static LocalisableString ShowDetailsLoginRequiredBottom => new TranslatableString(getKey(@"show.details.login_required.bottom"), @"to access more features");

        /// <summary>
        /// "Sign In"
        /// </summary>
        public static LocalisableString ShowDetailsLoginRequiredTop => new TranslatableString(getKey(@"show.details.login_required.top"), @"Sign In");

        /// <summary>
        /// "approved {0}"
        /// </summary>
        public static LocalisableString ShowDetailsDateApproved(LocalisableString timeago) => new TranslatableString(getKey(@"show.details_date.approved"), @"approved {0}", timeago);

        /// <summary>
        /// "loved {0}"
        /// </summary>
        public static LocalisableString ShowDetailsDateLoved(LocalisableString timeago) => new TranslatableString(getKey(@"show.details_date.loved"), @"loved {0}", timeago);

        /// <summary>
        /// "qualified {0}"
        /// </summary>
        public static LocalisableString ShowDetailsDateQualified(LocalisableString timeago) => new TranslatableString(getKey(@"show.details_date.qualified"), @"qualified {0}", timeago);

        /// <summary>
        /// "ranked {0}"
        /// </summary>
        public static LocalisableString ShowDetailsDateRanked(LocalisableString timeago) => new TranslatableString(getKey(@"show.details_date.ranked"), @"ranked {0}", timeago);

        /// <summary>
        /// "submitted {0}"
        /// </summary>
        public static LocalisableString ShowDetailsDateSubmitted(LocalisableString timeago) => new TranslatableString(getKey(@"show.details_date.submitted"), @"submitted {0}", timeago);

        /// <summary>
        /// "last updated {0}"
        /// </summary>
        public static LocalisableString ShowDetailsDateUpdated(LocalisableString timeago) => new TranslatableString(getKey(@"show.details_date.updated"), @"last updated {0}", timeago);

        /// <summary>
        /// "You have too many favourited beatmaps! Please unfavourite some before trying again."
        /// </summary>
        public static LocalisableString ShowFavouritesLimitReached => new TranslatableString(getKey(@"show.favourites.limit_reached"), @"You have too many favourited beatmaps! Please unfavourite some before trying again.");

        /// <summary>
        /// "Hype this map if you enjoyed playing it to help it progress to &lt;strong&gt;Ranked&lt;/strong&gt; status."
        /// </summary>
        public static LocalisableString ShowHypeAction => new TranslatableString(getKey(@"show.hype.action"), @"Hype this map if you enjoyed playing it to help it progress to <strong>Ranked</strong> status.");

        /// <summary>
        /// "This map is currently {0}."
        /// </summary>
        public static LocalisableString ShowHypeCurrentDefault(LocalisableString status) => new TranslatableString(getKey(@"show.hype.current._"), @"This map is currently {0}.", status);

        /// <summary>
        /// "pending"
        /// </summary>
        public static LocalisableString ShowHypeCurrentStatusPending => new TranslatableString(getKey(@"show.hype.current.status.pending"), @"pending");

        /// <summary>
        /// "qualified"
        /// </summary>
        public static LocalisableString ShowHypeCurrentStatusQualified => new TranslatableString(getKey(@"show.hype.current.status.qualified"), @"qualified");

        /// <summary>
        /// "work in progress"
        /// </summary>
        public static LocalisableString ShowHypeCurrentStatusWip => new TranslatableString(getKey(@"show.hype.current.status.wip"), @"work in progress");

        /// <summary>
        /// "If you find an issue with this beatmap, please disqualify it {0}."
        /// </summary>
        public static LocalisableString ShowHypeDisqualifyDefault(LocalisableString link) => new TranslatableString(getKey(@"show.hype.disqualify._"), @"If you find an issue with this beatmap, please disqualify it {0}.", link);

        /// <summary>
        /// "If you find an issue with this beatmap, please report it {0} to alert the team."
        /// </summary>
        public static LocalisableString ShowHypeReportDefault(LocalisableString link) => new TranslatableString(getKey(@"show.hype.report._"), @"If you find an issue with this beatmap, please report it {0} to alert the team.", link);

        /// <summary>
        /// "Report Problem"
        /// </summary>
        public static LocalisableString ShowHypeReportButton => new TranslatableString(getKey(@"show.hype.report.button"), @"Report Problem");

        /// <summary>
        /// "here"
        /// </summary>
        public static LocalisableString ShowHypeReportLink => new TranslatableString(getKey(@"show.hype.report.link"), @"here");

        /// <summary>
        /// "Description"
        /// </summary>
        public static LocalisableString ShowInfoDescription => new TranslatableString(getKey(@"show.info.description"), @"Description");

        /// <summary>
        /// "Genre"
        /// </summary>
        public static LocalisableString ShowInfoGenre => new TranslatableString(getKey(@"show.info.genre"), @"Genre");

        /// <summary>
        /// "Language"
        /// </summary>
        public static LocalisableString ShowInfoLanguage => new TranslatableString(getKey(@"show.info.language"), @"Language");

        /// <summary>
        /// "Data still being calculated..."
        /// </summary>
        public static LocalisableString ShowInfoNoScores => new TranslatableString(getKey(@"show.info.no_scores"), @"Data still being calculated...");

        /// <summary>
        /// "Nominators"
        /// </summary>
        public static LocalisableString ShowInfoNominators => new TranslatableString(getKey(@"show.info.nominators"), @"Nominators");

        /// <summary>
        /// "Explicit content"
        /// </summary>
        public static LocalisableString ShowInfoNsfw => new TranslatableString(getKey(@"show.info.nsfw"), @"Explicit content");

        /// <summary>
        /// "Online offset"
        /// </summary>
        public static LocalisableString ShowInfoOffset => new TranslatableString(getKey(@"show.info.offset"), @"Online offset");

        /// <summary>
        /// "Points of Failure"
        /// </summary>
        public static LocalisableString ShowInfoPointsOfFailure => new TranslatableString(getKey(@"show.info.points-of-failure"), @"Points of Failure");

        /// <summary>
        /// "Source"
        /// </summary>
        public static LocalisableString ShowInfoSource => new TranslatableString(getKey(@"show.info.source"), @"Source");

        /// <summary>
        /// "This beatmap contains storyboard"
        /// </summary>
        public static LocalisableString ShowInfoStoryboard => new TranslatableString(getKey(@"show.info.storyboard"), @"This beatmap contains storyboard");

        /// <summary>
        /// "Success Rate"
        /// </summary>
        public static LocalisableString ShowInfoSuccessRate => new TranslatableString(getKey(@"show.info.success-rate"), @"Success Rate");

        /// <summary>
        /// "Tags"
        /// </summary>
        public static LocalisableString ShowInfoTags => new TranslatableString(getKey(@"show.info.tags"), @"Tags");

        /// <summary>
        /// "This beatmap contains video"
        /// </summary>
        public static LocalisableString ShowInfoVideo => new TranslatableString(getKey(@"show.info.video"), @"This beatmap contains video");

        /// <summary>
        /// "This beatmap contains explicit, offensive, or disturbing content. Would you like to view it anyway?"
        /// </summary>
        public static LocalisableString ShowNsfwWarningDetails => new TranslatableString(getKey(@"show.nsfw_warning.details"), @"This beatmap contains explicit, offensive, or disturbing content. Would you like to view it anyway?");

        /// <summary>
        /// "Explicit Content"
        /// </summary>
        public static LocalisableString ShowNsfwWarningTitle => new TranslatableString(getKey(@"show.nsfw_warning.title"), @"Explicit Content");

        /// <summary>
        /// "Disable warning"
        /// </summary>
        public static LocalisableString ShowNsfwWarningButtonsDisable => new TranslatableString(getKey(@"show.nsfw_warning.buttons.disable"), @"Disable warning");

        /// <summary>
        /// "Beatmap listing"
        /// </summary>
        public static LocalisableString ShowNsfwWarningButtonsListing => new TranslatableString(getKey(@"show.nsfw_warning.buttons.listing"), @"Beatmap listing");

        /// <summary>
        /// "Show"
        /// </summary>
        public static LocalisableString ShowNsfwWarningButtonsShow => new TranslatableString(getKey(@"show.nsfw_warning.buttons.show"), @"Show");

        /// <summary>
        /// "achieved {0}"
        /// </summary>
        public static LocalisableString ShowScoreboardAchieved(LocalisableString when) => new TranslatableString(getKey(@"show.scoreboard.achieved"), @"achieved {0}", when);

        /// <summary>
        /// "Country Ranking"
        /// </summary>
        public static LocalisableString ShowScoreboardCountry => new TranslatableString(getKey(@"show.scoreboard.country"), @"Country Ranking");

        /// <summary>
        /// "Failed loading ranking"
        /// </summary>
        public static LocalisableString ShowScoreboardError => new TranslatableString(getKey(@"show.scoreboard.error"), @"Failed loading ranking");

        /// <summary>
        /// "Friend Ranking"
        /// </summary>
        public static LocalisableString ShowScoreboardFriend => new TranslatableString(getKey(@"show.scoreboard.friend"), @"Friend Ranking");

        /// <summary>
        /// "Global Ranking"
        /// </summary>
        public static LocalisableString ShowScoreboardGlobal => new TranslatableString(getKey(@"show.scoreboard.global"), @"Global Ranking");

        /// <summary>
        /// "Click &lt;a href=&quot;{0}&quot;&gt;here&lt;/a&gt; to see all the fancy features that you get!"
        /// </summary>
        public static LocalisableString ShowScoreboardSupporterLink(LocalisableString link) => new TranslatableString(getKey(@"show.scoreboard.supporter-link"), @"Click <a href=""{0}"">here</a> to see all the fancy features that you get!", link);

        /// <summary>
        /// "You need to be an osu!supporter to access the friend, country, or mod-specific rankings!"
        /// </summary>
        public static LocalisableString ShowScoreboardSupporterOnly => new TranslatableString(getKey(@"show.scoreboard.supporter-only"), @"You need to be an osu!supporter to access the friend, country, or mod-specific rankings!");

        /// <summary>
        /// "Scoreboard"
        /// </summary>
        public static LocalisableString ShowScoreboardTitle => new TranslatableString(getKey(@"show.scoreboard.title"), @"Scoreboard");

        /// <summary>
        /// "Accuracy"
        /// </summary>
        public static LocalisableString ShowScoreboardHeadersAccuracy => new TranslatableString(getKey(@"show.scoreboard.headers.accuracy"), @"Accuracy");

        /// <summary>
        /// "Max Combo"
        /// </summary>
        public static LocalisableString ShowScoreboardHeadersCombo => new TranslatableString(getKey(@"show.scoreboard.headers.combo"), @"Max Combo");

        /// <summary>
        /// "Miss"
        /// </summary>
        public static LocalisableString ShowScoreboardHeadersMiss => new TranslatableString(getKey(@"show.scoreboard.headers.miss"), @"Miss");

        /// <summary>
        /// "Mods"
        /// </summary>
        public static LocalisableString ShowScoreboardHeadersMods => new TranslatableString(getKey(@"show.scoreboard.headers.mods"), @"Mods");

        /// <summary>
        /// "Pin"
        /// </summary>
        public static LocalisableString ShowScoreboardHeadersPin => new TranslatableString(getKey(@"show.scoreboard.headers.pin"), @"Pin");

        /// <summary>
        /// "Player"
        /// </summary>
        public static LocalisableString ShowScoreboardHeadersPlayer => new TranslatableString(getKey(@"show.scoreboard.headers.player"), @"Player");

        /// <summary>
        /// "pp"
        /// </summary>
        public static LocalisableString ShowScoreboardHeaderspp => new TranslatableString(getKey(@"show.scoreboard.headers.pp"), @"pp");

        /// <summary>
        /// "Rank"
        /// </summary>
        public static LocalisableString ShowScoreboardHeadersRank => new TranslatableString(getKey(@"show.scoreboard.headers.rank"), @"Rank");

        /// <summary>
        /// "Score"
        /// </summary>
        public static LocalisableString ShowScoreboardHeadersScore => new TranslatableString(getKey(@"show.scoreboard.headers.score"), @"Score");

        /// <summary>
        /// "Total Score"
        /// </summary>
        public static LocalisableString ShowScoreboardHeadersScoreTotal => new TranslatableString(getKey(@"show.scoreboard.headers.score_total"), @"Total Score");

        /// <summary>
        /// "Time"
        /// </summary>
        public static LocalisableString ShowScoreboardHeadersTime => new TranslatableString(getKey(@"show.scoreboard.headers.time"), @"Time");

        /// <summary>
        /// "No one from your country has set a score on this map yet!"
        /// </summary>
        public static LocalisableString ShowScoreboardNoScoresCountry => new TranslatableString(getKey(@"show.scoreboard.no_scores.country"), @"No one from your country has set a score on this map yet!");

        /// <summary>
        /// "None of your friends have set a score on this map yet!"
        /// </summary>
        public static LocalisableString ShowScoreboardNoScoresFriend => new TranslatableString(getKey(@"show.scoreboard.no_scores.friend"), @"None of your friends have set a score on this map yet!");

        /// <summary>
        /// "No scores yet. Maybe you should try setting some?"
        /// </summary>
        public static LocalisableString ShowScoreboardNoScoresGlobal => new TranslatableString(getKey(@"show.scoreboard.no_scores.global"), @"No scores yet. Maybe you should try setting some?");

        /// <summary>
        /// "Loading scores..."
        /// </summary>
        public static LocalisableString ShowScoreboardNoScoresLoading => new TranslatableString(getKey(@"show.scoreboard.no_scores.loading"), @"Loading scores...");

        /// <summary>
        /// "Unranked beatmap."
        /// </summary>
        public static LocalisableString ShowScoreboardNoScoresUnranked => new TranslatableString(getKey(@"show.scoreboard.no_scores.unranked"), @"Unranked beatmap.");

        /// <summary>
        /// "In the Lead"
        /// </summary>
        public static LocalisableString ShowScoreboardScoreFirst => new TranslatableString(getKey(@"show.scoreboard.score.first"), @"In the Lead");

        /// <summary>
        /// "Your Best"
        /// </summary>
        public static LocalisableString ShowScoreboardScoreOwn => new TranslatableString(getKey(@"show.scoreboard.score.own"), @"Your Best");

        /// <summary>
        /// "Click {0} to see all the fancy features that you get!"
        /// </summary>
        public static LocalisableString ShowScoreboardSupporterLinkDefault(LocalisableString here) => new TranslatableString(getKey(@"show.scoreboard.supporter_link._"), @"Click {0} to see all the fancy features that you get!", here);

        /// <summary>
        /// "here"
        /// </summary>
        public static LocalisableString ShowScoreboardSupporterLinkHere => new TranslatableString(getKey(@"show.scoreboard.supporter_link.here"), @"here");

        /// <summary>
        /// "Circle Size"
        /// </summary>
        public static LocalisableString ShowStatsCs => new TranslatableString(getKey(@"show.stats.cs"), @"Circle Size");

        /// <summary>
        /// "Key Count"
        /// </summary>
        public static LocalisableString ShowStatsCsMania => new TranslatableString(getKey(@"show.stats.cs-mania"), @"Key Count");

        /// <summary>
        /// "HP Drain"
        /// </summary>
        public static LocalisableString ShowStatsDrain => new TranslatableString(getKey(@"show.stats.drain"), @"HP Drain");

        /// <summary>
        /// "Accuracy"
        /// </summary>
        public static LocalisableString ShowStatsAccuracy => new TranslatableString(getKey(@"show.stats.accuracy"), @"Accuracy");

        /// <summary>
        /// "Approach Rate"
        /// </summary>
        public static LocalisableString ShowStatsAr => new TranslatableString(getKey(@"show.stats.ar"), @"Approach Rate");

        /// <summary>
        /// "Star Rating"
        /// </summary>
        public static LocalisableString ShowStatsStars => new TranslatableString(getKey(@"show.stats.stars"), @"Star Rating");

        /// <summary>
        /// "Length (Drain length: {0})"
        /// </summary>
        public static LocalisableString ShowStatsTotalLength(LocalisableString hitLength) => new TranslatableString(getKey(@"show.stats.total_length"), @"Length (Drain length: {0})", hitLength);

        /// <summary>
        /// "BPM"
        /// </summary>
        public static LocalisableString ShowStatsBpm => new TranslatableString(getKey(@"show.stats.bpm"), @"BPM");

        /// <summary>
        /// "Circle Count"
        /// </summary>
        public static LocalisableString ShowStatsCountCircles => new TranslatableString(getKey(@"show.stats.count_circles"), @"Circle Count");

        /// <summary>
        /// "Slider Count"
        /// </summary>
        public static LocalisableString ShowStatsCountSliders => new TranslatableString(getKey(@"show.stats.count_sliders"), @"Slider Count");

        /// <summary>
        /// "Online offset: {0}"
        /// </summary>
        public static LocalisableString ShowStatsOffset(LocalisableString offset) => new TranslatableString(getKey(@"show.stats.offset"), @"Online offset: {0}", offset);

        /// <summary>
        /// "User Rating"
        /// </summary>
        public static LocalisableString ShowStatsUserRating => new TranslatableString(getKey(@"show.stats.user-rating"), @"User Rating");

        /// <summary>
        /// "Rating Spread"
        /// </summary>
        public static LocalisableString ShowStatsRatingSpread => new TranslatableString(getKey(@"show.stats.rating-spread"), @"Rating Spread");

        /// <summary>
        /// "Nominations"
        /// </summary>
        public static LocalisableString ShowStatsNominations => new TranslatableString(getKey(@"show.stats.nominations"), @"Nominations");

        /// <summary>
        /// "Playcount"
        /// </summary>
        public static LocalisableString ShowStatsPlaycount => new TranslatableString(getKey(@"show.stats.playcount"), @"Playcount");

        /// <summary>
        /// "Ranked"
        /// </summary>
        public static LocalisableString ShowStatusRanked => new TranslatableString(getKey(@"show.status.ranked"), @"Ranked");

        /// <summary>
        /// "Approved"
        /// </summary>
        public static LocalisableString ShowStatusApproved => new TranslatableString(getKey(@"show.status.approved"), @"Approved");

        /// <summary>
        /// "Loved"
        /// </summary>
        public static LocalisableString ShowStatusLoved => new TranslatableString(getKey(@"show.status.loved"), @"Loved");

        /// <summary>
        /// "Qualified"
        /// </summary>
        public static LocalisableString ShowStatusQualified => new TranslatableString(getKey(@"show.status.qualified"), @"Qualified");

        /// <summary>
        /// "WIP"
        /// </summary>
        public static LocalisableString ShowStatusWip => new TranslatableString(getKey(@"show.status.wip"), @"WIP");

        /// <summary>
        /// "Pending"
        /// </summary>
        public static LocalisableString ShowStatusPending => new TranslatableString(getKey(@"show.status.pending"), @"Pending");

        /// <summary>
        /// "Graveyard"
        /// </summary>
        public static LocalisableString ShowStatusGraveyard => new TranslatableString(getKey(@"show.status.graveyard"), @"Graveyard");

        /// <summary>
        /// "Spotlight"
        /// </summary>
        public static LocalisableString SpotlightBadgeLabel => new TranslatableString(getKey(@"spotlight_badge.label"), @"Spotlight");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}