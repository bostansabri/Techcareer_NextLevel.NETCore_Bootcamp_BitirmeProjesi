﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TechSurvey.MVC.Areas.Admin.Models.DTOs
{
    public class UserCreateDTO
    {
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Role!")]
        public string? RoleId { get; set; }
        public ICollection<SelectListItem>? Roles { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Name!")]
        public string? Name { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Surname!")]
        public string? Surname { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Username!")]
        public string? UserName { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Email!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter Correct Email Format!")]
        public string Email { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select Email Confirmed!")]
        public bool EmailConfirmed { get; set; }
        //-----------------------------------------------------------------------
        public string? Gender { get; set; }
        //-----------------------------------------------------------------------
        [MaxLength(10, ErrorMessage = "Phone number must be 10 characters")]
        public string? PhoneNumber { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select Phone Number Confirmed!")]
        public bool PhoneNumberConfirmed { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select Two Factor Enabled!")]
        public bool TwoFactorEnabled { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Select Lockout Enabled!")]
        public bool LockoutEnabled { get; set; }
        //-----------------------------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Access Failed Count!")]
        public int AccessFailedCount { get; set; }
        //-----------------------------------------------------------------------
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Password!")]
        public string Password { get; set; }
        //-----------------------------------------------------------------------
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords Do Not Match!")]
        public string RePassword { get; set; }
        //-----------------------------------------------------------------------
    }
}
