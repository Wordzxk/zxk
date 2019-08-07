using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
   public class Message
    {
        public virtual User Receiver { get; set; }
        public string Content { get; set; }
        public DateTime? ReadTime { get; set; }

    }
}
