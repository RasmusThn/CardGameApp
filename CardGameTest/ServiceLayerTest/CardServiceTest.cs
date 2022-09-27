using AutoMapper;
using Contracts;
using Entites.Models;
using Moq;
using Service;
using Service.Contracts;
using SharedDtos.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameTest.ServiceLayerTest
{
    public class CardServiceTest
    {

        private readonly Mock<ICardService> _cardServiceMock = new();
        public CardServiceTest()
        {
            _cardServiceMock = new Mock<ICardService>();
        }
        [Fact]
        public async Task GetCardAsyncTest()
        {
            //Arrange

            bool trackchanges = false;
            var cardId = 1;
            CardDto card1 = new CardDto();
            var cardreturn = new CardDto()
            {
                Id = cardId
            };

            _cardServiceMock.Setup(x => x.GetCardAsync(cardId, trackchanges))
                .ReturnsAsync(cardreturn);
            //Act
            card1 = await _cardServiceMock.Object.GetCardAsync(cardId, trackchanges);
            //Assert
            Assert.Equal(1, card1.Id);

        }
        [Fact]
        public async Task GetAllCardsAsyncTest()
        {
            //Arrange
            bool trackchanges = false;
            List<CardDto> cardList = new List<CardDto>()
            {
                new CardDto() { Id = 1 },
                new CardDto() { Id = 2 },
                new CardDto() { Id = 3}
            };
            _cardServiceMock.Setup(x => x.GetAllCardsAsync(trackchanges))
                .ReturnsAsync(cardList);

            //Act
            List<CardDto> cardListResult = (List<CardDto>)await _cardServiceMock.Object.GetAllCardsAsync(trackchanges);

            //Assert
            Assert.Equal(cardList, cardListResult);
        }
    }
}
