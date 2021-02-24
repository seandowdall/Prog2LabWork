using System;

namespace Lab_Strings
{
    class Program
    {
        static string one = "123456789.com";
        static string str = "my secrets";
        static void Main(string[] args)
        {

            //q1(one);
            //q2(one);
            //Console.WriteLine(q3(one));
            //q4(one);
            //Console.WriteLine(IsFirstCharacterNumeric(one));
            //InsertDashesOne(one);
            // Console.WriteLine(RemoveSpecialCharacters(one));
            //InsertDashes(one);
            //Console.WriteLine(q8(one));
            Console.WriteLine(Encrypt(str));

        }
        static string q1(string one)
        {
            
            for (int i =0;i<one.Length;i++)
            {
                Console.WriteLine(one[i]);
            }
            return one;
        }
        static string q2(string one)
        {
            for (int i = 0; i < one.Length; i++)
            {
                for (int count = 2;  count<one.Length;count=count+3)
                {
                    if (i == count)
                    {
                        Console.WriteLine(one[i]);

                    }
                }
                
                
            }
            return one;

        }
        static int q3(string one)
        {
            int count = 0;
            for (int i = 0; i < one.Length;i++)
            {
                
                if (one[i] == 'x')
                {
                    count++;
                }
                else if (one[i]== 'y')
                {
                    count++;
                }
                
 
            }
            return count;
        }
        static string q4(string one)
        {
            for (int i = 0; i < one.Length; i++)
            {
                
                if (i==3||i==4||i==5||i==9||i==10||i==11)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(one[i]);
                }

            }
            return one;
        }
        static bool IsFirstCharacterNumeric(string one)
        {
            bool isTrue;
            if (one.Length > 0 && char.IsDigit(one[0]))
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
            return isTrue;
        }
        static string InsertDashesOne(string one)
        {
            int count = 2;
            
            for (int i = 0; i < one.Length; i++)
            {
                Console.Write(one[i]);
                if (i == count)
                {
                    Console.Write("-");
                    count = count + 3;
                }  
            }
            return one;  
        }
        static string RemoveSpecialCharacters(string one)
        {
            string newSentance = "";

            for (int i = 0; i < one.Length; i++)
            {
                if (one[i].ToString() != "%" && one[i].ToString() != " " && one[i].ToString() != "'" && one[i].ToString() != "$")
                {
                    newSentance = newSentance + one[i];
                }
            }

            return newSentance;
        }
        static string InsertDashes(string one)
        {
            for (int i = 3; i < one.Length; i=i+4)
            {
                one = one.Insert(i, "-");
            }
            return one;
        }
        static bool q8(string one)
        {
            bool checkEndOfString = one.EndsWith(".com");
            bool check = false;
            if(checkEndOfString == true)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
        static string Encrypt(string str)
        {

            char[] array = str.ToCharArray();
            for (int i = 0; i < str.Length; i+=2)
            {
                char temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;

            }
            return new string(array);
        }
       












    }
}
