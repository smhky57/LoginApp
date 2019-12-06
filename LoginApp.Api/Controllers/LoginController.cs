using LoginApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoginApp.Api.Controllers
{
    public class LoginController : BaseController
    {
        [HttpPost]
        public string Post([FromBody]User model)
        {
            var item = unit.UserRepo.FirstOrDefault(x => x.UserName == model.UserName);
            if (item != null)
            {
                if (item.Stat == 1)
                {

                    var hashedPassword = service.Register(model.Password);
                    if (hashedPassword == item.Password)
                    {
                        item.lastLogintime = DateTime.Now;

                        unit.UserRepo.Update(item);
                        unit.Save();

                        return "Success";

                    }
                    else
                    {
                        item.errorLoginCount++;
                        if (item.errorLoginCount == 3)
                            item.Stat = 2;

                        unit.UserRepo.Update(item);
                        unit.Save();

                        return "Password is incorrect!";
                    }

                }
                else if (item.Stat == 2)
                {
                    return "Your account is blocked!";

                }
                else
                {
                    return "Your account has been canceled!";

                }
            }
            else
            {
                return "User is not found!";
            }
        }
    }
}
