using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Single_Page_Applicaton.Models
{
    [Table("Emp")]
    public class Employee
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int EmpNo { set; get; }

        public string EmpName { set; get; }

        public decimal EmpSalary { get; set; }

    }
}