using alefbafilm6.Domain.Entities.Pages;
using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Pages.Commands.PostAboutPage
{
    public class UpdateAboutPageService : IUpdateAboutPageService
    {
        private readonly IDataBaseContext _context;
        public UpdateAboutPageService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestUpdateAboutPageDto req)
        {
            try
            {
                Page aboutPage = new Page();
                aboutPage = _context.Pages.First();

                if (aboutPage == null)
                {
                    return new ResultDto
                    {
                        IsSuccess = false,
                        Message = "اطلاعاتی جهت ویرایش یافت نشد",
                    };
                }
                aboutPage.AboutPage = req.AboutPage;
                _context.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "صفحه درباره ی ما ویرایش شد"
                };
            }
            catch (Exception ex)
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
