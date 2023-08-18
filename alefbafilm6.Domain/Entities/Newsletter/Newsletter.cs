using alefbafilms.domian.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Domain.Entities.Newsletter
{
    public class Newsletter:BaseEntity
    {
        public long Id { get; set; }
        public string Email { get; set; }
    }
}
