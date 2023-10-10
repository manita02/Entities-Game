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
                hexagon.Click += Hexagon_Click;
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
            /*hexagons = this.Controls
            .OfType<HexagonControl>()
            .OrderBy(control => control.Name)
            .ToList();*/
        }


        private void Hexagon_Click(object sender, EventArgs e)
        {
            HexagonControl clickedHexagon = sender as HexagonControl;

            int index = hexagonsList.IndexOf(clickedHexagon);
            cbCurrentTerrain.SelectedIndex = index;
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
            hexagonsList[terrain.Id].BorderColor = Color.HotPink;
            for (int i = 0; i < terrain.BorderingTerrainsList.Count(); i++)
            {
                hexagonsList[terrain.BorderingTerrainsList[i].Id].BorderColor = Color.Red;
            }
        }

        private void btnGenerateMap_Click(object sender, EventArgs e)
        {
            mapController.GenerateMap();
            cbMaps.DataSource = mapController.GetMaps();



            cbCurrentTerrain.DataSource = mapController.GetTerrains((Map)cbMaps.SelectedItem);

            foreach (Terrain i in mapController.GetBorderingTerrains((Terrain)cbCurrentTerrain.SelectedItem))
            {
                lbBorderingTerrains.Items.Add(i.ToString());
            }
            //lbBorderingTerrains.DataSource= mapController.GetBorderingTerrains((Terrain)cbCurrentTerrain.SelectedItem);


            //quedaa este q seria terreno a donde se moveraa formController.RefreshDataSource(bsSelectedLand, cbSelectedLand, () => mapController.getLands((Map)cbMaps.SelectedItem));


            cbMaps.SelectedIndex = 0;
            PaintHexagons();
            //btnGenerateMap.Enabled = false;

        }

        private void PaintHexagons()
        {
            List<Terrain> terrainsList = mapController.GetTerrains((Map)cbMaps.SelectedItem);

            for (int i = 0; i < hexagonsList.Count(); i++)
            {
                hexagonsList[i].BackColor = terrainsList[i].TerrainType.getColor();
            }
        }


        //queda ver el de generar map mepa q voy a tener q meter el id de mapa para hacerlo funcar como lista
    }
}
