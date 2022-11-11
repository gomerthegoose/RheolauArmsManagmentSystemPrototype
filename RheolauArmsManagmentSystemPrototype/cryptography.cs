using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheolauArmsManagmentSystemPrototype
{
    internal class Cryptography
    {

        public string encryptStr(string input)
        {

            return input;
        }

        public string decryptStr(string input)
        {
            char[] inputCharArray = input.ToCharArray();
            byte[] asciiValues = Encoding.ASCII.GetBytes(inputCharArray);
            string output = "";

            for (int i =0; i < asciiValues.Length; i++)
            {
                asciiValues[i] = (byte)(asciiValues[i] + (byte) 2);
                asciiValues[i] = (byte)(asciiValues[i] - (byte)2);
                output += (char)asciiValues[i];
            }
            return output;
        }

    }
}
