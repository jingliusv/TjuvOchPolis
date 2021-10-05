using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    class MovePerson
    {
        public static void MoveAndShowPerson(string symbol, PersonModel person, StadModel stan)
        {
            DrawPerson(symbol, person);
            CheckPosition(person,stan);
            Move(person);
        }

        private static void DrawPerson(string output, PersonModel person)
        {
            foreach(PositionModel pos in person.PersonPositionHistory)
            {
                Console.SetCursorPosition(pos.X, pos.Y);
                Console.Write(output);
                Console.CursorVisible = false;
            }
        }

        private static void Move(PersonModel person)
        {
            switch (person.Inriktning)
            {
                case Direction.Höger:
                    person.X++;
                    break;
                case Direction.Vänster:
                    person.X--;
                    break;
                case Direction.Upp:
                    person.Y++;
                    break;
                case Direction.Ner:
                    person.Y--;
                    break;
                case Direction.SnettHöger:
                    person.X++;
                    person.Y++;
                    break;
                case Direction.SnettVänster:
                    person.X--;
                    person.Y--;
                    break;
            }

            person.PersonPositionHistory.Add(new PositionModel(person.X, person.Y));
            person.PersonPositionHistory.RemoveAt(0);
            Thread.Sleep(50);
        }

        private static void CheckPosition(PersonModel person, StadModel stan)
        {
            if (person.X == 0)
                person.X = stan.Width;
            else if (person.X == stan.Width)
                person.X = 0;

            if (person.Y == 0)
                person.Y = stan.Height;
            else if (person.Y == stan.Height)
                person.Y = 0;
        }

    }
}
