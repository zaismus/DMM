﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMM.AddPage
{
    public partial class Add_Supplier : DevExpress.XtraEditors.XtraForm
    {
        public Add_Supplier()
        {
            InitializeComponent();
        }


        // Define Database, Table, var & Page
        DBDMMEntities db;
        TB_Suppliers tbAdd;
        public int id;
        public DMM.Pages.Page_Suppliers page;


        // Function Add
        private void Add()
        {
            // Check Empty value
            if (edt_name.Text == "")
            {
                MessageBox.Show("Certains champs sont obligatoires", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            else
            {
                // Check if Add or Edit
                if (id == 0)
                    AddData();
                else
                    EditData();

                // Update Data
                page.LoadData();
            }
        }

        // Add Data
        private void AddData()
        {
            try
            {
                db = new DBDMMEntities();
                tbAdd = new TB_Suppliers
                {
                    FullName = edt_name.Text,
                    Phone = edt_phone.Text,
                    Address = edt_address.Text,
                    DateT = DateTime.Now
                };

                db.Entry(tbAdd).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("c5735894-7960-49f3-a6b9-8a4d4ab688fd");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Edit Data
        private void EditData()
        {

        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            Add();
            ClearData();
        }

        private void btn_addclose_Click(object sender, EventArgs e)
        {
            Add();
            Close();
        }

        // Clear Value
        private void ClearData()
        {
            edt_address.Text =
            edt_name.Text =
            edt_phone.Text = "";
        }
    }
}