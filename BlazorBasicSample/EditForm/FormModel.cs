﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorBasicSample.EditForm
{
    public class FormModel
    {
        [Required(ErrorMessage = "名前は入力必須です。")]
        [MinLength(3), MaxLength(20)]
        public string Name { get; set; }

        public DateTime Birthday { get; set; } = DateTime.Today;

        [Range(0, 100, ErrorMessage = "年齢は0～100の間で入力してください。")]
        public int Age { get; set; }

        public GenderType Gender { get; set; }

        public string Profile { get; set; }

        public Prefecture Prefecture { get; set; }
    }
}