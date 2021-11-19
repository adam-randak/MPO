using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MPOnew.Entities
{
    public class Post
    {
        
        public int ID { get; set; }
        public int HEADER_ID { get; set; }
        public virtual Post_Header HEADER {get;set;}
        public string VIN { get; set; }
        public string CONDITION { get; set; }
        public Boolean FIRST_OWNER { get; set; }
        public DateTime FIRST_REGISTERED { get; set; }
        public string COUNTRY_OF_ORIGIN { get; set; }
        public string COLOR { get; set; }
        public int SEATS { get; set; }
        public int DOORS { get; set; }
        public string DRIVE { get; set; }
        public string GEARBOX { get; set; }
        public int POWER_HORSES { get; set; }
        public string FUEL { get; set; }
        public int MILES { get; set; }
        public DateTime YEAR { get; set; }
        public int BODY_TYPE { get; set; } 
        public string ENGINE_DISPLACMENT { get; set; }
        public string BRAND { get; set; }
        public string MODEL { get; set; }
        public string DESCRIPTION { get; set; }
        public List<Photo> PHOTOS { get; set; }
    }
}
