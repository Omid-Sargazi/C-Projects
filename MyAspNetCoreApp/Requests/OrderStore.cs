using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyAspNetCoreApp.Models;

namespace MyAspNetCoreApp.Requests
{
    public static class OrderStore
    {
        public static List<Order> orders {get;}=new();
    }
}