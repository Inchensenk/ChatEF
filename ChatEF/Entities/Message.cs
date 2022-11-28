using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatEF.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int ChatId { get; set; }
        public string MessageText { get; set; } = null!;
        public Chat? Chat { get; set; }= null!;
        public MessageStatus? MessageStatus { get; set; } = null!;

    }
}
