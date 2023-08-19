using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Contact.Commands.UpdateContact
{
    public class UpdateContactService : IUpdateContactService
    {
        private readonly IDataBaseContext _context;
        public UpdateContactService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestUpdateContactServiceDto req)
        {
            try
            {
                var contact = _context.Contacts.Find(req.Id);

                if (contact != null)
                {
                    contact.IsCheck = true;
                    _context.SaveChanges();
                    return new ResultDto
                    {
                        IsSuccess = true,
                        Message = contact.Message,
                    };
                }
                else
                {
                    return new ResultDto
                    {
                        IsSuccess = false,
                        Message = "پیامی یافت نشد",
                    };
                }
            }
            catch
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "خطایی رخ داده است",
                };
            }
        }
    }
}
