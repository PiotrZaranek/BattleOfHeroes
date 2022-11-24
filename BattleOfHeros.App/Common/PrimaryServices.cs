using BattleOfHeroes.App.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.App.Common
{
    public abstract class PrimaryServices<T> : IPrimaryServices<T>
    {
        public List<T> Elements { get; set; }

        public void AddElement(T obj)
        {
            Elements.Add(obj);
        }

        public List<T> GetElements(string type)
        {
            return Elements;
        }

        protected abstract void Initialize();
    }
}
