using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatEF.Entities.Configuration
{
    public class MessageStatusConfigarition : IEntityTypeConfiguration<MessageStatus>
    {
        public void Configure(EntityTypeBuilder<MessageStatus> builder)
        {
            builder.HasKey(messageStatus => messageStatus.Id);

            builder.Property(messageStatus => messageStatus.IsRead)
                   .HasDefaultValue(false);

            builder.Property(messageStatus => messageStatus.IsDelivered)
                   .HasDefaultValue(false);

            builder.Property(messageStatus => messageStatus.MessageId)
                   .IsRequired();

            builder.Property(messageStatus => messageStatus.MessageId)
                   .IsRequired();

        }
    }
}
