using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static crudsGame.src.views.MaterialUI;
using MaterialSkin.Controls;
using crudsGame.Properties;
using crudsGame.src.controllers;
using crudsGame.src.model.Terrains.Map;
using crudsGame.src.model.Terrains;
using crudsGame.src.model;

namespace crudsGame.src.views
{
    public partial class MapTest : MaterialForm
    {
        List<HexagonControl> hexagonsList = new List<HexagonControl>();
        MapController mapController = MapController.GetInstance();
        public MapTest()
        {
            InitializeComponent();
            LoadMaterial(this);
            AddHexagonsToList();
            foreach (var hexagon in hexagonsList)
            {
                //MessageBox.Show(hexagon.Name);
                hexagon.Click += Hexagon_Click;
            }
            for (int i = 0; i < hexagonsList.Count(); i++)
            {
                hexagonsList[i].HexagonText = $"{i}";
            }
        }

        private void AddHexagonsToList()
        {
            hexagonsList.AddRange(new List<HexagonControl>
            {
                hex0, hex1, hex2, hex3, hex4, hex5,
                hex6, hex7, hex8, hex9, hex10, hex11,
                hex12, hex13, hex14, hex15, hex16, hex17,
                hex18
            });

            int i = 0;
            foreach (var hexagon in hexagonsList)
            {
                //MessageBox.Show("nombre: " + hexagon.Name + ", index: " + i);
                i++;
            }
            /*hexagons = this.Controls
            .OfType<HexagonControl>()
            .OrderBy(control => control.Name)
            .ToList();*/
        }


        private void Hexagon_Click(object sender, EventArgs e)
        {
            HexagonControl clickedHexagon = sender as HexagonControl;

            int index = hexagonsList.IndexOf(clickedHexagon);
            //MessageBox.Show("indice hxagono clikeado: " + index);
            cbCurrentTerrain.SelectedIndex = index;
            //MessageBox.Show("index en combo currentTerrain: " + cbCurrentTerrain.SelectedIndex);
            ChangeColorOfSelectedHexagonAndTheirBorderingHexagons(mapController.GetTerrains((Map)cbMaps.SelectedItem)[index]);
        }

        private void ResetHexagonBorderColor()
        {
            foreach (var hexagon in hexagonsList)
            {
                hexagon.BorderColor = SystemColors.ControlText; // O utiliza el color original del borde
            }
        }

        private void ChangeColorOfSelectedHexagonAndTheirBorderingHexagons(Terrain terrain)
        {
            ResetHexagonBorderColor();
            hexagonsList[terrain.Id].BorderColor = Color.Yellow;
            //MessageBox.Show("terreno que debe coindir: " + terrain.ToString());
            for (int i = 0; i < terrain.BorderingTerrainsList.Count(); i++)
            {
                hexagonsList[terrain.BorderingTerrainsList[i].Id].BorderColor = Color.DarkOrange;
            }
        }

        private void btnGenerateMap_Click(object sender, EventArgs e)
        {
            mapController.GenerateMap();
            cbMaps.DataSource = mapController.GetMaps();



            cbCurrentTerrain.DataSource = mapController.GetTerrains((Map)cbMaps.SelectedItem);
            lbBonderingTerrains.DataSource = mapController.GetBorderingTerrains((Terrain)cbCurrentTerrain.SelectedItem);

            /*
            foreach (Terrain i in mapController.GetBorderingTerrains((Terrain)cbCurrentTerrain.SelectedItem))
            {
                lbBorderingTerrains.Items.Add(i.ToString());
            }
            */
            //lbBorderingTerrains.DataSource= mapController.GetBorderingTerrains((Terrain)cbCurrentTerrain.SelectedItem);


            //quedaa este q seria terreno a donde se moveraa formController.RefreshDataSource(bsSelectedLand, cbSelectedLand, () => mapController.getLands((Map)cbMaps.SelectedItem));


            cbMaps.SelectedIndex = 0;
            PaintHexagons();
            btnGenerateMap.Enabled = false;

            //habria que hacer una validacion de que para generar un mapa debe haber mas de 36 entidades, comidas e items, ya que esta programado para que haya dos de cada una por terreno

        }

        private void PaintHexagons()
        {
            List<Terrain> terrainsList = mapController.GetTerrains((Map)cbMaps.SelectedItem);

            for (int i = 0; i < hexagonsList.Count(); i++)
            {
                hexagonsList[i].BackColor = terrainsList[i].TerrainType.getColor();
            }
        }

        private void cbCurrentTerrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBonderingTerrains.DataSource = mapController.GetBorderingTerrains((Terrain)cbCurrentTerrain.SelectedItem);
            lbEntitiesOnAterrain.DataSource = ((Terrain)cbCurrentTerrain.SelectedItem).EntitiesList;
            lbFoodsOnAterrain.DataSource = ((Terrain)cbCurrentTerrain.SelectedItem).FoodsList;
            lbItemsOnAterrain.DataSource = ((Terrain)cbCurrentTerrain.SelectedItem).ItemsList;
            ChangeColorOfSelectedHexagonAndTheirBorderingHexagons((Terrain)cbCurrentTerrain.SelectedItem);

        }



        private void lbEnvironmentsOfAnEntity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbEntitiesOnAterrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            MessageBox.Show("NOMBRE DE ENTIDAD SELECCIONADA: " + ((Entity)lbEntitiesOnAterrain.SelectedItem).name);
            foreach (var s in ((Entity)lbEntitiesOnAterrain.SelectedItem).environmentList)
            {
                MessageBox.Show("ambiente: " + s.ToString());
            }
            */
            lbEnvironmentsOfAnEntity.DataSource = ((Entity)lbEntitiesOnAterrain.SelectedItem).environmentList;//funciona
            lbId.Text = "Id = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).id;
            lbName.Text = "Name = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).name;
            lbDiet.Text = "Diet = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).diet;

            lbCurrentLife.Text = "Current Life = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).currentLife;
            pbCurrentLife.Value = ((Entity)lbEntitiesOnAterrain.SelectedItem).currentLife;


            lbCurrentEnergy.Text = "Current Energy = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).currentEnergy;
            pbCurrentEnergy.Value = ((Entity)lbEntitiesOnAterrain.SelectedItem).currentEnergy;

            lbAttack.Text = "Attack Points = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).attackPoints;
            pbAttackPoints.Value = ((Entity)lbEntitiesOnAterrain.SelectedItem).attackPoints;

            lbDefense.Text = "Defense Points = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).defensePoints;
            pbDefensePoints.Value = ((Entity)lbEntitiesOnAterrain.SelectedItem).defensePoints;


            lbRange.Text = "Attack Range = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).attackRange;


        }
    }
}
