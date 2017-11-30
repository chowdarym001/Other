using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rasmussen.Models.Navigation
{
    public class FooterLinks
    {

        public IEnumerable<MenuLink> Footerlink { get; set; }

        public MenuLink Disclosure { get; set; }

        public FooterLinks()
        {
            Disclosure = new Models.MenuLink();
        }

    }
}