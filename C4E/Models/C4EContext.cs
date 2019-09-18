using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C4E.Models
{
    public class C4EContext:DbContext
    {

        public C4EContext(DbContextOptions options):base(options){}


        public DbSet<Person> persons { get; set; }
    }
}
