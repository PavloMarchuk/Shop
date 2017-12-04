namespace Shop.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderPos
    {
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid OrderPosId { get; set; }

        public Guid CartId { get; set; }

        public Guid ProductId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ProductCount { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual Product Product { get; set; }
    }
}
