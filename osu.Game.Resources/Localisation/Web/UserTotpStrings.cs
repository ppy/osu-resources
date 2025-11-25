// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class UserTotpStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.UserTotp";

        /// <summary>
        /// "Finish"
        /// </summary>
        public static LocalisableString CreateFinish => new TranslatableString(getKey(@"create.finish"), @"Finish");

        /// <summary>
        /// "Scan the QR code with the authenticator app and enter the verification key"
        /// </summary>
        public static LocalisableString CreateKey => new TranslatableString(getKey(@"create.key"), @"Scan the QR code with the authenticator app and enter the verification key");

        /// <summary>
        /// "Or click this link to copy the key for the authenticator app"
        /// </summary>
        public static LocalisableString CreateKeyCopy => new TranslatableString(getKey(@"create.key_copy"), @"Or click this link to copy the key for the authenticator app");

        /// <summary>
        /// "Use this link if you&#39;re using mobile phone"
        /// </summary>
        public static LocalisableString CreateKeyLink => new TranslatableString(getKey(@"create.key_link"), @"Use this link if you're using mobile phone");

        /// <summary>
        /// "To set up authenticator app verification, please enter your current password"
        /// </summary>
        public static LocalisableString CreatePassword => new TranslatableString(getKey(@"create.password"), @"To set up authenticator app verification, please enter your current password");

        /// <summary>
        /// "Continue"
        /// </summary>
        public static LocalisableString CreateStart => new TranslatableString(getKey(@"create.start"), @"Continue");

        /// <summary>
        /// "You don&#39;t have authenticator app verification set up."
        /// </summary>
        public static LocalisableString DestroyMissing => new TranslatableString(getKey(@"destroy.missing"), @"You don't have authenticator app verification set up.");

        /// <summary>
        /// "Authenticator app verification removed."
        /// </summary>
        public static LocalisableString DestroyOk => new TranslatableString(getKey(@"destroy.ok"), @"Authenticator app verification removed.");

        /// <summary>
        /// "Please enter your current password to remove authenticator app verification."
        /// </summary>
        public static LocalisableString EditPassword => new TranslatableString(getKey(@"edit.password"), @"Please enter your current password to remove authenticator app verification.");

        /// <summary>
        /// "Remove"
        /// </summary>
        public static LocalisableString EditStart => new TranslatableString(getKey(@"edit.start"), @"Remove");

        /// <summary>
        /// "You already have authenticator app verification set up."
        /// </summary>
        public static LocalisableString StoreExisting => new TranslatableString(getKey(@"store.existing"), @"You already have authenticator app verification set up.");

        /// <summary>
        /// "Authenticator app verification has been set up"
        /// </summary>
        public static LocalisableString StoreOk => new TranslatableString(getKey(@"store.ok"), @"Authenticator app verification has been set up");

        /// <summary>
        /// "Error occurred. Please restart the process."
        /// </summary>
        public static LocalisableString StoreRestart => new TranslatableString(getKey(@"store.restart"), @"Error occurred. Please restart the process.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}