using crudsGame.src.model;
using crudsGame.src.model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.interfaces
{
    public interface IInteractuable
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public bool Type { get; set; }

        //public int Value { get; set; }

        //void Interact(IEntity entity); //puedo usar el metodo caneat y accedo a la energia con entity. ...

        bool Interact(Entity entity);


    }


}
