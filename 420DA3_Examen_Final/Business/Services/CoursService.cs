using _420DA3_Examen_Final.Business.Domain;
using _420DA3_Examen_Final.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.Business.Services;
internal class CoursService
{
    private CoursDAO coursDAO;

    public CoursService(AppDbContext context)
    {
        this.coursDAO = new CoursDAO(context);
    }

    public List<Cours> GetAll()
    {
        return this.coursDAO.GetAll();
    }

    public List<Cours> GetEtudiantCoursInscrits (Etudiant etudiant)
    {
        return this.coursDAO.GetEtudiantCoursInscrits(etudiant);
    }

    public List<Cours> GetEtudiantNotCoursInscrits(Etudiant etudiant)
    {
        return this.coursDAO.GetEtudiantNotCoursInscrits(etudiant);
    }
}
