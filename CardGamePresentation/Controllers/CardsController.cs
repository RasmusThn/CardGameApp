using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGamePresentation.Controllers
{
    [Route("cards")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly IServiceManager _service;
        public CardsController(IServiceManager service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> GetCards()
        {
            var cards = await _service.CardService.GetAllCardsAsync(trackChanges: false);
            return Ok(cards);
        }
        [HttpGet("{id:int}", Name ="CardById")]
        public async Task<IActionResult> GetCard(int id)
        {
            var card = await _service.CardService.GetCardAsync(id, trackChanges: false);
            return Ok(card);
        }
        [HttpGet]
        [Route("/random")]
        public async Task<IActionResult> GetRandomActiveCard()
        {
            var card = await _service.CardService.GetRandomActiveCard(trackChanges: false);
            return Ok(card);
        }
    }
}
