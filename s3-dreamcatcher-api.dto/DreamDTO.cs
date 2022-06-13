using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3_dreamcatcher_api.dto
{
    public class DreamDTO
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string UserID { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public virtual ICollection<TagDTO>? Tags { get; set; }
    }
}
