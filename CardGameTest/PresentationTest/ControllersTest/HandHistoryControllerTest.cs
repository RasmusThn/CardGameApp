using CardGamePresentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel;
using Moq;
using Service.Contracts;
using SharedDtos.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameTest.PresentationTest.ControllersTest
{
    public class HandHistoryControllerTest
    {
        private readonly Mock<IServiceManager> _serviceManagerMock;

        public HandHistoryControllerTest()
        {
            _serviceManagerMock = new Mock<IServiceManager>();
        }
        [Fact]
        public async Task GetAllHandHistoryTest()
        {
            //Arrange
            bool trackChanges = false;
            IEnumerable<HandHistoryDto> historyDtos = new List<HandHistoryDto>()
            {
                new HandHistoryDto(){Id=1,CardImgUrlOne = ""},
                new HandHistoryDto(){Id=2},
                new HandHistoryDto(){Id=3}
            };

            _serviceManagerMock
                .Setup(x=>x.HandHistoryService.GetAllHandHistoryAsync(trackChanges))
                .ReturnsAsync(historyDtos);
            //Act
            var result = await _serviceManagerMock.Object.HandHistoryService.GetAllHandHistoryAsync(trackChanges);

            //Assert
            Assert.Equal(historyDtos,result);
        }
        [Fact]
        public async Task GetAllHandHistory_ReturnTypeTest()
        {
            //Arrange
            bool trackChanges = false;
            IEnumerable<HandHistoryDto> historyDtos = new List<HandHistoryDto>()
            {
                new HandHistoryDto(){Id=1,CardImgUrlOne = ""},
                new HandHistoryDto(){Id=2},
                new HandHistoryDto(){Id=3}
            };
            _serviceManagerMock
                .Setup(x => x.HandHistoryService.GetAllHandHistoryAsync(trackChanges))
                .ReturnsAsync(historyDtos);
            var controller = new HandHistoryController(_serviceManagerMock.Object);

            //Act

            var taskIActionResult = controller.GetAllHandHistory();
            var result = taskIActionResult.Result as OkObjectResult;
            //Assert
            Assert.NotNull(taskIActionResult);
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public async Task CreateHandHistory()
        {
            //Arrange
            HandHistoryDto handHistoryDto = new HandHistoryDto();
            handHistoryDto.Id = 1;
            
            _serviceManagerMock
                .Setup(x=>x.HandHistoryService.CreateHandHistory(handHistoryDto))
                .ReturnsAsync(handHistoryDto);

            //Act
            var result = await _serviceManagerMock.Object.HandHistoryService.CreateHandHistory(handHistoryDto);
            
            //Assert
            Assert.Equal(handHistoryDto.Id, result.Id);
            Assert.Equal(handHistoryDto, result);
        }
        [Fact]
        public async Task CreateHandHistory_ReturnTypeTest()
        {
            //Arrange
            var handHistoryDto = new HandHistoryDto();

            _serviceManagerMock
                .Setup(x => x.HandHistoryService.CreateHandHistory(handHistoryDto))
                .ReturnsAsync(handHistoryDto);

            var controller = new HandHistoryController(_serviceManagerMock.Object);

            //Act
            var taskIActionResult = controller.CreateHandHistory(handHistoryDto);
            var result = taskIActionResult.Result as OkObjectResult;
            var objectResult = result.Value;
            //Assert
            Assert.NotNull(taskIActionResult);
            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<HandHistoryDto>(objectResult);
        }
    }
}
