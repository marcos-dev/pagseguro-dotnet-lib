using System;
using System.Collections.Generic;
using System.Text;

namespace RMC.Pagseguro.Configuration
{
    internal static class Url
    {
        public static string GetWs()
        {
            return  Config.IsSandBox() ? "https://ws.sandbox.pagseguro.uol.com.br/" : "https://ws.pagseguro.uol.com.br/";
        }

        public static string GetPage()
        {
            return Config.IsSandBox() ? "https://sandbox.pagseguro.uol.com.br/" : "https://pagseguro.uol.com.br/";
        }

        public static string GetStc()
        {
            return Config.IsSandBox() ? "https://stc.sandbox.pagseguro.uol.com.br/" : "https://stc.pagseguro.uol.com.br/";
        }
    }
}
