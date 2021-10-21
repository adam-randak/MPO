using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPO.Models
{
  public class Posts
  {
    public int ID { get; set; }
    public int POST_PRICE { get; set; }
    public DateTime POST_CREATE_AT { get; set; }
    public DateTime POST_UPDATE_AT { get; set; }
    public string POST_TITLE { get; set; }
    public int POST_OWNER { get; set; }
    public int POST_DESCRIPTION { get; set; } //Relacja Description.cs
    public int POST_PHOTOS { get; set; } //Relacja Photos.cs
    public Boolean POST_PROMOTE { get; set; }
    public int POST_OBJECT { get; set; } //Relacja Car.cs
    public int POST_CATEGORY { get; set; } //Relacja BodyType.cs
  }
}
