using DTS_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTS_API.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContext) : base(dbContext)
        {

        }

        // Memasukkan Model yang digunakkan untuk melakukkan oprasi CRUD / migrasi
        public DbSet<Karyawan> Karyawans { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Late> Lates { get; set; }
    }
}
