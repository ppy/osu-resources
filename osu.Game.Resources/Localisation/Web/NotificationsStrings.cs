// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class NotificationsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Notifications";

        /// <summary>
        /// "All notifications read!"
        /// </summary>
        public static LocalisableString AllRead => new TranslatableString(getKey(@"all_read"), @"All notifications read!");

        /// <summary>
        /// "Delete {0}"
        /// </summary>
        public static LocalisableString Delete(LocalisableString type) => new TranslatableString(getKey(@"delete"), @"Delete {0}", type);

        /// <summary>
        /// "Loading unread notifications..."
        /// </summary>
        public static LocalisableString Loading => new TranslatableString(getKey(@"loading"), @"Loading unread notifications...");

        /// <summary>
        /// "Clear {0}"
        /// </summary>
        public static LocalisableString MarkRead(LocalisableString type) => new TranslatableString(getKey(@"mark_read"), @"Clear {0}", type);

        /// <summary>
        /// "No notifications"
        /// </summary>
        public static LocalisableString None => new TranslatableString(getKey(@"none"), @"No notifications");

        /// <summary>
        /// "see all notifications"
        /// </summary>
        public static LocalisableString SeeAll => new TranslatableString(getKey(@"see_all"), @"see all notifications");

        /// <summary>
        /// "go to chat"
        /// </summary>
        public static LocalisableString SeeChannel => new TranslatableString(getKey(@"see_channel"), @"go to chat");

        /// <summary>
        /// "Please verify session to view notifications"
        /// </summary>
        public static LocalisableString Verifying => new TranslatableString(getKey(@"verifying"), @"Please verify session to view notifications");

        /// <summary>
        /// "all"
        /// </summary>
        public static LocalisableString ActionTypeDefault => new TranslatableString(getKey(@"action_type._"), @"all");

        /// <summary>
        /// "beatmaps"
        /// </summary>
        public static LocalisableString ActionTypeBeatmapset => new TranslatableString(getKey(@"action_type.beatmapset"), @"beatmaps");

        /// <summary>
        /// "builds"
        /// </summary>
        public static LocalisableString ActionTypeBuild => new TranslatableString(getKey(@"action_type.build"), @"builds");

        /// <summary>
        /// "chat"
        /// </summary>
        public static LocalisableString ActionTypeChannel => new TranslatableString(getKey(@"action_type.channel"), @"chat");

        /// <summary>
        /// "forum"
        /// </summary>
        public static LocalisableString ActionTypeForumTopic => new TranslatableString(getKey(@"action_type.forum_topic"), @"forum");

        /// <summary>
        /// "news"
        /// </summary>
        public static LocalisableString ActionTypeNewsPost => new TranslatableString(getKey(@"action_type.news_post"), @"news");

        /// <summary>
        /// "team"
        /// </summary>
        public static LocalisableString ActionTypeTeam => new TranslatableString(getKey(@"action_type.team"), @"team");

        /// <summary>
        /// "profile"
        /// </summary>
        public static LocalisableString ActionTypeUser => new TranslatableString(getKey(@"action_type.user"), @"profile");

        /// <summary>
        /// "all"
        /// </summary>
        public static LocalisableString FiltersDefault => new TranslatableString(getKey(@"filters._"), @"all");

        /// <summary>
        /// "beatmaps"
        /// </summary>
        public static LocalisableString FiltersBeatmapset => new TranslatableString(getKey(@"filters.beatmapset"), @"beatmaps");

        /// <summary>
        /// "builds"
        /// </summary>
        public static LocalisableString FiltersBuild => new TranslatableString(getKey(@"filters.build"), @"builds");

        /// <summary>
        /// "chat"
        /// </summary>
        public static LocalisableString FiltersChannel => new TranslatableString(getKey(@"filters.channel"), @"chat");

        /// <summary>
        /// "forum"
        /// </summary>
        public static LocalisableString FiltersForumTopic => new TranslatableString(getKey(@"filters.forum_topic"), @"forum");

        /// <summary>
        /// "news"
        /// </summary>
        public static LocalisableString FiltersNewsPost => new TranslatableString(getKey(@"filters.news_post"), @"news");

        /// <summary>
        /// "team"
        /// </summary>
        public static LocalisableString FiltersTeam => new TranslatableString(getKey(@"filters.team"), @"team");

        /// <summary>
        /// "profile"
        /// </summary>
        public static LocalisableString FiltersUser => new TranslatableString(getKey(@"filters.user"), @"profile");

        /// <summary>
        /// "Beatmap"
        /// </summary>
        public static LocalisableString ItemBeatmapsetDefault => new TranslatableString(getKey(@"item.beatmapset._"), @"Beatmap");

        /// <summary>
        /// "Guest difficulty"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapOwnerChangeDefault => new TranslatableString(getKey(@"item.beatmapset.beatmap_owner_change._"), @"Guest difficulty");

        /// <summary>
        /// "You&#39;re now owner of difficulty &quot;{0}&quot; for beatmap &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapOwnerChangeBeatmapOwnerChange(LocalisableString beatmap, LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.beatmap_owner_change.beatmap_owner_change"), @"You're now owner of difficulty ""{0}"" for beatmap ""{1}""", beatmap, title);

        /// <summary>
        /// "You&#39;re now owner of difficulty &quot;{0}&quot;"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapOwnerChangeBeatmapOwnerChangeCompact(LocalisableString beatmap) => new TranslatableString(getKey(@"item.beatmapset.beatmap_owner_change.beatmap_owner_change_compact"), @"You're now owner of difficulty ""{0}""", beatmap);

        /// <summary>
        /// "Beatmap discussion"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionDefault => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion._"), @"Beatmap discussion");

        /// <summary>
        /// "Discussion on &quot;{0}&quot; has been locked"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionLock(LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.beatmapset_discussion_lock"), @"Discussion on ""{0}"" has been locked", title);

        /// <summary>
        /// "Discussion was locked"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionLockCompact => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.beatmapset_discussion_lock_compact"), @"Discussion was locked");

        /// <summary>
        /// "New post on &quot;{0}&quot; by {1}: &quot;{2}&quot;"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionPostNew(LocalisableString title, LocalisableString username, LocalisableString content) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.beatmapset_discussion_post_new"), @"New post on ""{0}"" by {1}: ""{2}""", title, username, content);

        /// <summary>
        /// "New post on &quot;{0}&quot; by {1}"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionPostNewEmpty(LocalisableString title, LocalisableString username) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.beatmapset_discussion_post_new_empty"), @"New post on ""{0}"" by {1}", title, username);

        /// <summary>
        /// "New post by {0}: &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionPostNewCompact(LocalisableString username, LocalisableString content) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.beatmapset_discussion_post_new_compact"), @"New post by {0}: ""{1}""", username, content);

        /// <summary>
        /// "New post by {0}"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionPostNewCompactEmpty(LocalisableString username) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.beatmapset_discussion_post_new_compact_empty"), @"New post by {0}", username);

        /// <summary>
        /// "New review on &quot;{0}&quot; by {1} containing {2}"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionReviewNew(LocalisableString title, LocalisableString username, LocalisableString reviewCounts) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.beatmapset_discussion_review_new"), @"New review on ""{0}"" by {1} containing {2}", title, username, reviewCounts);

        /// <summary>
        /// "New review by {0} containing {1}"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionReviewNewCompact(LocalisableString username, LocalisableString reviewCounts) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.beatmapset_discussion_review_new_compact"), @"New review by {0} containing {1}", username, reviewCounts);

        /// <summary>
        /// "Discussion on &quot;{0}&quot; has been unlocked"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionUnlock(LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.beatmapset_discussion_unlock"), @"Discussion on ""{0}"" has been unlocked", title);

        /// <summary>
        /// "Discussion was unlocked"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionUnlockCompact => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.beatmapset_discussion_unlock_compact"), @"Discussion was unlocked");

        /// <summary>
        /// "{0} praise|{0} praises"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionReviewCountPraises(LocalisableString countDelimited) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.review_count.praises"), @"{0} praise|{0} praises", countDelimited);

        /// <summary>
        /// "{0} problem|{0} problems"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionReviewCountProblems(LocalisableString countDelimited) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.review_count.problems"), @"{0} problem|{0} problems", countDelimited);

        /// <summary>
        /// "{0} suggestion|{0} suggestions"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetDiscussionReviewCountSuggestions(LocalisableString countDelimited) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_discussion.review_count.suggestions"), @"{0} suggestion|{0} suggestions", countDelimited);

        /// <summary>
        /// "Qualified Beatmap problem"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetProblemDefault => new TranslatableString(getKey(@"item.beatmapset.beatmapset_problem._"), @"Qualified Beatmap problem");

        /// <summary>
        /// "Reported by {0} on &quot;{1}&quot;: &quot;{2}&quot;"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetProblemBeatmapsetDiscussionQualifiedProblem(LocalisableString username, LocalisableString title, LocalisableString content) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_problem.beatmapset_discussion_qualified_problem"), @"Reported by {0} on ""{1}"": ""{2}""", username, title, content);

        /// <summary>
        /// "Reported by {0} on &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetProblemBeatmapsetDiscussionQualifiedProblemEmpty(LocalisableString username, LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_problem.beatmapset_discussion_qualified_problem_empty"), @"Reported by {0} on ""{1}""", username, title);

        /// <summary>
        /// "Reported by {0}: &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetProblemBeatmapsetDiscussionQualifiedProblemCompact(LocalisableString username, LocalisableString content) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_problem.beatmapset_discussion_qualified_problem_compact"), @"Reported by {0}: ""{1}""", username, content);

        /// <summary>
        /// "Reported by {0}"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetProblemBeatmapsetDiscussionQualifiedProblemCompactEmpty(LocalisableString username) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_problem.beatmapset_discussion_qualified_problem_compact_empty"), @"Reported by {0}", username);

        /// <summary>
        /// "Beatmap status changed"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateDefault => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state._"), @"Beatmap status changed");

        /// <summary>
        /// "&quot;{0}&quot; has been disqualified"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetDisqualify(LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_disqualify"), @"""{0}"" has been disqualified", title);

        /// <summary>
        /// "Beatmap was disqualified"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetDisqualifyCompact => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_disqualify_compact"), @"Beatmap was disqualified");

        /// <summary>
        /// "&quot;{0}&quot; was promoted to loved"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetLove(LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_love"), @"""{0}"" was promoted to loved", title);

        /// <summary>
        /// "Beatmap was promoted to loved"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetLoveCompact => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_love_compact"), @"Beatmap was promoted to loved");

        /// <summary>
        /// "&quot;{0}&quot; has been nominated"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetNominate(LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_nominate"), @"""{0}"" has been nominated", title);

        /// <summary>
        /// "Beatmap was nominated"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetNominateCompact => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_nominate_compact"), @"Beatmap was nominated");

        /// <summary>
        /// "&quot;{0}&quot; has gained enough nominations and entered the ranking queue"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetQualify(LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_qualify"), @"""{0}"" has gained enough nominations and entered the ranking queue", title);

        /// <summary>
        /// "Beatmap entered ranking queue"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetQualifyCompact => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_qualify_compact"), @"Beatmap entered ranking queue");

        /// <summary>
        /// "&quot;{0}&quot; has been ranked"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetRank(LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_rank"), @"""{0}"" has been ranked", title);

        /// <summary>
        /// "Beatmap was ranked"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetRankCompact => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_rank_compact"), @"Beatmap was ranked");

        /// <summary>
        /// "&quot;{0}&quot; was removed from Loved"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetRemoveFromLoved(LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_remove_from_loved"), @"""{0}"" was removed from Loved", title);

        /// <summary>
        /// "Beatmap was removed from Loved"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetRemoveFromLovedCompact => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_remove_from_loved_compact"), @"Beatmap was removed from Loved");

        /// <summary>
        /// "Nomination of &quot;{0}&quot; has been reset"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetResetNominations(LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_reset_nominations"), @"Nomination of ""{0}"" has been reset", title);

        /// <summary>
        /// "Nomination was reset"
        /// </summary>
        public static LocalisableString ItemBeatmapsetBeatmapsetStateBeatmapsetResetNominationsCompact => new TranslatableString(getKey(@"item.beatmapset.beatmapset_state.beatmapset_reset_nominations_compact"), @"Nomination was reset");

        /// <summary>
        /// "New comment"
        /// </summary>
        public static LocalisableString ItemBeatmapsetCommentDefault => new TranslatableString(getKey(@"item.beatmapset.comment._"), @"New comment");

        /// <summary>
        /// "{0} commented &quot;{1}&quot; on &quot;{2}&quot;"
        /// </summary>
        public static LocalisableString ItemBeatmapsetCommentCommentNew(LocalisableString username, LocalisableString content, LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.comment.comment_new"), @"{0} commented ""{1}"" on ""{2}""", username, content, title);

        /// <summary>
        /// "{0} commented &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemBeatmapsetCommentCommentNewCompact(LocalisableString username, LocalisableString content) => new TranslatableString(getKey(@"item.beatmapset.comment.comment_new_compact"), @"{0} commented ""{1}""", username, content);

        /// <summary>
        /// "{0} replied &quot;{1}&quot; on &quot;{2}&quot;"
        /// </summary>
        public static LocalisableString ItemBeatmapsetCommentCommentReply(LocalisableString username, LocalisableString content, LocalisableString title) => new TranslatableString(getKey(@"item.beatmapset.comment.comment_reply"), @"{0} replied ""{1}"" on ""{2}""", username, content, title);

        /// <summary>
        /// "{0} replied &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemBeatmapsetCommentCommentReplyCompact(LocalisableString username, LocalisableString content) => new TranslatableString(getKey(@"item.beatmapset.comment.comment_reply_compact"), @"{0} replied ""{1}""", username, content);

        /// <summary>
        /// "Chat"
        /// </summary>
        public static LocalisableString ItemChannelDefault => new TranslatableString(getKey(@"item.channel._"), @"Chat");

        /// <summary>
        /// "New announcement"
        /// </summary>
        public static LocalisableString ItemChannelAnnouncementDefault => new TranslatableString(getKey(@"item.channel.announcement._"), @"New announcement");

        /// <summary>
        /// "{0} says &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemChannelAnnouncementAnnounceChannelAnnouncement(LocalisableString username, LocalisableString title) => new TranslatableString(getKey(@"item.channel.announcement.announce.channel_announcement"), @"{0} says ""{1}""", username, title);

        /// <summary>
        /// "{0}"
        /// </summary>
        public static LocalisableString ItemChannelAnnouncementAnnounceChannelAnnouncementCompact(LocalisableString title) => new TranslatableString(getKey(@"item.channel.announcement.announce.channel_announcement_compact"), @"{0}", title);

        /// <summary>
        /// "Announcement from {0}"
        /// </summary>
        public static LocalisableString ItemChannelAnnouncementAnnounceChannelAnnouncementGroup(LocalisableString username) => new TranslatableString(getKey(@"item.channel.announcement.announce.channel_announcement_group"), @"Announcement from {0}", username);

        /// <summary>
        /// "New message"
        /// </summary>
        public static LocalisableString ItemChannelChannelDefault => new TranslatableString(getKey(@"item.channel.channel._"), @"New message");

        /// <summary>
        /// "{0} says &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemChannelChannelPmChannelMessage(LocalisableString username, LocalisableString title) => new TranslatableString(getKey(@"item.channel.channel.pm.channel_message"), @"{0} says ""{1}""", username, title);

        /// <summary>
        /// "{0}"
        /// </summary>
        public static LocalisableString ItemChannelChannelPmChannelMessageCompact(LocalisableString title) => new TranslatableString(getKey(@"item.channel.channel.pm.channel_message_compact"), @"{0}", title);

        /// <summary>
        /// "from {0}"
        /// </summary>
        public static LocalisableString ItemChannelChannelPmChannelMessageGroup(LocalisableString username) => new TranslatableString(getKey(@"item.channel.channel.pm.channel_message_group"), @"from {0}", username);

        /// <summary>
        /// "New team message"
        /// </summary>
        public static LocalisableString ItemChannelChannelTeamDefault => new TranslatableString(getKey(@"item.channel.channel_team._"), @"New team message");

        /// <summary>
        /// "{0} says &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemChannelChannelTeamTeamChannelTeam(LocalisableString username, LocalisableString title) => new TranslatableString(getKey(@"item.channel.channel_team.team.channel_team"), @"{0} says ""{1}""", username, title);

        /// <summary>
        /// "{0} says &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemChannelChannelTeamTeamChannelTeamCompact(LocalisableString username, LocalisableString title) => new TranslatableString(getKey(@"item.channel.channel_team.team.channel_team_compact"), @"{0} says ""{1}""", username, title);

        /// <summary>
        /// "{0} says &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemChannelChannelTeamTeamChannelTeamGroup(LocalisableString username, LocalisableString title) => new TranslatableString(getKey(@"item.channel.channel_team.team.channel_team_group"), @"{0} says ""{1}""", username, title);

        /// <summary>
        /// "Changelog"
        /// </summary>
        public static LocalisableString ItemBuildDefault => new TranslatableString(getKey(@"item.build._"), @"Changelog");

        /// <summary>
        /// "New comment"
        /// </summary>
        public static LocalisableString ItemBuildCommentDefault => new TranslatableString(getKey(@"item.build.comment._"), @"New comment");

        /// <summary>
        /// "{0} commented &quot;{1}&quot; on &quot;{2}&quot;"
        /// </summary>
        public static LocalisableString ItemBuildCommentCommentNew(LocalisableString username, LocalisableString content, LocalisableString title) => new TranslatableString(getKey(@"item.build.comment.comment_new"), @"{0} commented ""{1}"" on ""{2}""", username, content, title);

        /// <summary>
        /// "{0} commented &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemBuildCommentCommentNewCompact(LocalisableString username, LocalisableString content) => new TranslatableString(getKey(@"item.build.comment.comment_new_compact"), @"{0} commented ""{1}""", username, content);

        /// <summary>
        /// "{0} replied &quot;{1}&quot; on &quot;{2}&quot;"
        /// </summary>
        public static LocalisableString ItemBuildCommentCommentReply(LocalisableString username, LocalisableString content, LocalisableString title) => new TranslatableString(getKey(@"item.build.comment.comment_reply"), @"{0} replied ""{1}"" on ""{2}""", username, content, title);

        /// <summary>
        /// "{0} replied &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemBuildCommentCommentReplyCompact(LocalisableString username, LocalisableString content) => new TranslatableString(getKey(@"item.build.comment.comment_reply_compact"), @"{0} replied ""{1}""", username, content);

        /// <summary>
        /// "News"
        /// </summary>
        public static LocalisableString ItemNewsPostDefault => new TranslatableString(getKey(@"item.news_post._"), @"News");

        /// <summary>
        /// "New comment"
        /// </summary>
        public static LocalisableString ItemNewsPostCommentDefault => new TranslatableString(getKey(@"item.news_post.comment._"), @"New comment");

        /// <summary>
        /// "{0} commented &quot;{1}&quot; on &quot;{2}&quot;"
        /// </summary>
        public static LocalisableString ItemNewsPostCommentCommentNew(LocalisableString username, LocalisableString content, LocalisableString title) => new TranslatableString(getKey(@"item.news_post.comment.comment_new"), @"{0} commented ""{1}"" on ""{2}""", username, content, title);

        /// <summary>
        /// "{0} commented &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemNewsPostCommentCommentNewCompact(LocalisableString username, LocalisableString content) => new TranslatableString(getKey(@"item.news_post.comment.comment_new_compact"), @"{0} commented ""{1}""", username, content);

        /// <summary>
        /// "{0} replied &quot;{1}&quot; on &quot;{2}&quot;"
        /// </summary>
        public static LocalisableString ItemNewsPostCommentCommentReply(LocalisableString username, LocalisableString content, LocalisableString title) => new TranslatableString(getKey(@"item.news_post.comment.comment_reply"), @"{0} replied ""{1}"" on ""{2}""", username, content, title);

        /// <summary>
        /// "{0} replied &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemNewsPostCommentCommentReplyCompact(LocalisableString username, LocalisableString content) => new TranslatableString(getKey(@"item.news_post.comment.comment_reply_compact"), @"{0} replied ""{1}""", username, content);

        /// <summary>
        /// "Forum topic"
        /// </summary>
        public static LocalisableString ItemForumTopicDefault => new TranslatableString(getKey(@"item.forum_topic._"), @"Forum topic");

        /// <summary>
        /// "New forum reply"
        /// </summary>
        public static LocalisableString ItemForumTopicForumTopicReplyDefault => new TranslatableString(getKey(@"item.forum_topic.forum_topic_reply._"), @"New forum reply");

        /// <summary>
        /// "{0} replied to &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString ItemForumTopicForumTopicReplyForumTopicReply(LocalisableString username, LocalisableString title) => new TranslatableString(getKey(@"item.forum_topic.forum_topic_reply.forum_topic_reply"), @"{0} replied to ""{1}""", username, title);

        /// <summary>
        /// "{0} replied"
        /// </summary>
        public static LocalisableString ItemForumTopicForumTopicReplyForumTopicReplyCompact(LocalisableString username) => new TranslatableString(getKey(@"item.forum_topic.forum_topic_reply.forum_topic_reply_compact"), @"{0} replied", username);

        /// <summary>
        /// "Team join request"
        /// </summary>
        public static LocalisableString ItemTeamTeamApplicationDefault => new TranslatableString(getKey(@"item.team.team_application._"), @"Team join request");

        /// <summary>
        /// "You&#39;re now member of team {0}"
        /// </summary>
        public static LocalisableString ItemTeamTeamApplicationTeamApplicationAccept(LocalisableString title) => new TranslatableString(getKey(@"item.team.team_application.team_application_accept"), @"You're now member of team {0}", title);

        /// <summary>
        /// "You&#39;re now member of team {0}"
        /// </summary>
        public static LocalisableString ItemTeamTeamApplicationTeamApplicationAcceptCompact(LocalisableString title) => new TranslatableString(getKey(@"item.team.team_application.team_application_accept_compact"), @"You're now member of team {0}", title);

        /// <summary>
        /// "Team join request updates"
        /// </summary>
        public static LocalisableString ItemTeamTeamApplicationTeamApplicationGroup => new TranslatableString(getKey(@"item.team.team_application.team_application_group"), @"Team join request updates");

        /// <summary>
        /// "Your request to join team {0} has been declined"
        /// </summary>
        public static LocalisableString ItemTeamTeamApplicationTeamApplicationReject(LocalisableString title) => new TranslatableString(getKey(@"item.team.team_application.team_application_reject"), @"Your request to join team {0} has been declined", title);

        /// <summary>
        /// "Your request to join team {0} has been declined"
        /// </summary>
        public static LocalisableString ItemTeamTeamApplicationTeamApplicationRejectCompact(LocalisableString title) => new TranslatableString(getKey(@"item.team.team_application.team_application_reject_compact"), @"Your request to join team {0} has been declined", title);

        /// <summary>
        /// "{0} requested to join your team"
        /// </summary>
        public static LocalisableString ItemTeamTeamApplicationTeamApplicationStore(LocalisableString title) => new TranslatableString(getKey(@"item.team.team_application.team_application_store"), @"{0} requested to join your team", title);

        /// <summary>
        /// "{0} requested to join your team"
        /// </summary>
        public static LocalisableString ItemTeamTeamApplicationTeamApplicationStoreCompact(LocalisableString title) => new TranslatableString(getKey(@"item.team.team_application.team_application_store_compact"), @"{0} requested to join your team", title);

        /// <summary>
        /// "New beatmap"
        /// </summary>
        public static LocalisableString ItemUserUserBeatmapsetNewDefault => new TranslatableString(getKey(@"item.user.user_beatmapset_new._"), @"New beatmap");

        /// <summary>
        /// "New beatmap &quot;{0}&quot; by {1}"
        /// </summary>
        public static LocalisableString ItemUserUserBeatmapsetNewUserBeatmapsetNew(LocalisableString title, LocalisableString username) => new TranslatableString(getKey(@"item.user.user_beatmapset_new.user_beatmapset_new"), @"New beatmap ""{0}"" by {1}", title, username);

        /// <summary>
        /// "New beatmap &quot;{0}&quot;"
        /// </summary>
        public static LocalisableString ItemUserUserBeatmapsetNewUserBeatmapsetNewCompact(LocalisableString title) => new TranslatableString(getKey(@"item.user.user_beatmapset_new.user_beatmapset_new_compact"), @"New beatmap ""{0}""", title);

        /// <summary>
        /// "New beatmaps by {0}"
        /// </summary>
        public static LocalisableString ItemUserUserBeatmapsetNewUserBeatmapsetNewGroup(LocalisableString username) => new TranslatableString(getKey(@"item.user.user_beatmapset_new.user_beatmapset_new_group"), @"New beatmaps by {0}", username);

        /// <summary>
        /// "Beatmap &quot;{0}&quot; revived by {1}"
        /// </summary>
        public static LocalisableString ItemUserUserBeatmapsetNewUserBeatmapsetRevive(LocalisableString title, LocalisableString username) => new TranslatableString(getKey(@"item.user.user_beatmapset_new.user_beatmapset_revive"), @"Beatmap ""{0}"" revived by {1}", title, username);

        /// <summary>
        /// "Beatmap &quot;{0}&quot; revived"
        /// </summary>
        public static LocalisableString ItemUserUserBeatmapsetNewUserBeatmapsetReviveCompact(LocalisableString title) => new TranslatableString(getKey(@"item.user.user_beatmapset_new.user_beatmapset_revive_compact"), @"Beatmap ""{0}"" revived", title);

        /// <summary>
        /// "Medals"
        /// </summary>
        public static LocalisableString ItemUserAchievementDefault => new TranslatableString(getKey(@"item.user_achievement._"), @"Medals");

        /// <summary>
        /// "New medal"
        /// </summary>
        public static LocalisableString ItemUserAchievementUserAchievementUnlockDefault => new TranslatableString(getKey(@"item.user_achievement.user_achievement_unlock._"), @"New medal");

        /// <summary>
        /// "Unlocked &quot;{0}&quot;!"
        /// </summary>
        public static LocalisableString ItemUserAchievementUserAchievementUnlockUserAchievementUnlock(LocalisableString title) => new TranslatableString(getKey(@"item.user_achievement.user_achievement_unlock.user_achievement_unlock"), @"Unlocked ""{0}""!", title);

        /// <summary>
        /// "Unlocked &quot;{0}&quot;!"
        /// </summary>
        public static LocalisableString ItemUserAchievementUserAchievementUnlockUserAchievementUnlockCompact(LocalisableString title) => new TranslatableString(getKey(@"item.user_achievement.user_achievement_unlock.user_achievement_unlock_compact"), @"Unlocked ""{0}""!", title);

        /// <summary>
        /// "Medals unlocked!"
        /// </summary>
        public static LocalisableString ItemUserAchievementUserAchievementUnlockUserAchievementUnlockGroup => new TranslatableString(getKey(@"item.user_achievement.user_achievement_unlock.user_achievement_unlock_group"), @"Medals unlocked!");

        /// <summary>
        /// "You&#39;re now guest of beatmap &quot;{0}&quot;"
        /// </summary>
        public static LocalisableString MailBeatmapsetBeatmapOwnerChangeBeatmapOwnerChange(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.beatmap_owner_change.beatmap_owner_change"), @"You're now guest of beatmap ""{0}""", title);

        /// <summary>
        /// "The discussion on &quot;{0}&quot; has been locked"
        /// </summary>
        public static LocalisableString MailBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionLock(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.beatmapset_discussion.beatmapset_discussion_lock"), @"The discussion on ""{0}"" has been locked", title);

        /// <summary>
        /// "The discussion on &quot;{0}&quot; has new updates"
        /// </summary>
        public static LocalisableString MailBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionPostNew(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.beatmapset_discussion.beatmapset_discussion_post_new"), @"The discussion on ""{0}"" has new updates", title);

        /// <summary>
        /// "The discussion on &quot;{0}&quot; has been unlocked"
        /// </summary>
        public static LocalisableString MailBeatmapsetBeatmapsetDiscussionBeatmapsetDiscussionUnlock(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.beatmapset_discussion.beatmapset_discussion_unlock"), @"The discussion on ""{0}"" has been unlocked", title);

        /// <summary>
        /// "A new problem was reported on &quot;{0}&quot;"
        /// </summary>
        public static LocalisableString MailBeatmapsetBeatmapsetProblemBeatmapsetDiscussionQualifiedProblem(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.beatmapset_problem.beatmapset_discussion_qualified_problem"), @"A new problem was reported on ""{0}""", title);

        /// <summary>
        /// "&quot;{0}&quot; has been disqualified"
        /// </summary>
        public static LocalisableString MailBeatmapsetBeatmapsetStateBeatmapsetDisqualify(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.beatmapset_state.beatmapset_disqualify"), @"""{0}"" has been disqualified", title);

        /// <summary>
        /// "&quot;{0}&quot; was promoted to loved"
        /// </summary>
        public static LocalisableString MailBeatmapsetBeatmapsetStateBeatmapsetLove(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.beatmapset_state.beatmapset_love"), @"""{0}"" was promoted to loved", title);

        /// <summary>
        /// "&quot;{0}&quot; has been nominated"
        /// </summary>
        public static LocalisableString MailBeatmapsetBeatmapsetStateBeatmapsetNominate(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.beatmapset_state.beatmapset_nominate"), @"""{0}"" has been nominated", title);

        /// <summary>
        /// "&quot;{0}&quot; has gained enough nominations and entered the ranking queue"
        /// </summary>
        public static LocalisableString MailBeatmapsetBeatmapsetStateBeatmapsetQualify(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.beatmapset_state.beatmapset_qualify"), @"""{0}"" has gained enough nominations and entered the ranking queue", title);

        /// <summary>
        /// "&quot;{0}&quot; has been ranked"
        /// </summary>
        public static LocalisableString MailBeatmapsetBeatmapsetStateBeatmapsetRank(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.beatmapset_state.beatmapset_rank"), @"""{0}"" has been ranked", title);

        /// <summary>
        /// "&quot;{0}&quot; was removed from Loved"
        /// </summary>
        public static LocalisableString MailBeatmapsetBeatmapsetStateBeatmapsetRemoveFromLoved(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.beatmapset_state.beatmapset_remove_from_loved"), @"""{0}"" was removed from Loved", title);

        /// <summary>
        /// "Nomination of &quot;{0}&quot; has been reset"
        /// </summary>
        public static LocalisableString MailBeatmapsetBeatmapsetStateBeatmapsetResetNominations(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.beatmapset_state.beatmapset_reset_nominations"), @"Nomination of ""{0}"" has been reset", title);

        /// <summary>
        /// "Beatmap &quot;{0}&quot; has new comments"
        /// </summary>
        public static LocalisableString MailBeatmapsetCommentCommentNew(LocalisableString title) => new TranslatableString(getKey(@"mail.beatmapset.comment.comment_new"), @"Beatmap ""{0}"" has new comments", title);

        /// <summary>
        /// "There is a new announcement in &quot;{0}&quot;"
        /// </summary>
        public static LocalisableString MailChannelAnnouncementChannelAnnouncement(LocalisableString name) => new TranslatableString(getKey(@"mail.channel.announcement.channel_announcement"), @"There is a new announcement in ""{0}""", name);

        /// <summary>
        /// "You&#39;ve received a new message from {0}"
        /// </summary>
        public static LocalisableString MailChannelChannelChannelMessage(LocalisableString username) => new TranslatableString(getKey(@"mail.channel.channel.channel_message"), @"You've received a new message from {0}", username);

        /// <summary>
        /// "There is a new message in team &quot;{0}&quot;"
        /// </summary>
        public static LocalisableString MailChannelChannelTeamChannelTeam(LocalisableString name) => new TranslatableString(getKey(@"mail.channel.channel_team.channel_team"), @"There is a new message in team ""{0}""", name);

        /// <summary>
        /// "Changelog &quot;{0}&quot; has new comments"
        /// </summary>
        public static LocalisableString MailBuildCommentCommentNew(LocalisableString title) => new TranslatableString(getKey(@"mail.build.comment.comment_new"), @"Changelog ""{0}"" has new comments", title);

        /// <summary>
        /// "News &quot;{0}&quot; has new comments"
        /// </summary>
        public static LocalisableString MailNewsPostCommentCommentNew(LocalisableString title) => new TranslatableString(getKey(@"mail.news_post.comment.comment_new"), @"News ""{0}"" has new comments", title);

        /// <summary>
        /// "There are new replies in &quot;{0}&quot;"
        /// </summary>
        public static LocalisableString MailForumTopicForumTopicReplyForumTopicReply(LocalisableString title) => new TranslatableString(getKey(@"mail.forum_topic.forum_topic_reply.forum_topic_reply"), @"There are new replies in ""{0}""", title);

        /// <summary>
        /// "You&#39;re now member of team {0}"
        /// </summary>
        public static LocalisableString MailTeamTeamApplicationTeamApplicationAccept(LocalisableString title) => new TranslatableString(getKey(@"mail.team.team_application.team_application_accept"), @"You're now member of team {0}", title);

        /// <summary>
        /// "Your request to join team {0} has been declined"
        /// </summary>
        public static LocalisableString MailTeamTeamApplicationTeamApplicationReject(LocalisableString title) => new TranslatableString(getKey(@"mail.team.team_application.team_application_reject"), @"Your request to join team {0} has been declined", title);

        /// <summary>
        /// "{0} requested to join your team"
        /// </summary>
        public static LocalisableString MailTeamTeamApplicationTeamApplicationStore(LocalisableString title) => new TranslatableString(getKey(@"mail.team.team_application.team_application_store"), @"{0} requested to join your team", title);

        /// <summary>
        /// "{0} has created new beatmaps"
        /// </summary>
        public static LocalisableString MailUserUserBeatmapsetNewUserBeatmapsetNew(LocalisableString username) => new TranslatableString(getKey(@"mail.user.user_beatmapset_new.user_beatmapset_new"), @"{0} has created new beatmaps", username);

        /// <summary>
        /// "{0} has revived beatmaps"
        /// </summary>
        public static LocalisableString MailUserUserBeatmapsetNewUserBeatmapsetRevive(LocalisableString username) => new TranslatableString(getKey(@"mail.user.user_beatmapset_new.user_beatmapset_revive"), @"{0} has revived beatmaps", username);

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}