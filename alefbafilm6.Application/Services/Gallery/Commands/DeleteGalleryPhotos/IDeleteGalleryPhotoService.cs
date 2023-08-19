using alefbafilms.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Gallery.Commands.DeleteGalleryPhotos
{
    public interface IDeleteGalleryPhotoService
    {
        ResultDto Execute(RequestDeleteGalleryPhotoServiceDto req);
    }
}
