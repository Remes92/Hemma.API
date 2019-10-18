using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemma.Entities.Entities
{
    [Table("Persons")]
    public class Person
    {
        public Person() { }   
        [Key]
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    }
}
