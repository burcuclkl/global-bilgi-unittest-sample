using global_bilgi_unittest_sample.Controllers;
using global_bilgi_unittest_sample.ORM;
using global_bilgi_unittest_sample.Repository.Interfaces;
using global_bilgi_unittest_sample.Repository.Manager;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace globa_bilgi_unit_test_sample.test.ControllerTests
{
    public class WebUserControllerTests
    {

        private readonly Mock<IWebUserRepository> _webuserRepository;
        private WebUserController _webUserController;

        public WebUserControllerTests()
        {
            _webuserRepository = new Mock<IWebUserRepository>();
            _webUserController = new WebUserController(_webuserRepository.Object);

            _webuserRepository.Setup(q => q.GetWebUserById(It.IsAny<int>())).Returns(new WebUser() { EMail = "cagatay@mail.com", Name = "Çağatay" });
        }

        [Fact]
        public void Index()
        {

            List<WebUser> webUsers = new List<WebUser>();
            webUsers.Add(new WebUser() { Id = 1, EMail = "z@z.com" });

            _webuserRepository.Setup(q => q.GetAll()).Returns(webUsers);

            var result = _webUserController.Index() as ViewResult;

            Assert.NotNull(result);

        }

        [Theory]
        [InlineData(0)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void GetWebUserById(int id)
        {

            var result = _webUserController.GetWebUserById(id);

            Assert.NotNull(result);
        }
    }
}
