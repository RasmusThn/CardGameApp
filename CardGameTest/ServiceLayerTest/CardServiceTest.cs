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
        private readonly IServiceManager _serviceManager;
        private readonly Mock<IRepositoryManager> _repositoryManagerMock = new();
        private readonly Mock<ILoggerManager> _loggerManagerMock = new();
        private readonly Mock<IMapper> _mapperMock = new();
        public CardServiceTest()
        {
            _serviceManager= new ServiceManager(_repositoryManagerMock.Object,_loggerManagerMock.Object, _mapperMock.Object);
        }
        [Fact]
        public async Task GetCardAsyncTest()
        {
            //Arrange
            int id = 1;
            bool trackchanges = false;
            Card card1 = new Card();
           await _serviceManager.CardService.GetCardAsync(id, trackchanges);
            //Act
           
            //Assert
           
        }
    }
}
