using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QualificationWork.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Nomenclature> Nomenclatures { get; set; }
        public IEnumerable<Branche> Branches { get; set; }
        public PageInfo PageInfo { get; set; }

    }
}
