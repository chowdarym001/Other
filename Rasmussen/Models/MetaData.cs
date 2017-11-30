using System;
using Glass.Mapper.Sc;
using Rasmussen.Lib;
using Sitecore.Mvc.Presentation;

namespace Rasmussen.Models
{
    public partial class MetaData
    {
        private readonly SitecoreContext _sitecoreContext = new SitecoreContext();

        public string TitleBase
        {
            get
            {
                var home = _sitecoreContext.GetItem<HomePage>(new Guid(Consts.Ids.RasmussenHome));
                return home != null ? home.TitleBase : "";
            }
        }

        public string BorderColor
        {
            get
            {
                if (RenderingContext.Current == null) return "";
                var current = RenderingContext.Current.ContextItem;
                if (current == null || current.Fields["Border Color"] == null) return "";
                var bc = _sitecoreContext.GetItem<IColor>(new Guid(current.Fields["Border Color"].Value));
                return bc == null ? "" : bc.Value;
            }
        }
    }
}