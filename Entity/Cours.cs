//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Entity
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Cours
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cours()
        {
            this.CourseStudents = new HashSet<CourseStudent>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Select Department")]
        [Range(1, int.MaxValue, ErrorMessage = "Select Department")]
        public int DeptId { get; set; }

        [Required(ErrorMessage = "Course Name")]
        public string CourseName { get; set; }

        public virtual Dept Dept { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseStudent> CourseStudents { get; set; }
    }
}
