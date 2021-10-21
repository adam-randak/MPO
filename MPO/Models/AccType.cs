using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPO.Models
{
  public class AccType
  {
    public int ID { get; set; }
    public string TYPE_NAME { get; set; }
    public Boolean ADMIN_ACCESS { get; set; }
    public Boolean CREATE { get; set; }
    public Boolean UPDATE { get; set; }
    public Boolean READ { get; set; }
    public Boolean DELETE { get; set; }
  }
}
