﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static class MVC
{
    public static Mvc4BootstrapLessDemo.Controllers.AccountController Account = new Mvc4BootstrapLessDemo.Controllers.T4MVC_AccountController();
    public static Mvc4BootstrapLessDemo.Controllers.HomeController Home = new Mvc4BootstrapLessDemo.Controllers.T4MVC_HomeController();
    public static Mvc4BootstrapLessDemo.Controllers.PagesController Pages = new Mvc4BootstrapLessDemo.Controllers.T4MVC_PagesController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
                      
        public static readonly string application_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/application.min.js") ? Url("application.min.js") : Url("application.js");
                      
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
                      
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string jquery_1_8_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.8.0.min.js") ? Url("jquery-1.8.0.min.js") : Url("jquery-1.8.0.js");
                      
        public static readonly string jquery_1_8_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.8.2.min.js") ? Url("jquery-1.8.2.min.js") : Url("jquery-1.8.2.js");
                      
        public static readonly string jquery_1_9_1_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.9.1.intellisense.min.js") ? Url("jquery-1.9.1.intellisense.min.js") : Url("jquery-1.9.1.intellisense.js");
                      
        public static readonly string jquery_1_9_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.9.1.min.js") ? Url("jquery-1.9.1.min.js") : Url("jquery-1.9.1.js");
                      
        public static readonly string jquery_1_9_1_min_js = Url("jquery-1.9.1.min.js");
        public static readonly string jquery_1_9_1_min_map = Url("jquery-1.9.1.min.map");
        public static readonly string jquery_ui_1_10_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.10.0.min.js") ? Url("jquery-ui-1.10.0.min.js") : Url("jquery-ui-1.10.0.js");
                      
        public static readonly string jquery_ui_1_10_0_min_js = Url("jquery-ui-1.10.0.min.js");
        public static readonly string jquery_ui_1_8_23_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.8.23.min.js") ? Url("jquery-ui-1.8.23.min.js") : Url("jquery-ui-1.8.23.js");
                      
        public static readonly string jquery_ui_1_8_23_min_js = Url("jquery-ui-1.8.23.min.js");
        public static readonly string jquery_ui_1_8_24_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.8.24.min.js") ? Url("jquery-ui-1.8.24.min.js") : Url("jquery-ui-1.8.24.js");
                      
        public static readonly string jquery_ui_1_8_24_min_js = Url("jquery-ui-1.8.24.min.js");
        public static readonly string jquery_ui_1_9_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.9.2.min.js") ? Url("jquery-ui-1.9.2.min.js") : Url("jquery-ui-1.9.2.js");
                      
        public static readonly string jquery_ui_1_9_2_min_js = Url("jquery-ui-1.9.2.min.js");
        public static readonly string jquery_unobtrusive_ajax_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.unobtrusive-ajax.min.js") ? Url("jquery.unobtrusive-ajax.min.js") : Url("jquery.unobtrusive-ajax.js");
                      
        public static readonly string jquery_unobtrusive_ajax_min_js = Url("jquery.unobtrusive-ajax.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
                      
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
                      
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
                      
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string knockout_2_1_0_debug_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/knockout-2.1.0.debug.min.js") ? Url("knockout-2.1.0.debug.min.js") : Url("knockout-2.1.0.debug.js");
                      
        public static readonly string knockout_2_1_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/knockout-2.1.0.min.js") ? Url("knockout-2.1.0.min.js") : Url("knockout-2.1.0.js");
                      
        public static readonly string knockout_2_2_1_debug_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/knockout-2.2.1.debug.min.js") ? Url("knockout-2.2.1.debug.min.js") : Url("knockout-2.2.1.debug.js");
                      
        public static readonly string knockout_2_2_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/knockout-2.2.1.min.js") ? Url("knockout-2.2.1.min.js") : Url("knockout-2.2.1.js");
                      
        public static readonly string less_min_js = Url("less.min.js");
        public static readonly string modernizr_2_5_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.5.3.min.js") ? Url("modernizr-2.5.3.min.js") : Url("modernizr-2.5.3.js");
                      
        public static readonly string modernizr_2_6_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.6.2.min.js") ? Url("modernizr-2.6.2.min.js") : Url("modernizr-2.6.2.js");
                      
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Prettify {
            private const string URLPATH = "~/Scripts/Prettify";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string lang_apollo_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-apollo.min.js") ? Url("lang-apollo.min.js") : Url("lang-apollo.js");
                          
            public static readonly string lang_clj_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-clj.min.js") ? Url("lang-clj.min.js") : Url("lang-clj.js");
                          
            public static readonly string lang_css_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-css.min.js") ? Url("lang-css.min.js") : Url("lang-css.js");
                          
            public static readonly string lang_go_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-go.min.js") ? Url("lang-go.min.js") : Url("lang-go.js");
                          
            public static readonly string lang_hs_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-hs.min.js") ? Url("lang-hs.min.js") : Url("lang-hs.js");
                          
            public static readonly string lang_lisp_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-lisp.min.js") ? Url("lang-lisp.min.js") : Url("lang-lisp.js");
                          
            public static readonly string lang_lua_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-lua.min.js") ? Url("lang-lua.min.js") : Url("lang-lua.js");
                          
            public static readonly string lang_ml_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-ml.min.js") ? Url("lang-ml.min.js") : Url("lang-ml.js");
                          
            public static readonly string lang_n_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-n.min.js") ? Url("lang-n.min.js") : Url("lang-n.js");
                          
            public static readonly string lang_proto_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-proto.min.js") ? Url("lang-proto.min.js") : Url("lang-proto.js");
                          
            public static readonly string lang_scala_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-scala.min.js") ? Url("lang-scala.min.js") : Url("lang-scala.js");
                          
            public static readonly string lang_sql_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-sql.min.js") ? Url("lang-sql.min.js") : Url("lang-sql.js");
                          
            public static readonly string lang_tex_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-tex.min.js") ? Url("lang-tex.min.js") : Url("lang-tex.js");
                          
            public static readonly string lang_vb_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-vb.min.js") ? Url("lang-vb.min.js") : Url("lang-vb.js");
                          
            public static readonly string lang_vhdl_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-vhdl.min.js") ? Url("lang-vhdl.min.js") : Url("lang-vhdl.js");
                          
            public static readonly string lang_wiki_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-wiki.min.js") ? Url("lang-wiki.min.js") : Url("lang-wiki.js");
                          
            public static readonly string lang_xq_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-xq.min.js") ? Url("lang-xq.min.js") : Url("lang-xq.js");
                          
            public static readonly string lang_yaml_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/lang-yaml.min.js") ? Url("lang-yaml.min.js") : Url("lang-yaml.js");
                          
            public static readonly string prettify_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/prettify.min.js") ? Url("prettify.min.js") : Url("prettify.js");
                          
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string docs_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/docs.min.css") ? Url("docs.min.css") : Url("docs.css");
             
        public static readonly string icons_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/icons.min.css") ? Url("icons.min.css") : Url("icons.css");
             
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class images {
            private const string URLPATH = "~/Content/images";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string apple_touch_icon_114_precomposed_png = Url("apple-touch-icon-114-precomposed.png");
            public static readonly string apple_touch_icon_144_precomposed_png = Url("apple-touch-icon-144-precomposed.png");
            public static readonly string apple_touch_icon_57_precomposed_png = Url("apple-touch-icon-57-precomposed.png");
            public static readonly string apple_touch_icon_72_precomposed_png = Url("apple-touch-icon-72-precomposed.png");
            public static readonly string bootstrap_example_fluid_jpg = Url("bootstrap-example-fluid.jpg");
            public static readonly string bootstrap_example_hero_jpg = Url("bootstrap-example-hero.jpg");
            public static readonly string bootstrap_example_starter_jpg = Url("bootstrap-example-starter.jpg");
            public static readonly string bootstrap_mdo_sfmoma_01_jpg = Url("bootstrap-mdo-sfmoma-01.jpg");
            public static readonly string bootstrap_mdo_sfmoma_02_jpg = Url("bootstrap-mdo-sfmoma-02.jpg");
            public static readonly string bootstrap_mdo_sfmoma_03_jpg = Url("bootstrap-mdo-sfmoma-03.jpg");
            public static readonly string bs_docs_bootstrap_features_png = Url("bs-docs-bootstrap-features.png");
            public static readonly string bs_docs_masthead_pattern_png = Url("bs-docs-masthead-pattern.png");
            public static readonly string bs_docs_responsive_illustrations_png = Url("bs-docs-responsive-illustrations.png");
            public static readonly string bs_docs_twitter_github_png = Url("bs-docs-twitter-github.png");
            public static readonly string favicon_ico = Url("favicon.ico");
            public static readonly string fleetio_png = Url("fleetio.png");
            public static readonly string glyphicons_halflings_white_png = Url("glyphicons-halflings-white.png");
            public static readonly string glyphicons_halflings_png = Url("glyphicons-halflings.png");
            public static readonly string icon_facebook_png = Url("icon-facebook.png");
            public static readonly string icon_google_png = Url("icon-google.png");
            public static readonly string icon_microsoft_png = Url("icon-microsoft.png");
            public static readonly string icon_twitter_png = Url("icon-twitter.png");
            public static readonly string jshint_png = Url("jshint.png");
            public static readonly string kippt_png = Url("kippt.png");
            public static readonly string less_logo_large_png = Url("less-logo-large.png");
            public static readonly string responsive_illustrations_png = Url("responsive-illustrations.png");
            public static readonly string soundready_png = Url("soundready.png");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class less {
            private const string URLPATH = "~/Content/less";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string accordion_less = Url("accordion.less");
            public static readonly string alerts_less = Url("alerts.less");
            public static readonly string bootstrap_less = Url("bootstrap.less");
            public static readonly string breadcrumbs_less = Url("breadcrumbs.less");
            public static readonly string button_groups_less = Url("button-groups.less");
            public static readonly string buttons_less = Url("buttons.less");
            public static readonly string carousel_less = Url("carousel.less");
            public static readonly string close_less = Url("close.less");
            public static readonly string code_less = Url("code.less");
            public static readonly string component_animations_less = Url("component-animations.less");
            public static readonly string dropdowns_less = Url("dropdowns.less");
            public static readonly string forms_less = Url("forms.less");
            public static readonly string grid_less = Url("grid.less");
            public static readonly string hero_unit_less = Url("hero-unit.less");
            public static readonly string labels_badges_less = Url("labels-badges.less");
            public static readonly string layouts_less = Url("layouts.less");
            public static readonly string media_less = Url("media.less");
            public static readonly string mixins_less = Url("mixins.less");
            public static readonly string modals_less = Url("modals.less");
            public static readonly string navbar_less = Url("navbar.less");
            public static readonly string navs_less = Url("navs.less");
            public static readonly string pager_less = Url("pager.less");
            public static readonly string pagination_less = Url("pagination.less");
            public static readonly string popovers_less = Url("popovers.less");
            public static readonly string progress_bars_less = Url("progress-bars.less");
            public static readonly string reset_less = Url("reset.less");
            public static readonly string responsive_1200px_min_less = Url("responsive-1200px-min.less");
            public static readonly string responsive_767px_max_less = Url("responsive-767px-max.less");
            public static readonly string responsive_768px_979px_less = Url("responsive-768px-979px.less");
            public static readonly string responsive_navbar_less = Url("responsive-navbar.less");
            public static readonly string responsive_utilities_less = Url("responsive-utilities.less");
            public static readonly string responsive_less = Url("responsive.less");
            public static readonly string scaffolding_less = Url("scaffolding.less");
            public static readonly string sprites_less = Url("sprites.less");
            public static readonly string tables_less = Url("tables.less");
            public static readonly string thumbnails_less = Url("thumbnails.less");
            public static readonly string tooltip_less = Url("tooltip.less");
            public static readonly string type_less = Url("type.less");
            public static readonly string utilities_less = Url("utilities.less");
            public static readonly string variables_less = Url("variables.less");
            public static readonly string wells_less = Url("wells.less");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Prettify {
            private const string URLPATH = "~/Content/Prettify";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string prettify_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/prettify.min.css") ? Url("prettify.min.css") : Url("prettify.css");
                 
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Themes {
                private const string URLPATH = "~/Content/Prettify/Themes";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string desert_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/desert.min.css") ? Url("desert.min.css") : Url("desert.css");
                     
                public static readonly string sons_of_obsidian_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/sons-of-obsidian.min.css") ? Url("sons-of-obsidian.min.css") : Url("sons-of-obsidian.css");
                     
                public static readonly string sunburst_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/sunburst.min.css") ? Url("sunburst.min.css") : Url("sunburst.css");
                     
            }
        
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class themes {
            private const string URLPATH = "~/Content/themes";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class @base {
                private const string URLPATH = "~/Content/themes/base";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Content/themes/base/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string animated_overlay_gif = Url("animated-overlay.gif");
                    public static readonly string ui_bg_flat_0_aaaaaa_40x100_png = Url("ui-bg_flat_0_aaaaaa_40x100.png");
                    public static readonly string ui_bg_flat_75_ffffff_40x100_png = Url("ui-bg_flat_75_ffffff_40x100.png");
                    public static readonly string ui_bg_glass_55_fbf9ee_1x400_png = Url("ui-bg_glass_55_fbf9ee_1x400.png");
                    public static readonly string ui_bg_glass_65_ffffff_1x400_png = Url("ui-bg_glass_65_ffffff_1x400.png");
                    public static readonly string ui_bg_glass_75_dadada_1x400_png = Url("ui-bg_glass_75_dadada_1x400.png");
                    public static readonly string ui_bg_glass_75_e6e6e6_1x400_png = Url("ui-bg_glass_75_e6e6e6_1x400.png");
                    public static readonly string ui_bg_glass_95_fef1ec_1x400_png = Url("ui-bg_glass_95_fef1ec_1x400.png");
                    public static readonly string ui_bg_highlight_soft_75_cccccc_1x100_png = Url("ui-bg_highlight-soft_75_cccccc_1x100.png");
                    public static readonly string ui_icons_222222_256x240_png = Url("ui-icons_222222_256x240.png");
                    public static readonly string ui_icons_2e83ff_256x240_png = Url("ui-icons_2e83ff_256x240.png");
                    public static readonly string ui_icons_454545_256x240_png = Url("ui-icons_454545_256x240.png");
                    public static readonly string ui_icons_888888_256x240_png = Url("ui-icons_888888_256x240.png");
                    public static readonly string ui_icons_cd0a0a_256x240_png = Url("ui-icons_cd0a0a_256x240.png");
                }
            
                public static readonly string jquery_ui_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui.min.css") ? Url("jquery-ui.min.css") : Url("jquery-ui.css");
                     
                public static readonly string jquery_ui_accordion_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.accordion.min.css") ? Url("jquery.ui.accordion.min.css") : Url("jquery.ui.accordion.css");
                     
                public static readonly string jquery_ui_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.all.min.css") ? Url("jquery.ui.all.min.css") : Url("jquery.ui.all.css");
                     
                public static readonly string jquery_ui_autocomplete_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.autocomplete.min.css") ? Url("jquery.ui.autocomplete.min.css") : Url("jquery.ui.autocomplete.css");
                     
                public static readonly string jquery_ui_base_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.base.min.css") ? Url("jquery.ui.base.min.css") : Url("jquery.ui.base.css");
                     
                public static readonly string jquery_ui_button_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.button.min.css") ? Url("jquery.ui.button.min.css") : Url("jquery.ui.button.css");
                     
                public static readonly string jquery_ui_core_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.core.min.css") ? Url("jquery.ui.core.min.css") : Url("jquery.ui.core.css");
                     
                public static readonly string jquery_ui_datepicker_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.datepicker.min.css") ? Url("jquery.ui.datepicker.min.css") : Url("jquery.ui.datepicker.css");
                     
                public static readonly string jquery_ui_dialog_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.dialog.min.css") ? Url("jquery.ui.dialog.min.css") : Url("jquery.ui.dialog.css");
                     
                public static readonly string jquery_ui_menu_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.menu.min.css") ? Url("jquery.ui.menu.min.css") : Url("jquery.ui.menu.css");
                     
                public static readonly string jquery_ui_progressbar_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.progressbar.min.css") ? Url("jquery.ui.progressbar.min.css") : Url("jquery.ui.progressbar.css");
                     
                public static readonly string jquery_ui_resizable_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.resizable.min.css") ? Url("jquery.ui.resizable.min.css") : Url("jquery.ui.resizable.css");
                     
                public static readonly string jquery_ui_selectable_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.selectable.min.css") ? Url("jquery.ui.selectable.min.css") : Url("jquery.ui.selectable.css");
                     
                public static readonly string jquery_ui_slider_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.slider.min.css") ? Url("jquery.ui.slider.min.css") : Url("jquery.ui.slider.css");
                     
                public static readonly string jquery_ui_spinner_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.spinner.min.css") ? Url("jquery.ui.spinner.min.css") : Url("jquery.ui.spinner.css");
                     
                public static readonly string jquery_ui_tabs_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.tabs.min.css") ? Url("jquery.ui.tabs.min.css") : Url("jquery.ui.tabs.css");
                     
                public static readonly string jquery_ui_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.theme.min.css") ? Url("jquery.ui.theme.min.css") : Url("jquery.ui.theme.css");
                     
                public static readonly string jquery_ui_tooltip_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.tooltip.min.css") ? Url("jquery.ui.tooltip.min.css") : Url("jquery.ui.tooltip.css");
                     
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class minified {
                    private const string URLPATH = "~/Content/themes/base/minified";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                    public static class images {
                        private const string URLPATH = "~/Content/themes/base/minified/images";
                        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                        public static readonly string animated_overlay_gif = Url("animated-overlay.gif");
                        public static readonly string ui_bg_flat_0_aaaaaa_40x100_png = Url("ui-bg_flat_0_aaaaaa_40x100.png");
                        public static readonly string ui_bg_flat_75_ffffff_40x100_png = Url("ui-bg_flat_75_ffffff_40x100.png");
                        public static readonly string ui_bg_glass_55_fbf9ee_1x400_png = Url("ui-bg_glass_55_fbf9ee_1x400.png");
                        public static readonly string ui_bg_glass_65_ffffff_1x400_png = Url("ui-bg_glass_65_ffffff_1x400.png");
                        public static readonly string ui_bg_glass_75_dadada_1x400_png = Url("ui-bg_glass_75_dadada_1x400.png");
                        public static readonly string ui_bg_glass_75_e6e6e6_1x400_png = Url("ui-bg_glass_75_e6e6e6_1x400.png");
                        public static readonly string ui_bg_glass_95_fef1ec_1x400_png = Url("ui-bg_glass_95_fef1ec_1x400.png");
                        public static readonly string ui_bg_highlight_soft_75_cccccc_1x100_png = Url("ui-bg_highlight-soft_75_cccccc_1x100.png");
                        public static readonly string ui_icons_222222_256x240_png = Url("ui-icons_222222_256x240.png");
                        public static readonly string ui_icons_2e83ff_256x240_png = Url("ui-icons_2e83ff_256x240.png");
                        public static readonly string ui_icons_454545_256x240_png = Url("ui-icons_454545_256x240.png");
                        public static readonly string ui_icons_888888_256x240_png = Url("ui-icons_888888_256x240.png");
                        public static readonly string ui_icons_cd0a0a_256x240_png = Url("ui-icons_cd0a0a_256x240.png");
                    }
                
                    public static readonly string jquery_ui_min_css = Url("jquery-ui.min.css");
                    public static readonly string jquery_ui_accordion_min_css = Url("jquery.ui.accordion.min.css");
                    public static readonly string jquery_ui_autocomplete_min_css = Url("jquery.ui.autocomplete.min.css");
                    public static readonly string jquery_ui_button_min_css = Url("jquery.ui.button.min.css");
                    public static readonly string jquery_ui_core_min_css = Url("jquery.ui.core.min.css");
                    public static readonly string jquery_ui_datepicker_min_css = Url("jquery.ui.datepicker.min.css");
                    public static readonly string jquery_ui_dialog_min_css = Url("jquery.ui.dialog.min.css");
                    public static readonly string jquery_ui_menu_min_css = Url("jquery.ui.menu.min.css");
                    public static readonly string jquery_ui_progressbar_min_css = Url("jquery.ui.progressbar.min.css");
                    public static readonly string jquery_ui_resizable_min_css = Url("jquery.ui.resizable.min.css");
                    public static readonly string jquery_ui_selectable_min_css = Url("jquery.ui.selectable.min.css");
                    public static readonly string jquery_ui_slider_min_css = Url("jquery.ui.slider.min.css");
                    public static readonly string jquery_ui_spinner_min_css = Url("jquery.ui.spinner.min.css");
                    public static readonly string jquery_ui_tabs_min_css = Url("jquery.ui.tabs.min.css");
                    public static readonly string jquery_ui_theme_min_css = Url("jquery.ui.theme.min.css");
                    public static readonly string jquery_ui_tooltip_min_css = Url("jquery.ui.tooltip.min.css");
                }
            
            }
        
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591


