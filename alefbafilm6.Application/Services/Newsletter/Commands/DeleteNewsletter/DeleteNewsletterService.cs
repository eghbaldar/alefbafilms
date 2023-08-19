using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Newsletter.Commands.DeleteNewsletter
{
    public class DeleteNewsletterService : IDeleteNewsletterService
    {
        private readonly IDataBaseContext _context;
        public DeleteNewsletterService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestDeleteNewsletterServiceDto req)
        {
            try
            {
                var newsletter = _context.Newsletters.Find(req.Id);
                if (newsletter != null)
                {
                    newsletter.DeleteTime = DateTime.Now;
                }
                else
                {
                    return new ResultDto
                    {
                        IsSuccess = false,
                        Message = "خطایی رخ داده است"
                    };
                }
                _context.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "ایمیل با موفقیت حدف شد"
                };
            }
            catch (Exception ex)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "خطایی رخ داده است"
                };
            }
        }
    }


}
