using MicroService;
using MicroService.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Net.Http;

namespace Test.DevOps
{
    public class Tests
    {
        private RequestModel fakeModel;
        private ILogger<DevOpsController> logger;

        [SetUp]
        public void Setup()
        {
            fakeModel = new RequestModel()
            {
                message = "This is a test",
                to = "Roger Achig",
                from = "Fernando Aguilar",
                timeToLifeSec = 45
            };
            logger = Mock.Of<ILogger<DevOpsController>>();
        }

        [Test]
        public void WebApiMethodResponseType()
        {
            var devOpsController = new DevOpsController(logger);
            var actionResult = devOpsController.Post(fakeModel);

            //Assert
            Assert.IsAssignableFrom<ResponseModel>(actionResult);
        }

        [Test]
        public void WebApiMethodResponseMessage()
        {
            var devOpsController = new DevOpsController(logger);
            var actionResult = devOpsController.Post(fakeModel);

            //Assert
            Assert.AreEqual($"Hello { fakeModel.to } your message will be send", actionResult.message);
        }
    }
}