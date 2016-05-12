using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntityFramework
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Column("Gender")]
        [MaxLength(50)]
        public string Gender { get; set; }
    }
}
