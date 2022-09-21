using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using SharedDtos.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGamePresentation.Controllers
{
    [Route("/carddeck")]
    [ApiController]
    public class CardDeckController : ControllerBase
    {
        private readonly IServiceManager _service;
        public CardDeckController(IServiceManager service) => _service = service;

        [HttpPost]
        public IActionResult CreateCardDeck([FromBody] CardDeckForCreationDto cardDeck)
        {
            if (cardDeck is null)
            {
                return BadRequest("CardDeckForCreationDto object is null");
            }

                var createdCardDeck = _service.CardDeckService.CreateCardDeck(cardDeck);

                return Ok(createdCardDeck);
        }
    }
}
