using Rasmussen.Models;
using System.Web.Mvc;

namespace Rasmussen.Controllers
{
    public class PageController : Controller
    {
        // GET: HomeBanner
        public ActionResult HomeBanner()
        {
            var entity = new HomeBannerModel();
          
            return View(entity);
        }

        [HttpGet]
        public ViewResult FourColumnContent()
        {
            var entity = new FourColumnContentBlockModel();
            return View(entity);
        }

        [HttpGet]
        public ViewResult Slides()
        {
            CarouselModel entity = new CarouselModel();
            return View(entity);
        }

        [HttpGet]
        public ViewResult SearchBar()
        {
            var search = new GenericContentBlockModel();
            return View(search);
        }
        public ActionResult AdmissionBanner()
        {
            var entitys = new HomeBannerModel();

            return View(entitys);
        }
        [HttpGet]
        public ViewResult AdmissionIntro() 
        {
            var search = new GenericContentBlockModel();
            return View(search);
        }
        [HttpGet]
        public ViewResult AdmissionAudience()
        {
            var search = new GenericContentBlockModel();
            return View(search);
        }
        [HttpGet]
        public ViewResult AdmissionContact()
        {
            var search = new GenericContentBlockModel();
            return View(search);
        }
        [HttpGet]
        public ViewResult AdmissionFaq()  
        {
            var search = new GenericContentBlockModel();
            return View(search);
        }
        [HttpGet]
        public ViewResult AdmissionNextsteps()
        {
            var search = new GenericContentBlockModel();
            return View(search);
        }
        public ViewResult AreasofStudy()
        {
            var entity = new FourColumnContentBlockModel();
            return View(entity);
        }

        public ActionResult NursingProgramBanner()
        {
            var entitys = new HomeBannerModel();

            return View(entitys);
        }
        public ActionResult NursingProgramQuadrant()
        {
            var entitys = new FourColumnContentBlockModel();

            return View(entitys);
        }
        public ActionResult NursingProgramCredentialOffering()
        {
            var entitys = new GenericContentBlockModel();

            return View(entitys);
        }
        public ActionResult NursingProgramBannerTwo()
        {
            var entitys = new HomeBannerModel();

            return View(entitys);
        }
        public ActionResult NursingProgramCareerPath()
        {
            var entitys = new GenericContentBlockModel();

            return View(entitys);
        }
        public ActionResult NursingProgramDualCol()
        {
            var entitys = new GenericContentBlockModel();

            return View(entitys);
        }
        public ActionResult NursingProgramRelatedContent()
        {
            var entitys = new FourColumnContentBlockModel();

            return View(entitys);
        }
        public ActionResult NursingCredentialOverview()
        {
            var entitys = new GenericContentBlockModel();

            return View(entitys);
        }
        public ActionResult NursingCredentialIntro()
        {
            var entitys = new GenericContentBlockModel();

            return View(entitys);
        }
        public ActionResult NursingCredentialDoDone()
        {
            var entitys = new GenericContentBlockModel();

            return View(entitys);
        }
        public ActionResult NursingCredentialSkillGain()
        {
            var entitys = new HomeBannerModel();

            return View(entitys);
        }
        public ActionResult NursingCredentialGlance()
        {
            var entitys = new GenericContentBlockModel();

            return View(entitys);
        }
        public ActionResult NursingCredentialBeforeEnroll()
        {
            var entitys = new GenericContentBlockModel();

            return View(entitys);
        }
        public ActionResult NursingCredentialLocations()
        {
            var entitys = new HeaderNavModel();

            return View(entitys);
        }
       
        public ActionResult NursingIndustryBanner()
        {
            var entitys = new GenericContentBlockModel();

            return View(entitys);
        }
        public ActionResult NursingIndustryContent()
        {
            var entitys = new FourColumnContentBlockModel();

            return View(entitys);
        }
        public ActionResult NursingIndustryTiles()
        {
            var entitys = new GenericContentBlockModel();

            return View(entitys);
        }
        public ActionResult StudentExpBannerIntro()
        {
            var entitys = new HomeBannerModel();

            return View(entitys);
        }
        public ActionResult StudentExpSupportQuote()
        {
            var entitys = new FourColumnContentBlockModel();

            return View(entitys);
        }
        public ActionResult StudentExpOnlineOncampus()
        {
            var entitys = new HomeBannerModel();

            return View(entitys);
        }
        public ActionResult StudentExpCommunity()
        {
            CarouselModel entitys = new CarouselModel();

            return View(entitys);
        }
        
    }
    
}