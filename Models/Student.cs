using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NewProject.Models;
public class Student
{
    [Key]
    public int StudentId { get; set; }

    [Required]
    [MaxLength(100)]
    public string StudentName { get; set; }

    [Required]
    [MaxLength(50)]
    public string HallTicketNumber { get; set; }

    [Required]
    [MaxLength(100)]
    public string CourseName { get; set; }

    [Required]
    [MaxLength(100)]
    public string SubjectName { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal InternalMarksMaximum { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal InternalMarksSecured { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal SemesterMarksMaximum { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal SemesterMarksSecured { get; set; }
}
