using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telefin.Models
{
    public class EFRegularPrintRepository : IPrintRepository
    {
        public ApplicationDbContext context;

        public EFRegularPrintRepository(ApplicationDbContext cxt)
        {
            context = cxt;
        }

        public IQueryable<Print> Prints => context.RegularPrints;
    }
}