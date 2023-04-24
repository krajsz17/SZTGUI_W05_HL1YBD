using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Message
    {
        public string UID { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
    }
}
