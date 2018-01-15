using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountBalanceViewer.Models
{
    public class AccountBalance
    {
        [Key]
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }

        public DateTime Date { get; set; }
    }
}