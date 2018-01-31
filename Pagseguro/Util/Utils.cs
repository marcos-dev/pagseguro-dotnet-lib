using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RMC.Pagseguro.Util
{
    internal static class Utils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns>string</returns>
        public static string OnlyNumbers(string number)
        {
            return Regex.Replace(number, @"[^\d]", "");
        }

        public static bool ValidCpf(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
                return false;

            cpf = OnlyNumbers(cpf);
            cpf = cpf.PadLeft(11, '0');

            if (cpf.Length != 11 ||
            cpf == "00000000000" ||
            cpf == "11111111111" ||
            cpf == "22222222222" ||
            cpf == "33333333333" ||
            cpf == "44444444444" ||
            cpf == "55555555555" ||
            cpf == "66666666666" ||
            cpf == "77777777777" ||
            cpf == "88888888888" ||
            cpf == "99999999999") {
                return false;
            }
            

            //TODO: Implementar Validações

            return true;
        }

    }
}
