using alefbafilms.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Gallery.Commands.UpdateGalleryCategory
{
    public interface IUpdateGalleryCategoryService
    {
        ResultDto Exectue(int Id, string Name);
    }
}
