using Microsoft.EntityFrameworkCore;
using net_migrations.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using net_migrations.Infrastructure.EntityConfigurations;

namespace net_migrations.Infrastructure
{

    public class net_migrationsDbContext : DbContext {
    public net_migrationsDbContext(DbContextOptions<net_migrationsDbContext> options): base(options){
   
   
    }
    public DbSet<Book> Books {get; set;}
    public DbSet<Author> Authors {get; set;}

     protected override void OnModelCreating(ModelBuilder builder){
        builder.ApplyConfiguration(new AuthorEntityConfiguration());
        builder.ApplyConfiguration(new BookEntityConfiguration());
    }
    
    }

}