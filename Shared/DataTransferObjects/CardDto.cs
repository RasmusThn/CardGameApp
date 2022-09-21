
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDtos.DataTransferObjects
{
    public record CardDto(int Id,string Suit,char Number,
                            bool IsActive,string ImgUrl );
}
