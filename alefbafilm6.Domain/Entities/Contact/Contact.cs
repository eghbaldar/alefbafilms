using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Domain.Entities.Contact
{
    public class Contact
    {
        public long Id { get; set; } 
        public string FullName { get; set;}
        public string Organization { get; set; }
        public string Email { get; set;}
        public string Phone { get; set;}
        public string Message { get; set;}
        public bool IsCheck { get; set; }
    }
}
