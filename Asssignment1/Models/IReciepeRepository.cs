using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asssignment1.Models
{
    interface IReciepeRepository
    {
        IQueryable<ReciepeModel> Reciepes { get; }
    }
}
