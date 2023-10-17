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
using crudsGame.src.model.Items;
using crudsGame.src.interfaces;

namespace crudsGame.src.views
{
    public partial class MapTest : MaterialForm
    {
        List<HexagonControl> hexagonsList = new List<HexagonControl>();
        MapController mapController = MapController.GetInstance();
        int i = 0;
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
            LoadMap();
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
            if (pnMove.Visible == false)//CAMBIOSSSSSSSSSSSSSSS
            {
                HexagonControl clickedHexagon = sender as HexagonControl;

                int index = hexagonsList.IndexOf(clickedHexagon);
                hexagonsList[index].Enabled = true;
                //MessageBox.Show("indice hxagono clikeado: " + index);
                cbCurrentTerrain.SelectedIndex = index;
                //MessageBox.Show("index en combo currentTerrain: " + cbCurrentTerrain.SelectedIndex);
                ChangeColorOfSelectedHexagonAndTheirBorderingHexagons(mapController.GetTerrains((Map)cbMaps.SelectedItem)[index]);
            }

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



        private void LoadMap()
        {
            if (mapController.GetMaps().Count > 0)
            {
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

                //habria que hacer una validacion de que para generar un mapa debe haber mas de 40 entidades, comidas e items, ya que esta programado para que haya dos de cada una por terreno

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

            //habria que hacer una validacion de que para generar un mapa debe haber mas de 40 entidades, comidas e items, ya que esta programado para que haya dos de cada una por terreno

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
            //lbEntitiesOnAterrain.DataSource = ((Terrain)cbCurrentTerrain.SelectedItem).EntitiesList;
            LoadListBoxWithEntitiesOnATerrain();
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
            btnMoveInfo.Text = "MOVER entidad seleccionada (" + ((Entity)lbEntitiesOnAterrain.SelectedItem).name + ") a otro terreno";


            lbEnvironmentsOfAnEntity.DataSource = ((Entity)lbEntitiesOnAterrain.SelectedItem).environmentList;//funciona
            lbId.Text = "Id = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).id;
            lbName.Text = "Name = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).name;
            lbDiet.Text = "Diet = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).diet;
            lbRange.Text = "Attack Range = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).attackRange;
            lbKingdom.Text = "Kingdom = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).kingdom;


            UpdateProgressbars();

            cargarlistobentidadesposiblesdeataaque();








        }


        private void obtenerelementodelista(List<Entity> entities)
        {
            foreach (Entity e in entities)
            {
                lbEntitiesToAttack.Items.Add(e);
            }
        }

        private void cargarlistobentidadesposiblesdeataaque()
        {

            lbEntitiesToAttack.Items.Clear();
            if (((Entity)lbEntitiesOnAterrain.SelectedItem).attackRange == 1)
            {

                foreach (Terrain terr in ((Terrain)cbCurrentTerrain.SelectedItem).BorderingTerrainsList)//terrenos limitrofes del terreno actual
                {
                    obtenerelementodelista(terr.EntitiesList);
                }

                foreach (Entity entity in ((Terrain)cbCurrentTerrain.SelectedItem).EntitiesList)//entidades en terreno actual
                {
                    lbEntitiesToAttack.Items.Add(entity);
                }
            }
            else if (((Entity)lbEntitiesOnAterrain.SelectedItem).attackRange == 0)
            {
                foreach (Entity entity in ((Terrain)cbCurrentTerrain.SelectedItem).EntitiesList)//entidades en terreno actual
                {
                    lbEntitiesToAttack.Items.Add(entity);
                }
            }

            lbEntitiesToAttack.Items.Remove((Entity)lbEntitiesOnAterrain.SelectedItem);//elimina el seleccionado

            if (lbEntitiesToAttack.Items.Count > 0)
            {
                lbEntitiesToAttack.SelectedIndex = 0;
            }

        }


        private void UpdateProgressbars()
        {
            lbCurrentLife.Text = "Current Life = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).currentLife;
            pbCurrentLife.Value = ((Entity)lbEntitiesOnAterrain.SelectedItem).currentLife;


            lbCurrentEnergy.Text = "Current Energy = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).currentEnergy;
            pbCurrentEnergy.Value = ((Entity)lbEntitiesOnAterrain.SelectedItem).currentEnergy;

            lbAttack.Text = "Attack Points = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).attackPoints;
            pbAttackPoints.Value = ((Entity)lbEntitiesOnAterrain.SelectedItem).attackPoints;

            lbDefense.Text = "Defense Points = " + ((Entity)lbEntitiesOnAterrain.SelectedItem).defensePoints;
            pbDefensePoints.Value = ((Entity)lbEntitiesOnAterrain.SelectedItem).defensePoints;



        }

        private void btnEat_Click(object sender, EventArgs e)
        {
            try
            {
                ((Entity)lbEntitiesOnAterrain.SelectedItem).Eat(((Entity)lbEntitiesOnAterrain.SelectedItem), ((Food)lbFoodsOnAterrain.SelectedItem));
                UpdateProgressbars();
            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
                UpdateProgressbars();
            }

        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            try
            {
                ((Entity)lbEntitiesOnAterrain.SelectedItem).UsarItem(((Entity)lbEntitiesOnAterrain.SelectedItem), ((Item)lbItemsOnAterrain.SelectedItem));
                UpdateProgressbars();
            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
                UpdateProgressbars();
            }


        }

        public void LoadListBoxWithEntitiesOnATerrain()
        {

            lbEntitiesOnAterrain.Items.Clear();
            foreach (Entity creatures in ((Terrain)cbCurrentTerrain.SelectedItem).EntitiesList)
            {
                lbEntitiesOnAterrain.Items.Add(creatures);
            }

            if (lbEntitiesOnAterrain.Items.Count > 0)
            {
                lbEntitiesOnAterrain.SelectedIndex = 0;
            }

        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            try
            {
                int result = ((Entity)lbEntitiesOnAterrain.SelectedItem).BeingAttacked(((Entity)lbEntitiesOnAterrain.SelectedItem).Attack(((Entity)lbEntitiesToAttack.SelectedItem)), ((Entity)lbEntitiesToAttack.SelectedItem));
                if (result == 1)//puede ser con booleanos esto en vez de int
                {
                    //MessageBox.Show("la vida esta en 0 de la entidad player one: " + ((Entity)lbEntitiesOnAterrain.SelectedItem).name);
                    new MessageBoxDarkMode(((Entity)lbEntitiesToAttack.SelectedItem).name + " mató a " + ((Entity)lbEntitiesOnAterrain.SelectedItem).name + "!!!", "ATENCIÓN", "Ok", Resources.ko, true);
                    mapController.eliminarDelMapaUnaEntidadqMurio((Entity)lbEntitiesOnAterrain.SelectedItem, (Map)cbMaps.SelectedItem);//no me va a dejar eliminar porque esta con el datasource
                    LoadListBoxWithEntitiesOnATerrain();
                    cargarlistobentidadesposiblesdeataaque();
                }
                else if (result == 2)
                {
                    //MessageBox.Show("la vida esta en 0 de la entidad player two: " + ((Entity)lbEntitiesToAttack.SelectedItem).name);
                    new MessageBoxDarkMode(((Entity)lbEntitiesOnAterrain.SelectedItem).name + " mató a " + ((Entity)lbEntitiesToAttack.SelectedItem).name + "!!!", "ATENCIÓN", "Ok", Resources.ko, true);
                    mapController.eliminarDelMapaUnaEntidadqMurio((Entity)lbEntitiesToAttack.SelectedItem, (Map)cbMaps.SelectedItem);
                    cargarlistobentidadesposiblesdeataaque();
                    LoadListBoxWithEntitiesOnATerrain();
                }

                UpdateProgressbars();
                UpdateInfoPlayerTWO();

            }
            catch (Exception ex)
            {
                new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
                UpdateProgressbars();
            }
        }

        private void UpdateInfoPlayerTWO()
        {
            if (lbEntitiesToAttack.Items.Count > 0)
            {
                pnAttack.Enabled = true;
                lbCurrentLifePlayerTwo.Text = "Current Life = " + ((Entity)lbEntitiesToAttack.SelectedItem).currentLife;
                pbCurrentLifePlayerTwo.Value = ((Entity)lbEntitiesToAttack.SelectedItem).currentLife;
            }
            else
            {
                pnAttack.Enabled = false;
            }

        }
        private void lbEntitiesToAttack_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfoPlayerTWO();


        }


