﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SocketService.Framework.SharedObjects;

namespace SocketService.Framework.Client.Response
{
    [Serializable]
    public class UpdateRoomVariableResponse : IResponse
    {
        public string Room
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public RoomVariable Value
        {
            get;
            set;
        }

    }
}
