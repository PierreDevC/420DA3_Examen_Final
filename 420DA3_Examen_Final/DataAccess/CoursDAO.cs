using _420DA3_Examen_Final.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.DataAccess;
internal class CoursDAO
{
    private AppDbContext context;

    public CoursDAO(AppDbContext context)
    {
        this.context = context;
    }

    public List<Cours> GetAll()
    {
        return this.context.Courses
            .ToList();
    }

    public List<Cours> GetEtudiantCoursInscrits (Etudiant etudiant)
    {
        return this.context.Courses
            .Include(c => c.EtudiantInscrits)
            .Where(c => c.EtudiantInscrits.Contains(etudiant))
            .ToList();
    }

    public List<Cours> GetEtudiantNotCoursInscrits(Etudiant etudiant)
    {
        return this.context.Courses
            .Include(c => c.EtudiantInscrits)
            .Where(c => !c.EtudiantInscrits.Contains(etudiant))
            .ToList();
    }
}
