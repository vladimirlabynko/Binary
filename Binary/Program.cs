using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static string myStringOutput;
        static string thirdparam;
        private static readonly Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> {
    { '0', "0000" },
    { '1', "0001" },
    { '2', "0010" },
    { '3', "0011" },
    { '4', "0100" },
    { '5', "0101" },
    { '6', "0110" },
    { '7', "0111" },
    { '8', "1000" },
    { '9', "1001" },
    { 'a', "1010" },
    { 'b', "1011" },
    { 'c', "1100" },
    { 'd', "1101" },
    { 'e', "1110" },
    { 'f', "1111" }
                                                                                                                   };

        public static string HexStringToBinary(string hex)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in hex)
            {
                
                result.Append(hexCharacterToBinary[char.ToLower(c)]);
            }
            return result.ToString();
        }

       static string HexConverted(string strBinary)
        {
            string strHex = Convert.ToInt32(strBinary, 2).ToString("X");
            return strHex;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        static void Main(string[] args)
        {
            string start = "5FABFF01";
            
           string result= HexStringToBinary(start);
            char[] arr;
            arr = result.ToCharArray(0, result.Length);
            Console.WriteLine("Исходная строка : {0}", start);//Given string    
            Console.WriteLine("Бинарная строка : {0}", result);// converted string to bin

            for(int i=4; i<8; i++)
            {
                myStringOutput += arr[i];
            }
            string firstparam = HexConverted(myStringOutput);
            Console.WriteLine("Первый параметр в двоичной системе = {0}", myStringOutput);// first parametr in binary
            Console.WriteLine("Первый параметр = {0}",firstparam);//first parametr in HEX

            if (arr[6] == '1')
            {
                arr[6] = '0';
            }
            else arr[6] = '1';

            for (int i = 16; i < 20; i++)
            {
                thirdparam += arr[i];
            }
           
            Console.WriteLine("Второй параметр = {0}", arr[6]);//second parametr
            string revthird = Reverse(thirdparam);
            string sp = HexConverted(revthird);
            Console.WriteLine("Третий параметр в двоичной системе = {0}", revthird);//third parametr in binary
            Console.WriteLine("Третий параметр = {0}", sp);// third parametr in hex
            Console.ReadKey();
        }


       

    }
}


