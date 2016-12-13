namespace WCFServiceWebRole1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Temp
    {
        public int Id { get; set; }

        public int Temparature { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
