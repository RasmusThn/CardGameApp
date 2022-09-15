using CardLibrary.AbstractCards;
using CardLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary.Cards
{
    public class Hearts : AbstractHearts
    {
        //public override Enum Color => CardColors.Hearts;
        public Enum Color { get; set; }
    }
}
