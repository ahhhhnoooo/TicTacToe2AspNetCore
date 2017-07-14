using System;

namespace TicTacToe2ASPNETCore.Models
{
    public class Game{
        public int ID { get; set; }
        public DateTime StartDateUTC { get; set; }
        public DateTime? EndDateUTC {get;set;}
        public bool XTurn{get;set;}
    }
}