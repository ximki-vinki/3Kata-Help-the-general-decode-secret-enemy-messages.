using System;
using System.Linq;
using System.Text;

namespace _3Kata_Help_the_general_decode_secret_enemy_messages_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

    }
    public static class Decoder
    {
        public static string Decode(string p_what)
        {
            string allChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,? ";
            string exceptChar = "!@#$%^&*()_+-";
            char[] p_whatArray = p_what.ToCharArray();
            char[] p_whatEncoderArray = new char[p_what.Length];


            for (int i = 0; i < allChar.Length; i++)
            {
                for (int j = 0; j < p_what.Length; j++) p_whatEncoderArray[j] = allChar[i];
                string p_whatEncoder = Encoder.Encode(new string(p_whatEncoderArray));

                for (int j = 0; j < p_what.Length; j++)
                {
                    if (exceptChar.Where(x => x == p_what[j]).Any()) continue;
                    if (p_what[j] == p_whatEncoder[j])
                    {
                        p_whatArray[j] = allChar[i];
                        continue;
                    }
                }
            }
            return new string(p_whatArray);
        }
    }
}