        private void Hexagon_ClickForMove(object sender, EventArgs e)
        {
            Terrain terrenoAnteriorSeleccionado = (Terrain)cbCurrentTerrain.SelectedItem;
            HexagonControl clickedHexagon = sender as HexagonControl;

            int index = hexagonsList.IndexOf(clickedHexagon);
            //MessageBox.Show("indice hxagono clikeado: " + index);
            //cbCurrentTerrain.SelectedIndex = index;
            //MessageBox.Show("index en combo currentTerrain: " + cbCurrentTerrain.SelectedIndex);
            ChangeColorOfSelectedHexagonToMove(mapController.GetTerrains((Map)cbMaps.SelectedItem)[index], terrenoAnteriorSeleccionado);
        }


        private void ChangeColorOfSelectedHexagonToMove(Terrain terrainDondeSeMovera, Terrain terrenoAnteriorSeleccionado)
        {

            ResetHexagonBorderColor();
            hexagonsList[((Terrain)cbCurrentTerrain.SelectedItem).Id].BorderColor = Color.Yellow;
            hexagonsList[((Terrain)cbCurrentTerrain.SelectedItem).Id].Enabled = false;

            for (int i = 0; i < ((Terrain)cbCurrentTerrain.SelectedItem).BorderingTerrainsList.Count(); i++)
            {
                hexagonsList[terrenoAnteriorSeleccionado.BorderingTerrainsList[i].Id].BorderColor = Color.DarkOrange;
            }


            hexagonsList[terrainDondeSeMovera.Id].BorderColor = Color.DarkViolet;//este vendria a ser a donde se va a mover


            btnMove.Text = "Mover a " + ((Entity)lbEntitiesOnAterrain.SelectedItem).name + " al terreno N°" + terrainDondeSeMovera.Id;
        }

