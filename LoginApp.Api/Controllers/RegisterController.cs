using LoginApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;

namespace LoginApp.Api.Controllers
{
    public class RegisterController : BaseController
    {
        [HttpPost]
        public HttpResponseMessage Post([FromBody]User model)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            if (unit.UserRepo.AnyWithQuery(x => x.UserName == model.UserName))
                 response = Request.CreateResponse(HttpStatusCode.BadRequest, "This UserName is used!");
            else
                response = Request.CreateResponse(HttpStatusCode.OK, "Success"); ;

            var hashedPassword = service.Register(model.Password);

            model.Password = hashedPassword;
            unit.UserRepo.Add(model);
            unit.Save();

            return response;
        }

    }
}
