using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.App.Abstract
{
    internal interface IPrimaryServices<T>
    {
        List<T> Elements { get; set; }

        void AddElement(T obj);

        List<T> GetElements(string type);        
    }
}
