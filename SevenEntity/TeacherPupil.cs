namespace ConsoleApp6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeacherPupil")]
    public partial class TeacherPupil
    {
        public int Id { get; set; }

        public int TeacherId { get; set; }

        public int PupilId { get; set; }

        public virtual Pupil Pupil { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
