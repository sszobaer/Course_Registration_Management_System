﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMS
{
    public static class SessionManager
    {
        public static bool IsLoggedIn { get; set; }
        public static string AdminName { get; set; }
    }
}
