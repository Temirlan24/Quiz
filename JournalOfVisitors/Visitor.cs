using System;
using System.Collections.Generic;
using System.Text;

namespace JournalOfVisitors
{
    public class Visitor
    {
        public int Order { get; set; } = 0;
        public string ID { get; set; }
        public string FullName { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime? ExitTime { get; set; } = null;
    }
}
