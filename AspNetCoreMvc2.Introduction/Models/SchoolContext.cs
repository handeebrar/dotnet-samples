using AspNetCoreMvc2.Introduction.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc2.Introduction.Models
{
    public class SchoolContext:DbContext
    {
        //context ile ilgili konf. yapılmasını dependency injection ile sagliyoruz
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {

        }

        //beni db'deki student ile map et
        public DbSet<Student> Students { get; set; }
    }
}
