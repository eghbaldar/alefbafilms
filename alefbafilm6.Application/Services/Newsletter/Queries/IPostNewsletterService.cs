using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Newsletter.Queries
{
    public class RequestNewsletterServiceDto
    {
        public string Email { get; set; }
    }
    public  interface IPostNewsletterService
    {
        ResultDto Execute(RequestNewsletterServiceDto req);
    }
    public class PostNewsletterService : IPostNewsletterService
    {
        private readonly IDataBaseContext _context;
        public PostNewsletterService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestNewsletterServiceDto req)
        {
            alefbafilm6.Domain.Entities.Newsletter.Newsletter newsletter = new Domain.Entities.Newsletter.Newsletter();
            newsletter.Email = req.Email;
            _context.Newsletters.Add(newsletter);
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "ایمیل شما با موفقیت ثبت شد"
            };
        }
    }
}
