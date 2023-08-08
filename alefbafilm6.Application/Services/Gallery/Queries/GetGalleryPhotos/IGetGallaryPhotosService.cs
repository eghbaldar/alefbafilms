using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Gallery.Queries.GetGalleryPhotos
{
    public interface IGetGallaryPhotosService
    {
        ResultGetGalleryPhotosServiceDto Execute();
    }
}
