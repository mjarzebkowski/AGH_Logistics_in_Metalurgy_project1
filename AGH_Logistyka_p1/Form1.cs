using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CriticalPathMethod;
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
            cPMElementBindingSource2.DataSource  = new List<CPM_Element>();
            criticalPathBindingSource.DataSource = new List<CriticalPath>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //zapisz
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = @"CSV|.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        var writer = new CsvWriter(sw);
                        writer.WriteHeader(typeof(CPM_Element));
                        writer.NextRecord();
                        writer.WriteRecords((List<CPM_Element>)cPMElementBindingSource2.DataSource);
                        //foreach (CPM_Element s in (List<CPM_Element>)cPMElementBindingSource2.DataSource)
                        //{
                            
                        //}
                    }
                    MessageBox.Show("Dane zapisane", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            //otwórz
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = @"CSV|.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    var csv = new CsvReader(sr);
                    cPMElementBindingSource2.DataSource = csv.GetRecords<CPM_Element>();
                }
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<CriticalPath> crcPath = (List<CriticalPath>)cPMElementBindingSource2.DataSource;


            //Activity[] act = act.
            ////CriticalPath.CalculatePath(CRCPath);
            //act.M



            //foreach (CriticalPath mCriticalPath in CRCPath)
            //{
            //    mCriticalPath.
            //}

            //CriticalPath.CalculatePath(cPMElementBindingSource2.DataSource.




            //DataTable CRCPath = new DataTable();
            //CRCPath.BeginLoadData();
            //CRCPath.DataSet.

            //criticalPathBindingSource.AddNew().
            //criticalPathBindingSource.Current.row.item("Name") = "";

            //(CriticalPath.CountCRCElements()) = List<>;

            //    CriticalPath.CalculatePatch(cPMElementBindingSource2.DataSource);

            //    int CRCElem = ;

            //przelicz
            //criticalPathBindingSource.DataSource = cPMElementBindingSource2.
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //wykres
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
