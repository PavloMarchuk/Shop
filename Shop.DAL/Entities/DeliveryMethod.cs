namespace Shop.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeliveryMethod")]
    public partial class DeliveryMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeliveryMethod()
        {
            Carts = new HashSet<Cart>();
        }
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid DeliveryMethodId { get; set; }

        [Required]
        [StringLength(128)]
        public string DeliveryMethodName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
