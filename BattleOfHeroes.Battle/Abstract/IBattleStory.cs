﻿using BattleOfHeroes.BattleApp.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Abstract
{
    public interface IBattleStory
    {
        int Id { get; set; }
        string PlayerOne { get; set; }        
        string PlayerTwo { get; set; }        
        BattleList BattleList { get; set; }
    }
}
