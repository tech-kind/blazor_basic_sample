﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorBasicSample.EditForm
{
    public class PasswordModel
    {
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "パスワードが一致しません。")]
        public string ConfirmPassword { get; set; }
    }
}
