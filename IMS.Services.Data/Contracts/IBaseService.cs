﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Data.Contracts
{
    public interface ICommercialSiteProductsService
    {
        bool IsGuidValid(string? id, ref Guid parsedGuid);
    }
}
