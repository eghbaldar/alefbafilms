using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Gallery.Commands.DeleteGalleryCategory;
using alefbafilm6.Application.Services.Gallery.Commands.PostGalleryCategory;
using alefbafilm6.Application.Services.Gallery.Commands.UpdateGalleryCategory;
using alefbafilm6.Application.Services.Gallery.Queries.GetGalleryCategory;
using alefbafilms.application.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Gallery.FacadePattern
{
    public class GalleryFacade: IGalleryFacade
    {
        ////////////////////////////////////////////////////////// Context
        private readonly IDataBaseContext _context;
        public GalleryFacade(IDataBaseContext context)
        {
            _context = context;
        }
        ////////////////////////////////////////////////////////// 
        private PostGalleryCategoryService _postGalleryCategoryService;
        public PostGalleryCategoryService PostGalleryCategoryService
        {
            get { return _postGalleryCategoryService = _postGalleryCategoryService ?? new PostGalleryCategoryService(_context); }
        }
        ////////////////////////////////////////////////////////// 
        private GetGalleryCategoryService _getGalleryCategoryService;
        public GetGalleryCategoryService GetGalleryCategoryService
        {
            get { return _getGalleryCategoryService = _getGalleryCategoryService ?? new GetGalleryCategoryService(_context); }
        }
        //////////////////////////////////////////////////////////
        private DeleteGalleryCategoryService _deleteGalleryCategoryService;
        public DeleteGalleryCategoryService DeleteGalleryCategoryService
        {
            get { return _deleteGalleryCategoryService = _deleteGalleryCategoryService ?? new DeleteGalleryCategoryService(_context); }
        }
        //////////////////////////////////////////////////////////
        private UpdateGalleryCategoryService _updateGalleryCategoryService;
        public UpdateGalleryCategoryService UpdateGalleryCategoryService
        {
            get { return _updateGalleryCategoryService=_updateGalleryCategoryService?? new UpdateGalleryCategoryService(_context); }
        }
        //////////////////////////////////////////////////////////
    }
}
