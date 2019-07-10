using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationCar.Models
{
    public class WebApplicationCarContext : DbContext
    {
        public WebApplicationCarContext()
        {
        }

        public WebApplicationCarContext (DbContextOptions<WebApplicationCarContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationCar.Models.Car> Cars { get; set; }
    }
}
