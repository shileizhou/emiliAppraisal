﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace emiliAppraisal
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "InventoryRoute",
                routeTemplate: "inventory/{id}",
                defaults: new { controller = "Referrals", action = "GetReferrals", 
                                id = RouteParameter.Optional});

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}
