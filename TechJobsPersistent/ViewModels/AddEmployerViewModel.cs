using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Employer name  required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employer location  required.")]
        public string Location { get; set; }

        public AddEmployerViewModel()
        {
        }
    }
}