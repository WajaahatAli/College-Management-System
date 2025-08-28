using College_Management_System.Models;
using Microsoft.EntityFrameworkCore;




namespace College_Management_System.DATA
{
    public class AppDbSTudentsList : DbContext
    {
        public AppDbSTudentsList(DbContextOptions<AppDbSTudentsList> options) : base(options)
        {


        }

        public DbSet<Attributes> attributes { get; set; }
    }


}
