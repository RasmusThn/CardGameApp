using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDtos.DataTransferObjects
{
    public record HandHistoryDto
    //(int Id , int Round, int CardIdOne, int CardIdTwo,
    //int CardIdThree, int CardIdFour, int CardIdFive);
    {
        public int Id { get; set; }
        public int Round { get; set; }
        public int CardIdOne { get; set; }
        public int CardIdTwo { get; set; }
        public int CardIdThree { get; set; }
        public int CardIdFour { get; set; }
        public int CardIdFive { get; set; }
    }
}
