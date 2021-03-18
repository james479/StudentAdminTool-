using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ScheduleAdminTool.DATA.EF
{


    #region CoursMetadata
    public class CoursMetadata
    {
        [Display(Name = "Course")]
        [Required(ErrorMessage = "*Course name required")]
        [StringLength(50, ErrorMessage = "*Must be 50 characteres or less")]
        public string CourseName { get; set; }

        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "*Course name required")]
        public string CourseDescription { get; set; }

        [Display(Name = "Credit Hours")]
        [Required(ErrorMessage = "*Numbner of credit hours required")]
        public byte CreditHours { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(250, ErrorMessage = "*Cirriculum must be 250 characters or less")]
        public string Cirriculum { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(500, ErrorMessage = "*Notes must be 500 characters or less")]
        public string Notes { get; set; }

        [Display(Name = "Active")]
        [Required(ErrorMessage = "*required")]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(CoursMetadata))]

    public partial class Cours
    {

    }
    #endregion

    #region EnrollmentMetadata

    public class EnrollmentMetadata
    {
        [Display(Name = "Enrollment Date")]
        [Required(ErrorMessage = "*Enrollment date required")]
        public System.DateTime EnrollmentDate { get; set; }
    }

    [MetadataType(typeof(EnrollmentMetadata))]

    public partial class Enrollment
    {

    }

    #endregion

    #region Instructor metadata
    public class InstructorMetadata
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "*First name required")]
        [StringLength(20, ErrorMessage = "*Must be 20 characteres or less")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "*Last name required")]
        [StringLength(20, ErrorMessage = "*Must be 20 characteres or less")]
        public string LastName { get; set; }
    }

    [MetadataType(typeof(InstructorMetadata))]
    public partial class Instructor
    {
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
    #endregion

    #region Scheduled Class metadata


    public class ScheduledClassMetadata
    {
        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "*Start date required")]
        public System.DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "*End date required")]
        public System.DateTime EndDate { get; set; }

        [Display(Name = "Instructor")]
        [Required(ErrorMessage = "*Instructor required")]
        public int InstructorId { get; set; }

        [Required(ErrorMessage = "*Location required")]
        [StringLength(20, ErrorMessage = "*Must be 20 characteres or less")]
        public string Loaction { get; set; }
    }

    [MetadataType(typeof(ScheduledClassMetadata))]

    public partial class ScheduledClass
    {

    }
    #endregion

    #region ScheduledClassStatus

    public class ScheduledClassStatusMetadata
    {
        [Display(Name = "Status Name")]
        [Required(ErrorMessage = "*Status name required")]
        [StringLength(50, ErrorMessage = "*Notes must be 50 characters or less")]
        public string SCSName { get; set; }
    }

    [MetadataType(typeof(ScheduledClassStatusMetadata))]

    public partial class ScheduledClassStatus
    {

    }
    #endregion

    #region Student Metadata

    public class StudentMetadata
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "*First name required")]
        [StringLength(20, ErrorMessage = "*Must be 20 characteres or less")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "*Last name required")]
        [StringLength(20, ErrorMessage = "*Must be 20 characteres or less")]
        public string LastName { get; set; }

        [Display(Name = "Major")]
        [StringLength(15, ErrorMessage = "*Must be 15 characteres or less")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        public string Major { get; set; }

        [Display(Name = "Address")]
        [StringLength(50, ErrorMessage = "*Must be 50 characteres or less")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        public string Address { get; set; }

        [Display(Name = "City")]
        [StringLength(25, ErrorMessage = "*Must be 25 characteres or less")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        public string City { get; set; }

        [Display(Name = "State")]
        [StringLength(2, ErrorMessage = "*Must be 2 characteres or less")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(25, ErrorMessage = "*Must be 10 characteres or less")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        public string ZipCode { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(15, ErrorMessage = "*Must be 15 characteres or less")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        public string Phone { get; set; }

        [Display(Name = "Email Address")]
        [StringLength(25, ErrorMessage = "*Must be 60 characteres or less")]
        [Required(ErrorMessage = "*An email address is required")]
        public string Email { get; set; }

        [Display(Name = "Image")]
        [StringLength(100, ErrorMessage = "*Must be 100 characteres or less")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        public string PhotoUrl { get; set; }

        [Display(Name = "SS ID")]
        [Required(ErrorMessage = "*SS ID is required")]
        public int SSID { get; set; }
    }

    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
        [Display(Name = "Name")]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }


    #endregion

    #region Student Status
    public class StudentStatusMetadata
    {
        [Display(Name = "Student Status Name")]
        [StringLength(30, ErrorMessage = "*Must be 30 characteres or less")]
        [Required(ErrorMessage = "*SS Name is required")]
        public string SSName { get; set; }

        [Display(Name = "Student Status Description")]
        [StringLength(250, ErrorMessage = "*Must be 250 characteres or less")]
        public string SSDescription { get; set; }
    }
    [MetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus
    {

    }

    #endregion

}
