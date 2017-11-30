using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Rasmussen.Models
{
    public partial class GlassBase
    {
        public string ItemName => string.IsNullOrWhiteSpace(DisplayName) ? Name : DisplayName;

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        public virtual string DisplayName { get; private set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string Name { get; private set; }
    }
}