using Microsoft.AspNetCore.Http;

namespace alefbafilm6.Application.Services.Gallery.Commands.PostGallery
{
    public class RequestPostGalleryServiceDto
    {
        public string Name { get; set; }
        public string Detail { get; set; }        
        public int IdGalleryCategory { get; set; }
        public IFormFile Filename { get; set; }
    }
}
