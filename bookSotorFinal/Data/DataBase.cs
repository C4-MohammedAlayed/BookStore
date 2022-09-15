using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookSotorFinal.Data
{
    public class DataBase:DbContext
    {
        public DataBase(DbContextOptions<DataBase> options)
           : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
    }
}
    