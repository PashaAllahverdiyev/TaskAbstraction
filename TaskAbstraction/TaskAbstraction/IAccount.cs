﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAbstraction
{
    internal interface IAccount
    {
        public bool PasswordChecker(string password);

        public void ShowInfo();
    }
}
