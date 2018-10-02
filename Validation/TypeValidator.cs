using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Validation
{
    public class TypeValidator : IValidator
    {

        private bool validateResult = false;

        private String inputString;
        public String GetInputString() => inputString;
        public String SetInputString(String InputString) => this.inputString = InputString;

        private String dataType;
        public String GetDataType() => dataType;
        public String SetDataType(String InputDataType) => this.dataType = InputDataType;

        private int requiredLength;
        public int GetrequiredLength() => requiredLength;
        public int SetrequiredLength(int inputLength) => this.requiredLength = inputLength;



        public Regex GetInstance(String regexString)

        {

            Regex r = new Regex(regexString);

            return r;
        }

       

        public void RaiseFlag(string ErrorMessage)
        { 
            Console.WriteLine(ErrorMessage, GetInputString());
          
        
        }

        public void RaiseFlagForLength(string ErrorMessage, int length)
        {
            Console.WriteLine(ErrorMessage, length);


        }



        public TypeValidator IsMandatory() {

            if (string.IsNullOrWhiteSpace(GetInputString()))

                RaiseFlag("String is Either null or just Whitespaces");
          
            return this;
        }


        public TypeValidator CheckLength()
        {

            if  (GetInputString().Length != GetrequiredLength()) {

                RaiseFlagForLength("Value entered is not equal to {0} in length", GetrequiredLength());

            }


            return this;
        }


        public bool Validate()
        {
        
            switch (GetDataType())
            {
                case "Alpha":

                    Regex r = GetInstance(Utils.Alpha_Regex);
                    if (! r.IsMatch(inputString))
                    {

                        RaiseFlag("Validation failed for Alpha with value {0}");


                    }

                    break;

                case "Currency":
                    r = GetInstance(Utils.Currency_Regex);
                    if (! r.IsMatch(inputString))
                    {

                        RaiseFlag("Validation failed for Currency with value {0}");

                    }


                    break;


                default:

                    break;
            }



            return validateResult;

        }

      
   
    
    
    
    
    }
}