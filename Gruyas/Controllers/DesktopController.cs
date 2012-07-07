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
    public class DesktopController : System.Web.Mvc.Controller
    {
        //
        // GET: /Desktop/

        public ActionResult Index()
        {
            return View();
        }
        [DirectMethod(ShowMask = true)]
        public ActionResult NewFolder(string FolderName, string type)
        {
            string FolderIcon="FolderDefaultIcon";
            switch (type) {
                case "Default":
                    FolderIcon = "FolderDefaultIcon";
                break;
                case "Shared":
                    FolderIcon = "FolderSharedIcon";
                break;
                case "Course":
                    FolderIcon = "FolderCourseIcon";
                break;
                case "Favourite":
                FolderIcon = "FolderFavouriteIcon";
                break;
                case "Images":
                FolderIcon = "FolderImagesIcon";
                break;
                case "Videos":
                FolderIcon = "FolderVideosIcon";
                break;
                case "MyPC":
                FolderIcon = "FolderVirtualUserHDDIcon";
                break;
            }
            AjaxResult r = new AjaxResult();
            Desktop desktop = X.GetCmp<Desktop>("Desktop1");
            var folder = new DesktopModule
            {
                ModuleID = FolderName,
                Shortcut = new DesktopShortcut
                {
                    Name = FolderName,
                    IconCls = FolderIcon,
                    X = "150",
                    Y = "30"
                },
                //Launcher = new Ext.Net.MenuItem
                //{
                //    Text = "Dynamic module"
                //},
                Window = 
                {
                    new Window 
                    { 
                        Title = FolderName,
                        Width = 500,
                        Height = 500,
                        DefaultRenderTo = Ext.Net.DefaultRenderTo.Form,
                        Icon = Icon.ApplicationAdd                    
                    }
                },
            };
            desktop.AddModule(folder);
            return r;
        }
    }
}
