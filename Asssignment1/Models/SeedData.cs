using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Asssignment1.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Asssignment1.Models;

namespace Asssignment1.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ReciepesAllContext context = app.ApplicationServices.GetRequiredService<ReciepesAllContext>();
            context.Database.Migrate();
            if (!context.ReciepeModel.Any())
            {
                context.ReciepeModel.AddRange(
                    new ReciepeModel
                    {
                        reciepeName = "Dosa",
                        reciepeIngredients = "Get mdh dosa masala",
                        reciepeProcedure = "Put the content of Rava dosa on the pan for making it properly."
                    },
                    new ReciepeModel
                    {
                        reciepeName = "Pau Bhaji",
                        reciepeIngredients = "Get mdh pau and bhaji",
                        reciepeProcedure = "Heat it properly."
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}