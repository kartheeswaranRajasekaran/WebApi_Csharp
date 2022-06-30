using Employee_DetailsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Models
{
    public class EmployeeWebContxt : DbContext
    {
        public EmployeeWebContxt(DbContextOptions<EmployeeWebContxt> options) : base(options)
        {
            
        }
        public DbSet<Employee> EmployeeTable { get; set; }
    }
}
