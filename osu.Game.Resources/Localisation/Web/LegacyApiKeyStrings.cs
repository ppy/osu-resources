// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class LegacyApiKeyStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.LegacyApiKey";

        /// <summary>
        /// "New Legacy API Key"
        /// </summary>
        public static LocalisableString New => new TranslatableString(getKey(@"new"), @"New Legacy API Key");

        /// <summary>
        /// "No key."
        /// </summary>
        public static LocalisableString None => new TranslatableString(getKey(@"none"), @"No key.");

        /// <summary>
        /// "Documentation is available at {0}."
        /// </summary>
        public static LocalisableString DocsDefault(LocalisableString github) => new TranslatableString(getKey(@"docs._"), @"Documentation is available at {0}.", github);

        /// <summary>
        /// "GitHub"
        /// </summary>
        public static LocalisableString DocsGithub => new TranslatableString(getKey(@"docs.github"), @"GitHub");

        /// <summary>
        /// "Create Key"
        /// </summary>
        public static LocalisableString FormCreate => new TranslatableString(getKey(@"form.create"), @"Create Key");

        /// <summary>
        /// "Hide Key"
        /// </summary>
        public static LocalisableString ViewHide => new TranslatableString(getKey(@"view.hide"), @"Hide Key");

        /// <summary>
        /// "Show Key"
        /// </summary>
        public static LocalisableString ViewShow => new TranslatableString(getKey(@"view.show"), @"Show Key");

        /// <summary>
        /// "Delete"
        /// </summary>
        public static LocalisableString ViewDelete => new TranslatableString(getKey(@"view.delete"), @"Delete");

        /// <summary>
        /// "Do not give this out to others."
        /// </summary>
        public static LocalisableString WarningLine1 => new TranslatableString(getKey(@"warning.line1"), @"Do not give this out to others.");

        /// <summary>
        /// "It&#39;s equivalent to giving out your password."
        /// </summary>
        public static LocalisableString WarningLine2 => new TranslatableString(getKey(@"warning.line2"), @"It's equivalent to giving out your password.");

        /// <summary>
        /// "Your account may be compromised."
        /// </summary>
        public static LocalisableString WarningLine3 => new TranslatableString(getKey(@"warning.line3"), @"Your account may be compromised.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}