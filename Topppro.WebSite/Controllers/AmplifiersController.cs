﻿using Topppro.Interfaces.Business;

namespace Topppro.WebSite.Controllers
{
    public class AmplifiersController : LayoutController
    {
        public AmplifiersController() { }

        public AmplifiersController(IAssnCategorySerieProductBusiness bizCategorySerieProduct, IAssnCategorySerieBusiness bizCategorySerie) :
            base(bizCategorySerieProduct, bizCategorySerie)
        {

        }
    }
}
