﻿using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.EntitywiseContracts
{
    public interface IAddressRepository  : IRepositoryBase<Address>
    {
        void prit();
    }
}
