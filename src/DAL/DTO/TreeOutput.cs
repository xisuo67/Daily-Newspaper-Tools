using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class TreeOutput
    {
        public string Title { get; set; }

        public Guid Key { get; set; }

        public List<TreeOutput> Children { get; set; }
    }
}
