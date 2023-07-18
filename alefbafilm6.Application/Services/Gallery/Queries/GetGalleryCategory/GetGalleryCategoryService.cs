using alefbafilms.application.Interfaces.Contexts;

namespace alefbafilm6.Application.Services.Gallery.Queries.GetGalleryCategory
{
    public class GetGalleryCategoryService : IGetGalleryCategory
    {
        private readonly IDataBaseContext _context;
        public GetGalleryCategoryService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetGalleryCategoryDto Execute()
        {
            var _galleryCategory = _context.GalleryCategory.Select(x => new GetGalleryCategoryDto
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
            return new ResultGetGalleryCategoryDto {
                GalleryCategory = _galleryCategory,
            };
        }
    }
}
