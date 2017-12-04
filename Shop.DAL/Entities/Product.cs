namespace Shop.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderPos = new HashSet<OrderPos>();
            Photos = new HashSet<Photo>();
        }
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        public Guid CategoryId { get; set; }

        public string ProductDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public DateTime DateCreate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Stockpile { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderPos> OrderPos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
