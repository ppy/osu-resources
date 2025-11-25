// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web.ModelValidation
{
    public static class TokenStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.ModelValidation.Token";

        /// <summary>
        /// "* is not allowed with Client Credentials"
        /// </summary>
        public static LocalisableString InvalidScopeAllScopeNoClientCredentials => new TranslatableString(getKey(@"invalid_scope.all_scope_no_client_credentials"), @"* is not allowed with Client Credentials");

        /// <summary>
        /// "* is not valid with other scopes"
        /// </summary>
        public static LocalisableString InvalidScopeAllScopeNoMix => new TranslatableString(getKey(@"invalid_scope.all_scope_no_mix"), @"* is not valid with other scopes");

        /// <summary>
        /// "The client is missing owner."
        /// </summary>
        public static LocalisableString InvalidScopeClientMissingOwner => new TranslatableString(getKey(@"invalid_scope.client_missing_owner"), @"The client is missing owner.");

        /// <summary>
        /// "The client is not authorized."
        /// </summary>
        public static LocalisableString InvalidScopeClientUnauthorized => new TranslatableString(getKey(@"invalid_scope.client_unauthorized"), @"The client is not authorized.");

        /// <summary>
        /// "Delegation with Client Credentials is only available to chat bots."
        /// </summary>
        public static LocalisableString InvalidScopeDelegateBotOnly => new TranslatableString(getKey(@"invalid_scope.delegate_bot_only"), @"Delegation with Client Credentials is only available to chat bots.");

        /// <summary>
        /// "This scope is only valid for client_credentials tokens."
        /// </summary>
        public static LocalisableString InvalidScopeClientCredentialsOnly => new TranslatableString(getKey(@"invalid_scope.client_credentials_only"), @"This scope is only valid for client_credentials tokens.");

        /// <summary>
        /// "Delegation is not supported for this combination of scopes."
        /// </summary>
        public static LocalisableString InvalidScopeDelegateInvalidCombination => new TranslatableString(getKey(@"invalid_scope.delegate_invalid_combination"), @"Delegation is not supported for this combination of scopes.");

        /// <summary>
        /// "delegate scope is required."
        /// </summary>
        public static LocalisableString InvalidScopeDelegateRequired => new TranslatableString(getKey(@"invalid_scope.delegate_required"), @"delegate scope is required.");

        /// <summary>
        /// "Tokens without scopes are not valid."
        /// </summary>
        public static LocalisableString InvalidScopeEmpty => new TranslatableString(getKey(@"invalid_scope.empty"), @"Tokens without scopes are not valid.");

        /// <summary>
        /// "This scope is only available for chat bots or your own clients."
        /// </summary>
        public static LocalisableString InvalidScopeBotOnly => new TranslatableString(getKey(@"invalid_scope.bot_only"), @"This scope is only available for chat bots or your own clients.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}