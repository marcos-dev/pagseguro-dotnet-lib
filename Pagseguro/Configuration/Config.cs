using System;
using System.Collections.Generic;
using System.Text;

namespace RMC.Pagseguro.Configuration
{
    internal static class Config
    {
        private static bool _SandBox { get; set; }

        private static string _Email { get; set; }

        private static  string _TokenProduction {get; set;}

        private static string _TokenSandbox { get; set; }

        public static string _GetEmail()
        {
            return _Email;
        }

        public static bool IsSandBox()
        {
            return _SandBox;
        }

        public static void SetSandBox()
        {
            _SandBox = true;
        }

        public static void SetProduction()
        {
            _SandBox = false;
        }

        public static string GetToken()
        {
            return IsSandBox() ? _TokenSandbox : _TokenProduction;
        }


        public static void SetAccountCredenials(string email, string token, bool isSandbox = true)
        {
            _Email = email;

            if(isSandbox == true)
            {
                SetSandBox();
                _TokenSandbox = token;
            }
            else
            {
                SetProduction();
                _TokenProduction = token;
            }
        }
        
    }
}
