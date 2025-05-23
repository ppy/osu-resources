﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class AdminStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Admin";

        /// <summary>
        /// "Regenerate"
        /// </summary>
        public static LocalisableString BeatmapsetsCoversRegenerate => new TranslatableString(getKey(@"beatmapsets.covers.regenerate"), @"Regenerate");

        /// <summary>
        /// "Regenerating..."
        /// </summary>
        public static LocalisableString BeatmapsetsCoversRegenerating => new TranslatableString(getKey(@"beatmapsets.covers.regenerating"), @"Regenerating...");

        /// <summary>
        /// "Remove"
        /// </summary>
        public static LocalisableString BeatmapsetsCoversRemove => new TranslatableString(getKey(@"beatmapsets.covers.remove"), @"Remove");

        /// <summary>
        /// "Removing..."
        /// </summary>
        public static LocalisableString BeatmapsetsCoversRemoving => new TranslatableString(getKey(@"beatmapsets.covers.removing"), @"Removing...");

        /// <summary>
        /// "Beatmap covers"
        /// </summary>
        public static LocalisableString BeatmapsetsCoversTitle => new TranslatableString(getKey(@"beatmapsets.covers.title"), @"Beatmap covers");

        /// <summary>
        /// "Manage Beatmap Covers"
        /// </summary>
        public static LocalisableString BeatmapsetsShowCovers => new TranslatableString(getKey(@"beatmapsets.show.covers"), @"Manage Beatmap Covers");

        /// <summary>
        /// "Delete"
        /// </summary>
        public static LocalisableString ForumForumCoversIndexDelete => new TranslatableString(getKey(@"forum.forum-covers.index.delete"), @"Delete");

        /// <summary>
        /// "Forum #{0}: {1}"
        /// </summary>
        public static LocalisableString ForumForumCoversIndexForumName(LocalisableString id, LocalisableString name) => new TranslatableString(getKey(@"forum.forum-covers.index.forum-name"), @"Forum #{0}: {1}", id, name);

        /// <summary>
        /// "No cover set"
        /// </summary>
        public static LocalisableString ForumForumCoversIndexNoCover => new TranslatableString(getKey(@"forum.forum-covers.index.no-cover"), @"No cover set");

        /// <summary>
        /// "Save"
        /// </summary>
        public static LocalisableString ForumForumCoversIndexSubmitSave => new TranslatableString(getKey(@"forum.forum-covers.index.submit.save"), @"Save");

        /// <summary>
        /// "Update"
        /// </summary>
        public static LocalisableString ForumForumCoversIndexSubmitUpdate => new TranslatableString(getKey(@"forum.forum-covers.index.submit.update"), @"Update");

        /// <summary>
        /// "Forum Covers List"
        /// </summary>
        public static LocalisableString ForumForumCoversIndexTitle => new TranslatableString(getKey(@"forum.forum-covers.index.title"), @"Forum Covers List");

        /// <summary>
        /// "Default Topic Cover"
        /// </summary>
        public static LocalisableString ForumForumCoversIndexTypeTitleDefaultTopic => new TranslatableString(getKey(@"forum.forum-covers.index.type-title.default-topic"), @"Default Topic Cover");

        /// <summary>
        /// "Forum Cover"
        /// </summary>
        public static LocalisableString ForumForumCoversIndexTypeTitleMain => new TranslatableString(getKey(@"forum.forum-covers.index.type-title.main"), @"Forum Cover");

        /// <summary>
        /// "Log Viewer"
        /// </summary>
        public static LocalisableString LogsIndexTitle => new TranslatableString(getKey(@"logs.index.title"), @"Log Viewer");

        /// <summary>
        /// "Beatmaps"
        /// </summary>
        public static LocalisableString PagesRootSectionsBeatmapsets => new TranslatableString(getKey(@"pages.root.sections.beatmapsets"), @"Beatmaps");

        /// <summary>
        /// "Forum"
        /// </summary>
        public static LocalisableString PagesRootSectionsForum => new TranslatableString(getKey(@"pages.root.sections.forum"), @"Forum");

        /// <summary>
        /// "General"
        /// </summary>
        public static LocalisableString PagesRootSectionsGeneral => new TranslatableString(getKey(@"pages.root.sections.general"), @"General");

        /// <summary>
        /// "User"
        /// </summary>
        public static LocalisableString PagesRootSectionsUsersHeader => new TranslatableString(getKey(@"pages.root.sections.users.header"), @"User");

        /// <summary>
        /// "Profile Cover Presets"
        /// </summary>
        public static LocalisableString PagesRootSectionsUsersCoverPresets => new TranslatableString(getKey(@"pages.root.sections.users.cover_presets"), @"Profile Cover Presets");

        /// <summary>
        /// "This user is currently restricted."
        /// </summary>
        public static LocalisableString UsersRestrictedBannerTitle => new TranslatableString(getKey(@"users.restricted_banner.title"), @"This user is currently restricted.");

        /// <summary>
        /// "(only admins can see this)"
        /// </summary>
        public static LocalisableString UsersRestrictedBannerMessage => new TranslatableString(getKey(@"users.restricted_banner.message"), @"(only admins can see this)");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}