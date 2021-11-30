using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randarr=RandomArray();
            GetrandomArr(randarr);
            Printmaxmin(randarr);
            Printsum(randarr);
            string coinstr=TossCoin();
           double cointossed= TossMultipleCoins(2);
           Console.WriteLine(cointossed);

           List<string> name= Names();
           Namelength(name);

        }

        public static void Printmaxmin(int[] randarr)
        {
            int max=randarr[0];
            int min=randarr[0];
            for(int i=0; i<randarr.Length;i++)
            {
                if(randarr[i]>max)
                {
                    max=randarr[i];
                }
                if(randarr[i]<min)
                {
                    min=randarr[i];
                }
            }
            Console.WriteLine("max is:"+max);
            Console.WriteLine("min is:"+min);
        }
public static void Printsum(int[] randarr)
        {
            int sum=0;
            for(int i=0;i<randarr.Length;i++)
            {
                sum += randarr[i];
            }
            Console.WriteLine("sum is:"+sum);

        }
        public static void GetrandomArr(int[] randarr)
        {
            for(int i=0;i<randarr.Length;i++)
            {
                Console.Write(randarr[i]+",");
            }
        }

        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] arr=new int[10];
            for(int i=0;i<10;i++)
            {
                arr[i]=rand.Next(5,25);
            }
            return arr;
        }

        public static string TossCoin()
        {
            string str="Tossing a coin";
            Console.WriteLine(str);
            Random random= new Random();
            int val=random.Next(0,1);
            if(val == 0)
            {
                Console.WriteLine("Head");
                return "Head";
            }
            else{
                Console.WriteLine("Tail");
                return "Tail";
            }
        
        }

        public static double TossMultipleCoins(int num)
        {
            int head = 0;
            for(int i=0;i<num;i++)
            {
                if (TossCoin() == "Head")
                {
                    head++;
                }
                
            }
            return head / num;
        }
        public static List<string> Names()
        {
            List<string> names = new List<string>();
                names.Add("Todd");
                names.Add("Tiffany");
                names.Add("Charlie");
                names.Add("Geneva");
                names.Add("Sydney");
            List<string> names1 = new List<string>();
            Random random= new Random();
            var randomized = names.OrderBy(item => random.Next());
             foreach (var value in randomized)
             {
               
                Console.WriteLine(value);
                if(value.Length >5)
                {
                  names1.Add(value);
                }
    }
    return names1;
}
public static void Namelength(List<string> names1)
{
    for(int i=0;i<names1.Count;i++)
    {
    Console.WriteLine("More than 5 letter names are:"+names1[i]);
    }
}
}
}
