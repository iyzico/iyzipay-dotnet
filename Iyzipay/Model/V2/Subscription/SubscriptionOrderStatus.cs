namespace Iyzipay.Model.V2.Subscription
{
    public enum SubscriptionOrderStatus
    {
        MERCHANT_SUSPENDED = -99,
        FAILED = -1,
        SUCCESS = 1,
        WAITING = 2,
        PROCESSING = 3,
        SUBSCRIPTION_UPGRADED = 4,
        SUBSCRIPTION_CANCELED = 5,
        QUEUED = 6
    }
}