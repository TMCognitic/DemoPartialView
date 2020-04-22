using DemoPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //récupération des posts de ma DB
            IEnumerable<Post> posts = new List<Post>(
                new Post[]
                {
                    new Post() { Id = 1, Title = "Demo Partial View", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer elit nunc, tristique at justo ac, pharetra eleifend nulla. Duis malesuada viverra aliquet. Sed malesuada nisi nec suscipit rhoncus. Suspendisse metus diam, semper vitae accumsan et, dictum in sem. Fusce ut dui nec arcu eleifend rutrum at aliquam lorem. Nam consequat dictum volutpat. Vivamus vehicula nulla tempus, varius odio vehicula, pellentesque arcu. Curabitur ut lacus eget diam ultricies efficitur. ", PostDate = DateTime.Now.AddDays(-2) },
                    new Post() { Id = 2, Title = "Demo Partial View 2", Content = "Vestibulum malesuada lacus a tellus scelerisque iaculis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum imperdiet augue nibh, non consectetur ante accumsan id. Nullam risus libero, sagittis ut mollis mollis, tincidunt sed lectus. Nulla aliquam erat non magna pretium, vel pulvinar diam gravida. Aliquam erat volutpat. Nunc et nulla auctor, elementum sem non, mollis justo. Curabitur a sapien non ante placerat pretium. Ut varius tincidunt neque sit amet volutpat. Donec accumsan tincidunt congue. Suspendisse feugiat massa diam, vel maximus diam efficitur vitae. Nullam ut massa elementum, consectetur ipsum in, consectetur tellus.", PostDate = DateTime.Now.AddDays(-1) },
                    new Post() { Id = 3, Title = "Demo Partial View 3", Content = "Mauris lacinia magna vel justo auctor, sit amet facilisis lorem elementum. Quisque magna metus, cursus id rhoncus vel, venenatis eu libero. Donec vulputate, nibh et sollicitudin gravida, eros tortor aliquet mauris, in commodo purus metus vel erat. Proin nec nulla volutpat, egestas urna ut, porttitor tortor. In hac habitasse platea dictumst. Vestibulum mollis elementum ante in tempus. Suspendisse id ipsum hendrerit, imperdiet sem eget, iaculis magna. Aliquam commodo purus vehicula magna porta luctus. Fusce posuere purus at commodo semper. Nam sit amet tempus ipsum, sagittis ullamcorper ante. Duis in metus lectus. Integer mollis nunc sem, ut congue neque vehicula eu. Cras varius sapien a feugiat ultricies. ", PostDate = DateTime.Now },
                });

            //La partial view est la vue "Post.cshtml"
            //Cette dernière n'étant utilisée que dans le controller home, je l'ai mise dans le répertoire Views/Home
            //Si cette dernière devrait être utilisée dans plusieurs controlleurs, je la mettrait dans Views/Shared

            return View(posts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}