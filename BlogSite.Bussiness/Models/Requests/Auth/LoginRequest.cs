﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Bussiness.Models.Requests.Auth
{
  public  class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsRemember { get; set; }
    }
}
