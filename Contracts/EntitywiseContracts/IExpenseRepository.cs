﻿using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.EntitywiseContracts
{
    public interface IExpenseRepository : IRepositoryBase<Expense>
    {
    }
}
