// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class ChatStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Chat";

        /// <summary>
        /// "loading users..."
        /// </summary>
        public static LocalisableString LoadingUsers => new TranslatableString(getKey(@"loading_users"), @"loading users...");

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
        /// "unread messages"
        /// </summary>
        public static LocalisableString UnreadMessages => new TranslatableString(getKey(@"unread_messages"), @"unread messages");

        /// <summary>
        /// "You cannot message this channel at this time."
        /// </summary>
        public static LocalisableString CannotSendChannel => new TranslatableString(getKey(@"cannot_send.channel"), @"You cannot message this channel at this time.");

        /// <summary>
        /// "You cannot message this user at this time."
        /// </summary>
        public static LocalisableString CannotSendUser => new TranslatableString(getKey(@"cannot_send.user"), @"You cannot message this user at this time.");

        /// <summary>
        /// "Do you want to hide this channel? You will still receive messages from this channel."
        /// </summary>
        public static LocalisableString ChannelsConfirmPart => new TranslatableString(getKey(@"channels.confirm_part"), @"Do you want to hide this channel? You will still receive messages from this channel.");

        /// <summary>
        /// "create announcement"
        /// </summary>
        public static LocalisableString ChannelsCreate => new TranslatableString(getKey(@"channels.create"), @"create announcement");

        /// <summary>
        /// "join channel"
        /// </summary>
        public static LocalisableString ChannelsJoin => new TranslatableString(getKey(@"channels.join"), @"join channel");

        /// <summary>
        /// "no channel"
        /// </summary>
        public static LocalisableString ChannelsNone => new TranslatableString(getKey(@"channels.none"), @"no channel");

        /// <summary>
        /// "Announcements"
        /// </summary>
        public static LocalisableString ChannelsListTitleANNOUNCE => new TranslatableString(getKey(@"channels.list.title.announce"), @"Announcements");

        /// <summary>
        /// "Groups"
        /// </summary>
        public static LocalisableString ChannelsListTitleGROUP => new TranslatableString(getKey(@"channels.list.title.group"), @"Groups");

        /// <summary>
        /// "Direct messages"
        /// </summary>
        public static LocalisableString ChannelsListTitlePM => new TranslatableString(getKey(@"channels.list.title.pm"), @"Direct messages");

        /// <summary>
        /// "Channels"
        /// </summary>
        public static LocalisableString ChannelsListTitlePUBLIC => new TranslatableString(getKey(@"channels.list.title.public"), @"Channels");

        /// <summary>
        /// "Create New Announcement"
        /// </summary>
        public static LocalisableString FormTitleAnnouncement => new TranslatableString(getKey(@"form.title.announcement"), @"Create New Announcement");

        /// <summary>
        /// "description"
        /// </summary>
        public static LocalisableString FormLabelsDescription => new TranslatableString(getKey(@"form.labels.description"), @"description");

        /// <summary>
        /// "message"
        /// </summary>
        public static LocalisableString FormLabelsMessage => new TranslatableString(getKey(@"form.labels.message"), @"message");

        /// <summary>
        /// "room name"
        /// </summary>
        public static LocalisableString FormLabelsName => new TranslatableString(getKey(@"form.labels.name"), @"room name");

        /// <summary>
        /// "players to add"
        /// </summary>
        public static LocalisableString FormLabelsUsers => new TranslatableString(getKey(@"form.labels.users"), @"players to add");

        /// <summary>
        /// "There&#39;s nothing here, maybe you left the channel or it doesn&#39;t exist..."
        /// </summary>
        public static LocalisableString NotFoundMessage => new TranslatableString(getKey(@"not_found.message"), @"There's nothing here, maybe you left the channel or it doesn't exist...");

        /// <summary>
        /// "channel not found"
        /// </summary>
        public static LocalisableString NotFoundTitle => new TranslatableString(getKey(@"not_found.title"), @"channel not found");

        /// <summary>
        /// "Create"
        /// </summary>
        public static LocalisableString InputCreate => new TranslatableString(getKey(@"input.create"), @"Create");

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

        /// <summary>
        /// "Loading channel list..."
        /// </summary>
        public static LocalisableString JoinChannelsLoading => new TranslatableString(getKey(@"join_channels.loading"), @"Loading channel list...");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}