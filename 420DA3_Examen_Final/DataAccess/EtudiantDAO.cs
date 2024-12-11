using _420DA3_Examen_Final.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.DataAccess;
internal class EtudiantDAO
{
    private AppDbContext context;

    public EtudiantDAO(AppDbContext context)
    {
        this.context = context;
    }

    public List<Etudiant> GetAll()
    {
        return this.context.Etudiants
            .Include(e => e.Courses)
            .ToList();
    }

    public List<Etudiant> Search (string criterion)
    {
        return this.context.Etudiants
                .Include(e => e.Courses)
                .Where(e =>
                     e.FirstName.Contains(criterion)
                     || e.LastName.Contains(criterion))
                .ToList();
    }

    public Etudiant Insert(Etudiant etudiant)
    {
        this.context.Etudiants.Add(etudiant);
        this.context.SaveChanges();
        return etudiant;
    }

    public Etudiant Update(Etudiant etudiant)
    {
        this.context.Etudiants.Update(etudiant);
        this.context.SaveChanges();
        return etudiant;
    }

    public Etudiant Delete(Etudiant etudiant)
    {
        this.context.Etudiants.Remove(etudiant);
        this.context.SaveChanges();
        return etudiant;
    }
}
