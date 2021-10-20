using dotnetcore_restapi.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetcore_restapi.Data
{
    public class SubjectContext : DbContext
    {
        public SubjectContext(DbContextOptions<SubjectContext> opt) : base(opt)
        {

        }

        public DbSet<Subject> Subjects { get; set; }
    }
}
