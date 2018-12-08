using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    class Program
    {
        static char[] charLib = {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '~', '!', '@', '#', '$', '%', '^', '&', '*'};

        static Random random = new Random();

        static void Main(string[] args)
        {
            int nPasswordNums = 0;

            Console.WriteLine("This is a Password Generator.");

            ReadInput: Console.Write("Please input the password numbers you want:");
            string strPasswordNums = Console.ReadLine();
            if (!int.TryParse(strPasswordNums, out nPasswordNums))
            {
                Console.WriteLine("Please input the numbers!");
                goto ReadInput;
            }

            Console.WriteLine("Password: " + createPassword(nPasswordNums));

            Console.Write("Generate again?(y/n)");
            string strIsAgain = Console.ReadLine();
            if (strIsAgain == "y" || strIsAgain == "Y" || strIsAgain == "yes" || strIsAgain == "Yes" || strIsAgain == "YES")
            {
                goto ReadInput;
            }
        }

        static string createPassword(int nums)
        {
            string sbPassword = "";

            for (int i = 0; i < nums; i++)
            {
                //随机选择里面其中的一种字符生成
                switch (random.Next(4))
                {
                    case 0:
                        sbPassword += createNum();
                        break;
                    case 1:
                        sbPassword += createSmallAbc();
                        break;
                    case 2:
                        sbPassword += createBigAbc();
                        break;
                    case 3:
                        sbPassword += createSpecialChar();
                        break;
                }
            }
            return sbPassword;
        }

        /// <summary>
        /// 生成单个大写随机字母
        /// </summary>
        static string createBigAbc()
        {
            //A-Z的 ASCII值为65-90
            int num = random.Next(65, 91);
            string abc = Convert.ToChar(num).ToString();
            return abc;
        }

        /// <summary>
        /// 生成单个小写随机字母
        /// </summary>
        static string createSmallAbc()
        {
            //a-z的 ASCII值为97-122
            int num = random.Next(97, 123);
            string abc = Convert.ToChar(num).ToString();
            return abc;
        }

        /// <summary>
        /// 生成单个随机数字
        /// </summary>
        static int createNum()
        {
            int num = random.Next(10);
            return num;
        }

        /// <summary>
        /// 生成特殊字符
        /// </summary>
        static string createSpecialChar()
        {
            int num = 33;
            switch (random.Next(2))
            {
                case 0:
                    num  = random.Next(33, 47);
                    break;
                case 1:
                    num = random.Next(91, 96);
                    break;
            }
            
            string special = Convert.ToChar(num).ToString();
            return special;
        }
    }
}
