using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatEF.Entities
{
    public class Chat
    {
        public int Id { get; set; }
        public string ChatName { get; set; } = null!;
        public int UserId { get; set; }
        public User? User { get; set; } = null!;
        public UserChatLink? UserChatLink { get; set; }=null!;
        public Message? Message { get; set; } = null!;   
    }
}
