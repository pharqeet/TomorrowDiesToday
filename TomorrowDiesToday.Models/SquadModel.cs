﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TomorrowDiesToday.Models
{
    public class SquadModel : IModel
    {
        public string SquadId { get; set; }

        public Dictionary<string, int> Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<string, int> Stats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime Timestamp => throw new NotImplementedException();

        public SquadModel()
        {
            Stats.Add("Combat", 0);
            Stats.Add("Stealth", 0);
            Stats.Add("Cunning", 0);
            Stats.Add("Diplomacy", 0);

            Data.Add("Thief", 0);
            Data.Add("Hacker", 0);
            Data.Add("Soldier", 0);
            Data.Add("Assassin", 0);
            Data.Add("Fixer", 0);
            Data.Add("Scientist", 0);

            Data.Add("Faced Henchmen", 0);

            Data.Add("Hypnotic Spray", 0);
            Data.Add("Explosive Rounds", 0);

            Data.Add("Ugo Combat", 0);
            Data.Add("Ugo Stealth", 0);
            Data.Add("Ugo Cunning", 0);
            Data.Add("Ugo Diplomacy", 0);
        }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
