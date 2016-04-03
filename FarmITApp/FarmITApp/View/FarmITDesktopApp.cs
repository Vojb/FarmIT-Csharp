﻿using FarmITApp.DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmITApp.EntityFramework;

namespace FarmITApp.View
{
    public partial class FarmITDesktopApp : Form
    {
        Dal dal = new Dal();

        public FarmITDesktopApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FarmITDesktopApp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmITDataSet.Buildings' table. You can move, or remove it, as needed.
            this.buildingsTableAdapter.Fill(this.farmITDataSet.Buildings);
            // TODO: This line of code loads data into the 'farmITDataSet.Foods' table. You can move, or remove it, as needed.
            this.foodsTableAdapter.Fill(this.farmITDataSet.Foods);
            // TODO: This line of code loads data into the 'farmITDataSet.Animals' table. You can move, or remove it, as needed.
            this.animalsTableAdapter.Fill(this.farmITDataSet.Animals);

        }
    }
}
