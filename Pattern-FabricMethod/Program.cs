using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_FabricMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer paneldeveloper = new PanelDeveloper("ООО Панель");
            Developer woodDeveloper = new WoodDeveloper("ООО Деревянные дома");
            House panelHouse = paneldeveloper.Create();
            House woodHouse = woodDeveloper.Create();
        }
    }
}
