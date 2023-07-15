using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//=================================================================
//=================================================================
// What does this class do?
// In most of time we need to call a class as DTO for returning repeated properties, so instead of defining repated
// properties we can just call these classes!
//=================================================================
//=================================================================
namespace alefbafilms.Common.Dtos
{
    public class ResultDto
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
    public class ResultDto<T>
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
    }

}
