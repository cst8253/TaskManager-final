using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager;

[Table("List")]
public class List
{
      [Key]
      public int Id { get; set; }
      
      [ForeignKey("Item")]
      public int ItemId { get; set; }
      [ForeignKey("Category")]
      public int CategoryId { get; set; }
}