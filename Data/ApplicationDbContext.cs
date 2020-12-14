using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace practica03.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        /*public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }*/
        public DbSet<practica03.Models.Producto> Registrar { get; set; }

        public ApplicationDbContext(DbContextOptions dco) : base(dco) {
            
        }
    }
}
