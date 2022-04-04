// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class ChatStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Chat";

        /// <summary>
        /// "talking in {0}"
        /// </summary>
        public static LocalisableString TalkingIn(LocalisableString channel) => new TranslatableString(getKey(@"talking_in"), @"talking in {0}", channel);

        /// <summary>
        /// "talking with {0}"
        /// </summary>
        public static LocalisableString TalkingWith(LocalisableString name) => new TranslatableString(getKey(@"talking_with"), @"talking with {0}", name);

        /// <summary>
        /// "chat"
        /// </summary>
        public static LocalisableString TitleCompact => new TranslatableString(getKey(@"title_compact"), @"chat");

        /// <summary>
        /// "You cannot message this channel at this time."
        /// </summary>
        public static LocalisableString CannotSendChannel => new TranslatableString(getKey(@"cannot_send.channel"), @"You cannot message this channel at this time.");

        /// <summary>
        /// "You cannot message this user at this time."
        /// </summary>
        public static LocalisableString CannotSendUser => new TranslatableString(getKey(@"cannot_send.user"), @"You cannot message this user at this time.");

        /// <summary>
        /// "There&#39;s nothing here, maybe you left the channel or it doesn&#39;t exist..."
        /// </summary>
        public static LocalisableString NotFoundMessage => new TranslatableString(getKey(@"not_found.message"), @"There's nothing here, maybe you left the channel or it doesn't exist...");

        /// <summary>
        /// "channel not found"
        /// </summary>
        public static LocalisableString NotFoundTitle => new TranslatableString(getKey(@"not_found.title"), @"channel not found");

        /// <summary>
        /// "unable to send message..."
        /// </summary>
        public static LocalisableString InputDisabled => new TranslatableString(getKey(@"input.disabled"), @"unable to send message...");

        /// <summary>
        /// "Disconnected"
        /// </summary>
        public static LocalisableString InputDisconnected => new TranslatableString(getKey(@"input.disconnected"), @"Disconnected");

        /// <summary>
        /// "type message..."
        /// </summary>
        public static LocalisableString InputPlaceholder => new TranslatableString(getKey(@"input.placeholder"), @"type message...");

        /// <summary>
        /// "Send"
        /// </summary>
        public static LocalisableString InputSend => new TranslatableString(getKey(@"input.send"), @"Send");

        /// <summary>
        /// "Start conversations from a user&#39;s profile or a usercard popup."
        /// </summary>
        public static LocalisableString NoConversationsHowto => new TranslatableString(getKey(@"no-conversations.howto"), @"Start conversations from a user's profile or a usercard popup.");

        /// <summary>
        /// "Public channels you join via &lt;a href=&quot;{0}&quot;&gt;osu!lazer&lt;/a&gt; will also be visible here."
        /// </summary>
        public static LocalisableString NoConversationsLazer(LocalisableString link) => new TranslatableString(getKey(@"no-conversations.lazer"), @"Public channels you join via <a href=""{0}"">osu!lazer</a> will also be visible here.", link);

        /// <summary>
        /// "no conversations yet"
        /// </summary>
        public static LocalisableString NoConversationsTitle => new TranslatableString(getKey(@"no-conversations.title"), @"no conversations yet");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}