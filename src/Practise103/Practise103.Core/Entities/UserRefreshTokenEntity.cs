using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise103.Core.Entities
{
    public class UserRefreshTokenEntity
    {
        [Key]
        public int UserId { get; set; }

        [Required, MaxLength(200)]
        public string Code { get; set; }
        public DateTime Expiration { get; set; }
        public UserEntity User { get; set; }
    }

    public class UserRefreshTokenConfiguration : IEntityTypeConfiguration<UserRefreshTokenEntity>
    {
        public void Configure(EntityTypeBuilder<UserRefreshTokenEntity> builder)
        {
            builder.HasOne(u => u.User)
                .WithMany(r => r.Tokens)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
