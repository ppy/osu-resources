// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class PasswordResetStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.PasswordReset";

        /// <summary>
        /// "Resend verification email"
        /// </summary>
        public static LocalisableString ButtonResend => new TranslatableString(getKey(@"button.resend"), @"Resend verification email");

        /// <summary>
        /// "Set password"
        /// </summary>
        public static LocalisableString ButtonSet => new TranslatableString(getKey(@"button.set"), @"Set password");

        /// <summary>
        /// "Start"
        /// </summary>
        public static LocalisableString ButtonStart => new TranslatableString(getKey(@"button.start"), @"Start");

        /// <summary>
        /// "Please contact support to recover account."
        /// </summary>
        public static LocalisableString ErrorContactSupport => new TranslatableString(getKey(@"error.contact_support"), @"Please contact support to recover account.");

        /// <summary>
        /// "Verification code has expired."
        /// </summary>
        public static LocalisableString ErrorExpired => new TranslatableString(getKey(@"error.expired"), @"Verification code has expired.");

        /// <summary>
        /// "Unexpected error in verification code."
        /// </summary>
        public static LocalisableString ErrorInvalid => new TranslatableString(getKey(@"error.invalid"), @"Unexpected error in verification code.");

        /// <summary>
        /// "Please contact a high level admin to recover account."
        /// </summary>
        public static LocalisableString ErrorIsPrivileged => new TranslatableString(getKey(@"error.is_privileged"), @"Please contact a high level admin to recover account.");

        /// <summary>
        /// "Required."
        /// </summary>
        public static LocalisableString ErrorMissingKey => new TranslatableString(getKey(@"error.missing_key"), @"Required.");

        /// <summary>
        /// "Password reset request limit has been reached. Please contact support to recover account."
        /// </summary>
        public static LocalisableString ErrorTooManyRequests => new TranslatableString(getKey(@"error.too_many_requests"), @"Password reset request limit has been reached. Please contact support to recover account.");

        /// <summary>
        /// "Too many failed attempts."
        /// </summary>
        public static LocalisableString ErrorTooManyTries => new TranslatableString(getKey(@"error.too_many_tries"), @"Too many failed attempts.");

        /// <summary>
        /// "Requested user does not exist."
        /// </summary>
        public static LocalisableString ErrorUserNotFound => new TranslatableString(getKey(@"error.user_not_found"), @"Requested user does not exist.");

        /// <summary>
        /// "Please wait a few moments."
        /// </summary>
        public static LocalisableString ErrorWaitResend => new TranslatableString(getKey(@"error.wait_resend"), @"Please wait a few moments.");

        /// <summary>
        /// "Incorrect code."
        /// </summary>
        public static LocalisableString ErrorWrongKey => new TranslatableString(getKey(@"error.wrong_key"), @"Incorrect code.");

        /// <summary>
        /// "Check your email for the verification code."
        /// </summary>
        public static LocalisableString NoticeSent => new TranslatableString(getKey(@"notice.sent"), @"Check your email for the verification code.");

        /// <summary>
        /// "New password saved!"
        /// </summary>
        public static LocalisableString NoticeSaved => new TranslatableString(getKey(@"notice.saved"), @"New password saved!");

        /// <summary>
        /// "New password"
        /// </summary>
        public static LocalisableString StartedPassword => new TranslatableString(getKey(@"started.password"), @"New password");

        /// <summary>
        /// "Password confirmation"
        /// </summary>
        public static LocalisableString StartedPasswordConfirmation => new TranslatableString(getKey(@"started.password_confirmation"), @"Password confirmation");

        /// <summary>
        /// "Resetting password for account &lt;strong&gt;{0}&lt;/strong&gt;."
        /// </summary>
        public static LocalisableString StartedTitle(LocalisableString username) => new TranslatableString(getKey(@"started.title"), @"Resetting password for account <strong>{0}</strong>.", username);

        /// <summary>
        /// "Verification code"
        /// </summary>
        public static LocalisableString StartedVerificationKey => new TranslatableString(getKey(@"started.verification_key"), @"Verification code");

        /// <summary>
        /// "Enter email address or username"
        /// </summary>
        public static LocalisableString StartingUsername => new TranslatableString(getKey(@"starting.username"), @"Enter email address or username");

        /// <summary>
        /// "Your account hasn&#39;t been used in a long time. To ensure your account security please reset your password."
        /// </summary>
        public static LocalisableString StartingReasonInactiveDifferentCountry => new TranslatableString(getKey(@"starting.reason.inactive_different_country"), @"Your account hasn't been used in a long time. To ensure your account security please reset your password.");

        /// <summary>
        /// "Need further assistance? Contact us via our {0}."
        /// </summary>
        public static LocalisableString StartingSupportDefault(LocalisableString button) => new TranslatableString(getKey(@"starting.support._"), @"Need further assistance? Contact us via our {0}.", button);

        /// <summary>
        /// "support system"
        /// </summary>
        public static LocalisableString StartingSupportButton => new TranslatableString(getKey(@"starting.support.button"), @"support system");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}