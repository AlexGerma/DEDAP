using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace ORM
{
    public class Validaciones
    {

        public static bool letras(string Chaa)
        {
            Regex regEx = new Regex(@"^[a-zA-ZñÑ]$");
            return regEx.IsMatch(Chaa);
        }
        public static bool Cha(string ch)
        {
            Regex regEx = new Regex(@"^[a-zA-ZñÑ0-9]{0,1}$");
            return regEx.IsMatch(ch);
        }
        public static bool numeros(string Num)
        {
            Regex regEx = new Regex(@"^[0-9]{0,3}$");
            return regEx.IsMatch(Num);
        }
        public static bool Deecimal(string Dec)
        {
            Regex regEx = new Regex(@"^\-{ 0, 1 }\d + (.\d +){ 0,1}$");
            return regEx.IsMatch(Dec);
        }
        public static bool dooble(String Dob)
        {
            Regex regEx = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            return regEx.IsMatch(Dob);
        }
        
    }
}
