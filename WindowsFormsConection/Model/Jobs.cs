using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsConection
{
    public class Jobs
    {
        public int? id { get; set; }
        public string jobTitle { get; set; }
        public decimal? min_salary { get; set; }

        public decimal? max_salary { get; set; }

        public Jobs(int? id, string jobsTitle, decimal? min_salary, decimal? max_salary)
        {
            this.id = id;
            this.jobTitle = jobsTitle;
            this.min_salary = min_salary;
            this.max_salary = max_salary;
        }
    }
}
