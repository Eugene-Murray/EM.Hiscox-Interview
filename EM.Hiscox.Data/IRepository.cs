using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Hiscox.Data
{
    public interface IRepository
    {
        IEnumerable<string> GetSations(string searchTerm);
        IEnumerable<string> GetAll();
    }
}
