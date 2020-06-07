using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiFacu.WebAPi.Data.Entities;

namespace WebApiFacu.WebAPi.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base (options)
        {

        }
        public DbSet<Professional> Profesionales { get; set; }
    }
}
