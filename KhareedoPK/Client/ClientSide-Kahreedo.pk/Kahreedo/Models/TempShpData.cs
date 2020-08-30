using eCommerceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceApp.Models
{
    public static class TempShpData
    {
        public static int UserID { get; set; }
        public static List<OrderDetail> items { get; set; }
    }
}