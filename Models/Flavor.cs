using Microsoft.AspNetCore.Mvc;
using FactoryTreats.Models;
using System.Collections.Generic;
using System.Linq;

namespace FactoryTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public virtual ApplicationUser User { get; set; }
    
    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}
