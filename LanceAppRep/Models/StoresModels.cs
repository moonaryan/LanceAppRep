using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace LanceAppRep.Models
{

    public class Store
    {
        public string StoreName { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }


    }

    public class Coupons
    {
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }
}
