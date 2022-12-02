using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatEF.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string NickName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Password { get; set; } =null!;

        public List<Chat> Chats { get; set; }

        public List<Message> Messages { get; set; }

        public User()
        {
            Chats = new List<Chat>();
            Messages = new List<Message>();
        }

        //public Chat? Chat { get; set; }
        //public UserChatLink? UserChatLink { get; set; }=null!;   
        //public MessageStatus? MessageStatus { get; set; }
    }
}
