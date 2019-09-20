using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTccWebBD.Models
{
    public interface ITccDAL
    {
        IEnumerable<Tcc> GetAllTcc();
        void AddTcc(Tcc tcc);
        void UpdateTcc(Tcc tcc);
        Tcc GetTcc(int? id);
        void DeleteTcc(int? id);
    }
}
