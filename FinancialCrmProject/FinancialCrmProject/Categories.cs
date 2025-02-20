using System.Collections.Generic;

namespace FinancialCrmDb
{
    public partial class Categories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categories()
        {
            this.Spendings = new HashSet<Spendings>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Spendings> Spendings { get; set; }
    }
}