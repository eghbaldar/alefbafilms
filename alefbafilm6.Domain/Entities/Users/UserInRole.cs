namespace alefbafilms.domian.Entities.Users
{
    public class UserInRole
    {
        public long id { get; set; }
        public virtual User User { get; set; }
        public long UserId { get; set; }
        public virtual Role Role { get; set; }
        public long RoleId { get; set; }
    }
}
