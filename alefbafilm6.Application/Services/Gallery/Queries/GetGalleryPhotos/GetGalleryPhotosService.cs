using alefbafilms.application.Interfaces.Contexts;

namespace alefbafilm6.Application.Services.Gallery.Queries.GetGalleryPhotos
{
    public class GetGalleryPhotosService : IGetGallaryPhotosService
    {
        private readonly IDataBaseContext _context;
        public GetGalleryPhotosService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetGalleryPhotosServiceDto Execute()
        {
            //Combine three tables together!
            var photos = (
                from tbPhoto in _context.Gallery
                join tbPhotoInCat in _context.GalleryInCategory on tbPhoto.Id equals tbPhotoInCat.GalleryId
                join tbCat in _context.GalleryCategory on tbPhotoInCat.GalleryCategoryId equals tbCat.Id
                select new GetGalleryPhotosServiceDto
                {
                    IdPhoto = tbPhoto.Id,
                    Name = tbPhoto.Name,
                    Detail = tbPhoto.Detail,
                    Filename = tbPhoto.Filename,
                    IdCategory = tbCat.Id,
                    NameCategory = tbCat.Name,
                }).ToList();
            return new ResultGetGalleryPhotosServiceDto
            {
                GetGalleryPhotosServiceDto = photos,
            };
        }
    }
}
