namespace Shop.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Photo")]
    public partial class Photo
    {
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid PhotoId { get; set; }

        [Required]
        public string PhotoURL { get; set; }

        public Guid ProductId { get; set; }

        public bool? PrimePhoto { get; set; }

        public virtual Product Product { get; set; }
    }
}
