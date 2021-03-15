namespace EWSApplication.Entities.DBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Faculty")]
    public partial class Faculty
    {
        
        public int facultyid { get; set; }

        [Required]
        [StringLength(100)]
        public string facultyname { get; set; }

        public DateTime facultyear { get; set; }
    }
}
