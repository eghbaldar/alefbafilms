using alefbafilms.domian.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilms.domian.Entities.Users
{
    //User Entity  
    public class User : BaseEntity
    {
        //The below property won't be used, because this class will inherit from [BaseEntity] that there is own Id there.
        public long id { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<UserInRole> UserInRole { get; set; }
    }
}
