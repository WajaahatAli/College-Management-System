using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace College_Management_System.DATA
{
    public class AppDbSTudentsListFactory : IDesignTimeDbContextFactory<AppDbSTudentsList>
    {
        public AppDbSTudentsList CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbSTudentsList>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CollegeDb;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new AppDbSTudentsList(optionsBuilder.Options);
        }
    }
}
