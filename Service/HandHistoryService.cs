using AutoMapper;
using Contracts;
using Entites.Models;
using Service.Contracts;
using SharedDtos.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class HandHistoryService : IHandHistoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;
        public HandHistoryService(IRepositoryManager repository, ILoggerManager loggerManager , IMapper mapper)
        {
            _repository = repository;
            _loggerManager = loggerManager;
            _mapper = mapper;

        }

        public async Task<HandHistoryDto> CreateHandHistory(HandHistoryDto handHistory)
        {
            var handHistoryEntity = _mapper.Map<HandHistory>(handHistory);

             _repository.HandHistory.CreateHandHistory(handHistoryEntity);
            await _repository.SaveAsync();
           
            var HandHistoryReturn = _mapper.Map<HandHistoryDto>(handHistoryEntity);
            return HandHistoryReturn;
        }

        public async Task<IEnumerable<HandHistoryDto>> GetAllHandHistoryAsync(bool trackChanges)
        {
            var hands = await _repository.HandHistory.GetAllHandHistoryAsync(trackChanges);

            var handsDto = _mapper.Map<IEnumerable<HandHistoryDto>>(hands);

            return handsDto;
        }
    }
}
