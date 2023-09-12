using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common;
using ServiceStack.Web;

namespace alefbafilm6.Application.Services.Contact.Queries.GetContact
{
    public class GetContactService : IGetContactService
    {
        private readonly IDataBaseContext _context;
        public GetContactService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetContactServiceDto Execute(RequestGetContactServiceDto req)
        {
            // With Pagination
            int RowsCount = 0;

            //NOTE
            //RowsCount will be filled by [toPaged] method automatically!
            //req.CurrenetPage => what is current page? 1,2,3,4,...
            //req.HowManyRecord => how many records should be shown in each page?
            var result =
                _context.Contacts.ToPaged(req.CurrenetPage, req.HowManyRecord, out RowsCount)
                .Select(x => new GetContactServiceDto
                {
                    Id = x.Id,
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
                RowCount = RowsCount,
            };
        }
    }
}
