using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Timers;

namespace TestLanguageFeatures
{
    class Program
    {
        public class Example
        {
            public string Greeting { get; set; }

            public Example() => Greeting = "Hello there!";

            public Example(string Greeting) => this.Greeting = Greeting;
        }

        public class CuratedIncludeUid
        {
            public string type { get; set; }
            public string uid { get; set; }

            public override bool Equals(object obj)
            {
                var item = obj as CuratedIncludeUid;

                return uid.Equals(item.uid) && type.Equals(item.type);
            }

            public override int GetHashCode() => 
                uid.GetHashCode();
        }
        public enum ExampleEnum
        {
            ValueA,
            ValueB,
            ValueC,
            ValueD,
            ValueE
        }

        private static readonly Random random = new Random();

        private static List<Example> examples;

        static void Main(string[] args)
        {
            //Random random = new Random();
            //IEnumerable<int> testEnum = new List<int>() { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            //IEnumerable<DateTime> testDates = new List<DateTime>() { DateTime.Now.AddDays(-7), DateTime.Now.AddDays(-6), DateTime.Now.AddDays(-5), DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1), DateTime.Now };
            //List<int> testList = new List<int>();

            try
            {
                for (int i = 0; i < 1000; i++)
                    Console.WriteLine(buildRandomString());
                

                Console.WriteLine("No Problem");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Problem: " + ex.Message);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// returns a randomly generated integer value;
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        private static int buildRandomInt(int min = 0, int max = 50) =>
            random.Next(min, max);

        /// <summary>
        /// Returns a random character from the ascii values between 0-Z
        /// </summary>
        /// <returns></returns>
        private static char buildRandomCharacter() =>
            (char)buildRandomInt(48, 90);

        /// <summary>
        /// Creates a randomly sized string from random character values.
        /// </summary>
        /// <returns></returns>
        private static string buildRandomString()
        {
            char[] chars = new char[buildRandomInt()];
            for (int i = 0; i < chars.Length; i++)
                chars[i] = buildRandomCharacter();

            return new string(chars);
        }


    }

}
