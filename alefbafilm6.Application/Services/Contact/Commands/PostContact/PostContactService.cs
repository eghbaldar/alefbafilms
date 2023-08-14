using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Contact.Commands.PostContact
{
    public class PostContactService : IPostContactService
    {
        private readonly IDataBaseContext _context;
        public PostContactService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestPostContactDto req)
        {
            Domain.Entities.Contact.Contact contact = new Domain.Entities.Contact.Contact();
            contact.FullName = req.FullName;
            contact.Organization = req.Organization;
            contact.Email = req.Email;
            contact.Phone = req.Phone;
            contact.Message = req.Message;

            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "پیام شما با موفقیت به ثبت رسید و در اسرع وقت پاسخ داده خواهد شد."
            };
        }
    }
}
