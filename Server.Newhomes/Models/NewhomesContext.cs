using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace Server.Newhomes.Models
{
    public class NewhomesContext : DbContext
    {
        public DbSet<NumericalModel> Numbers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Newhomes;Trusted_Connection=True;ConnectRetryCount=0");
        }
    }
}
