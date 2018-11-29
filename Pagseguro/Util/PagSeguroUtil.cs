using System;
using System.Collections.Generic;
using System.Text;

namespace RMC.Pagseguro.Util
{
    public class PagSeguroUtil
    {

        protected List<string> Post { get; set; }

        protected string Url { get; set; }

        protected List<string> Get { get; set; }

        protected bool Result { get; set; }

        protected HttpUrlUtil HttpUtil { get; set; }


        PagSeguroUtil()
        {
            HttpUtil = new HttpUrlUtil();
        }

        /// <summary>
        /// Build URL
        /// </summary>
        /// <returns></returns>
        public string BuildUrl()
        {

            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Send()
        {
            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Build()
        {


        }

    }
}
