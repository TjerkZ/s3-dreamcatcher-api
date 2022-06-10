using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using s3_dreamcatcher_api.dto;

namespace s3_dreamcatcher_api.abstraction
{
    public interface IDreamDal
    {
        public List<DreamDTO> GetAllDreams(string userid);
        public DreamDTO GetDream(int dreamId);
        public int AddDream(DreamDTO dto);
    }
}
