using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCampProject.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AddCommentPartial()
        {
            return PartialView();
        }

        public PartialViewResult CommentListOnBlog()
        {
            return PartialView();
        }
    }
}
