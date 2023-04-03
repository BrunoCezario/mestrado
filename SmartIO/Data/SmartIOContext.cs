using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartIO.Models;

namespace SmartIO.Data
{
    public class SmartIOContext : DbContext
    {
        public SmartIOContext (DbContextOptions<SmartIOContext> options)
            : base(options)
        {
        }

        public DbSet<SmartIO.Models.Usuario> Usuario { get; set; } = default!;
    }
}
