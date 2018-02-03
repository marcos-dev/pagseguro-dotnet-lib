using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace RMC.Pagseguro.Util
{
    public static class HttpUrlUtil
    {
        internal const string PostMethod = "POST";
        internal const string GetMethod = "GET";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="urlPath"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        internal static HttpWebResponse GetHttpPostConnection(string urlPath, string query)
        {
            string formUrlEncoded = string.Empty;
            string encoding = string.Empty;

            string contentType = $"{formUrlEncoded}; charset= {encoding}";
            return GetURLConnection(PostMethod, contentType, urlPath, query);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="method"></param>
        /// <param name="contentType"></param>
        /// <param name="urlPath"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        private static HttpWebResponse GetURLConnection(string method, string contentType, string urlPath, string query)
        {
            throw new NotImplementedException();
        }
    }
}
