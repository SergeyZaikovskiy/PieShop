using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using PieShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PieShop.TagHelpers
{
    public class SortTagHelper : TagHelper
    {
        private readonly IUrlHelperFactory urlHelperFactory;

        public SortPieState Property { get; set; }

        public SortPieState Current{ get; set; }

        public string Action { get; set; }

        public bool Up { get; set; }

        public Dictionary<string, string> RouteData { get; set; }

        public SortTagHelper(IUrlHelperFactory urlHelperFactory)
        {
            this.urlHelperFactory = urlHelperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            output.TagName = "a";

            var query = CheckDataRoute(RouteData);

            string url = urlHelper.Action(Action, new { sortOrder = Property });
            output.Attributes.SetAttribute("href", url);

            if(Current == Property)
            {
                TagBuilder tag = new TagBuilder("i");
                tag.AddCssClass("glyphicon");

                if (Up)
                    tag.AddCssClass("glyphicon-chevron-up");
                else
                    tag.AddCssClass("glyphicon-chevron-down");

                output.PreContent.AppendHtml(tag);
            }
        }

        private string CheckDataRoute(Dictionary<string, string> DataDictionary)
        {
            if (DataDictionary != null)
            {
                var fixedRouteValues = new Dictionary<string, string>();
                foreach (var (newKey, value) in DataDictionary.Where(r => !string.IsNullOrWhiteSpace(r.Value)))
                {
                    var key = fixedRouteValues.Keys.FirstOrDefault(k => string.Equals(k, newKey, StringComparison.InvariantCultureIgnoreCase)) ?? newKey;
                    fixedRouteValues[key] = value;
                }
               
                fixedRouteValues.Add("sortValue", Property.ToString());

                var query = "?" + string.Join("&", fixedRouteValues.Select(kvp => $"{kvp.Key}={kvp.Value}"));

                return query;
            }
            else
                return null;

        }
    }
}
