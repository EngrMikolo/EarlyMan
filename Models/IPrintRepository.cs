using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telefin.Models
{
    public interface IPrintRepository
    {
        IQueryable<Print> Prints { get; }
    }
}