﻿using alefbafilms.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Gallery.Commands.DeleteGalleryCategory
{
    public interface IDeleteGalleryCategoryService
    {
        ResultDto Execute(RequestDeleteGalleryCategoryServiceDto req);
    }
}
