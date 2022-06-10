using AutoMapper;
using s3_dreamcatcher_api.dto;
using s3_dreamcatcher_api.abstraction;

namespace s3_dreamcatcher_api.dal
{
    public class DreamDal : IDreamDal
    {
        private readonly DreamContext _context;
        public DreamDal(DreamContext dreamContext)
        {
            _context = dreamContext;
        }

        public List<DreamDTO> GetAllDreams(string userid)
        {
            List<DreamDTO> dreams;
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

        public DreamDTO GetDream(int dreamId)
        {
            DreamDTO? dream;
            if (_context.Dreams != null)
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
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DreamDTO, DreamDTO>());
            var mapper = config.CreateMapper();

            DreamDTO dream = mapper.Map<DreamDTO>(dreamDTO);
            return 1;
        }
    }
}
