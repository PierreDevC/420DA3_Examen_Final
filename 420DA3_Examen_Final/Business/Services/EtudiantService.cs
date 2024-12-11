using _420DA3_Examen_Final.Business.Domain;
using _420DA3_Examen_Final.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.Business.Services;
internal class EtudiantService
{
    private EtudiantDAO etudiantDAO;

    public EtudiantService(AppDbContext context)
    {
        this.etudiantDAO = new EtudiantDAO(context);
    }

    public List<Etudiant> GetAll()
    {
        return this.etudiantDAO.GetAll();
    }

    public List<Etudiant> Search (string criterion)
    {
        return this.etudiantDAO.Search(criterion);
    }

    public Etudiant Insert(Etudiant etudiant)
    {
        return this.etudiantDAO.Insert(etudiant);
    }

    public Etudiant Update (Etudiant etudiant)
    {
        return this.etudiantDAO.Update(etudiant);
    }

    public Etudiant Delete (Etudiant etudiant)
    {
        return this.etudiantDAO.Delete(etudiant);
    }
}
