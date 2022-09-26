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
    [Route("/handhistory")]
    [ApiController]
    public class HandHistoryController : ControllerBase
    {
        private readonly IServiceManager _service;
        public HandHistoryController(IServiceManager service) => _service = service;

        [HttpPost]
        public async Task<IActionResult> CreateHandHistory([FromBody] HandHistoryDto handHistory)
        {
           var createdHand = await _service.HandHistoryService.CreateHandHistory(handHistory);

            return Ok(createdHand);
        }
    }
}
