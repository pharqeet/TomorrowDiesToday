﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TomorrowDiesToday.Services.Game
{
    public interface IGameService
    {
        string GameId { get; set; }

        string PlayerId { get; set; }

        string GenerateGameId();
    }
}
