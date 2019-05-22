using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activosFijos.Code
{
    class libRep
    {
        
    }

    class rptDep
    {
        public int idOfi { get; set; }
        public string nomOfi { get; set; }
        public int idCat { get; set; }
        public string desCat { get; set; }
        public int idAct { get; set; }
        public string desAct { get; set; }
        public decimal valCom { get; set; }
        public decimal depAcu { get; set; }
        public decimal depAct { get; set; }
        public int idEst { get; set; }
        public string nomEst { get; set; }
        public decimal monDep { get; set; }
        public int mesDep { get; set; }
        public string desDep { get; set; }
        public DateTime fecDep { get; set; }
        public int idUsu { get; set; }
        public string nomUsu { get; set; }
    }
    class rptAjuste
    {
        public int idAct { get; set; }
        public DateTime fecCom { get; set; }
        public string numCom { get; set; }
        public string desAct { get; set; }
        public decimal valCom { get; set; }
        public decimal depAcu { get; set; }
        public decimal valAct { get; set; }
        public decimal valRes { get; set; }
        public string desCat { get; set; }
        public string nomOfi { get; set; }
        public string nomEst { get; set; }
        public string nomPar { get; set; }
        public DateTime fecDep { get; set; }
        public decimal monDep { get; set; }
        public int mesDep { get; set; }
        public string desDep { get; set; }
        public string nomUsu { get; set; }
    }
}
