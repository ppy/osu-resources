// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class TeamsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Teams";

        /// <summary>
        /// "Settings saved successfully"
        /// </summary>
        public static LocalisableString EditSaved => new TranslatableString(getKey(@"edit.saved"), @"Settings saved successfully");

        /// <summary>
        /// "Team Settings"
        /// </summary>
        public static LocalisableString EditTitle => new TranslatableString(getKey(@"edit.title"), @"Team Settings");

        /// <summary>
        /// "Description"
        /// </summary>
        public static LocalisableString EditDescriptionLabel => new TranslatableString(getKey(@"edit.description.label"), @"Description");

        /// <summary>
        /// "Team Description"
        /// </summary>
        public static LocalisableString EditDescriptionTitle => new TranslatableString(getKey(@"edit.description.title"), @"Team Description");

        /// <summary>
        /// "Header Image"
        /// </summary>
        public static LocalisableString EditHeaderLabel => new TranslatableString(getKey(@"edit.header.label"), @"Header Image");

        /// <summary>
        /// "Set Header Image"
        /// </summary>
        public static LocalisableString EditHeaderTitle => new TranslatableString(getKey(@"edit.header.title"), @"Set Header Image");

        /// <summary>
        /// "Team Flag"
        /// </summary>
        public static LocalisableString EditLogoLabel => new TranslatableString(getKey(@"edit.logo.label"), @"Team Flag");

        /// <summary>
        /// "Set Team Flag"
        /// </summary>
        public static LocalisableString EditLogoTitle => new TranslatableString(getKey(@"edit.logo.title"), @"Set Team Flag");

        /// <summary>
        /// "Team Application"
        /// </summary>
        public static LocalisableString EditSettingsApplication => new TranslatableString(getKey(@"edit.settings.application"), @"Team Application");

        /// <summary>
        /// "Whether to allow people to apply for the team"
        /// </summary>
        public static LocalisableString EditSettingsApplicationHelp => new TranslatableString(getKey(@"edit.settings.application_help"), @"Whether to allow people to apply for the team");

        /// <summary>
        /// "Default Ruleset"
        /// </summary>
        public static LocalisableString EditSettingsDefaultRuleset => new TranslatableString(getKey(@"edit.settings.default_ruleset"), @"Default Ruleset");

        /// <summary>
        /// "The ruleset to be selected by default when visiting the team page"
        /// </summary>
        public static LocalisableString EditSettingsDefaultRulesetHelp => new TranslatableString(getKey(@"edit.settings.default_ruleset_help"), @"The ruleset to be selected by default when visiting the team page");

        /// <summary>
        /// "Team Settings"
        /// </summary>
        public static LocalisableString EditSettingsTitle => new TranslatableString(getKey(@"edit.settings.title"), @"Team Settings");

        /// <summary>
        /// "URL"
        /// </summary>
        public static LocalisableString EditSettingsUrl => new TranslatableString(getKey(@"edit.settings.url"), @"URL");

        /// <summary>
        /// "Closed"
        /// </summary>
        public static LocalisableString EditSettingsApplicationStateState0 => new TranslatableString(getKey(@"edit.settings.application_state.state_0"), @"Closed");

        /// <summary>
        /// "Open"
        /// </summary>
        public static LocalisableString EditSettingsApplicationStateState1 => new TranslatableString(getKey(@"edit.settings.application_state.state_1"), @"Open");

        /// <summary>
        /// "Team member removed"
        /// </summary>
        public static LocalisableString MembersDestroySuccess => new TranslatableString(getKey(@"members.destroy.success"), @"Team member removed");

        /// <summary>
        /// "Manage Members"
        /// </summary>
        public static LocalisableString MembersIndexTitle => new TranslatableString(getKey(@"members.index.title"), @"Manage Members");

        /// <summary>
        /// "Status"
        /// </summary>
        public static LocalisableString MembersIndexTableStatus => new TranslatableString(getKey(@"members.index.table.status"), @"Status");

        /// <summary>
        /// "Join Date"
        /// </summary>
        public static LocalisableString MembersIndexTableJoinedAt => new TranslatableString(getKey(@"members.index.table.joined_at"), @"Join Date");

        /// <summary>
        /// "Remove"
        /// </summary>
        public static LocalisableString MembersIndexTableRemove => new TranslatableString(getKey(@"members.index.table.remove"), @"Remove");

        /// <summary>
        /// "Current Members"
        /// </summary>
        public static LocalisableString MembersIndexTableTitle => new TranslatableString(getKey(@"members.index.table.title"), @"Current Members");

        /// <summary>
        /// "Inactive"
        /// </summary>
        public static LocalisableString MembersIndexStatusStatus0 => new TranslatableString(getKey(@"members.index.status.status_0"), @"Inactive");

        /// <summary>
        /// "Active"
        /// </summary>
        public static LocalisableString MembersIndexStatusStatus1 => new TranslatableString(getKey(@"members.index.status.status_1"), @"Active");

        /// <summary>
        /// "Settings"
        /// </summary>
        public static LocalisableString ShowBarSettings => new TranslatableString(getKey(@"show.bar.settings"), @"Settings");

        /// <summary>
        /// "Formed"
        /// </summary>
        public static LocalisableString ShowInfoCreated => new TranslatableString(getKey(@"show.info.created"), @"Formed");

        /// <summary>
        /// "Website"
        /// </summary>
        public static LocalisableString ShowInfoWebsite => new TranslatableString(getKey(@"show.info.website"), @"Website");

        /// <summary>
        /// "Team Members"
        /// </summary>
        public static LocalisableString ShowMembersMembers => new TranslatableString(getKey(@"show.members.members"), @"Team Members");

        /// <summary>
        /// "Team Leader"
        /// </summary>
        public static LocalisableString ShowMembersOwner => new TranslatableString(getKey(@"show.members.owner"), @"Team Leader");

        /// <summary>
        /// "Members"
        /// </summary>
        public static LocalisableString ShowSectionsMembers => new TranslatableString(getKey(@"show.sections.members"), @"Members");

        /// <summary>
        /// "Info"
        /// </summary>
        public static LocalisableString ShowSectionsInfo => new TranslatableString(getKey(@"show.sections.info"), @"Info");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}