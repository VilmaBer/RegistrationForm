using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;

namespace RegistrationApp.Extensions
{
    public static class HtmlExtensions
    {
        public static IDictionary<string, object> Disable(this object htmlAttributes, bool disabled)
        {
            var dictionary = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);

            if (disabled)
                dictionary.Add("disabled", "disabled");

            return dictionary;
        }
    }
}
