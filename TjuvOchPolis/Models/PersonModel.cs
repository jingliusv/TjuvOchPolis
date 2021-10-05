using System;
using System.Collections.Generic;
using System.Threading;

namespace TjuvOchPolis
{
    class PersonModel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Inriktning { get; set; }

        
        public List<PositionModel> PersonPositionHistory = new List<PositionModel>();

        public PersonModel()
        {
            StadModel stan = new StadModel();
            this.X = RandomPositionDirection.GenerateRandomX(stan);
            this.Y = RandomPositionDirection.GenerateRandomY(stan);
            this.Inriktning = RandomPositionDirection.GetRandomDirection();           
            PersonPositionHistory.Add(new PositionModel(X, Y));           
        }
         
    }
}
