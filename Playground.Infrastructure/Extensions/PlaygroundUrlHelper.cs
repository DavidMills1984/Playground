using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Playground.Infrastructure
{
    public static class PlaygroundUrlHelper
    { 
        public static string CurrentController(this UrlHelper urlHelper)
        {
            var routeValueDictionary = urlHelper.RequestContext.RouteData.Values;
            return routeValueDictionary["controller"].ToString();
        }

        public static string CurrentAction(this UrlHelper urlHelper)
        {
            var routeValueDictionary = urlHelper.RequestContext.RouteData.Values;
            return routeValueDictionary["action"].ToString();
        }
        
    }
}