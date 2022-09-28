using Contracts;
using Moq;
using Service.Contracts;
using SharedDtos.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameTest.ServiceLayerTest
{
    public class HistoryHandServiceTest
    {
        private readonly Mock<IHandHistoryService> _handServiceMock = new();
        private bool _trackChanges = false;
        public HistoryHandServiceTest()
        {
            _handServiceMock = new Mock<IHandHistoryService>();
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

            _handServiceMock.Setup(x => x.GetAllHandHistoryAsync(_trackChanges))
                .ReturnsAsync(historyDtos);
            //Act
            List<HandHistoryDto> historyDtosResults = (List<HandHistoryDto>)
                await _handServiceMock.Object.GetAllHandHistoryAsync(_trackChanges);
            //Assert
            Assert.Equal(historyDtos, historyDtosResults);
            Assert.True(historyDtosResults.Any());
            Assert.Equal(historyDtos[1].Id, historyDtosResults[1].Id);
            Assert.Equal(historyDtosResults[0].CardImgUrlOne, cardUrlName);
        }
        [Fact]
        public async Task CreateHandHistoryAsyncTest()
        {
            //Arrange
            string cardUrlName = "/images/cards/1";
            HandHistoryDto historyDtoExpected = new HandHistoryDto()
            {
                Id=1,
                CardImgUrlOne = cardUrlName,
                CardImgUrlTwo = "",
                CardImgUrlThree = "",
                CardImgUrlFour = "",
                CardImgUrlFive = "",
                Round = 1

            };

            _handServiceMock.Setup(x=>x.CreateHandHistory(historyDtoExpected))
                .ReturnsAsync(historyDtoExpected);
            //Act
            HandHistoryDto handHistoryResult = await _handServiceMock.Object.CreateHandHistory(historyDtoExpected);
            
            //Assert
            Assert.Equal(historyDtoExpected, handHistoryResult);
            Assert.Equal(1, handHistoryResult.Round);
        }

    }
}
