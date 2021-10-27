using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MPO.Entities
{
    public class Photo

    {
        public int ID { get; set; }
        public byte[] IMG { get; set; }
    }
}
