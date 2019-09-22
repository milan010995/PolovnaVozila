 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Model
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [NotMapped]
        public Make Make { get; set; }

        public int MakeId { get; set; }
    }
}
