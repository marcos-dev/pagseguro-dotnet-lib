using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace RMC.Pagseguro.Util
{
    public class HttpUrlUtil
    {
        private List<string> Header { get; set; }

        private List<string> Data { get; set; }

        private string Url { get; set; }

        private HttpWebRequest Request { get; set; }

        private string CustomRequest { get; set; }

        public HttpUrlUtil()
        {

        }

        public HttpUrlUtil(string url, List<string> data, List<string> header, HttpWebRequest request, string customRequest)
        {
            Header = header;
            Data = data;
            Url = url;
            Request = request;
            CustomRequest = customRequest;
        }

        public void SetUrl()
        {

        }

        /// <summary>
        /// Get Header
        /// </summary>
        /// <returns></returns>
        public string GetHeader()
        {
            return string.Empty;
        }


        public void SetHeader(List<string> header)
        {

        }

        public void SetContentType(List<string> data)
        {

        }

        public void SetAccept(List<string> data)
        {

        }

        private string DetectDataFormat()
        {
            return string.Empty;
        }

        public void SetData()
        {

        }

        public void SetCustomRequest()
        {

        }

        public string Exec()
        {
            return string.Empty;
        }
    }
}
