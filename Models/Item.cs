using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager;
[Table("Item")]
public class Item
{
    [Key]
    public int Id { get; set; }
    public string Task { get; set; } = "";
    public bool IsComplete { get; set; } = false;
    [NotMapped]
    public List<CheckboxItem> Categories { get; set; } = [];  
}