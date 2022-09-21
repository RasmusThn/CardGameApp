using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Exceptions
{
    public sealed class CardNotFoundException : NotFoundException
    {
        public CardNotFoundException(int cardId) 
            : base($"The Card with Id: {cardId} doesn't exist in the database")
        {
        }
    }
}
