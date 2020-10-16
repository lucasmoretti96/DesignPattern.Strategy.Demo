using System.ComponentModel;

namespace DesignPattern.Strategy.Demo.Enums
{
    public enum PurchaseOriginEnum
    {
        [Description("Local Purchase")]
        LocalPurchase = 1,

        [Description("Foreign Purchase")]
        ForeignPurchase = 2
    }
}
