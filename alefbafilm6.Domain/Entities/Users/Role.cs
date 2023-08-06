using alefbafilms.domian.Commons;

namespace alefbafilms.domian.Entities.Users
{
    public class Role: BaseEntity
    {
        //The below property won't be used, because this class will inherit from [BaseEntity] that there is own Id there.
        public long id { get; set; }
        public string name { get; set; }
        public virtual ICollection<UserInRole> UserInRole { get; set; }
    }
}
