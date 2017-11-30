using BundleTransformer.Core.Builders;
using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Resolvers;
using BundleTransformer.Core.Transformers;
using Sitecore;
using Sitecore.Pipelines;
using System.Web.Optimization;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.Msie;

namespace Rasmussen
{
    public class RegisterSiteBundles
    {
        [UsedImplicitly]
        public virtual void Process(PipelineArgs args)
        {
            RegisterBundles(BundleTable.Bundles);
        }

        public void RegisterBundles(BundleCollection bundles)
        {
            JsEngineSwitcher engineSwitcher = JsEngineSwitcher.Instance;
            engineSwitcher.EngineFactories.AddMsie(new MsieSettings
            {
                UseEcmaScript5Polyfill = true,
                UseJson2Library = true
            });

            engineSwitcher.DefaultEngineName = MsieJsEngine.EngineName;

            bundles.UseCdn = true;
            BundleTable.EnableOptimizations =
                Sitecore.Configuration.Settings.GetBoolSetting("BundleTableEnableOptimizations", true);
            BundleResolver.Current = new CustomBundleResolver();

            // JS Bundle
            bundles.Add(new ScriptBundle("~/bundles/js").Include("~/Assets/js/jquery.validate*",
                "~/Assets/js/modernizr-*",
                "~/Assets/js/app.js"));

            //Rasmussen Bundle
            bundles.Add(new ScriptBundle("~/bundles/js/rasmussen").
                Include("~/Assets/dev/js/common.js"));
                        //can add more "~/Assets/dev/js/header.js"));

            //Backend JS Bundles

            //This Bundle is used on following components : 
            //1. PageNavigation.cshtml
            bundles.Add(new ScriptBundle("~/bundles/js/pagenavigation").Include("~/Assets/dev/js/PageNavigation.js"));

            //This Bundle is used on following components : 
            //1. VerticalTabComponent.cshtml
            bundles.Add(new ScriptBundle("~/bundles/js/verticalnav").Include("~/Assets/dev/js/VerticalTabs.js"));

            // CSS Bundle
            //CSS Bundle for Rasmussen
            var rasStyleBundle =
                new Bundle("~/bundles/css").Include("~/Assets/css/app.css", new CssRewriteUrlFixedTransform());
            rasStyleBundle.Builder = new NullBuilder();
            rasStyleBundle.Transforms.Add(new StyleTransformer());
            rasStyleBundle.Orderer = new NullOrderer();
            rasStyleBundle.Transforms.Add(new CssMinify());
            bundles.Add(rasStyleBundle);
        }
    }
}