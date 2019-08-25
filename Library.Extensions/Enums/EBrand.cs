using System.ComponentModel;

namespace Library.Extensions.Enums
{
    public enum EBrand
    {
        Toyota = 1,
        Ford = 2,
        [Description("Aston Martin")]
        AstonMartin = 3,
        BMW = 4
    }
}
