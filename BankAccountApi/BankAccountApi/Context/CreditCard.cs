using System;
using System.ComponentModel.DataAnnotations;

namespace BankAccountApi.Context
{
    public class CreditCard
    {
        [StringLength(50)]
        [Key]
        public string CreditCardNumber { get; set; }

        [StringLength(50)]
        public string CVC { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
