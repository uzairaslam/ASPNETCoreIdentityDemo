﻿using Microsoft.AspNetCore.Identity;

namespace ASPNETCoreIdentityDemo.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string? Description { get; set; }
    }
}
