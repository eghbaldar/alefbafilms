using alefbafilms.application.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Gallery.Queries.GetGalleryPhotos
{
    public class ResultGetGalleryPhotosServiceDto
    {
        public List<GetGalleryPhotosServiceDto> GetGalleryPhotosServiceDto { get; set; }
    }
    public class GetGalleryPhotosServiceDto
    {
        public long IdPhoto { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string Filename { get; set; }
        public int IdCategory { get; set; }
        public string NameCategory { get; set; }
    }
    public interface IGetGallaryPhotosService
    {
        ResultGetGalleryPhotosServiceDto Execute();
    }
    public class GetGalleryPhotosService : IGetGallaryPhotosService
    {
        private readonly IDataBaseContext _context;
        public GetGalleryPhotosService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetGalleryPhotosServiceDto Execute()
        {
            var photos = (
                from tbPhoto in _context.Gallery
                join tbPhotoInCat in _context.GalleryInCategory on tbPhoto.Id equals tbPhotoInCat.GalleryId
                join tbCat in _context.GalleryCategory on tbPhotoInCat.GalleryId equals tbCat.Id
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
