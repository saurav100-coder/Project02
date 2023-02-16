using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project02.Models;
namespace Project02.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }
        public virtual DbSet<StudentInfo> StudentInfos { get; set; }
    }
}
