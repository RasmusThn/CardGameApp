using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDtos.DataTransferObjects
{
    public record HandHistoryDto
    {
        public int Id { get; set; }
        public int Round { get; set; }
        public string? CardImgUrlOne { get; set; }
        public string? CardImgUrlTwo { get; set; }
        public string? CardImgUrlThree { get; set; }
        public string? CardImgUrlFour { get; set; }
        public string? CardImgUrlFive { get; set; }
    }
}
