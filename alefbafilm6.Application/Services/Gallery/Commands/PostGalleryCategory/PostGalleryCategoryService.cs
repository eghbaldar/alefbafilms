using alefbafilm6.Domain.Entities.Gallery;
using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Gallery.Commands.PostGalleryCategory
{
    public class PostGalleryCategoryService : IPostGalleryCategory
    {
        private readonly IDataBaseContext _context;
        public PostGalleryCategoryService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultPostGalleryCategoryDto> Execute(RequestPostGalleryCategoryDto req)
        {
            GalleryCategory galleryCategory = new GalleryCategory();
            galleryCategory.Name = req.Name;
            _context.GalleryCategory.Add(galleryCategory);
            _context.SaveChanges();

            return new ResultDto<ResultPostGalleryCategoryDto>
            {
                Data = new ResultPostGalleryCategoryDto
                {
                    Id = galleryCategory.Id,
                },
                IsSuccess = true,
                Message = "دسته گالری با موفقیت درج شد - The New Gallery Category Was Added Succesfully!",
            };

        }
    }
}
