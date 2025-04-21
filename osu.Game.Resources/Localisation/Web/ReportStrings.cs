// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class ReportStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Report";

        /// <summary>
        /// "Report"
        /// </summary>
        public static LocalisableString BeatmapsetButton => new TranslatableString(getKey(@"beatmapset.button"), @"Report");

        /// <summary>
        /// "Report {0}&#39;s beatmap?"
        /// </summary>
        public static LocalisableString BeatmapsetTitle(LocalisableString username) => new TranslatableString(getKey(@"beatmapset.title"), @"Report {0}'s beatmap?", username);

        /// <summary>
        /// "Report"
        /// </summary>
        public static LocalisableString BeatmapsetDiscussionPostButton => new TranslatableString(getKey(@"beatmapset_discussion_post.button"), @"Report");

        /// <summary>
        /// "Report {0}&#39;s post?"
        /// </summary>
        public static LocalisableString BeatmapsetDiscussionPostTitle(LocalisableString username) => new TranslatableString(getKey(@"beatmapset_discussion_post.title"), @"Report {0}'s post?", username);

        /// <summary>
        /// "Report"
        /// </summary>
        public static LocalisableString CommentButton => new TranslatableString(getKey(@"comment.button"), @"Report");

        /// <summary>
        /// "Report {0}&#39;s comment?"
        /// </summary>
        public static LocalisableString CommentTitle(LocalisableString username) => new TranslatableString(getKey(@"comment.title"), @"Report {0}'s comment?", username);

        /// <summary>
        /// "Report"
        /// </summary>
        public static LocalisableString ForumPostButton => new TranslatableString(getKey(@"forum_post.button"), @"Report");

        /// <summary>
        /// "Report {0}&#39;s post?"
        /// </summary>
        public static LocalisableString ForumPostTitle(LocalisableString username) => new TranslatableString(getKey(@"forum_post.title"), @"Report {0}'s post?", username);

        /// <summary>
        /// "Report Message"
        /// </summary>
        public static LocalisableString MessageButton => new TranslatableString(getKey(@"message.button"), @"Report Message");

        /// <summary>
        /// "Report {0}&#39;s message?"
        /// </summary>
        public static LocalisableString MessageTitle(LocalisableString username) => new TranslatableString(getKey(@"message.title"), @"Report {0}'s message?", username);

        /// <summary>
        /// "Report Score"
        /// </summary>
        public static LocalisableString ScoresButton => new TranslatableString(getKey(@"scores.button"), @"Report Score");

        /// <summary>
        /// "Report {0}&#39;s score?"
        /// </summary>
        public static LocalisableString ScoresTitle(LocalisableString username) => new TranslatableString(getKey(@"scores.title"), @"Report {0}'s score?", username);

        /// <summary>
        /// "Report Team"
        /// </summary>
        public static LocalisableString TeamButton => new TranslatableString(getKey(@"team.button"), @"Report Team");

        /// <summary>
        /// "Report {0}&#39;s team?"
        /// </summary>
        public static LocalisableString TeamTitle(LocalisableString username) => new TranslatableString(getKey(@"team.title"), @"Report {0}'s team?", username);

        /// <summary>
        /// "Report"
        /// </summary>
        public static LocalisableString UserButton => new TranslatableString(getKey(@"user.button"), @"Report");

        /// <summary>
        /// "Report {0}?"
        /// </summary>
        public static LocalisableString UserTitle(LocalisableString username) => new TranslatableString(getKey(@"user.title"), @"Report {0}?", username);

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}