using System;
using System.Collections.Generic;
using System.Text;

namespace Inclock.VO
{
    class MenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType{ get; set; }
        public MenuItem()
        {
           // TargetType = typeof(MenuDetail);
        }
    }
}
