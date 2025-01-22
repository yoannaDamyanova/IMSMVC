﻿using IMS.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Data.Contracts
{
    public interface ICommercialSiteService
    {
        IEnumerable<CommercialSiteViewModel> AllCommercialSites();

    }
}