using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MyUserDataModels.Models;

namespace MyHelloBO
{
    public class HelloService
    {
        public string GetHelloWorld()
        {
            return "Hello .net Standard 2.0 Web API Framework!!!.";
        }

        public IEnumerable<User> GetUsers()
        {
            MyBusinessDemoDBContext context = new MyBusinessDemoDBContext();

            var result = context.User.ToList();

            return result;
        }
    }
}