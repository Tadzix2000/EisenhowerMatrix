﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EisenhowerCore
{
    internal class ProgramLogicInput : Input
    {
        public ProgramLogicInput(string message) : base(message)
        {
        }

        protected override bool IsInputValid() => value.ToLower() == "c" || value.ToLower() == "s";

        public bool Running()
        {
            if (value == "c")
                return true;
            else
            {
                return false;
            }
        }
    }
}