using KodotiAzureDevOps.Api.Controllers;
using KodotiAzureDevOps.Services.InMemoryData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodotiAzureDevOps2.Tests
{
    [TestClass]
    public class UserControllerGetTest
    {
        [TestMethod]
        public void TryToGetNotFoundStatusCode()
        {
            ApplicationDbContext.Initialize();

            // Get Controller
            var controller = new UserController();

            // Find a record by USD code
            var result = controller.Get(Guid.NewGuid());

            // Check
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}
