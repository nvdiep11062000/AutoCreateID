using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace AutoCreateID.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey(string strInput)
        {
            string numPart, strPart, personKey = "", newNumPart = "";
            int intNumber;
            numPart = Regex.Match(strInput, @"\d+").Value;
            intNumber = Convert.ToInt32(numPart) + 1;
            for (int i = 0; i < numPart.Length - intNumber.ToString().Length; i++)
            {
                newNumPart += "0";
            }
            newNumPart += intNumber;
            strPart = numPart = Regex.Match(strInput, @"\D+").Value;
            personKey = strPart + newNumPart;
            return personKey;
        }
    }
}