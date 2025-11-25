// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class ApiStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Api";

        /// <summary>
        /// "Cannot send blank message."
        /// </summary>
        public static LocalisableString ErrorChatEmpty => new TranslatableString(getKey(@"error.chat.empty"), @"Cannot send blank message.");

        /// <summary>
        /// "You are sending messages too quickly, please wait a bit before trying again."
        /// </summary>
        public static LocalisableString ErrorChatLimitExceeded => new TranslatableString(getKey(@"error.chat.limit_exceeded"), @"You are sending messages too quickly, please wait a bit before trying again.");

        /// <summary>
        /// "The message you are trying to send is too long."
        /// </summary>
        public static LocalisableString ErrorChatTooLong => new TranslatableString(getKey(@"error.chat.too_long"), @"The message you are trying to send is too long.");

        /// <summary>
        /// "Act as a chat bot."
        /// </summary>
        public static LocalisableString ScopesBot => new TranslatableString(getKey(@"scopes.bot"), @"Act as a chat bot.");

        /// <summary>
        /// "Identify you and read your public profile."
        /// </summary>
        public static LocalisableString ScopesIdentify => new TranslatableString(getKey(@"scopes.identify"), @"Identify you and read your public profile.");

        /// <summary>
        /// "Read messages on your behalf."
        /// </summary>
        public static LocalisableString ScopesChatRead => new TranslatableString(getKey(@"scopes.chat.read"), @"Read messages on your behalf.");

        /// <summary>
        /// "Send messages on your behalf."
        /// </summary>
        public static LocalisableString ScopesChatWrite => new TranslatableString(getKey(@"scopes.chat.write"), @"Send messages on your behalf.");

        /// <summary>
        /// "Join and leave channels on your behalf."
        /// </summary>
        public static LocalisableString ScopesChatWriteManage => new TranslatableString(getKey(@"scopes.chat.write_manage"), @"Join and leave channels on your behalf.");

        /// <summary>
        /// "Create and edit forum topics and posts on your behalf."
        /// </summary>
        public static LocalisableString ScopesForumWrite => new TranslatableString(getKey(@"scopes.forum.write"), @"Create and edit forum topics and posts on your behalf.");

        /// <summary>
        /// "Manage forum topics and posts on your behalf."
        /// </summary>
        public static LocalisableString ScopesForumWriteManage => new TranslatableString(getKey(@"scopes.forum.write_manage"), @"Manage forum topics and posts on your behalf.");

        /// <summary>
        /// "See who you are following."
        /// </summary>
        public static LocalisableString ScopesFriendsRead => new TranslatableString(getKey(@"scopes.friends.read"), @"See who you are following.");

        /// <summary>
        /// "Read public data on your behalf."
        /// </summary>
        public static LocalisableString ScopesPublic => new TranslatableString(getKey(@"scopes.public"), @"Read public data on your behalf.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}