using alefbafilms.domian.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Domain.Entities.Staffs
{
    public class Staff: BaseEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string File { get; set; }
    }
}
