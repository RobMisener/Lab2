using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductController : Controller
    {

        // GET: Products/Index/
        public string Index()
        {
            string message =
                HttpUtility.HtmlEncode("Product/Index is displayed");
            return message;
        }

        // GET: Products/Browse
        public string Browse()
        {
            string message =
                HttpUtility.HtmlEncode("Product/Index is displayed");
            return message;
        }

        // GET: Products/Details/105
        public string Details(int id)
        {
            string message =
                HttpUtility.HtmlEncode("Details displayed for Id = " + id);
            return message;
        }

        // GET: Products/Location? zip = 44124
        public string Location()
        {
            return "location displayed for " + Request.QueryString["zip"].ToString() + "44124";
        }
    }
}