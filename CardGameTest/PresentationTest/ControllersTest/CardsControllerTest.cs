using CardGamePresentation.Controllers;
using Contracts;
using Entites.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Service;
using Service.Contracts;
using SharedDtos.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameTest.PresentationTest.ControllersTest
{
    public class CardsControllerTest
    {
        private readonly CardsController _cardController;
        private readonly Mock<IServiceManager> _serviceManagerMock = new();
        

        public CardsControllerTest()
        {
            _cardController = new CardsController(_serviceManagerMock.Object);
        }

        [Fact]
        public async Task GetCardTest()
        {
            //Arrange
            int id = 1;
            bool trackChanges = false;

            CardDto cardDto = new CardDto() { Id = id };
            var mockservice = new Mock<IServiceManager>();

            //mockservice.Setup(x => x.CardService.GetCardAsync(id, trackChanges))
            //    .Returns(Task.FromResult(cardDto));


            //_cardControllerMock.Setup(x => x.Ok())
            //    .ReturnsAsync(Task.FromResult(cardDto));

            mockservice
                .Setup(x => x.CardService.GetCardAsync(id,trackChanges))
                .ReturnsAsync(cardDto);


            //Act
            var result = (CardDto)await _cardController.GetCard(id);
            //Assert
            Assert.Equal(cardDto, result);
            //Assert.IsType<CardNotFoundException>(result);

        }
    }
}
