using System.Collections.Generic;

namespace Rasmussen.Models
{
    public partial class MenuLink
    {
        public bool IsActive { get; set; }

        public bool IsCentered { get; set; }
        public string CssClass { get; set; }
        public bool IsParent { get; set; }

        public int Level { get; set; }

        public string MenuName => string.IsNullOrWhiteSpace(DisplayText) ? ItemName : DisplayText;

        private string _mobileMenuName;
        public string MobileMenuName
        {
            get { return _mobileMenuName; }
            set { _mobileMenuName = string.IsNullOrWhiteSpace(value) ? MenuName : value; }
        }

        public IEnumerable<MenuLink> MenuChildren { get; set; }
        
    }
}