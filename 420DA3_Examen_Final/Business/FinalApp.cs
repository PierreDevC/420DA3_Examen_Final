using _420DA3_Examen_Final.Business.Services;
using _420DA3_Examen_Final.DataAccess;
using _420DA3_Examen_Final.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.Business;
internal class FinalApp
{
    private AppDbContext context;

    public EtudiantService EtudiantService { get; set; }

    public CoursService CoursService { get; set; }

    private EtudiantView window;

    public FinalApp()
    {
        this.context = new AppDbContext();
        this.EtudiantService = new EtudiantService(this.context);
        this.CoursService = new CoursService(this.context);
        this.window = new EtudiantView(this);
    }

    public void Start()
    {
        this.window.Initialize();
        Application.Run(this.window);
    }
}
