using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Contact.Commands.PostContact;
using alefbafilm6.Application.Services.Contact.Commands.UpdateContact;
using alefbafilm6.Application.Services.Contact.Queries.GetContact;
using alefbafilms.application.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Contact.FacadePattern
{
    public class ContactPattern : IContactFacade
    {
        // Context
        private readonly IDataBaseContext _context;
        public ContactPattern(IDataBaseContext context)
        {
            _context = context;
        }

        //////////////////////////////////////////////////// Post Contact
        private PostContactService _postContactService;
        public PostContactService PostContactService
        {
            get { return _postContactService = _postContactService ?? new PostContactService(_context); }
        }
        //////////////////////////////////////////////////// Get Contact
        private GetContactService _getContactService;
        public GetContactService GetContactService
        {
            get { return _getContactService = _getContactService ?? new GetContactService(_context); }
        }
        ////////////////////////////////////////////////////  Update Contact
        private UpdateContactService _updateContactService;
        public UpdateContactService UpdateContactService
        {
            get { return _updateContactService = _updateContactService ?? new UpdateContactService(_context); }
        }
        ////////////////////////////////////////////////////
    }
}
