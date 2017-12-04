namespace Shop.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cart()
        {
            OrderPos = new HashSet<OrderPos>();
        }
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid CartId { get; set; }

        [Required]
        [StringLength(128)]
        public string AspNetUserId { get; set; }

        public DateTime DateCreate { get; set; }

        public Guid? CartStatusId { get; set; }

        public Guid? DeliveryMethodId { get; set; }

        public string DeliveryDescription { get; set; }

        public virtual CartStatu CartStatu { get; set; }

        public virtual DeliveryMethod DeliveryMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderPos> OrderPos { get; set; }
    }
}
