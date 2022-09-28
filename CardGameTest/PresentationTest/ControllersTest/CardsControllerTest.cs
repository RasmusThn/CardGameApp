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
        
        private readonly Mock<IServiceManager> _serviceManagerMock;
        public CardsControllerTest()
        {
            _serviceManagerMock = new Mock<IServiceManager>();
        }

        [Fact]
        public async Task GetCardTest()
        {
            //Arrange
            int id = 1;
            bool trackChanges = false;

            CardDto cardDto = new CardDto() { Id = id };

            _serviceManagerMock
                .Setup(x => x.CardService.GetCardAsync(id, trackChanges))
                .ReturnsAsync(cardDto);


            //Act

            var result = await _serviceManagerMock.Object.CardService.GetCardAsync(id, trackChanges);

            //Assert
            Assert.Equal(cardDto, result);

        }
        [Fact]
        public async Task GetCardTest_ReturnType()
        {
            //Arrange
            int id = 1;
            bool trackChanges = false;
            CardDto cardDto = new CardDto() { Id = id };

            _serviceManagerMock
                .Setup(x => x.CardService.GetCardAsync(id, trackChanges))
                .ReturnsAsync(cardDto);

            var cardController = new CardsController(_serviceManagerMock.Object);
            //Act
            var taskIactionResult = cardController.GetCard(id);
            var result = taskIactionResult.Result as OkObjectResult;
            var objectResult = result.Value;

            var IncorrectIactionResult = cardController.GetCard(2);
            var IncResult = IncorrectIactionResult.Result;

            //Assert

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<CardDto>(objectResult);
            //null
            Assert.IsNotType<OkObjectResult>(IncorrectIactionResult);

        }
        [Fact]
        public async Task GetCardsTest()
        {
            //Arrange
            bool trackChanges = false;
            IEnumerable<CardDto> cards = new List<CardDto>()
            {  
                new CardDto(){Id=1},
                new CardDto(){Id=2},
                new CardDto(){Id=3}
            };

            _serviceManagerMock
                .Setup(x=>x.CardService.GetAllCardsAsync(trackChanges))
                .ReturnsAsync(cards);
            //Act
            var result =  await _serviceManagerMock.Object.CardService.GetAllCardsAsync(trackChanges);

            //Assert
            Assert.Equal(cards, result);
            //Assert.NotEqual(cards, result);
        }
        [Fact]
        public async Task GetCardsTest_ReturnType()
        {
            //Arrange
            bool trackChanges = false;
            IEnumerable<CardDto> cards = new List<CardDto>()
            {
                new CardDto(){Id=1},
                new CardDto(){Id=2},
                new CardDto(){Id=3}
            };

            _serviceManagerMock
                .Setup(x => x.CardService.GetAllCardsAsync(trackChanges))
                .ReturnsAsync(cards);
            var cardController = new CardsController(_serviceManagerMock.Object);
            //Act
            var taskIActionResult = cardController.GetCards();
            var result = taskIActionResult.Result;

            //Assert
            Assert.IsType<OkObjectResult>(result);
            //Assert.IsNotType<OkObjectResult>(result);
        }
    }
}
