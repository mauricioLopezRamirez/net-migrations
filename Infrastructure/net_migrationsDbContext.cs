using Microsoft.EntityFrameworkCore;
using net_migrations.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_migrations.Infrastructure
{

    public class net_migrationsDbContext : DbContext {
    public net_migrations(DbContextOptions<net_migrations> options): base(options){
    }
    public DbSet<Book> Books {get; set;}
    public DbSet<Author> Authors {get; set;}
    
    }

}