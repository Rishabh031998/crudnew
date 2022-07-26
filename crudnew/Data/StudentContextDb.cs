using crudnew.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace crudnew.Data
{
    //protected readonly IConfiguration Configuration;

    public class StudentContextDb:DbContext
    {
        public StudentContextDb(DbContextOptions<StudentContextDb> options):base(options)   
        {

        }
        public DbSet<Student> studentsInfo { get; set; }
        public DbSet<country> country { get; set; }
        public DbSet<State> States { get; set; }
    }

    


}
