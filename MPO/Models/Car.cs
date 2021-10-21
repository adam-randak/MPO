using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPO.Models
{
  public class Car
  {
    public int ID { get; set; }
    public string VIN { get; set; }
    public string CONDITION { get; set; }
    public Boolean FIRST_OWNER { get; set; }
    public DateTime REGISTERED { get; set; }
    public string COUNTRY { get; set; }
    public string COLOR_TYPE { get; set; }
    public string COLOR { get; set; }
    public int SEATS { get; set; }
    public int DOORS { get; set; }
    public string DRIVE { get; set; }
    public string GEARBOX { get; set; }
    public int HORSES { get; set; }
    public int POWER { get; set; }
    public string VERSION { get; set; }
    public string FUEL { get; set; }
    public int MILES { get; set; }
    public DateTime YEAR { get; set; }
    public int BODY_TYPE { get; set; } //Relacja z modelem BodyType.cs - wykorzystana jako kategoria
    public string ENGINE { get; set; }
    public string BRAND { get; set; }
    public string MODEL { get; set; }

  }
}
