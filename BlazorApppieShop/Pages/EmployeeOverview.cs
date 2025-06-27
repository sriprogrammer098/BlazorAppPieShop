using BlazorAppPieShop.Shared;
using System.Collections;
using System.Collections.Generic;

namespace BlazorApppieShop.Pages
{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee> Employees { get; set; }
        public List<Country> Countries { get; set; }
        public List<JobCategory> JobCategories { get; set; }

        private void InitializeJobCategories()
        {
            JobCategories = new List<JobCategory>()
            { new JobCategory{JobCategoryId = 1, JobCategoryName = "Pie research"},
              new JobCategory{JobCategoryId = 2, JobCategoryName = "Sales"},
              new JobCategory{JobCategoryId = 3, JobCategoryName = "Management"},
              new JobCategory{JobCategoryId = 4, JobCategoryName = "Store Staff"},

            };
        }

    }
}