        private void btnMoveInfo_Click(object sender, EventArgs e)
        {
            pnMove.Visible = true;
            lbMoveInfo.Text = "Haga click sobre el hexagono \ndonde quiera que se mueva \n" + ((Entity)lbEntitiesOnAterrain.SelectedItem).name + ". Tenga en cuenta que \nsólo podrá moverse sobre los \nterrenos limítrofes";
            foreach (var hexagon in hexagonsList)
            {
                //MessageBox.Show(hexagon.Name);
                hexagon.Click += Hexagon_ClickForMove;
            }
            btnMoveInfo.Visible = false;

            cbCurrentTerrain.Enabled = false;
            pnAttack.Enabled = false;
            pnEntities.Enabled = false;
            pnFoods.Enabled = false;
            pnItems.Enabled = false;



            btnMove.Visible = true;

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (var hexagon in hexagonsList)
            {
                if (hexagon.BorderColor == Color.DarkViolet)
                {
                    index = hexagonsList.IndexOf(hexagon);
                }
                // O utiliza el color original del borde
            }
            Terrain terr = (((Map)cbMaps.SelectedItem).TerrainsList[index]);
            MessageBox.Show("terreno seleccionado en color violeta: " + terr.ToString());

            if (mapController.chequearQueUnTerrenoEnParticularSeaLimitrofeDelTerrenoActualSeleccionado(((Terrain)cbCurrentTerrain.SelectedItem),terr)==true)
            {
                try
                {
                    if (((Entity)lbEntitiesOnAterrain.SelectedItem).MoveThrough(terr.TerrainType) == true)
                    {

                        //borrar la entidad del terreno donde se encuentra
                        mapController.eliminarUnaEntidadDeUnTerreno(((Entity)lbEntitiesOnAterrain.SelectedItem), (Terrain)cbCurrentTerrain.SelectedItem);



                        //luego agregarla a el terreno donde se va a mover
                        mapController.agregarEntidadAlTerrenoDondeSeMovio(((Entity)lbEntitiesOnAterrain.SelectedItem), terr);



                        MessageBox.Show("se puede..");

                        pnMove.Visible = false;

                        hexagonsList[((Terrain)cbCurrentTerrain.SelectedItem).Id].Enabled = true;

                        //hayq volver a llamar al hexagon click anterior
                        foreach (var hexagon in hexagonsList)
                        {
                            //MessageBox.Show(hexagon.Name);
                            hexagon.Click += Hexagon_Click;
                        }

                        LoadListBoxWithEntitiesOnATerrain();
                        btnMove.Visible = false;
                        btnMoveInfo.Visible = true;

                        cbCurrentTerrain.Enabled = true;
                        pnAttack.Enabled = true;
                        pnEntities.Enabled = true;
                        pnFoods.Enabled = true;
                        pnItems.Enabled = true;



                    }
                    /*
                    else
                    {
                        MessageBox.Show("no se puede..");
                    }
                    */

                }
                catch (Exception ex)
                {
                    new MessageBoxDarkMode(ex.Message, "ALERTA", "Ok", Resources.warning, true);
                }

            }
            else
            {
                new MessageBoxDarkMode("No se puede mover la entidad hasta el terreno N°"+terr.Id+" (esta muy lejos). Recuerde solo podra moverse en los terrenos limitrofes (bordes de color naranja)", "ERROR", "Ok", Resources.error, true);
            }
            


        }
    }
}
