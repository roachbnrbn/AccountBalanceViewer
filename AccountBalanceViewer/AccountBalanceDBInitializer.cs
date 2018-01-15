using AccountBalanceViewer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AccountBalanceViewer
{
    public class AccountBalanceDBInitializer : DropCreateDatabaseAlways<AccountBalanceContext>
    {
        protected override void Seed(AccountBalanceContext context)
        {
            IList<AccountBalance> defaultAccountBalances = new List<AccountBalance>();

            defaultAccountBalances.Add(new AccountBalance() {AccountID = 1,AccountName = "R&D",Balance = 10.56m,Date = DateTime.Parse("01/01/2017") });
            defaultAccountBalances.Add(new AccountBalance() { AccountID = 2, AccountName = "Canteen", Balance = 98000.00m, Date = DateTime.Parse("01/01/2017") });
            defaultAccountBalances.Add(new AccountBalance() { AccountID = 3, AccountName = "CEO's car", Balance = 24000.00m, Date = DateTime.Parse("01/01/2017") });
            defaultAccountBalances.Add(new AccountBalance() { AccountID = 4, AccountName = "Marketing", Balance = -19112.00m, Date = DateTime.Parse("01/01/2017") });
            defaultAccountBalances.Add(new AccountBalance() { AccountID = 5, AccountName = "Parkings fines", Balance = 11000.00m, Date = DateTime.Parse("01/01/2017") });

            foreach (AccountBalance accBalance in defaultAccountBalances)
                context.AccountBalances.Add(accBalance);

            base.Seed(context);
        }
    }
}