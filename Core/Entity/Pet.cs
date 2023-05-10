using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Pet
    {
        public int Id { get; set; }
        public string  type { get; set; }
        public string  alias { get; set; }
        public string  character { get; set; }
        public string  size { get; set; }
        public string  friendliness { get; set; }
        public string  heatresistance { get; set; }
        public string  coldtolerance { get; set; }
        public string  detail { get; set; }

    }
}