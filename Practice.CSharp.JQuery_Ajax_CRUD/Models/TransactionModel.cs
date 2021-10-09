using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.CSharp.JQuery_Ajax_CRUD.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "this field is Require")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "this field is Require")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "this field is Require")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "this field is Require")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "this field is Require")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyy}")]
        public DateTime Date { get; set; }
    }
}
