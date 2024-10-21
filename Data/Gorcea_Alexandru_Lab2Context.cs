using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gorcea_Alexandru_Lab2.Models;

namespace Gorcea_Alexandru_Lab2.Data
{
    public class Gorcea_Alexandru_Lab2Context : DbContext
    {
        public Gorcea_Alexandru_Lab2Context (DbContextOptions<Gorcea_Alexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Gorcea_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Gorcea_Alexandru_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Gorcea_Alexandru_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
