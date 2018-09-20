using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Utils
{
    public class PageUtils
    {
        public static void ReloadPage(Page P)
        {
            P.Response.Redirect(P.Request.Url.ToString(), true);
        }
    }
}