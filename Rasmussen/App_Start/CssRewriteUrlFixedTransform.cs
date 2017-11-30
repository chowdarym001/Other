using System;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Optimization;

namespace Rasmussen
{
    public class CssRewriteUrlFixedTransform : IItemTransform
    {
        internal static string ConvertUrlsToAbsolute(string baseUrl, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                return content;
            }
            var regex = new Regex("url\\(['\"]?((?!['\"]?data:))(?<url>[^)]+?)['\"]?\\)");

            var replacement = regex.Replace(content, match =>
            {
                var rebasedUrl = RebaseUrlToAbsolute(baseUrl, match.Groups["url"].Value);
                var concatenation = string.Concat("url(", rebasedUrl, ")");

                return concatenation;
            });

            return replacement;
        }

        public string Process(string includedVirtualPath, string input)
        {
            if (includedVirtualPath == null)
            {
                throw new ArgumentNullException("includedVirtualPath");
            }

            var directory = VirtualPathUtility.GetDirectory(includedVirtualPath.Substring(1));

            return ConvertUrlsToAbsolute(directory, input);
        }

        internal static string RebaseUrlToAbsolute(string baseUrl, string url)
        {
            var result = baseUrl;

            if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(baseUrl) ||
                url.StartsWith("/", StringComparison.OrdinalIgnoreCase))
            {
                result = url;
            }
            else
            {
                if (!baseUrl.EndsWith("/", StringComparison.OrdinalIgnoreCase))
                {
                    result = string.Concat(baseUrl, "/");
                }

                result = VirtualPathUtility.ToAbsolute(string.Concat(result, url));
            }

            return result;
        }
    }
}