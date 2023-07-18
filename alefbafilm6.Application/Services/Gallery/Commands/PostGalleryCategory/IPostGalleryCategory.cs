using alefbafilms.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Gallery.Commands.PostGalleryCategory
{
    public interface IPostGalleryCategory
    {
        ResultDto<ResultPostGalleryCategoryDto> Execute(RequestPostGalleryCategoryDto req);
    }
}
