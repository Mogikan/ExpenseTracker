﻿using ExpenseTracker.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Services
{
    [ServiceContract]
    public class ExpenseTrackerService
    {
        ExpenseTrackerContext _expensesContext;
    }
}
