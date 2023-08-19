using alefbafilm6.Domain.Entities.Newsletter;
using alefbafilms.application.Interfaces.Contexts;

namespace alefbafilm6.Application.Services.Newsletter.Queries.GetNewsletter
{
    public class GetNewsletterService : IGetNewsletterService
    {
        private readonly IDataBaseContext _context;
        public GetNewsletterService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetNewsletterDto Execute()
        {
            try
            {
                var newsletters = _context.Newsletters.Select(x => new GetNewsletterDto
                {
                    Id = x.Id,
                    Email = x.Email,
                }).ToList();
                return new ResultGetNewsletterDto
                {
                    getNewsletterDtos = newsletters
                };
            }
            catch (Exception ex)
            {
                return new ResultGetNewsletterDto
                {
                    getNewsletterDtos = null
                };
            }
        }
    }
}
