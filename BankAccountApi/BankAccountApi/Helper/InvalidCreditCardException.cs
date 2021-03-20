using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountApi.Helper
{
    public class InvalidCreditCardException : Exception
    {
        public InvalidCreditCardException(string error)
            : base(error)
        {

        }
    }
}
