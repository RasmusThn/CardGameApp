using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDtos.DataTransferObjects
{
    public record CardDeckDto(List<CardDto> CardList, int CardAmount);
}
