using ExpenseTracker.DataLayer;
using ExpenseTracker.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.BusinessLogic
{
    public class AccountRepository : IAccountRepository
    {
        private ExpenseTrackerContext _context = new ExpenseTrackerContext();
        public void Add(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void Edit(Account account)
        {
            _context.Entry<Account>(account).State = EntityState.Modified;
        }

        public Account FindById(int id)
        {
            return _context.Accounts.Find(id);            
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }

        public void Remove(int id)
        {
            _context.Accounts.Remove(FindById(id));
            _context.SaveChanges();
        }
    }
}
