using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Newsletter.Commands.PostNewsletter
{
    public class PostNewsletterService : IPostNewsletterService
    {
        private readonly IDataBaseContext _context;
        public PostNewsletterService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestNewsletterServiceDto req)
        {
            try
            {
                Domain.Entities.Newsletter.Newsletter newsletter = new Domain.Entities.Newsletter.Newsletter();
                newsletter.Email = req.Email;
                _context.Newsletters.Add(newsletter);
                _context.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "ایمیل شما با موفقیت ثبت شد"
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
