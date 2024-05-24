﻿using AdminPortal.Helpers;
using System.ComponentModel.DataAnnotations;

namespace AdminPortal.Models
{
    public class DeleteFormModel
    {
        [CheckBoxRequired(ErrorMessage = "You must confirm that you want to delete your account.")]
        [Required(ErrorMessage = "You must confirm that you want to delete your account.")]

        public bool ConfirmDelete { get; set; } = false;

        public string? AvoidBug { get; set; }
    }
}
