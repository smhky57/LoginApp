using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Data.Models
{
    public class Base
    {
        public Guid ID { get; set; }
        public int Stat { get; set; }
        public int recordStat { get; set; }
        public DateTime? lastLogintime { get; set; }
        public DateTime? lastUpdateDate { get; set; }
        public string HashType { get; set; }

    }
}
