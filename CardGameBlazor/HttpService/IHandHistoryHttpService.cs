﻿using SharedDtos.DataTransferObjects;

namespace CardGameBlazor.HttpService
{
    public interface IHandHistoryHttpService
    {
        Task CreateHandHistoryAsync(HandHistoryDto hand);
    }
}
