using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ui.Controllers;
using Ui.Data;
using Ui.Entities;
using Ui.Models;
using Ui.Services;
using Ui.ViewModelMappers;

namespace Ui.Tests.Controllers
{
    [TestClass]
    public class RobsDogsControllerTest
    {
        [TestMethod]
        public void Should_Controller_Return3DogsForRob()
        {
            // Arrange
            var _dogOwnerRepositoryMock = new Mock<IDogOwnerRepository>();
            var _dogRepositoryMock = new Mock<IDogRepository>();
            var dogOwnerList = new List<DogOwner> { new DogOwner { Name = "Rob" } };
            var dogList = new List<Dog> { new Dog { Name = "Willow" }, new Dog { Name = "Nook" }, new Dog { Name = "Sox" } };

            _dogOwnerRepositoryMock.Setup(o => o.GetAllDogOwners()).Returns(dogOwnerList);
            //_dogRepositoryMock.Setup(o => o.GetDogsByOwner(It.IsAny<string>())).Returns(dogList);
            _dogRepositoryMock.Setup(o => o.GetDogsByOwner(It.IsNotIn("Rob"))).Returns(new List<Dog>());
            _dogRepositoryMock.Setup(o => o.GetDogsByOwner("Rob")).Returns(dogList);

            var _dogService = new DogService(_dogRepositoryMock.Object);
            var _dogOwnerService = new DogOwnerService(_dogOwnerRepositoryMock.Object, _dogService);
            var _dogOwnerViewModelMapper = new DogOwnerViewModelMapper(_dogOwnerService);
            RobsDogsController _controller = new RobsDogsController(_dogOwnerViewModelMapper);

            // Act
            var result = _controller.Index() as ViewResult;

            // Assert
            // Should be testing/verifying call to GetAllDogOwners and subsequent methods down the stack.
            // Moq is installed to help you.
            Assert.IsNotNull(result);
            // normally separate test at each layer controller, service, repo etc, but add this check in for speed
            var res = ((DogOwnerListViewModel)result.Model).DogOwnerViewModels.Where(dgo => dgo.OwnerName == "Rob").SelectMany(d => d.DogNames);
            Assert.AreEqual(3, res.Count());

        }
    }
}