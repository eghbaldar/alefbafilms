﻿using alefbafilm6.Application.Services.Pages.Commands.PostAboutPage;
using alefbafilm6.Application.Services.Pages.Queries.GetAboutPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Interfaces.FacadePattern
{
    public interface IPagesFacade
    {
        UpdateAboutPageService UpdateAboutPageService { get; }
        GetAboutPageService GetAboutPageService { get; }
    }
}
