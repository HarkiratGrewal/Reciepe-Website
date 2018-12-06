using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asssignment1.Models
{
    public class EfReciepeRepository : IReciepeRepository
    {
        private ReciepesAllContext context;

        public EfReciepeRepository(ReciepesAllContext ctx)
        {
            context = ctx;
        }

        public IQueryable<ReciepeModel> Reciepes => context.ReciepeModel;
    }
}
