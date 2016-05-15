using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersBasic.Controllers
{
    public class MyController:IController
    {
        public void Execute(System.Web.Routing.RequestContext requestContext)
        {
            string ip = requestContext.HttpContext.Request.UserHostAddress;
            HttpResponseBase response = requestContext.HttpContext.Response;
            response.Write(String.Format("<h2>Ваш ip: {0}</h2>", ip));
        }
    }
}