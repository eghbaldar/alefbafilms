using alefbafilm6.Application.Services.Gallery.Queries.GetGalleryCategory;
using alefbafilm6.Application.Services.Gallery.Queries.GetGalleryPhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Gallery.Queries.Common
{
    public class GetGalleryPhotosForAdminPhotos
    {
        public ResultGetGalleryCategoryDto _resultGetGalleryCategoryDto { get; set; }
        public ResultGetGalleryPhotosServiceDto _resultGetGalleryPhotosServiceDto { get; set; }
    }
}
