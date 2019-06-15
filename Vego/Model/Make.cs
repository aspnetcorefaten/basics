using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vego.Model
{
    [Table("Makes")]
    public class Make
    {
        public Make()
        {
            Models = new Collection<Model>();
        }
        public int id { get; set; }

        [Required]
        [MaxLength(225)]
        public String Name { get; set; }

        public virtual ICollection<Model> Models { get; set; }
    }
}
