using Microsoft.Build.Framework;

namespace BirtdayApplication.Models
{
    public class InviteModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public bool? State { get; set; }
    }
}
