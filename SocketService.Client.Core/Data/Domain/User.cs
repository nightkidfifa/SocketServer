﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocketService.Framework.Client.Data.Domain
{
    public class User
    {
        public string UserName
        {
            get;
            set;
        }

        public Room Room
        {
            get;
            set;
        }

        public Guid ClientKey
        {
            get;
            set;
        }
    }
}
