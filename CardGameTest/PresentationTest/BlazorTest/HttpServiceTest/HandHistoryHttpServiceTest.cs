using CardGameBlazor.HttpService;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SharedDtos.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameTest.PresentationTest.BlazorTest.HttpServiceTest
{
    public class HandHistoryHttpServiceTest
    {
        private readonly Mock<IHandHistoryHttpService> _handHttpMock = new();

        public HandHistoryHttpServiceTest()
        {
            _handHttpMock = new Mock<IHandHistoryHttpService>();
        }
        [Fact]
        public async Task GetAllHandHistoryAsyncTest()
        {
            //Arrange
            string cardUrlName = "/images/cards/1";
            List<HandHistoryDto> historyDtos = new List<HandHistoryDto>()
            {
                new HandHistoryDto(){Id=1,CardImgUrlOne = cardUrlName},
                new HandHistoryDto(){Id=2},
                new HandHistoryDto(){Id=3}
            };

            _handHttpMock.Setup(x => x.GetAllHandHistoryAsync())
                .ReturnsAsync(historyDtos);
            //Act

            List<HandHistoryDto> result = await _handHttpMock.Object.GetAllHandHistoryAsync();

            //Assert
            Assert.Equal(historyDtos, result);

        }
      
    }
}
