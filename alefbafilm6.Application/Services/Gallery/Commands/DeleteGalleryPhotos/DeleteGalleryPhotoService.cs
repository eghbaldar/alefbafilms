using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Gallery.Commands.DeleteGalleryPhotos
{
    public class DeleteGalleryPhotoService : IDeleteGalleryPhotoService
    {
        private readonly IDataBaseContext _context;
        public DeleteGalleryPhotoService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestDeleteGalleryPhotoServiceDto req)
        {
            try
            {
                alefbafilm6.Domain.Entities.Gallery.Gallery photo = new alefbafilm6.Domain.Entities.Gallery.Gallery();
                photo = _context.Gallery.Find(req.Id);
                if (photo != null)
                {
                    photo.DeleteTime = DateTime.Now;

                    string PathFile = @"wwwroot/images/gallery/" + photo.Filename;
                    if (System.IO.File.Exists(PathFile)) System.IO.File.Delete(PathFile);

                    _context.SaveChanges();

                    return new ResultDto
                    {
                        IsSuccess = true,
                        Message = "حذف با موفقیت انجام شد",
                    };
                }
                else
                {
                    return new ResultDto
                    {
                        IsSuccess = false,
                        Message = "این تصویر موجود نیست",
                    };
                }
            } catch(Exception ex)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "خطایی رخ داده است"
                };
            }
        }
    }
}
