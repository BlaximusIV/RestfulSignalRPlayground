using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestBusinessLogic.Models;

namespace TestService.DataAccess
{
    /// <summary>
    /// A factory for generating the test repository.
    /// </summary>
    public static class TestFactory
    {
        private static readonly Random _random = new Random();

        /// <summary>
        /// Generates a variable-length list of TestModels
        /// </summary>
        /// <returns></returns>
        public static List<TestModel> GenerateTestmodels()
        {
            List<TestModel> returnModels = new List<TestModel>();

            for (int i = 0; i < buildRandomInt(0, 1000); i++ )
                returnModels.Add(buildRandomTestModel(returnModels.Count + 1));
            

            return returnModels;
        }

        /// <summary>
        /// returns a randomly generated integer value;
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        private static int buildRandomInt(int min = 0, int max = 50) =>
            _random.Next(min, max);

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

        /// <summary>
        /// Creates a well-formatted random phone number
        /// </summary>
        /// <returns></returns>
        private static string buildRandomPhoneNumber()
        {
            string countryCode = buildRandomInt(1, 9).ToString();
            string areaCode = buildRandomInt(100, 999).ToString();
            string preNumber = buildRandomInt(100, 999).ToString();
            string postNumber = buildRandomInt(1000, 9999).ToString();

            return string.Join("-", countryCode, areaCode, preNumber, postNumber);
        }

        /// <summary>
        /// Builds a test model object
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static TestModel buildRandomTestModel(int id) => new TestModel
        {
            ID = id,
            FirstName = buildRandomString(),
            LastName = buildRandomString(),
            PhoneNumber = buildRandomPhoneNumber()
        };
    }
}