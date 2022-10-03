namespace Lab.Ejercicio005.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerOrder(Customers newCustomer, Orders newOrder)
        {
            Customer = newCustomer;
            Order = newOrder;
        }
        public CustomerOrder()
        {
            
        }
        public Customers Customer { get; private set; }
        public Orders Order { get; private set; }
    }
}
