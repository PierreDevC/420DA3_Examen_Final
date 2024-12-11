using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.Business.Domain;
public class Cours
{
    public const int CourseCodeMaxLength = 16;
    public const int CourseTitleMaxLength = 256;

    private string courseCode = null!;
    private string courseTitle = null!;

    public int Id { get; set; }
    public string CourseCode
    {
        get { return this.courseCode; }
        set
        {
            if (value.Length > CourseCodeMaxLength)
            {
                throw new ArgumentException(nameof(this.CourseCode), $"Le code de cours ne peut dépasser {CourseCodeMaxLength} caractères.");
            }
            this.courseCode = value;
        }
    }
    public string CourseTitle
    {
        get { return this.courseTitle; }
        set
        {
            if (value.Length > CourseTitleMaxLength)
            {
                throw new ArgumentException(nameof(this.CourseTitle), $"Le titre de cours ne peut dépasser {CourseTitleMaxLength} caractères.");
            }
            this.courseTitle = value;
        }
    }
    public byte[] RowVersion { get; set; } = null!;

    public virtual List<Etudiant> EtudiantInscrits { get; set; } = new List<Etudiant>();

    public Cours()
    {

    }

    protected Cours(int id, string courseCode, string courseTitle, byte[] rowVersion)
    {
        this.Id = id;
        this.CourseCode = courseCode;
        this.CourseTitle = courseTitle;
        this.RowVersion = rowVersion;
    }

    public override string ToString()
    {
        return $"#{this.Id} - {this.CourseCode} ({this.CourseTitle})";
    }

}
