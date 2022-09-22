using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDtos.DataTransferObjects
{
    public record CardDeckDto
    {
        public List<CardDto> CardList { get; set; }
        public int CardAmount { get; set; }
    }
}
