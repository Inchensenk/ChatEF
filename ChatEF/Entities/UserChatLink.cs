using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatEF.Entities
{
    public class UserChatLink
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ChatId { get; set; }
        public User? User { get; set; } = null!;
        public Chat? Chat { get; set; } = null!;
    }
}
