using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Data.Models
{
    public class User : Base
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int errorLoginCount { get; set; }

    }
}
