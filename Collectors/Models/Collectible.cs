using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collectors.Models
{
    public class Collectible
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(55)]
        public string Name { get; set; }
        [MaxLength(4000)]
        public string Description { get; set; }

        public DateTime CollectedDate { get; set; }

        public Collectible()
        {
            this.CollectedDate = DateTime.UtcNow;
        }

        public int CollectionId { get; set; }
        public Collection Collection { get; set; }
    }
}