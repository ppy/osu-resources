﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class ErrorsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Errors";

        /// <summary>
        /// "Failed to load data."
        /// </summary>
        public static LocalisableString LoadFailed => new TranslatableString(getKey(@"load_failed"), @"Failed to load data.");

        /// <summary>
        /// "Invalid url or incorrect request method."
        /// </summary>
        public static LocalisableString MissingRoute => new TranslatableString(getKey(@"missing_route"), @"Invalid url or incorrect request method.");

        /// <summary>
        /// "You are not able to perform this action while your account is in a restricted state."
        /// </summary>
        public static LocalisableString NoRestrictedAccess => new TranslatableString(getKey(@"no_restricted_access"), @"You are not able to perform this action while your account is in a restricted state.");

        /// <summary>
        /// "{0} parameter has a maximum of {1} item|{0} parameter has a maximum of {1} items"
        /// </summary>
        public static LocalisableString ParamTooLarge(LocalisableString name, LocalisableString countDelimited) => new TranslatableString(getKey(@"param_too_large"), @"{0} parameter has a maximum of {1} item|{0} parameter has a maximum of {1} items", name, countDelimited);

        /// <summary>
        /// "You must be an osu!supporter to use this feature."
        /// </summary>
        public static LocalisableString SupporterOnly => new TranslatableString(getKey(@"supporter_only"), @"You must be an osu!supporter to use this feature.");

        /// <summary>
        /// "Unknown error occurred."
        /// </summary>
        public static LocalisableString Unknown => new TranslatableString(getKey(@"unknown"), @"Unknown error occurred.");

        /// <summary>
        /// "Please sign in to proceed."
        /// </summary>
        public static LocalisableString CodesHttp401 => new TranslatableString(getKey(@"codes.http-401"), @"Please sign in to proceed.");

        /// <summary>
        /// "Access denied."
        /// </summary>
        public static LocalisableString CodesHttp403 => new TranslatableString(getKey(@"codes.http-403"), @"Access denied.");

        /// <summary>
        /// "Not found."
        /// </summary>
        public static LocalisableString CodesHttp404 => new TranslatableString(getKey(@"codes.http-404"), @"Not found.");

        /// <summary>
        /// "Too many attempts. Try again later."
        /// </summary>
        public static LocalisableString CodesHttp429 => new TranslatableString(getKey(@"codes.http-429"), @"Too many attempts. Try again later.");

        /// <summary>
        /// "An error occured. Try refreshing the page."
        /// </summary>
        public static LocalisableString AccountProfileOrderGeneric => new TranslatableString(getKey(@"account.profile-order.generic"), @"An error occured. Try refreshing the page.");

        /// <summary>
        /// "Invalid mode specified."
        /// </summary>
        public static LocalisableString BeatmapsInvalidMode => new TranslatableString(getKey(@"beatmaps.invalid_mode"), @"Invalid mode specified.");

        /// <summary>
        /// "No scores are available for the requested mode on this beatmap difficulty."
        /// </summary>
        public static LocalisableString BeatmapsStandardConvertsOnly => new TranslatableString(getKey(@"beatmaps.standard_converts_only"), @"No scores are available for the requested mode on this beatmap difficulty.");

        /// <summary>
        /// "An error occurred while preparing your checkout."
        /// </summary>
        public static LocalisableString CheckoutGeneric => new TranslatableString(getKey(@"checkout.generic"), @"An error occurred while preparing your checkout.");

        /// <summary>
        /// "Invalid score id."
        /// </summary>
        public static LocalisableString ScoresInvalidId => new TranslatableString(getKey(@"scores.invalid_id"), @"Invalid score id.");

        /// <summary>
        /// "Could not get any results, try again later."
        /// </summary>
        public static LocalisableString SearchDefault => new TranslatableString(getKey(@"search.default"), @"Could not get any results, try again later.");

        /// <summary>
        /// "Invalid cursor parameter specified."
        /// </summary>
        public static LocalisableString SearchInvalidCursorException => new TranslatableString(getKey(@"search.invalid_cursor_exception"), @"Invalid cursor parameter specified.");

        /// <summary>
        /// "Search is currently busier than usual, try again later."
        /// </summary>
        public static LocalisableString SearchOperationTimeoutException => new TranslatableString(getKey(@"search.operation_timeout_exception"), @"Search is currently busier than usual, try again later.");

        /// <summary>
        /// "You&#39;ve already reported this recently."
        /// </summary>
        public static LocalisableString UserReportRecentlyReported => new TranslatableString(getKey(@"user_report.recently_reported"), @"You've already reported this recently.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}