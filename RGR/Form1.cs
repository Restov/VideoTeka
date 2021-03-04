using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace RGR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "video_libraryDataSet.Аренда". При необходимости она может быть перемещена или удалена.
            this.арендаTableAdapter.Fill(this.video_libraryDataSet.Аренда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "video_libraryDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.video_libraryDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "video_libraryDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.video_libraryDataSet.Фильмы);


            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string s = textBox1.Text.ToString();
            try
            {
                string[] subs = s.Split(';');
                this.фильмыTableAdapter.InsertQuery(subs[0], subs[1], subs[2], subs[3], subs[4], subs[5], subs[6]);
                this.фильмыTableAdapter.Update(this.video_libraryDataSet.Фильмы);
                this.фильмыTableAdapter.Fill(this.video_libraryDataSet.Фильмы);

            }
            catch
            {

                MessageBox.Show("Неверный ввод");

            }



        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                арендаTableAdapter.InsertQuery(Convert.ToDateTime(dateTimePicker1.Value),
                        Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox2.Text));
                арендаTableAdapter.Update(video_libraryDataSet.Аренда);
                арендаTableAdapter.Fill(video_libraryDataSet.Аренда);
            }
            catch
            {

                MessageBox.Show("Неверный ввод");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void button3_Click_1(object sender, EventArgs e)
        {

            int ID = 0;
            try
            {
                ID = Convert.ToInt32(textBox4.Text);
                string films;
                films = "";

                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView3.Rows[i].Cells[3].Value) == ID)
                    {
                        int a = Convert.ToInt32(dataGridView3.Rows[i].Cells[4].Value);
                        for (int j = 0; j < dataGridView1.Rows.Count; j++)
                        {
                            if (a == Convert.ToInt32(dataGridView1.Rows[j].Cells[0].Value))
                            {
                                films += dataGridView1.Rows[j].Cells[1].Value.ToString();
                                films += "\n";
                                break;
                            }
                        }

                    }
                }
                ReportParameterCollection rptparameter = new ReportParameterCollection();
                rptparameter.Add(new ReportParameter("startdate", films));
                this.reportViewer1.LocalReport.SetParameters(rptparameter);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception expp)
            {


                MessageBox.Show(expp.Message.ToString());
            }
            
        }
    }
}
