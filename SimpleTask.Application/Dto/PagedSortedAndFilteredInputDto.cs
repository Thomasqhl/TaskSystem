using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTask.Dto
{
    public class PagedSortedAndFilteredInputDto : PagedAndSortedInputDto
    {
        public PagedSortedAndFilteredInputDto()
        {
            this.Search = new DatatablesSearchInputDto();
        }

        public DatatablesSearchInputDto Search { get; set; }
    }
}
