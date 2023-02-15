using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.BaseDtos
{
    public class BaseUpdateDto
    {
        public int ID { get; set; }
        public DateTime ModifyDate { get; set; } = DateTime.Now;
        public int ModifiedBy { get; set; }
        public int CreatedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
