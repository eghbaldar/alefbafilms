using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Contact.Commands.DeleteContact
{
    public class DeleteContactService: IDeleteContactService
    {
        private readonly IDataBaseContext _context;
        public DeleteContactService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestDeleteContactServiceDto req)
        {
            var contant = _context.Contacts.Find(req.Id);
            if (contant == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "رکوردی یافت نشد",
                };
            }
            _context.Contacts.Remove(contant);
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "رکورد مد نظر با موفقیت حذف شد",
            };
        }
    }
}
