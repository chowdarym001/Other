using Rasmussen.Lib;
using Rasmussen.Models.GlobalComponent;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc;
using Rasmussen.Models;

namespace Rasmussen.Services
{
    public class GlobalComponentService
    {
        private readonly SitecoreContext _sitecoreContext;

        public GlobalComponentService()
        {
            _sitecoreContext = new SitecoreContext();
        }

        public HeaderData GetHeader()
        {
            
            Item CurrentItem = HelperMethods.getCurrentContextItem();
            HeaderData Hdata = new HeaderData
            {
                Heading = HelperMethods.getHtmlstring(CurrentItem, "Heading"),
                SubHeading = HelperMethods.getHtmlstring(CurrentItem, "SubHeading"),
                Title = HelperMethods.getHtmlstring(CurrentItem, "Content")
            };
            return Hdata;
        }

        public IEnumerable<MenuLink> GetFullMenu(Item topMenuItem)
        {
            var returnMenu = new List<MenuLink>();

            var isActive = true;
            foreach (Item child in topMenuItem.Children)
            {
                var menuLink = _sitecoreContext.GetItem<MenuLink>(child.ID.Guid);
                menuLink.IsActive = isActive;
                if (child.TemplateID == ITopMenuLinkConstants.TemplateId)
                {
                    menuLink.IsParent = true;
                    if (child.Fields["Is Centered"] != null)
                    {
                        var topLink = _sitecoreContext.GetItem<TopMenuLink>(child.ID.Guid);
                        menuLink.IsCentered = topLink.IsCentered;
                        menuLink.MobileMenuName = topLink.MobileDisplay;
                    }
                    menuLink.MenuChildren = GetFullMenu(child);
                    
                }
                else
                {
                    menuLink.MenuChildren = new List<MenuLink>();
                }
                returnMenu.Add(menuLink);
                isActive = false;
            }

            return returnMenu;
        }
    }
}