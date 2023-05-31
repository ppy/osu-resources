// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class LegacyIrcKeyStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.LegacyIrcKey";

        /// <summary>
        /// "Create new IRC password?"
        /// </summary>
        public static LocalisableString ConfirmNew => new TranslatableString(getKey(@"confirm_new"), @"Create new IRC password?");

        /// <summary>
        /// "New Legacy IRC Password"
        /// </summary>
        public static LocalisableString New => new TranslatableString(getKey(@"new"), @"New Legacy IRC Password");

        /// <summary>
        /// "IRC Password not set."
        /// </summary>
        public static LocalisableString None => new TranslatableString(getKey(@"none"), @"IRC Password not set.");

        /// <summary>
        /// "server"
        /// </summary>
        public static LocalisableString FormServerHost => new TranslatableString(getKey(@"form.server_host"), @"server");

        /// <summary>
        /// "port"
        /// </summary>
        public static LocalisableString FormServerPort => new TranslatableString(getKey(@"form.server_port"), @"port");

        /// <summary>
        /// "server password"
        /// </summary>
        public static LocalisableString FormToken => new TranslatableString(getKey(@"form.token"), @"server password");

        /// <summary>
        /// "username"
        /// </summary>
        public static LocalisableString FormUsername => new TranslatableString(getKey(@"form.username"), @"username");

        /// <summary>
        /// "Hide Password"
        /// </summary>
        public static LocalisableString ViewHide => new TranslatableString(getKey(@"view.hide"), @"Hide Password");

        /// <summary>
        /// "Show Password"
        /// </summary>
        public static LocalisableString ViewShow => new TranslatableString(getKey(@"view.show"), @"Show Password");

        /// <summary>
        /// "Delete"
        /// </summary>
        public static LocalisableString ViewDelete => new TranslatableString(getKey(@"view.delete"), @"Delete");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}