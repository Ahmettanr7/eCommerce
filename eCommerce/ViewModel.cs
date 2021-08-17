using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerce.Models.Entity;
using PagedList;
using PagedList.Mvc; 


namespace eCommerce
{
    public class ViewModel
    {
        public List<items> ItemList { get; set; }

        public List<category1> CategoryList { get; set; }
    }
}