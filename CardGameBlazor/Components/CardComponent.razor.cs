
using Microsoft.AspNetCore.Components;
using SharedDtos.DataTransferObjects;

namespace CardGameBlazor.Components
{
    public partial class CardComponent
    {
        [Parameter]
        public CardDto? Card { get; set; }

    
    }
}
