using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using net_migrations.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace net_migrations.Infrastructure.EntityConfigurations
{

    public class BookEntityConfiguration: IEntityTypeConfiguration<Book>{
      
      public void Configure(EntityTypeBuilder<Book> bookConfiguration)
      {
          bookConfiguration.HasKey(b => b.Id);
          bookConfiguration.Property(b => b.Name)
          .HasMaxLength(20)
          .IsRequired(false);

      }



    }

}