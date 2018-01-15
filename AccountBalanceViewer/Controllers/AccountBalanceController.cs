using AccountBalanceViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace AccountBalanceViewer.Controllers
{
    public class AccountBalanceController : ApiController
    {
        AccountBalanceContext dbContext = new AccountBalanceContext();
        // GET api/values
        public IHttpActionResult  Get()
        {
            return Ok(dbContext.AccountBalances);
        }

        public IHttpActionResult Get(int month, int year)
        {
            var accBalace = dbContext.AccountBalances.Where(d => d.Date.Year == year && d.Date.Month == month).ToList();
            if (accBalace == null)
                return NotFound();

            return Ok(accBalace);
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            var accBalace = dbContext.AccountBalances.Where(d => d.AccountID == id).SingleOrDefault();
            if (accBalace == null)
                return NotFound();

            return Ok(accBalace);
        }

        // POST api/values
        public void Post(AccountBalance newAccountBalance)
        {
            AccountBalance accBalace = new AccountBalance()
            {
                AccountID = newAccountBalance.AccountID,
                AccountName = newAccountBalance.AccountName,
                Balance = newAccountBalance.Balance,
                Date = newAccountBalance.Date

            };
            dbContext.AccountBalances.Add(accBalace);
            dbContext.SaveChanges();

        }

        // PUT api/values/5
        public void Put(AccountBalance updateAccountBalance)
        {
            var accBalace = dbContext.AccountBalances.Where(d => d.AccountID == updateAccountBalance.AccountID).SingleOrDefault();
            if (accBalace != null)
            {
                accBalace.AccountName = updateAccountBalance.AccountName;
                accBalace.Balance = updateAccountBalance.Balance;
                accBalace.Date = updateAccountBalance.Date;
                dbContext.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        
	}
}