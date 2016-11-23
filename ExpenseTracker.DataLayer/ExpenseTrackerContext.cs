using ExpenseTracker.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.DataLayer
{
    public class ExpenseTrackerContext:DbContext
    {

        public ExpenseTrackerContext() : base("name=ExpenseTracker")
        {
        }

        public DbSet<Account> Accounts { get; set; }

    
    }
}
