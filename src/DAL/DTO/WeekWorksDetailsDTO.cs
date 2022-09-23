using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class WeekWorksDetailsDTO
    {


        /// <summary>
        /// 所属项目
        /// </summary>
        public string AffiliatedProject { get; set; }

        public List<WeekWorksDTO> WeekWorksDTOs { get; set; }
    }
}
