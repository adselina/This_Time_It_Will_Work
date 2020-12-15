﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace This_Time_It_Will_Work
{
    public partial class AttributeAddForm : Form
    {
        public string currentDB;
        public string tableName;

        public AttributeAddForm()
        {
            InitializeComponent();
        }

        public AttributeAddForm(string db, string n)
        {
            InitializeComponent();
            currentDB = db;
            tableName = n;
            InfoLabel.Text = $"Новый атрибут таблицы {tableName}:";
        }

        private void AttributeAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DBChangeForm form = new DBChangeForm(currentDB, tableName);
            form.Show();
            this.Hide();
        }
    }
}
