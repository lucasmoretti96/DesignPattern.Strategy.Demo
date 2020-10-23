using System.ComponentModel;

namespace DesignPattern.Strategy.Demo.Enums
{
    public enum InvoiceOptionEnum
    {
        [Description("E-mail")]
        Email = 1,

        [Description("File")]
        File = 2
    }
}
