// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class TeamsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Teams";

        /// <summary>
        /// "Added user to team."
        /// </summary>
        public static LocalisableString ApplicationsAcceptOk => new TranslatableString(getKey(@"applications.accept.ok"), @"Added user to team.");

        /// <summary>
        /// "Cancelled join request."
        /// </summary>
        public static LocalisableString ApplicationsDestroyOk => new TranslatableString(getKey(@"applications.destroy.ok"), @"Cancelled join request.");

        /// <summary>
        /// "Rejected join request."
        /// </summary>
        public static LocalisableString ApplicationsRejectOk => new TranslatableString(getKey(@"applications.reject.ok"), @"Rejected join request.");

        /// <summary>
        /// "Requested to join team."
        /// </summary>
        public static LocalisableString ApplicationsStoreOk => new TranslatableString(getKey(@"applications.store.ok"), @"Requested to join team.");

        /// <summary>
        /// "Create Team"
        /// </summary>
        public static LocalisableString CreateSubmit => new TranslatableString(getKey(@"create.submit"), @"Create Team");

        /// <summary>
        /// "Your team name. The name is permanent at the moment."
        /// </summary>
        public static LocalisableString CreateFormNameHelp => new TranslatableString(getKey(@"create.form.name_help"), @"Your team name. The name is permanent at the moment.");

        /// <summary>
        /// "Maximum 4 characters."
        /// </summary>
        public static LocalisableString CreateFormShortNameHelp => new TranslatableString(getKey(@"create.form.short_name_help"), @"Maximum 4 characters.");

        /// <summary>
        /// "Let&#39;s set up a new team"
        /// </summary>
        public static LocalisableString CreateFormTitle => new TranslatableString(getKey(@"create.form.title"), @"Let's set up a new team");

        /// <summary>
        /// "Play together with friends; existing or new. You&#39;re not currently in a team. Join an existing team by visiting their team page or create your own team from this page."
        /// </summary>
        public static LocalisableString CreateIntroDescription => new TranslatableString(getKey(@"create.intro.description"), @"Play together with friends; existing or new. You're not currently in a team. Join an existing team by visiting their team page or create your own team from this page.");

        /// <summary>
        /// "Team!"
        /// </summary>
        public static LocalisableString CreateIntroTitle => new TranslatableString(getKey(@"create.intro.title"), @"Team!");

        /// <summary>
        /// "Team removed."
        /// </summary>
        public static LocalisableString DestroyOk => new TranslatableString(getKey(@"destroy.ok"), @"Team removed.");

        /// <summary>
        /// "Settings saved successfully."
        /// </summary>
        public static LocalisableString EditOk => new TranslatableString(getKey(@"edit.ok"), @"Settings saved successfully.");

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
        /// "Team Flag"
        /// </summary>
        public static LocalisableString EditFlagLabel => new TranslatableString(getKey(@"edit.flag.label"), @"Team Flag");

        /// <summary>
        /// "Set Team Flag"
        /// </summary>
        public static LocalisableString EditFlagTitle => new TranslatableString(getKey(@"edit.flag.title"), @"Set Team Flag");

        /// <summary>
        /// "Header Image"
        /// </summary>
        public static LocalisableString EditHeaderLabel => new TranslatableString(getKey(@"edit.header.label"), @"Header Image");

        /// <summary>
        /// "Set Header Image"
        /// </summary>
        public static LocalisableString EditHeaderTitle => new TranslatableString(getKey(@"edit.header.title"), @"Set Header Image");

        /// <summary>
        /// "Whether to allow people to apply for the team"
        /// </summary>
        public static LocalisableString EditSettingsApplicationHelp => new TranslatableString(getKey(@"edit.settings.application_help"), @"Whether to allow people to apply for the team");

        /// <summary>
        /// "The ruleset to be selected by default when visiting the team page"
        /// </summary>
        public static LocalisableString EditSettingsDefaultRulesetHelp => new TranslatableString(getKey(@"edit.settings.default_ruleset_help"), @"The ruleset to be selected by default when visiting the team page");

        /// <summary>
        /// "Maximum size of {0}&#215;{1}"
        /// </summary>
        public static LocalisableString EditSettingsFlagHelp(LocalisableString width, LocalisableString height) => new TranslatableString(getKey(@"edit.settings.flag_help"), @"Maximum size of {0}×{1}", width, height);

        /// <summary>
        /// "Maximum size of {0}&#215;{1}"
        /// </summary>
        public static LocalisableString EditSettingsHeaderHelp(LocalisableString width, LocalisableString height) => new TranslatableString(getKey(@"edit.settings.header_help"), @"Maximum size of {0}×{1}", width, height);

        /// <summary>
        /// "Team Settings"
        /// </summary>
        public static LocalisableString EditSettingsTitle => new TranslatableString(getKey(@"edit.settings.title"), @"Team Settings");

        /// <summary>
        /// "Closed"
        /// </summary>
        public static LocalisableString EditSettingsApplicationStateState0 => new TranslatableString(getKey(@"edit.settings.application_state.state_0"), @"Closed");

        /// <summary>
        /// "Open"
        /// </summary>
        public static LocalisableString EditSettingsApplicationStateState1 => new TranslatableString(getKey(@"edit.settings.application_state.state_1"), @"Open");

        /// <summary>
        /// "settings"
        /// </summary>
        public static LocalisableString HeaderLinksEdit => new TranslatableString(getKey(@"header_links.edit"), @"settings");

        /// <summary>
        /// "leaderboard"
        /// </summary>
        public static LocalisableString HeaderLinksLeaderboard => new TranslatableString(getKey(@"header_links.leaderboard"), @"leaderboard");

        /// <summary>
        /// "info"
        /// </summary>
        public static LocalisableString HeaderLinksShow => new TranslatableString(getKey(@"header_links.show"), @"info");

        /// <summary>
        /// "manage members"
        /// </summary>
        public static LocalisableString HeaderLinksMembersIndex => new TranslatableString(getKey(@"header_links.members.index"), @"manage members");

        /// <summary>
        /// "Global Rank"
        /// </summary>
        public static LocalisableString LeaderboardGlobalRank => new TranslatableString(getKey(@"leaderboard.global_rank"), @"Global Rank");

        /// <summary>
        /// "Team member removed"
        /// </summary>
        public static LocalisableString MembersDestroySuccess => new TranslatableString(getKey(@"members.destroy.success"), @"Team member removed");

        /// <summary>
        /// "Manage Members"
        /// </summary>
        public static LocalisableString MembersIndexTitle => new TranslatableString(getKey(@"members.index.title"), @"Manage Members");

        /// <summary>
        /// "No join requests at the moment."
        /// </summary>
        public static LocalisableString MembersIndexApplicationsEmpty => new TranslatableString(getKey(@"members.index.applications.empty"), @"No join requests at the moment.");

        /// <summary>
        /// "Available slots"
        /// </summary>
        public static LocalisableString MembersIndexApplicationsEmptySlots => new TranslatableString(getKey(@"members.index.applications.empty_slots"), @"Available slots");

        /// <summary>
        /// "Join Requests"
        /// </summary>
        public static LocalisableString MembersIndexApplicationsTitle => new TranslatableString(getKey(@"members.index.applications.title"), @"Join Requests");

        /// <summary>
        /// "Requested At"
        /// </summary>
        public static LocalisableString MembersIndexApplicationsCreatedAt => new TranslatableString(getKey(@"members.index.applications.created_at"), @"Requested At");

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
        /// "Left the team ;_;"
        /// </summary>
        public static LocalisableString PartOk => new TranslatableString(getKey(@"part.ok"), @"Left the team ;_;");

        /// <summary>
        /// "Team Chat"
        /// </summary>
        public static LocalisableString ShowBarChat => new TranslatableString(getKey(@"show.bar.chat"), @"Team Chat");

        /// <summary>
        /// "Disband Team"
        /// </summary>
        public static LocalisableString ShowBarDestroy => new TranslatableString(getKey(@"show.bar.destroy"), @"Disband Team");

        /// <summary>
        /// "Request Join"
        /// </summary>
        public static LocalisableString ShowBarJoin => new TranslatableString(getKey(@"show.bar.join"), @"Request Join");

        /// <summary>
        /// "Cancel Join"
        /// </summary>
        public static LocalisableString ShowBarJoinCancel => new TranslatableString(getKey(@"show.bar.join_cancel"), @"Cancel Join");

        /// <summary>
        /// "Leave Team"
        /// </summary>
        public static LocalisableString ShowBarPart => new TranslatableString(getKey(@"show.bar.part"), @"Leave Team");

        /// <summary>
        /// "Formed"
        /// </summary>
        public static LocalisableString ShowInfoCreated => new TranslatableString(getKey(@"show.info.created"), @"Formed");

        /// <summary>
        /// "Team Members"
        /// </summary>
        public static LocalisableString ShowMembersMembers => new TranslatableString(getKey(@"show.members.members"), @"Team Members");

        /// <summary>
        /// "Team Leader"
        /// </summary>
        public static LocalisableString ShowMembersOwner => new TranslatableString(getKey(@"show.members.owner"), @"Team Leader");

        /// <summary>
        /// "About Us!"
        /// </summary>
        public static LocalisableString ShowSectionsAbout => new TranslatableString(getKey(@"show.sections.about"), @"About Us!");

        /// <summary>
        /// "Info"
        /// </summary>
        public static LocalisableString ShowSectionsInfo => new TranslatableString(getKey(@"show.sections.info"), @"Info");

        /// <summary>
        /// "Members"
        /// </summary>
        public static LocalisableString ShowSectionsMembers => new TranslatableString(getKey(@"show.sections.members"), @"Members");

        /// <summary>
        /// "Rank"
        /// </summary>
        public static LocalisableString ShowStatisticsRank => new TranslatableString(getKey(@"show.statistics.rank"), @"Rank");

        /// <summary>
        /// "Team Leader"
        /// </summary>
        public static LocalisableString ShowStatisticsLeader => new TranslatableString(getKey(@"show.statistics.leader"), @"Team Leader");

        /// <summary>
        /// "Team created."
        /// </summary>
        public static LocalisableString StoreOk => new TranslatableString(getKey(@"store.ok"), @"Team created.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}