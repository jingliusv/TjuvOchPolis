﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolis
{
    public interface IMovePerson
    {
        void DrawPerson(string output);
        void Move();
        void CheckPosition();
    }
}