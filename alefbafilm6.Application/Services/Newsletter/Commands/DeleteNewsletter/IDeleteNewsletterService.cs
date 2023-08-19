using alefbafilms.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Newsletter.Commands.DeleteNewsletter
{
    public interface IDeleteNewsletterService
    {
        ResultDto Execute(RequestDeleteNewsletterServiceDto req);
    }


}
