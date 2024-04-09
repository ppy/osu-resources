// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class UserCoverPresetsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.UserCoverPresets";

        /// <summary>
        /// "Disable Selected"
        /// </summary>
        public static LocalisableString IndexBatchDisable => new TranslatableString(getKey(@"index.batch_disable"), @"Disable Selected");

        /// <summary>
        /// "Enable Selected"
        /// </summary>
        public static LocalisableString IndexBatchEnable => new TranslatableString(getKey(@"index.batch_enable"), @"Enable Selected");

        /// <summary>
        /// "{0} {1}?"
        /// </summary>
        public static LocalisableString IndexBatchConfirmDefault(LocalisableString action, LocalisableString items) => new TranslatableString(getKey(@"index.batch_confirm._"), @"{0} {1}?", action, items);

        /// <summary>
        /// "Disable"
        /// </summary>
        public static LocalisableString IndexBatchConfirmDisable => new TranslatableString(getKey(@"index.batch_confirm.disable"), @"Disable");

        /// <summary>
        /// "Enable"
        /// </summary>
        public static LocalisableString IndexBatchConfirmEnable => new TranslatableString(getKey(@"index.batch_confirm.enable"), @"Enable");

        /// <summary>
        /// "{0} cover|{0} covers"
        /// </summary>
        public static LocalisableString IndexBatchConfirmItems(LocalisableString countDelimited) => new TranslatableString(getKey(@"index.batch_confirm.items"), @"{0} cover|{0} covers", countDelimited);

        /// <summary>
        /// "Files"
        /// </summary>
        public static LocalisableString IndexCreateFormFiles => new TranslatableString(getKey(@"index.create_form.files"), @"Files");

        /// <summary>
        /// "Save"
        /// </summary>
        public static LocalisableString IndexCreateFormSubmit => new TranslatableString(getKey(@"index.create_form.submit"), @"Save");

        /// <summary>
        /// "Add New"
        /// </summary>
        public static LocalisableString IndexCreateFormTitle => new TranslatableString(getKey(@"index.create_form.title"), @"Add New");

        /// <summary>
        /// "Click to disable"
        /// </summary>
        public static LocalisableString IndexItemClickToDisable => new TranslatableString(getKey(@"index.item.click_to_disable"), @"Click to disable");

        /// <summary>
        /// "Click to enable"
        /// </summary>
        public static LocalisableString IndexItemClickToEnable => new TranslatableString(getKey(@"index.item.click_to_enable"), @"Click to enable");

        /// <summary>
        /// "Enabled"
        /// </summary>
        public static LocalisableString IndexItemEnabled => new TranslatableString(getKey(@"index.item.enabled"), @"Enabled");

        /// <summary>
        /// "Disabled"
        /// </summary>
        public static LocalisableString IndexItemDisabled => new TranslatableString(getKey(@"index.item.disabled"), @"Disabled");

        /// <summary>
        /// "Set Image"
        /// </summary>
        public static LocalisableString IndexItemImageStore => new TranslatableString(getKey(@"index.item.image_store"), @"Set Image");

        /// <summary>
        /// "Replace Image"
        /// </summary>
        public static LocalisableString IndexItemImageUpdate => new TranslatableString(getKey(@"index.item.image_update"), @"Replace Image");

        /// <summary>
        /// "Error occurred when creating cover: {0}"
        /// </summary>
        public static LocalisableString StoreFailed(LocalisableString error) => new TranslatableString(getKey(@"store.failed"), @"Error occurred when creating cover: {0}", error);

        /// <summary>
        /// "Covers created"
        /// </summary>
        public static LocalisableString StoreOk => new TranslatableString(getKey(@"store.ok"), @"Covers created");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}