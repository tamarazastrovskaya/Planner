using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Entity
{ [Table("cotegories")]
    class Category
    {
        [Column("id")]
        public int id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Discription")]
        public string Discription { get; set; }
    }
}
