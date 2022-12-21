using System.ComponentModel.DataAnnotations;

namespace MonitorApplication.Model
{
    public class MonitorApp
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
