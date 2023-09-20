using crudsGame.src.controllers.ItemsCtn;
using crudsGame.src.factoryMethod;
using crudsGame.src.interfaces;
using crudsGame.src.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsGame.src.controllers
{
    internal class EntityController
    {
        private static EntityController? Instance;


        private EntityController() { }

        public static EntityController getInstance()
        {
            if (Instance == null)
            {
                Instance = new EntityController();
            }
            return Instance;
        }

        /*
        public Entity CreateEntity(int id, IKingdom kingdom, string name, IDiet diet, IEnvironment environment, int maxEnergy, int maxLife, int attack, int defense, int range)
        {

            return new Entity(id, kingdom, name, diet, environment, maxEnergy, maxEnergy, maxLife, maxLife, attack, defense, range);

        }
        */


        public void AddEntity(Entity entity, List<Entity> entityList, DataGridView dgvEntity)
        {
            entityList.Add(entity); //se carga en la lista
            int x = dgvEntity.Rows.Add(); //se carga la tabla
            /*
            dgvEntity.Rows[x].Cells[0].Value = entity.Id;
            dgvEntity.Rows[x].Cells[1].Value = entity.Kingdom;
            dgvEntity.Rows[x].Cells[2].Value = entity.Name;
            dgvEntity.Rows[x].Cells[3].Value = entity.Diet;
            dgvEntity.Rows[x].Cells[4].Value = entity.Environment;
            dgvEntity.Rows[x].Cells[5].Value = entity.AttackPoints;
            dgvEntity.Rows[x].Cells[6].Value = entity.DefensePoints;
            dgvEntity.Rows[x].Cells[7].Value = entity.AttackRange;
            dgvEntity.Rows[x].Cells[8].Value = entity.MaxEnergy;
            dgvEntity.Rows[x].Cells[9].Value = entity.CurrentEnergy;
            dgvEntity.Rows[x].Cells[10].Value = entity.MaxLife;
            dgvEntity.Rows[x].Cells[11].Value = entity.CurrentLife;
            */

        }

        public int UpdateAnEntity(int rows, DataGridView dgvEntity, Entity entity)
        {
            /*
            dgvEntity.Rows[rows].Cells[0].Value = entity.Id;
            dgvEntity.Rows[rows].Cells[1].Value = entity.Kingdom;
            dgvEntity.Rows[rows].Cells[2].Value = entity.Name;
            dgvEntity.Rows[rows].Cells[3].Value = entity.Diet;
            dgvEntity.Rows[rows].Cells[4].Value = entity.Environment;
            dgvEntity.Rows[rows].Cells[5].Value = entity.AttackPoints;
            dgvEntity.Rows[rows].Cells[6].Value = entity.DefensePoints;
            dgvEntity.Rows[rows].Cells[7].Value = entity.AttackRange;
            dgvEntity.Rows[rows].Cells[8].Value = entity.MaxEnergy;
            dgvEntity.Rows[rows].Cells[9].Value = entity.CurrentEnergy;
            dgvEntity.Rows[rows].Cells[10].Value = entity.MaxLife;
            dgvEntity.Rows[rows].Cells[11].Value = entity.CurrentLife;
            */

            return rows = 0; 

        }

        /*
        public void DeleteAnEntity(int r)
        {
            for (int i = 0; i < entityList.Count; i++)
            {
                if (i == r)
                {
                    entityList.RemoveAt(i);
                }
            }
        }
        */
    }
}
