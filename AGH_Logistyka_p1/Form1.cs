﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace AGH_Logistyka_p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //zapisz
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //otwórz

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //przelicz
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //wykres
        }


        //techniczne


        //public static List<string> ReadInCSV(string absolutePath)
        //{
        //    IEnumerable<string> allValues;

        //    using (TextReader fileReader = File.OpenText(absolutePath))
        //    {
        //        var csv = new CsvReader(fileReader);
        //        csv.Configuration.HasHeaderRecord = false;
        //        //allValues = csv.GetRecord<string>
        //    }

        //    return allValues.ToList<string>();
        //}



    }
}
