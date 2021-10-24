using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }
    
    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }
}