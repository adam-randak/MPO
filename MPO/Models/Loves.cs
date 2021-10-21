using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPO.Models
{
  public class Loves
  {
    public int ID { get; set; }
    public int USER_ID { get; set; } //Relacja Users.cs
    public string POST_ID { get; set; } //Zbiór ID w formie string z Posts.cs

  }
}
