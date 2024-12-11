using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.Business.Domain;
public class Etudiant
{
    public const int FirstNameMaxLength = 64;
    public const int LastNameMaxLength = 64;

    private string firstName = null!;
    private string lastName = null!;

    public int Id { get; set; }
    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (value.Length > FirstNameMaxLength)
            {
                throw new ArgumentException(nameof(this.FirstName), $"Le prénom ne peut dépasser {FirstNameMaxLength} caractères.");
            }
            this.firstName = value;
        }
    }
    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (value.Length > LastNameMaxLength)
            {
                throw new ArgumentException(nameof(this.LastName), $"Le nom de famille ne peut dépasser {LastNameMaxLength} caractères.");
            }
            this.lastName = value;
        }
    }
    public byte[] RowVersion { get; set; } = null!;

    public virtual List<Cours> Courses { get; set; } = new List<Cours>();

    public Etudiant()
    {

    }

    protected Etudiant(int id, string firstName, string lastName, byte[] rowVersion)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.RowVersion = rowVersion;
    }

    public override string ToString()
    {
        return $"#{this.Id} - {this.FirstName} ({this.LastName})";
    }
}
