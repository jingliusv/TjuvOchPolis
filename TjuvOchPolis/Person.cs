﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace TjuvOchPolis
{
    class Person : IMovePerson
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Inriktning { get; set; }

        Stan stan = new Stan();
        
        List<Position> PersonPositionHistoria = new List<Position>();

        public Person()
        {           
            this.X = GenerateRandomX(stan);
            this.Y = GenerateRandomY(stan);
            this.Inriktning = GetRandomDirection();           
            PersonPositionHistoria.Add(new Position(X, Y));           
        }

        public void CheckPosition()
        {
            if(X == 0)
                this.X = stan.Width;
            else if(X == stan.Width)
                this.X = 0;
            else if(Y == 0)
                this.Y = stan.Height;
            else if (Y == stan.Height)
                this.Y = 0;
        }

        public void DrawPerson(string output)
        {
            foreach (Position pos in PersonPositionHistoria)
            {
                Console.SetCursorPosition(pos.X, pos.Y);
                Console.Write(output);
                Console.CursorVisible = false;
            }
        }

        public void Move()
        {
            switch (Inriktning)
            {
                case Direction.Höger:
                    X++;
                    break;
                case Direction.Vänster:
                    X--;
                    break;
                case Direction.Upp:
                    Y++;
                    break;
                case Direction.Ner:
                    Y--;
                    break;
                case Direction.SnettHöger:
                    X++;
                    Y++;
                    break;
                case Direction.SnettVänster:
                    X--;
                    Y--;
                    break;
            }
           
            PersonPositionHistoria.Add(new Position(X, Y));
            PersonPositionHistoria.RemoveAt(0);
            Thread.Sleep(50);
        }

        

        private static Direction GetRandomDirection()
        {
            Random rnd = new Random();
            Type type = typeof(Direction);
            Array values = type.GetEnumValues();
            int index = rnd.Next(0, Enum.GetNames(typeof(Direction)).Length);
            Direction value = (Direction)values.GetValue(index);
            return value;
        }

        private int GenerateRandomX(Stan stan)
        {
            Random rnd = new Random();
            return rnd.Next(0, stan.Width);
        }

        private int GenerateRandomY(Stan stan)
        {
            Random rnd = new Random();
            return rnd.Next(0, stan.Height);
        }

    }
}
