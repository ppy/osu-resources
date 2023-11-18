// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Resources.Localisation.Web
{
    public static class StoreStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Web.Store";

        /// <summary>
        /// "Checkout"
        /// </summary>
        public static LocalisableString CartCheckout => new TranslatableString(getKey(@"cart.checkout"), @"Checkout");

        /// <summary>
        /// "Remove all items from cart"
        /// </summary>
        public static LocalisableString CartEmptyCart => new TranslatableString(getKey(@"cart.empty_cart"), @"Remove all items from cart");

        /// <summary>
        /// "{0} item in cart (${1})|{0} items in cart (${1})"
        /// </summary>
        public static LocalisableString CartInfo(LocalisableString countDelimited, LocalisableString subtotal) => new TranslatableString(getKey(@"cart.info"), @"{0} item in cart (${1})|{0} items in cart (${1})", countDelimited, subtotal);

        /// <summary>
        /// "I want to check out more goodies before completing the order"
        /// </summary>
        public static LocalisableString CartMoreGoodies => new TranslatableString(getKey(@"cart.more_goodies"), @"I want to check out more goodies before completing the order");

        /// <summary>
        /// "shipping fees"
        /// </summary>
        public static LocalisableString CartShippingFees => new TranslatableString(getKey(@"cart.shipping_fees"), @"shipping fees");

        /// <summary>
        /// "Shopping Cart"
        /// </summary>
        public static LocalisableString CartTitle => new TranslatableString(getKey(@"cart.title"), @"Shopping Cart");

        /// <summary>
        /// "total"
        /// </summary>
        public static LocalisableString CartTotal => new TranslatableString(getKey(@"cart.total"), @"total");

        /// <summary>
        /// "Uh oh, there are problems with your cart preventing a checkout!"
        /// </summary>
        public static LocalisableString CartErrorsNoCheckoutLine1 => new TranslatableString(getKey(@"cart.errors_no_checkout.line_1"), @"Uh oh, there are problems with your cart preventing a checkout!");

        /// <summary>
        /// "Remove or update items above to continue."
        /// </summary>
        public static LocalisableString CartErrorsNoCheckoutLine2 => new TranslatableString(getKey(@"cart.errors_no_checkout.line_2"), @"Remove or update items above to continue.");

        /// <summary>
        /// "Your cart is empty."
        /// </summary>
        public static LocalisableString CartEmptyText => new TranslatableString(getKey(@"cart.empty.text"), @"Your cart is empty.");

        /// <summary>
        /// "Return to the {0} to find some goodies!"
        /// </summary>
        public static LocalisableString CartEmptyReturnLinkDefault(LocalisableString link) => new TranslatableString(getKey(@"cart.empty.return_link._"), @"Return to the {0} to find some goodies!", link);

        /// <summary>
        /// "store listing"
        /// </summary>
        public static LocalisableString CartEmptyReturnLinkLinkText => new TranslatableString(getKey(@"cart.empty.return_link.link_text"), @"store listing");

        /// <summary>
        /// "Uh oh, there are problems with your cart!"
        /// </summary>
        public static LocalisableString CheckoutCartProblems => new TranslatableString(getKey(@"checkout.cart_problems"), @"Uh oh, there are problems with your cart!");

        /// <summary>
        /// "Click here to go edit it."
        /// </summary>
        public static LocalisableString CheckoutCartProblemsEdit => new TranslatableString(getKey(@"checkout.cart_problems_edit"), @"Click here to go edit it.");

        /// <summary>
        /// "The payment was cancelled."
        /// </summary>
        public static LocalisableString CheckoutDeclined => new TranslatableString(getKey(@"checkout.declined"), @"The payment was cancelled.");

        /// <summary>
        /// "We are currently overwhelmed with orders! You are welcome to place your order, but please expect an **additional 1-2 week delay** while we catch up with existing orders."
        /// </summary>
        public static LocalisableString CheckoutDelayedShipping => new TranslatableString(getKey(@"checkout.delayed_shipping"), @"We are currently overwhelmed with orders! You are welcome to place your order, but please expect an **additional 1-2 week delay** while we catch up with existing orders.");

        /// <summary>
        /// "Hide all osu!supporter tags in this order from my activity"
        /// </summary>
        public static LocalisableString CheckoutHideFromActivity => new TranslatableString(getKey(@"checkout.hide_from_activity"), @"Hide all osu!supporter tags in this order from my activity");

        /// <summary>
        /// "Your cart appears to be out of date and has been reloaded, please try again."
        /// </summary>
        public static LocalisableString CheckoutOldCart => new TranslatableString(getKey(@"checkout.old_cart"), @"Your cart appears to be out of date and has been reloaded, please try again.");

        /// <summary>
        /// "Checkout with Paypal"
        /// </summary>
        public static LocalisableString CheckoutPay => new TranslatableString(getKey(@"checkout.pay"), @"Checkout with Paypal");

        /// <summary>
        /// "checkout"
        /// </summary>
        public static LocalisableString CheckoutTitleCompact => new TranslatableString(getKey(@"checkout.title_compact"), @"checkout");

        /// <summary>
        /// "You have incomplete checkouts, click {0} to view them."
        /// </summary>
        public static LocalisableString CheckoutHasPendingDefault(LocalisableString link) => new TranslatableString(getKey(@"checkout.has_pending._"), @"You have incomplete checkouts, click {0} to view them.", link);

        /// <summary>
        /// "here"
        /// </summary>
        public static LocalisableString CheckoutHasPendingLinkText => new TranslatableString(getKey(@"checkout.has_pending.link_text"), @"here");

        /// <summary>
        /// "A previous checkout was started but did not finish."
        /// </summary>
        public static LocalisableString CheckoutPendingCheckoutLine1 => new TranslatableString(getKey(@"checkout.pending_checkout.line_1"), @"A previous checkout was started but did not finish.");

        /// <summary>
        /// "Resume your checkout by selecting a payment method."
        /// </summary>
        public static LocalisableString CheckoutPendingCheckoutLine2 => new TranslatableString(getKey(@"checkout.pending_checkout.line_2"), @"Resume your checkout by selecting a payment method.");

        /// <summary>
        /// "save {0}%"
        /// </summary>
        public static LocalisableString Discount(LocalisableString percent) => new TranslatableString(getKey(@"discount"), @"save {0}%", percent);

        /// <summary>
        /// "free!"
        /// </summary>
        public static LocalisableString Free => new TranslatableString(getKey(@"free"), @"free!");

        /// <summary>
        /// "Contact:"
        /// </summary>
        public static LocalisableString InvoiceContact => new TranslatableString(getKey(@"invoice.contact"), @"Contact:");

        /// <summary>
        /// "Date:"
        /// </summary>
        public static LocalisableString InvoiceDate => new TranslatableString(getKey(@"invoice.date"), @"Date:");

        /// <summary>
        /// "As your payment was an eCheck, please allow up to 10 extra days for the payment to clear through PayPal!"
        /// </summary>
        public static LocalisableString InvoiceEcheckDelay => new TranslatableString(getKey(@"invoice.echeck_delay"), @"As your payment was an eCheck, please allow up to 10 extra days for the payment to clear through PayPal!");

        /// <summary>
        /// "osu!supporter tags in this order are not displayed in your recent activities."
        /// </summary>
        public static LocalisableString InvoiceHideFromActivity => new TranslatableString(getKey(@"invoice.hide_from_activity"), @"osu!supporter tags in this order are not displayed in your recent activities.");

        /// <summary>
        /// "Sent Via:"
        /// </summary>
        public static LocalisableString InvoiceSentVia => new TranslatableString(getKey(@"invoice.sent_via"), @"Sent Via:");

        /// <summary>
        /// "Shipping To:"
        /// </summary>
        public static LocalisableString InvoiceShippingTo => new TranslatableString(getKey(@"invoice.shipping_to"), @"Shipping To:");

        /// <summary>
        /// "Invoice"
        /// </summary>
        public static LocalisableString InvoiceTitle => new TranslatableString(getKey(@"invoice.title"), @"Invoice");

        /// <summary>
        /// "invoice"
        /// </summary>
        public static LocalisableString InvoiceTitleCompact => new TranslatableString(getKey(@"invoice.title_compact"), @"invoice");

        /// <summary>
        /// "Your order has been cancelled"
        /// </summary>
        public static LocalisableString InvoiceStatusCancelledTitle => new TranslatableString(getKey(@"invoice.status.cancelled.title"), @"Your order has been cancelled");

        /// <summary>
        /// "If you didn&#39;t request a cancellation please contact {0} quoting your order number (#{1})."
        /// </summary>
        public static LocalisableString InvoiceStatusCancelledLine1Default(LocalisableString link, LocalisableString orderNumber) => new TranslatableString(getKey(@"invoice.status.cancelled.line_1._"), @"If you didn't request a cancellation please contact {0} quoting your order number (#{1}).", link, orderNumber);

        /// <summary>
        /// "osu!store support"
        /// </summary>
        public static LocalisableString InvoiceStatusCancelledLine1LinkText => new TranslatableString(getKey(@"invoice.status.cancelled.line_1.link_text"), @"osu!store support");

        /// <summary>
        /// "Your order has been delivered! We hope you are enjoying it!"
        /// </summary>
        public static LocalisableString InvoiceStatusDeliveredTitle => new TranslatableString(getKey(@"invoice.status.delivered.title"), @"Your order has been delivered! We hope you are enjoying it!");

        /// <summary>
        /// "If you have any issues with your purchase, please contact the {0}."
        /// </summary>
        public static LocalisableString InvoiceStatusDeliveredLine1Default(LocalisableString link) => new TranslatableString(getKey(@"invoice.status.delivered.line_1._"), @"If you have any issues with your purchase, please contact the {0}.", link);

        /// <summary>
        /// "osu!store support"
        /// </summary>
        public static LocalisableString InvoiceStatusDeliveredLine1LinkText => new TranslatableString(getKey(@"invoice.status.delivered.line_1.link_text"), @"osu!store support");

        /// <summary>
        /// "Your order is being prepared!"
        /// </summary>
        public static LocalisableString InvoiceStatusPreparedTitle => new TranslatableString(getKey(@"invoice.status.prepared.title"), @"Your order is being prepared!");

        /// <summary>
        /// "Please wait a bit longer for it to be shipped. Tracking information will appear here once the order has been processed and sent. This can take up to 5 days (but usually less!) depending on how busy we are."
        /// </summary>
        public static LocalisableString InvoiceStatusPreparedLine1 => new TranslatableString(getKey(@"invoice.status.prepared.line_1"), @"Please wait a bit longer for it to be shipped. Tracking information will appear here once the order has been processed and sent. This can take up to 5 days (but usually less!) depending on how busy we are.");

        /// <summary>
        /// "We send all orders from Japan using a variety of shipping services depending on the weight and value. This area will update with specifics once we have shipped the order."
        /// </summary>
        public static LocalisableString InvoiceStatusPreparedLine2 => new TranslatableString(getKey(@"invoice.status.prepared.line_2"), @"We send all orders from Japan using a variety of shipping services depending on the weight and value. This area will update with specifics once we have shipped the order.");

        /// <summary>
        /// "Your payment has not yet been confirmed!"
        /// </summary>
        public static LocalisableString InvoiceStatusProcessingTitle => new TranslatableString(getKey(@"invoice.status.processing.title"), @"Your payment has not yet been confirmed!");

        /// <summary>
        /// "If you have already paid, we may still be waiting to receive confirmation of your payment. Please refresh this page in a minute or two!"
        /// </summary>
        public static LocalisableString InvoiceStatusProcessingLine1 => new TranslatableString(getKey(@"invoice.status.processing.line_1"), @"If you have already paid, we may still be waiting to receive confirmation of your payment. Please refresh this page in a minute or two!");

        /// <summary>
        /// "If you encountered a problem during checkout, {0}"
        /// </summary>
        public static LocalisableString InvoiceStatusProcessingLine2Default(LocalisableString link) => new TranslatableString(getKey(@"invoice.status.processing.line_2._"), @"If you encountered a problem during checkout, {0}", link);

        /// <summary>
        /// "click here to resume your checkout"
        /// </summary>
        public static LocalisableString InvoiceStatusProcessingLine2LinkText => new TranslatableString(getKey(@"invoice.status.processing.line_2.link_text"), @"click here to resume your checkout");

        /// <summary>
        /// "Your order has been shipped!"
        /// </summary>
        public static LocalisableString InvoiceStatusShippedTitle => new TranslatableString(getKey(@"invoice.status.shipped.title"), @"Your order has been shipped!");

        /// <summary>
        /// "Tracking details follow:"
        /// </summary>
        public static LocalisableString InvoiceStatusShippedTrackingDetails => new TranslatableString(getKey(@"invoice.status.shipped.tracking_details"), @"Tracking details follow:");

        /// <summary>
        /// "We don&#39;t have tracking details as we sent your package via Air Mail, but you can expect to receive it within 1-3 weeks. For Europe, sometimes customs can delay the order out of our control. If you have any concerns, please reply to the order confirmation email you received {0}."
        /// </summary>
        public static LocalisableString InvoiceStatusShippedNoTrackingDetailsDefault(LocalisableString link) => new TranslatableString(getKey(@"invoice.status.shipped.no_tracking_details._"), @"We don't have tracking details as we sent your package via Air Mail, but you can expect to receive it within 1-3 weeks. For Europe, sometimes customs can delay the order out of our control. If you have any concerns, please reply to the order confirmation email you received {0}.", link);

        /// <summary>
        /// "send us an email"
        /// </summary>
        public static LocalisableString InvoiceStatusShippedNoTrackingDetailsLinkText => new TranslatableString(getKey(@"invoice.status.shipped.no_tracking_details.link_text"), @"send us an email");

        /// <summary>
        /// "Cancel Order"
        /// </summary>
        public static LocalisableString OrderCancel => new TranslatableString(getKey(@"order.cancel"), @"Cancel Order");

        /// <summary>
        /// "This order will be cancelled and payment will not be accepted for it. The payment provider might not release any reserved funds immediately. Are you sure?"
        /// </summary>
        public static LocalisableString OrderCancelConfirm => new TranslatableString(getKey(@"order.cancel_confirm"), @"This order will be cancelled and payment will not be accepted for it. The payment provider might not release any reserved funds immediately. Are you sure?");

        /// <summary>
        /// "This order cannot be cancelled at this time."
        /// </summary>
        public static LocalisableString OrderCancelNotAllowed => new TranslatableString(getKey(@"order.cancel_not_allowed"), @"This order cannot be cancelled at this time.");

        /// <summary>
        /// "View Invoice"
        /// </summary>
        public static LocalisableString OrderInvoice => new TranslatableString(getKey(@"order.invoice"), @"View Invoice");

        /// <summary>
        /// "No orders to view."
        /// </summary>
        public static LocalisableString OrderNoOrders => new TranslatableString(getKey(@"order.no_orders"), @"No orders to view.");

        /// <summary>
        /// "Order placed {0}"
        /// </summary>
        public static LocalisableString OrderPaidOn(LocalisableString date) => new TranslatableString(getKey(@"order.paid_on"), @"Order placed {0}", date);

        /// <summary>
        /// "Resume Checkout"
        /// </summary>
        public static LocalisableString OrderResume => new TranslatableString(getKey(@"order.resume"), @"Resume Checkout");

        /// <summary>
        /// "Shipping &amp; Handling"
        /// </summary>
        public static LocalisableString OrderShippingAndHandling => new TranslatableString(getKey(@"order.shipping_and_handling"), @"Shipping & Handling");

        /// <summary>
        /// "The checkout link for this order has expired."
        /// </summary>
        public static LocalisableString OrderShopifyExpired => new TranslatableString(getKey(@"order.shopify_expired"), @"The checkout link for this order has expired.");

        /// <summary>
        /// "Subtotal"
        /// </summary>
        public static LocalisableString OrderSubtotal => new TranslatableString(getKey(@"order.subtotal"), @"Subtotal");

        /// <summary>
        /// "Total"
        /// </summary>
        public static LocalisableString OrderTotal => new TranslatableString(getKey(@"order.total"), @"Total");

        /// <summary>
        /// "Order #"
        /// </summary>
        public static LocalisableString OrderDetailsOrderNumber => new TranslatableString(getKey(@"order.details.order_number"), @"Order #");

        /// <summary>
        /// "Payment Terms"
        /// </summary>
        public static LocalisableString OrderDetailsPaymentTerms => new TranslatableString(getKey(@"order.details.payment_terms"), @"Payment Terms");

        /// <summary>
        /// "Salesperson"
        /// </summary>
        public static LocalisableString OrderDetailsSalesperson => new TranslatableString(getKey(@"order.details.salesperson"), @"Salesperson");

        /// <summary>
        /// "Shipping Method"
        /// </summary>
        public static LocalisableString OrderDetailsShippingMethod => new TranslatableString(getKey(@"order.details.shipping_method"), @"Shipping Method");

        /// <summary>
        /// "Shipping Terms"
        /// </summary>
        public static LocalisableString OrderDetailsShippingTerms => new TranslatableString(getKey(@"order.details.shipping_terms"), @"Shipping Terms");

        /// <summary>
        /// "Order Details"
        /// </summary>
        public static LocalisableString OrderDetailsTitle => new TranslatableString(getKey(@"order.details.title"), @"Order Details");

        /// <summary>
        /// "Quantity"
        /// </summary>
        public static LocalisableString OrderItemQuantity => new TranslatableString(getKey(@"order.item.quantity"), @"Quantity");

        /// <summary>
        /// "{0} for {1} ({2})"
        /// </summary>
        public static LocalisableString OrderItemDisplayNameSupporterTag(LocalisableString name, LocalisableString username, LocalisableString duration) => new TranslatableString(getKey(@"order.item.display_name.supporter_tag"), @"{0} for {1} ({2})", name, username, duration);

        /// <summary>
        /// "Message: {0}"
        /// </summary>
        public static LocalisableString OrderItemSubtextSupporterTag(LocalisableString message) => new TranslatableString(getKey(@"order.item.subtext.supporter_tag"), @"Message: {0}", message);

        /// <summary>
        /// "You cannot modify your order as it has been cancelled."
        /// </summary>
        public static LocalisableString OrderNotModifiableExceptionCancelled => new TranslatableString(getKey(@"order.not_modifiable_exception.cancelled"), @"You cannot modify your order as it has been cancelled.");

        /// <summary>
        /// "You cannot modify your order while it is being processed."
        /// </summary>
        public static LocalisableString OrderNotModifiableExceptionCheckout => new TranslatableString(getKey(@"order.not_modifiable_exception.checkout"), @"You cannot modify your order while it is being processed.");

        /// <summary>
        /// "Order is not modifiable"
        /// </summary>
        public static LocalisableString OrderNotModifiableExceptionDefault => new TranslatableString(getKey(@"order.not_modifiable_exception.default"), @"Order is not modifiable");

        /// <summary>
        /// "You cannot modify your order as it has already been delivered."
        /// </summary>
        public static LocalisableString OrderNotModifiableExceptionDelivered => new TranslatableString(getKey(@"order.not_modifiable_exception.delivered"), @"You cannot modify your order as it has already been delivered.");

        /// <summary>
        /// "You cannot modify your order as it has already been paid for."
        /// </summary>
        public static LocalisableString OrderNotModifiableExceptionPaid => new TranslatableString(getKey(@"order.not_modifiable_exception.paid"), @"You cannot modify your order as it has already been paid for.");

        /// <summary>
        /// "You cannot modify your order while it is being processed."
        /// </summary>
        public static LocalisableString OrderNotModifiableExceptionProcessing => new TranslatableString(getKey(@"order.not_modifiable_exception.processing"), @"You cannot modify your order while it is being processed.");

        /// <summary>
        /// "You cannot modify your order as it has already been shipped."
        /// </summary>
        public static LocalisableString OrderNotModifiableExceptionShipped => new TranslatableString(getKey(@"order.not_modifiable_exception.shipped"), @"You cannot modify your order as it has already been shipped.");

        /// <summary>
        /// "Cancelled"
        /// </summary>
        public static LocalisableString OrderStatusCancelled => new TranslatableString(getKey(@"order.status.cancelled"), @"Cancelled");

        /// <summary>
        /// "Preparing"
        /// </summary>
        public static LocalisableString OrderStatusCheckout => new TranslatableString(getKey(@"order.status.checkout"), @"Preparing");

        /// <summary>
        /// "Delivered"
        /// </summary>
        public static LocalisableString OrderStatusDelivered => new TranslatableString(getKey(@"order.status.delivered"), @"Delivered");

        /// <summary>
        /// "Paid"
        /// </summary>
        public static LocalisableString OrderStatusPaid => new TranslatableString(getKey(@"order.status.paid"), @"Paid");

        /// <summary>
        /// "Pending confirmation"
        /// </summary>
        public static LocalisableString OrderStatusProcessing => new TranslatableString(getKey(@"order.status.processing"), @"Pending confirmation");

        /// <summary>
        /// "Shipped"
        /// </summary>
        public static LocalisableString OrderStatusShipped => new TranslatableString(getKey(@"order.status.shipped"), @"Shipped");

        /// <summary>
        /// "Order Status"
        /// </summary>
        public static LocalisableString OrderStatusTitle => new TranslatableString(getKey(@"order.status.title"), @"Order Status");

        /// <summary>
        /// "Thanks for your order!"
        /// </summary>
        public static LocalisableString OrderThanksTitle => new TranslatableString(getKey(@"order.thanks.title"), @"Thanks for your order!");

        /// <summary>
        /// "You will receive a confirmation email soon. If you have any enquiries, please {0}!"
        /// </summary>
        public static LocalisableString OrderThanksLine1Default(LocalisableString link) => new TranslatableString(getKey(@"order.thanks.line_1._"), @"You will receive a confirmation email soon. If you have any enquiries, please {0}!", link);

        /// <summary>
        /// "contact us"
        /// </summary>
        public static LocalisableString OrderThanksLine1LinkText => new TranslatableString(getKey(@"order.thanks.line_1.link_text"), @"contact us");

        /// <summary>
        /// "Name"
        /// </summary>
        public static LocalisableString ProductName => new TranslatableString(getKey(@"product.name"), @"Name");

        /// <summary>
        /// "This item is currently out of stock. Check back later!"
        /// </summary>
        public static LocalisableString ProductStockOut => new TranslatableString(getKey(@"product.stock.out"), @"This item is currently out of stock. Check back later!");

        /// <summary>
        /// "Unfortunately this item is out of stock. Use the dropdown to choose a different type or check back later!"
        /// </summary>
        public static LocalisableString ProductStockOutWithAlternative => new TranslatableString(getKey(@"product.stock.out_with_alternative"), @"Unfortunately this item is out of stock. Use the dropdown to choose a different type or check back later!");

        /// <summary>
        /// "Add to Cart"
        /// </summary>
        public static LocalisableString ProductAddToCart => new TranslatableString(getKey(@"product.add_to_cart"), @"Add to Cart");

        /// <summary>
        /// "Notify me when available!"
        /// </summary>
        public static LocalisableString ProductNotify => new TranslatableString(getKey(@"product.notify"), @"Notify me when available!");

        /// <summary>
        /// "you will be notified when we have new stock. click {0} to cancel"
        /// </summary>
        public static LocalisableString ProductNotificationSuccess(LocalisableString link) => new TranslatableString(getKey(@"product.notification_success"), @"you will be notified when we have new stock. click {0} to cancel", link);

        /// <summary>
        /// "here"
        /// </summary>
        public static LocalisableString ProductNotificationRemoveText => new TranslatableString(getKey(@"product.notification_remove_text"), @"here");

        /// <summary>
        /// "This product is already in stock!"
        /// </summary>
        public static LocalisableString ProductNotificationInStock => new TranslatableString(getKey(@"product.notification_in_stock"), @"This product is already in stock!");

        /// <summary>
        /// "gift to player"
        /// </summary>
        public static LocalisableString SupporterTagGift => new TranslatableString(getKey(@"supporter_tag.gift"), @"gift to player");

        /// <summary>
        /// "add an optional message to your gift! (up to {0} characters)"
        /// </summary>
        public static LocalisableString SupporterTagGiftMessage(LocalisableString length) => new TranslatableString(getKey(@"supporter_tag.gift_message"), @"add an optional message to your gift! (up to {0} characters)", length);

        /// <summary>
        /// "You need to be {0} to get an osu!supporter tag!"
        /// </summary>
        public static LocalisableString SupporterTagRequireLoginDefault(LocalisableString link) => new TranslatableString(getKey(@"supporter_tag.require_login._"), @"You need to be {0} to get an osu!supporter tag!", link);

        /// <summary>
        /// "signed in"
        /// </summary>
        public static LocalisableString SupporterTagRequireLoginLinkText => new TranslatableString(getKey(@"supporter_tag.require_login.link_text"), @"signed in");

        /// <summary>
        /// "Enter a username to check availability!"
        /// </summary>
        public static LocalisableString UsernameChangeCheck => new TranslatableString(getKey(@"username_change.check"), @"Enter a username to check availability!");

        /// <summary>
        /// "Checking availability of {0}..."
        /// </summary>
        public static LocalisableString UsernameChangeChecking(LocalisableString username) => new TranslatableString(getKey(@"username_change.checking"), @"Checking availability of {0}...", username);

        /// <summary>
        /// "Requested Username"
        /// </summary>
        public static LocalisableString UsernameChangePlaceholder => new TranslatableString(getKey(@"username_change.placeholder"), @"Requested Username");

        /// <summary>
        /// "New Username"
        /// </summary>
        public static LocalisableString UsernameChangeLabel => new TranslatableString(getKey(@"username_change.label"), @"New Username");

        /// <summary>
        /// "Your current username is &quot;{0}&quot;."
        /// </summary>
        public static LocalisableString UsernameChangeCurrent(LocalisableString username) => new TranslatableString(getKey(@"username_change.current"), @"Your current username is ""{0}"".", username);

        /// <summary>
        /// "You need to be {0} to change your name!"
        /// </summary>
        public static LocalisableString UsernameChangeRequireLoginDefault(LocalisableString link) => new TranslatableString(getKey(@"username_change.require_login._"), @"You need to be {0} to change your name!", link);

        /// <summary>
        /// "signed in"
        /// </summary>
        public static LocalisableString UsernameChangeRequireLoginLinkText => new TranslatableString(getKey(@"username_change.require_login.link_text"), @"signed in");

        /// <summary>
        /// "Xsolla is an authorised&lt;br&gt;global distributor of osu!"
        /// </summary>
        public static LocalisableString XsollaDistributor => new TranslatableString(getKey(@"xsolla.distributor"), @"Xsolla is an authorised<br>global distributor of osu!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}