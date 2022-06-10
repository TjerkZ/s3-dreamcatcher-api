using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using s3_dreamcatcher_api.abstraction;
using s3_dreamcatcher_api.dto;
using s3_dreamcatcher_api.logic.Models;
using AutoMapper;

namespace s3_dreamcatcher_api.logic.Managers
{
    public class DreamManager
    {
        private readonly IDreamDal _dreamDal;
        private readonly IMapper _mapper;
        public DreamManager(IDreamDal dreamDal, IMapper mapper)
        {
            _dreamDal = dreamDal;
            _mapper = mapper;
        }

        public List<Dream> GetAllDreams(string userid)
        {
            var dreamdto = _dreamDal.GetAllDreams(userid);
            return _mapper.Map<List<Dream>>(dreamdto);
        }

        public Dream GetDream(int dreamid)
        {
            var dreamdto = _dreamDal.GetDream(dreamid);
            return _mapper.Map<Dream>(dreamdto);
        }

        public int Adddream(Dream dream)
        {
            return _dreamDal.AddDream(_mapper.Map<DreamDTO>(dream));
        }
    }
}
