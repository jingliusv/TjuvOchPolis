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
            StanModel stan = new StanModel();
            this.X = GetRandomPositionDirection.GenerateRandomX(stan);
            this.Y = GetRandomPositionDirection.GenerateRandomY(stan);
            this.Inriktning = GetRandomPositionDirection.GetRandomDirection();           
            PersonPositionHistory.Add(new PositionModel(X, Y));           
        }
         
    }
}
