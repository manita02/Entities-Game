using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.interfaces
{
    public interface IDiet
    {
        bool CanEat(IEntity entity, IFood food); //preguntar maurooo
        string ToString();

        
    }
}
