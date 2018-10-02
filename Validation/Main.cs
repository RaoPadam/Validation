using System;

namespace Validation
{
    class Program
    {
        static void Main(string[] args)
        {

            TypeValidator validator = new TypeValidator();

          

            validator.SetInputString("ABCD");
            validator.SetDataType(ValidationDataTypes.Alpha.ToString());
            validator.Validate();

            validator.SetInputString("12.000000");
            validator.SetDataType(ValidationDataTypes.Currency.ToString());
            validator.SetrequiredLength(1);


            validator.Validate();
            validator.IsMandatory().CheckLength(;





        

        }
    }
}
