using GoogleAuth.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleAuth.Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasQueryFilter(student => !student.isDeleted);

            builder.HasKey(user => user.Id)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Property(user => user.Name);

            builder.Property(user => user.Password);

            builder.Property(user => user.Email);

            builder.Property(user => user.Role);

            builder.Property(user => user.isDeleted)
               .HasDefaultValue(false);
        }
    }
}
