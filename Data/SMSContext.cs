using Microsoft.EntityFrameworkCore;
public class SMSContext : DbContext
{
   public SMSContext(DbContextOptions<SMSContext> options) : base(options)
   {
       
   }
   public DbSet<Person> Students { get ; set ;}
}