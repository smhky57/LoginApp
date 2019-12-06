using LoginApp.Bussiness.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoginApp.Api.Controllers
{
    public class BaseController : ApiController
    {
        internal UnitOfWork unit;
        internal PasswordHashService service;
        public BaseController()
        {
            unit = new UnitOfWork();
            service = new PasswordHashService();
        }
    }
}
