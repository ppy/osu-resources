// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class MultiplayerStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Multiplayer";

        /// <summary>
        /// "No osu!(lazer) {0} games played yet!"
        /// </summary>
        public static LocalisableString EmptyDefault(LocalisableString typeGroup) => new TranslatableString(getKey(@"empty._"), @"No osu!(lazer) {0} games played yet!", typeGroup);

        /// <summary>
        /// "playlist"
        /// </summary>
        public static LocalisableString EmptyPlaylists => new TranslatableString(getKey(@"empty.playlists"), @"playlist");

        /// <summary>
        /// "multiplayer"
        /// </summary>
        public static LocalisableString EmptyRealtime => new TranslatableString(getKey(@"empty.realtime"), @"multiplayer");

        /// <summary>
        /// "hosted by {0}"
        /// </summary>
        public static LocalisableString RoomHostedBy(LocalisableString user) => new TranslatableString(getKey(@"room.hosted_by"), @"hosted by {0}", user);

        /// <summary>
        /// "Invalid room password"
        /// </summary>
        public static LocalisableString RoomInvalidPassword => new TranslatableString(getKey(@"room.invalid_password"), @"Invalid room password");

        /// <summary>
        /// "{0} map|{0} maps"
        /// </summary>
        public static LocalisableString RoomMapCount(LocalisableString countDelimited) => new TranslatableString(getKey(@"room.map_count"), @"{0} map|{0} maps", countDelimited);

        /// <summary>
        /// "{0} player|{0} players"
        /// </summary>
        public static LocalisableString RoomPlayerCount(LocalisableString countDelimited) => new TranslatableString(getKey(@"room.player_count"), @"{0} player|{0} players", countDelimited);

        /// <summary>
        /// "{0} left"
        /// </summary>
        public static LocalisableString RoomTimeLeft(LocalisableString time) => new TranslatableString(getKey(@"room.time_left"), @"{0} left", time);

        /// <summary>
        /// "Duration is too long."
        /// </summary>
        public static LocalisableString RoomErrorsDurationTooLong => new TranslatableString(getKey(@"room.errors.duration_too_long"), @"Duration is too long.");

        /// <summary>
        /// "active"
        /// </summary>
        public static LocalisableString RoomStatusActive => new TranslatableString(getKey(@"room.status.active"), @"active");

        /// <summary>
        /// "ended"
        /// </summary>
        public static LocalisableString RoomStatusEnded => new TranslatableString(getKey(@"room.status.ended"), @"ended");

        /// <summary>
        /// "ending soon"
        /// </summary>
        public static LocalisableString RoomStatusSoon => new TranslatableString(getKey(@"room.status.soon"), @"ending soon");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}