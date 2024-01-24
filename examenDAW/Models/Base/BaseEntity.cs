using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace examenDAW.Models.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
