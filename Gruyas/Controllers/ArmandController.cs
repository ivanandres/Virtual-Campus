using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext;
using Ext.Net;
using Ext.Net.MVC;
using Gruyas.Models;
using Gruyas;
using System.Web.Routing;
using System.Web.Security;

namespace Gruyas.Controllers
{
    public class ArmandController : Controller
    {
        //
        // GET: /Armand/ paciencia

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HelloWorld()
        {
            string script = X.Msg.Alert("DirectEvent", "Hello World!").ToScript();
            return new AjaxResult(script);
        }
    }
}
