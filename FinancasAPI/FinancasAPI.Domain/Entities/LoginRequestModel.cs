﻿using System;

namespace FinancasAPI.Domain.Entities
{
    public class LoginRequestModel
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
