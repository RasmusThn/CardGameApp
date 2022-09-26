using Microsoft.AspNetCore.Components;
using SharedDtos.DataTransferObjects;

namespace CardGameBlazor.Components
{
    public partial class HistoryComponent
    {
        [Parameter]
        public List<HandHistoryDto>? HistoryList { get; set; }


    }
}
