using alefbafilm6.Application.Services.Gallery.Commands.PostGallery;
using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace alefbafilm6.Application.Services.Staff.Commands.PostStaff
{
    public class PostStaffService : IPostStaffService
    {
        private readonly IDataBaseContext _context;
        public PostStaffService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestPostStaffServiceDto req)
        {
            try
            {
                alefbafilm6.Domain.Entities.Staffs.Staff staff = new alefbafilm6.Domain.Entities.Staffs.Staff();
                staff.Name = req.Name;
                staff.Title = req.Title;
                staff.Detail = req.Detail;

                var file = UploadFile(req.File);
                if (file.Status)
                {
                    staff.File = file.FileName;
                }
                else
                {
                    return new ResultDto
                    {
                        IsSuccess = false,
                        Message = "مشکلی در آپلود فایل بوجود آماده است، لطفا دوباره اقدام کنید.",
                    };
                }

                _context.Staff.Add(staff);
                _context.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "با موفقیت این کارمند درج شد",
                };
            } catch (Exception ex)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "خطایی رخ داده است"
                };
            }
        }
        private UploadDto UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return new UploadDto
                {
                    Status = false,
                    FileName = "",
                    Id = 0,
                };
            }

            string folder = $@"wwwroot\images\staff\";
            var uploadRootFolder = Path.Combine(Environment.CurrentDirectory, folder);
            if (!Directory.Exists(uploadRootFolder))
            {
                Directory.CreateDirectory(uploadRootFolder);
            }

            string filename = DateTime.Now.Ticks.ToString() + file.FileName;
            var filePath = Path.Combine(uploadRootFolder, filename);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return new UploadDto
            {
                Status = true,
                FileName = filename,
                Id = 0,
            };
        }
    }

}
