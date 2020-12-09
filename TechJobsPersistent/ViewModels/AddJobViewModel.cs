using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public string[] SelectedSkills { get; set; }

        public List<SelectListItem> AllEmployers { get; set; }
        public List<Skill> AllSkills { get; set; }


        public AddJobViewModel() { }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            AllEmployers = new List<SelectListItem>();

            foreach (Employer employer in employers)
            {
                AllEmployers.Add(new SelectListItem
                {
                    Text = employer.Name,
                    Value = employer.Id.ToString()
                });
            }

            AllSkills = skills;
        }
    }
}
