// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class EventsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Events";

        /// <summary>
        /// "{0} unlocked the &quot;{1}&quot; medal!"
        /// </summary>
        public static LocalisableString Achievement(LocalisableString user, LocalisableString achievement) => new TranslatableString(getKey(@"achievement"), @"{0} unlocked the ""{1}"" medal!", user, achievement);

        /// <summary>
        /// "{0} has been played {1} times!"
        /// </summary>
        public static LocalisableString BeatmapPlaycount(LocalisableString beatmap, LocalisableString count) => new TranslatableString(getKey(@"beatmap_playcount"), @"{0} has been played {1} times!", beatmap, count);

        /// <summary>
        /// "{0} by {1} has been {2}!"
        /// </summary>
        public static LocalisableString BeatmapsetApprove(LocalisableString beatmapset, LocalisableString user, LocalisableString approval) => new TranslatableString(getKey(@"beatmapset_approve"), @"{0} by {1} has been {2}!", beatmapset, user, approval);

        /// <summary>
        /// "{0} has been deleted."
        /// </summary>
        public static LocalisableString BeatmapsetDelete(LocalisableString beatmapset) => new TranslatableString(getKey(@"beatmapset_delete"), @"{0} has been deleted.", beatmapset);

        /// <summary>
        /// "{0} has been revived from eternal slumber by {1}."
        /// </summary>
        public static LocalisableString BeatmapsetRevive(LocalisableString beatmapset, LocalisableString user) => new TranslatableString(getKey(@"beatmapset_revive"), @"{0} has been revived from eternal slumber by {1}.", beatmapset, user);

        /// <summary>
        /// "{0} has updated the beatmap &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString BeatmapsetUpdate(LocalisableString user, LocalisableString beatmapset) => new TranslatableString(getKey(@"beatmapset_update"), @"{0} has updated the beatmap ""{1}""", user, beatmapset);

        /// <summary>
        /// "{0} has submitted a new beatmap &quot;{1}&quot;"
        /// </summary>
        public static LocalisableString BeatmapsetUpload(LocalisableString user, LocalisableString beatmapset) => new TranslatableString(getKey(@"beatmapset_upload"), @"{0} has submitted a new beatmap ""{1}""", user, beatmapset);

        /// <summary>
        /// "This user hasn&#39;t done anything notable recently!"
        /// </summary>
        public static LocalisableString Empty => new TranslatableString(getKey(@"empty"), @"This user hasn't done anything notable recently!");

        /// <summary>
        /// "{0} achieved {1} on {2} ({3})"
        /// </summary>
        public static LocalisableString Rank(LocalisableString user, LocalisableString rank, LocalisableString beatmap, LocalisableString mode) => new TranslatableString(getKey(@"rank"), @"{0} achieved {1} on {2} ({3})", user, rank, beatmap, mode);

        /// <summary>
        /// "{0} has lost first place on {1} ({2})"
        /// </summary>
        public static LocalisableString RankLost(LocalisableString user, LocalisableString beatmap, LocalisableString mode) => new TranslatableString(getKey(@"rank_lost"), @"{0} has lost first place on {1} ({2})", user, beatmap, mode);

        /// <summary>
        /// "{0} has once again chosen to support osu! - thanks for your generosity!"
        /// </summary>
        public static LocalisableString UserSupportAgain(LocalisableString user) => new TranslatableString(getKey(@"user_support_again"), @"{0} has once again chosen to support osu! - thanks for your generosity!", user);

        /// <summary>
        /// "{0} has supported osu! - thanks for your generosity!"
        /// </summary>
        public static LocalisableString UserSupportFirst(LocalisableString user) => new TranslatableString(getKey(@"user_support_first"), @"{0} has supported osu! - thanks for your generosity!", user);

        /// <summary>
        /// "{0} has received the gift of osu!supporter!"
        /// </summary>
        public static LocalisableString UserSupportGift(LocalisableString user) => new TranslatableString(getKey(@"user_support_gift"), @"{0} has received the gift of osu!supporter!", user);

        /// <summary>
        /// "{0} has changed their username to {1}!"
        /// </summary>
        public static LocalisableString UsernameChange(LocalisableString previousUsername, LocalisableString user) => new TranslatableString(getKey(@"username_change"), @"{0} has changed their username to {1}!", previousUsername, user);

        /// <summary>
        /// "approved"
        /// </summary>
        public static LocalisableString BeatmapsetStatusApproved => new TranslatableString(getKey(@"beatmapset_status.approved"), @"approved");

        /// <summary>
        /// "loved"
        /// </summary>
        public static LocalisableString BeatmapsetStatusLoved => new TranslatableString(getKey(@"beatmapset_status.loved"), @"loved");

        /// <summary>
        /// "qualified"
        /// </summary>
        public static LocalisableString BeatmapsetStatusQualified => new TranslatableString(getKey(@"beatmapset_status.qualified"), @"qualified");

        /// <summary>
        /// "ranked"
        /// </summary>
        public static LocalisableString BeatmapsetStatusRanked => new TranslatableString(getKey(@"beatmapset_status.ranked"), @"ranked");

        /// <summary>
        /// "rank #{0}"
        /// </summary>
        public static LocalisableString ValueRank(LocalisableString rank) => new TranslatableString(getKey(@"value.rank"), @"rank #{0}", rank);

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}