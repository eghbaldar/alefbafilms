using alefbafilms.application.Interfaces.Contexts;

namespace alefbafilm6.Application.Services.Contact.Queries.GetContact
{
    public class GetContactService: IGetContactService
    {
        private readonly IDataBaseContext _context;
        public GetContactService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetContactServiceDto Execute()
        {
            var result = _context.Contacts.Select(x => new GetContactServiceDto
            {
                Id=x.Id,
                FullName = x.FullName,
                Organization = x.Organization,
                Email = x.Email,
                Phone = x.Phone,
                Message = x.Message,
                IsCheck = x.IsCheck,

            }).ToList();
            return new ResultGetContactServiceDto
            {
                _ResultGetContactServiceDto = result,
            };
        }
    }
}
