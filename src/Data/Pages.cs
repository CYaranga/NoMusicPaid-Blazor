using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoMusicPaid.Data
{
    public class Pages
    {
        public Pages(Pages_enum page, string title)
        {
            this.page = page;
            this.title = title;
        }

        public Pages_enum page { get; set; }
        public string title { get; set; }
    }
}