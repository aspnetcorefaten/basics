using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vego.Model
{
    [Table("Models")]
    public class Model
    {
        public int id { get; set; }
        [Required]
        [MaxLength(225)]
        public string Name { get; set; }

        public int MakeId { get; set; }

        [ForeignKey("MakeId")]
        public virtual Make Make { get; set; }
    }
}
