using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPO.Entities
{
    public class Post_Header
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public int PRICE { get; set; }
        public int PHOTO_ID { get; set; }
        public virtual Photo MAIN_PHOTO {get; set;}
    }
}
