using alefbafilm6.Application.Services.Gallery.Commands.PostGallery;
using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;
using Microsoft.AspNetCore.Http;

namespace alefbafilm6.Application.Services.Staff.Commands.UpdateStaff
{
    public class UpdateStaffService : IUpdateStaffService
    {
        private readonly IDataBaseContext _context;
        public UpdateStaffService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestUpdateStaffServiceDto req)
        {
            alefbafilm6.Domain.Entities.Staffs.Staff staff = new alefbafilm6.Domain.Entities.Staffs.Staff();
            staff = _context.Staff.Find(req.Id);
            if (staff != null)
            {
                staff.Name = req.Name;
                staff.Title = req.Title;
                staff.Detail = req.Detail;

                //if client doesn't want to change staff's photo
                if(req.File!= null)
                    staff.File = Upload(staff.File, req.File).FileName;
                //end

                _context.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "تغییرات با موفقیت اعمال شد",
                };
            }
            else
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کارمندی یافت نشد",
                };
            }
        }
        private UploadDto Upload(string OldFile, IFormFile NewFile)
        {
            string FilePath = @"wwwroot/images/staff/" + OldFile;
            if (System.IO.File.Exists(FilePath))
            {
                System.IO.File.Delete(FilePath);
                string renameNewFile = DateTime.Now.Ticks.ToString() + NewFile.FileName;
                var uploadRootFolder = Path.Combine(Environment.CurrentDirectory, $@"wwwroot\images\staff\");
                var filePath = Path.Combine(uploadRootFolder, renameNewFile);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    NewFile.CopyTo(fileStream);
                }
                return new UploadDto
                {
                    Id = 0,
                    FileName = renameNewFile,
                    Status = true,
                };
            }
            else
            {
                return new UploadDto
                {
                    Id = 0,
                    FileName = OldFile,
                    Status = false,
                };
            }           
        }
    }
}
