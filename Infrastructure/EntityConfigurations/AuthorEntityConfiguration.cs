using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using net_migrations.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace net_migrations.Infrastructure.EntityConfigurations
{

    public class AuthorEntityConfiguration: IEntityTypeConfiguration<Author>{
      
      public void Configure(EntityTypeBuilder<Author> authorConfiguration)
      {
          authorConfiguration.HasKey(a => a.Id);
          authorConfiguration.Property(a => a.Name)
          .HasMaxLength(20)
          .IsRequired();

      }

    }

}