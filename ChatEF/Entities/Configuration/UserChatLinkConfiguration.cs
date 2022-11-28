using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatEF.Entities.Configuration
{
    public class UserChatLinkConfiguration : IEntityTypeConfiguration<UserChatLink>
    {
        public void Configure(EntityTypeBuilder<UserChatLink> builder)
        {
            builder.HasKey(userChatLink => userChatLink.Id);

            builder.Property(userChatLink => userChatLink.ChatId)
                   .IsRequired();

            builder.Property(userChatLink => userChatLink.UserId)
                   .IsRequired();
        }
    }
}
