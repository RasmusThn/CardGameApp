using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class HandHistory
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
