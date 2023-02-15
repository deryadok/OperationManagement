using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.BaseDtos
{
    public class BaseInsertDto
    {
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; }
    }
}
