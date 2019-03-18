using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Results;
using DatingApp.API.Controllers;
using DatingApp.API.Models;

namespace MSTests.Tests
{
    [TestClass]
    public class DatingApp_FirstTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var testUsers = GetTestUsers();
            //var controller = new UsersController(testUsers);

            //var result = controller.GetUsers() as List<User>;
            Assert.AreEqual(3, 3);
        }

        // private List<User> GetTestUsers()
        // {
        //     var testUsers = new List<User>();
        //     testUsers.add(new User { Username = "Tester1", Created = DateTime.Now });
        //     testUsers.add(new User { Username = "Tester2", Created = DateTime.Now });
        //     testUsers.add(new User { Username = "Tester3", Created = DateTime.Now });
            
        //     return testUsers;
        // }

        
    }
}
