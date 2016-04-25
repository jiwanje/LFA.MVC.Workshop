namespace LFA.EF.CodeFirst.Workshop.test.Models.NewFolder2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sales.vSalesSummaryCustomerProduct")]
    public partial class vSalesSummaryCustomerProduct
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesOrderID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        public int? TotalOrderQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalValue { get; set; }

        public long? CountLines { get; set; }
    }
}
