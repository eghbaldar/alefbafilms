using alefbafilms.Common.Dtos;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Gallery.Commands.PostGallery
{
    public interface IPostGalleryService
    {
        ResultDto Execute(RequestPostGalleryServiceDto req);
    }
}
