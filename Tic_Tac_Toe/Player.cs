using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tic_Tac_Toe
{
    class Player
    {
        private static int Id = 1;
        public string Name { get; set; }

        public Player()
        {
            Name = "Player " + Id.ToString();
            Id++;
        }

        public Player(string Name)
        {
            this.Name = Name;
            Id++;
        }

        public string checkRow()
        {
            Console.Write("Type row index: ");
            return Console.ReadLine();
        }
        public string checkColumn()
        {
            Console.Write("Type column index: ");
            return Console.ReadLine();
        }
    }
}
