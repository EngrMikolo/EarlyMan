using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Telefin.Models.ViewModels
{
    public class HomepageViewModel
    {
        // Do I plug in the services I have created here?
        public IPrintRepository printRepository { get; set; }

        public IPromotionRepository promotionRepository { get; set; }
    }
}