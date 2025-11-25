// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class GroupHistoryStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.GroupHistory";

        /// <summary>
        /// "No group history found!"
        /// </summary>
        public static LocalisableString None => new TranslatableString(getKey(@"none"), @"No group history found!");

        /// <summary>
        /// "View group history"
        /// </summary>
        public static LocalisableString View => new TranslatableString(getKey(@"view"), @"View group history");

        /// <summary>
        /// "by {0}"
        /// </summary>
        public static LocalisableString EventActor(LocalisableString user) => new TranslatableString(getKey(@"event.actor"), @"by {0}", user);

        /// <summary>
        /// "{0} created."
        /// </summary>
        public static LocalisableString EventMessageGroupAdd(LocalisableString group) => new TranslatableString(getKey(@"event.message.group_add"), @"{0} created.", group);

        /// <summary>
        /// "{0} deleted."
        /// </summary>
        public static LocalisableString EventMessageGroupRemove(LocalisableString group) => new TranslatableString(getKey(@"event.message.group_remove"), @"{0} deleted.", group);

        /// <summary>
        /// "{0} renamed to {1}."
        /// </summary>
        public static LocalisableString EventMessageGroupRename(LocalisableString previousGroup, LocalisableString group) => new TranslatableString(getKey(@"event.message.group_rename"), @"{0} renamed to {1}.", previousGroup, group);

        /// <summary>
        /// "{0} added to {1}."
        /// </summary>
        public static LocalisableString EventMessageUserAdd(LocalisableString user, LocalisableString group) => new TranslatableString(getKey(@"event.message.user_add"), @"{0} added to {1}.", user, group);

        /// <summary>
        /// "{0} added to {1} for {2}."
        /// </summary>
        public static LocalisableString EventMessageUserAddWithPlaymodes(LocalisableString user, LocalisableString group, LocalisableString rulesets) => new TranslatableString(getKey(@"event.message.user_add_with_playmodes"), @"{0} added to {1} for {2}.", user, group, rulesets);

        /// <summary>
        /// "{0} added to {1}&#39;s {2} membership."
        /// </summary>
        public static LocalisableString EventMessageUserAddPlaymodes(LocalisableString rulesets, LocalisableString user, LocalisableString group) => new TranslatableString(getKey(@"event.message.user_add_playmodes"), @"{0} added to {1}'s {2} membership.", rulesets, user, group);

        /// <summary>
        /// "{0} removed from {1}."
        /// </summary>
        public static LocalisableString EventMessageUserRemove(LocalisableString user, LocalisableString group) => new TranslatableString(getKey(@"event.message.user_remove"), @"{0} removed from {1}.", user, group);

        /// <summary>
        /// "{0} removed from {1}&#39;s {2} membership."
        /// </summary>
        public static LocalisableString EventMessageUserRemovePlaymodes(LocalisableString rulesets, LocalisableString user, LocalisableString group) => new TranslatableString(getKey(@"event.message.user_remove_playmodes"), @"{0} removed from {1}'s {2} membership.", rulesets, user, group);

        /// <summary>
        /// "{0}&#39;s default group set to {1}."
        /// </summary>
        public static LocalisableString EventMessageUserSetDefault(LocalisableString user, LocalisableString group) => new TranslatableString(getKey(@"event.message.user_set_default"), @"{0}'s default group set to {1}.", user, group);

        /// <summary>
        /// "Group"
        /// </summary>
        public static LocalisableString FormGroup => new TranslatableString(getKey(@"form.group"), @"Group");

        /// <summary>
        /// "All groups"
        /// </summary>
        public static LocalisableString FormGroupAll => new TranslatableString(getKey(@"form.group_all"), @"All groups");

        /// <summary>
        /// "To"
        /// </summary>
        public static LocalisableString FormMaxDate => new TranslatableString(getKey(@"form.max_date"), @"To");

        /// <summary>
        /// "From"
        /// </summary>
        public static LocalisableString FormMinDate => new TranslatableString(getKey(@"form.min_date"), @"From");

        /// <summary>
        /// "User"
        /// </summary>
        public static LocalisableString FormUser => new TranslatableString(getKey(@"form.user"), @"User");

        /// <summary>
        /// "Username or ID"
        /// </summary>
        public static LocalisableString FormUserPrompt => new TranslatableString(getKey(@"form.user_prompt"), @"Username or ID");

        /// <summary>
        /// "Older group history can be found in {0}."
        /// </summary>
        public static LocalisableString StaffLogDefault(LocalisableString wikiArticles) => new TranslatableString(getKey(@"staff_log._"), @"Older group history can be found in {0}.", wikiArticles);

        /// <summary>
        /// "the staff log wiki articles"
        /// </summary>
        public static LocalisableString StaffLogWikiArticles => new TranslatableString(getKey(@"staff_log.wiki_articles"), @"the staff log wiki articles");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}