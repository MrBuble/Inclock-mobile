using System;
using System.Collections.Generic;
using System.Text;

namespace Inclock.VO
{
    public class MasterPageItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}
