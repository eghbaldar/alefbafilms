using alefbafilm6.Application.Services.Gallery.Commands.DeleteGalleryCategory;
using alefbafilm6.Application.Services.Gallery.Commands.PostGalleryCategory;
using alefbafilm6.Application.Services.Gallery.Queries.GetGalleryCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Interfaces.FacadePattern
{
    public interface IGalleryFacade
    {
        PostGalleryCategoryService PostGalleryCategoryService { get; }
        GetGalleryCategoryService GetGalleryCategoryService { get; }
        DeleteGalleryCategoryService DeleteGalleryCategoryService { get; }
    }
}
