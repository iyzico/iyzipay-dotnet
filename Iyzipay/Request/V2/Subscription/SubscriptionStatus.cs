using System.ComponentModel;

namespace Iyzipay.Request.V2.Subscription
{
    public enum SubscriptionStatus
    { 
        [Description("Bir abonelik aktif ise ve ödemeler düzenli olarak alınıyorsa status active olur")]
        ACTIVE,
        
        [Description("Bir abonelik durdurulmuşsa status pending olur")]
        PENDING,
        
        [Description("Abonelik sırasında ödeme alınamamış ise status unpaid olur")]
        UNPAID,
        
        [Description("Abonelik başka bir plan ile güncellenmişse status upgraded olur")]
        UPGRADED,
        
        [Description("Abonelik iptal edilmişse status cancelled olur")]
        CANCELED,
        
        [Description("Abonelik periyodu bitmişse status expired olur. Karttan başka bir ödeme alınmaz")]
        EXPIRED
    }
}