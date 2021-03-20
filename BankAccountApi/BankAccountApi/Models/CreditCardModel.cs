using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountApi.Models
{
    public class CreditCardModel
    {
        [Required]
        [RegularExpression("^[a-zA-Z0-9]{1,50}$")]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[0-9]{1,50}$")]
        public string CreditCardNumber { get; set; }

        [Required]
        [RegularExpression("^[0-9]{1,50}$")]
        public string CVC { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }
    }
}
