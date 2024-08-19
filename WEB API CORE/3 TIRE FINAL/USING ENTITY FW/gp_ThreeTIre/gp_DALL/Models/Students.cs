using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp_DALL.Models
{
    [Table("gp_students")]
    public  class Students
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public string NAME { get; set; }    

        public double SALARY { get; set; }
    }
}
