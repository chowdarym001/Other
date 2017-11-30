using Rasmussen.Lib;
using Sitecore.Mvc.Presentation;
using System.Web;
namespace Rasmussen.Models
{
    public class CarouselModel : RenderingModel
    {
        public HtmlString Heading { get; set; }
        public HtmlString SubHeading { get; set; }
        public HtmlString Body { get; set; }
        public HtmlString BodyOne { get; set; }
        public HtmlString BodyTwo { get; set; }
        public HtmlString CTALink { get; set; }
        public HtmlString Footer { get; set; }


        public string BackgroundImageurl_Small { get; set; }
        public string BackgroundImageurl_Medium { get; set; }
        public string BackgroundImageurl_Large { get; set; }
        public string BackgroundImageurl_Xlarge { get; set; }
        public string BackgroundImageOneurl_Small { get; set; }
        public string BackgroundImageOneurl_Medium { get; set; }
        public string BackgroundImageOneurl_Large { get; set; }
        public string BackgroundImageOneurl_Xlarge { get; set; }

        public CarouselModel()
        {
            Initialize(RenderingContext.Current.Rendering);
            BackgroundImageurl_Small = HelperMethods.GetImageURL(Item, "BackgroundImageurl_Small");
            BackgroundImageurl_Medium = HelperMethods.GetImageURL(Item, "BackgroundImageurl_Medium");
            BackgroundImageurl_Large = HelperMethods.GetImageURL(Item, "BackgroundImageurl_Large");
            BackgroundImageurl_Xlarge = HelperMethods.GetImageURL(Item, "BackgroundImageurl_Xlarge");
            BackgroundImageOneurl_Small = HelperMethods.GetImageURL(Item, "BackgroundImageOneurl_Small");
            BackgroundImageOneurl_Medium = HelperMethods.GetImageURL(Item, "BackgroundImageOneurl_Medium");
            BackgroundImageOneurl_Large = HelperMethods.GetImageURL(Item, "BackgroundImageOneurl_Large");
            BackgroundImageOneurl_Xlarge = HelperMethods.GetImageURL(Item, "BackgroundImageOneurl_Xlarge");
        }




    }
}