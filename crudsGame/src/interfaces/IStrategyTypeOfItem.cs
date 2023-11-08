using crudsGame.src.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.interfaces
{
    public interface IStrategyTypeOfItem
    {
        public bool ApplyItem(Entity entity);
    }
}
