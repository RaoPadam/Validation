using System;
using System.ComponentModel;

namespace Validation
{
    public enum ValidationDataTypes
    {
        [Description("Alpha")]
         Alpha = 1,
        [Description("Currency")]
        Currency = 2,
        [Description("Percent")]
        Percent = 3,
        [Description("Phone")]
        Phone = 4,
        [Description("Email")]
        Email = 5,
        [Description ("WholeNumeric")]
        WholeNumeric = 6
}
}
