using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Gallery.Commands.DeleteGalleryCategory
{
    public class DeleteGalleryCategoryService : IDeleteGalleryCategoryService
    {
        private readonly IDataBaseContext _context;
        public DeleteGalleryCategoryService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestDeleteGalleryCategoryServiceDto req)
        {
            try
            {
                var galleryCategory = _context.GalleryCategory.Find(req.Id);
                if (galleryCategory == null)
                {
                    return new ResultDto()
                    {
                        IsSuccess = false,
                        Message = "دسته مورد نظر یافت نشد",
                    };
                }

                _context.GalleryCategory.Remove(galleryCategory);
                _context.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "دسته مورد نظر با موفقیت حذف شد",
                };
            } catch (Exception ex)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "خطایی رخ داده است"
                };
            }
        }
    }
}
