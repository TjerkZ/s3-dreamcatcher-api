using AutoMapper;
using s3_dreamcatcher_api.dal.DB_Models;
using s3_dreamcatcher_api.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3_dreamcatcher_api.dal
{
    public class DreamDal
    {
        private readonly DreamContext _context;
        public DreamDal(DreamContext dreamContext)
        {
            _context = dreamContext;
        }

        public List<Dream> Getalldreams(string userid)
        {
            List<Dream> dreams;
            if (_context.Dreams is not null)
            {
                dreams = _context.Dreams.Where(dream => dream.UserID == userid).ToList();
            }
            else
            {
                throw new Exception();
            }
            return dreams;
        }

        public Dream GetDream(int dreamId)
        {
            Dream? dream;
            if (_context.Dreams is not null)
            {
                dream = _context.Dreams.FirstOrDefault(dream => dream.ID == dreamId);
            }
            else
            {
                throw new Exception();
            }
                
            if (dream == null)
            {
                throw new Exception();
            }
            return dream;
        }

        public int AddDream(DreamDTO dreamDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DreamDTO, Dream>());
            var mapper = config.CreateMapper();

            Dream dream = mapper.Map<Dream>(dreamDTO);
            return 1;
        }
    }
}
