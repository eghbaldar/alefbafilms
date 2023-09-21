using alefbafilm6.Domain.Entities.Pages;
using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;
using alefbafilms.domian.Entities.Users;
using Microsoft.EntityFrameworkCore;
using ServiceStack;

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
                var page = _context.Pages.FirstOrDefault();
                if (page == null)
                {
                    Page aboutPage = new Page();
                    aboutPage.AboutPage = req.AboutPage;
                    _context.Pages.Add(aboutPage);
                }
                else
                    page.AboutPage = req.AboutPage;

                _context.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "صفحه درباره ی ما ویرایش شد"
                };
            }
            catch (Exception ex)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "خطایی رخ داده است" + ex.Message,
                };
            }
        }
    }
}
