using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Staff.Commands.DeleteStaff
{
    public class DeleteStaffService : IDeleteStaffService
    {
        private readonly IDataBaseContext _context;
        public DeleteStaffService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestDeleteStaffDto req)
        {
            alefbafilm6.Domain.Entities.Staffs.Staff staff = new Domain.Entities.Staffs.Staff();
            staff = _context.Staff.Find(req.Id);
            if (staff != null)
            {
                staff.DeleteTime= DateTime.Now;

                string filePath = @"wwwroot/images/staff/" + staff.File;
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }
                
                _context.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "حذف با موفقیت انجام شد.",
                };
            }
            else
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کارمندی یافت نشد.",
                };
            }

        }
    }

}
