using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Rasmussen.Lib;
using Rasmussen.Models;
using Rasmussen.Services;
using Sitecore.Data;
using Rasmussen.Models.Navigation;
using System;

namespace Rasmussen.Controllers
{
    public class NavigationController : Controller
    {
        private readonly SitecoreContext _sitecoreContext;
        private readonly List<MenuLink> _headerNav;
        private readonly List<MenuLink> _footer;


        public NavigationController()
        {
            _sitecoreContext = new SitecoreContext();
            var componentService = new GlobalComponentService();
            var headerNavItem = _sitecoreContext.Database.GetItem(new ID(Consts.Ids.HeaderNav));
            var footerItem = _sitecoreContext.Database.GetItem(new ID(Consts.Ids.Footer));
            _headerNav = componentService.GetFullMenu(headerNavItem).ToList();
            _footer = componentService.GetFullMenu(footerItem).ToList();
        }

        public ViewResult HeaderNav()
        {
            return View(_headerNav);
        }

        public ViewResult MobileNav()
        {
            return View(_headerNav);
        }

        public ViewResult Footer()
        {
            return View(_footer);
        }

        public ViewResult FooterLinks()
        {
            var model = new FooterLinks();
            var footerlinksOther = new List<MenuLink>();
            var footerlinks = _sitecoreContext.Database.GetItem(new ID(Consts.Ids.FooterLinks));
            foreach (MenuLink footer in footerlinks.Children.Select(c => _sitecoreContext.Cast<MenuLink>(c)))
            {
                if (Guid.Parse(Consts.Ids.FooterLinksDisclosure).Equals(footer.Id))
                {
                    model.Disclosure = footer;
                }
                else {
                    footerlinksOther.Add(footer);
                }
            }
            model.Footerlink = footerlinksOther;
            return View(model);
        }
        public ViewResult FooterLinksDisclosure()
        {
          
           return View(_sitecoreContext.GetItem<MenuLink>(Consts.Ids.FooterLinksDisclosure));
        }
        public ViewResult UtilityNav()
        {
            var utilityNav = _sitecoreContext.Database.GetItem(new ID(Consts.Ids.UtilityNav));

            return View(utilityNav.Children.Select(c => _sitecoreContext.GetItem<MenuLink>(c.ID.Guid)));
        }
    }
}