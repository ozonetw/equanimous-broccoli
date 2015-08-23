﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Polenter.Serialization;

namespace mindnalytics
{
    public partial class TimeLine : Form
    {

        

        public CargarAssets assets;
        string selectedList = "None";

        public TimeLine(CargarAssets assets)
        {
            InitializeComponent();
            this.assets = assets;
            /*
            foreach (Grupo grupo in grupoToSave)
            {
                ListViewItem itm = new ListViewItem(grupo.nombre);
                listView1.Items.Add(itm);
            }
             */ 
        }

        private void TimeLine_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAsset_Click(object sender, EventArgs e)  
        {
            if (selectedList == "Assets"){
                
                string name = "";
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    name = item.Text;


                    string[] row = new string[] { tablaTimeline.RowCount+1+"", name, "GA" };
                    tablaTimeline.Rows.Add(row);
                }
                
            }
            if(selectedList=="Narrativas"){
                string name = "";
                foreach (ListViewItem item in listView2.SelectedItems)
                {
                    name = item.Text;


                    string[] row = new string[] { tablaTimeline.RowCount + 1 + "", name, "N" };
                    tablaTimeline.Rows.Add(row);
                }
            }else{
                MessageBox.Show("Selecciona una lista primero");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.assets.narrativas.Show();
        }

        public void refreshLists()
        {

            listView2.Items.Clear();
            listView1.Items.Clear();
            foreach (Narrativa narrTL in this.assets.narrativas.listaNarrativas)
            {
                ListViewItem itm = new ListViewItem(narrTL.nombre);
                listView2.Items.Add(itm);
            }

            foreach (Grupo grupo in this.assets.grupoToSave)
            {
                ListViewItem itm = new ListViewItem(grupo.nombre);
                listView1.Items.Add(itm);
            }

            
            MessageBox.Show("Listar regrescadas");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedList = "Assets";
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedList = "Narrativas";
        }

        private void btnTimeLine_Click(object sender, EventArgs e)
        {
            
        }
    }
}