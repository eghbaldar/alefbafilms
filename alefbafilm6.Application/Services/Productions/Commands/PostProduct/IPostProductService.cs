using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Productions.Commands.PostProduct
{
    public interface IPostProductService
    {
        ResultDto Execute(RequestPostProductServiceDto req);
    }
}
