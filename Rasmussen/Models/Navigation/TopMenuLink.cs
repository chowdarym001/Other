using System.Collections.Generic;

namespace Rasmussen.Models
{
    public partial class TopMenuLink
    {
        public IEnumerable<MenuLink> TopMenuChildren { get; set; }
    }
}