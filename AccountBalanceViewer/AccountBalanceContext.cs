using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AccountBalanceViewer.Models;


namespace AccountBalanceViewer
{
    public class AccountBalanceContext : DbContext
    {
        public AccountBalanceContext():base()
        {
            Database.SetInitializer(new AccountBalanceDBInitializer());
        }
        public DbSet<AccountBalance> AccountBalances { get; set; }
    }
}