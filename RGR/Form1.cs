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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

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
                        Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox2.Text), Convert.ToDateTime(dateTimePicker2.Value));
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
        string names = "";
        string ids = "";
        void AddNewD(int id)
        {

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value) == id)
                {
                    names += dataGridView2.Rows[i].Cells[1].Value.ToString();
                    ids += dataGridView2.Rows[i].Cells[0].Value.ToString();
                    ids += " ";
                    names += " ";
                    names += dataGridView2.Rows[i].Cells[2].Value.ToString();
                    names += "\n";
                }
            }
            ReportParameterCollection rptparameter = new ReportParameterCollection();
            rptparameter.Add(new ReportParameter("nd", names));
            this.reportViewer2.LocalReport.SetParameters(rptparameter);
            this.reportViewer2.RefreshReport();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {


                if (DateTime.Now > Convert.ToDateTime(dataGridView3.Rows[i].Cells[2].Value))
                {
                    AddNewD(Convert.ToInt32(dataGridView3.Rows[i].Cells[3].Value));
                }
            }
            names = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ID = textBox5.Text.ToString();
            string[] depts = ids.Split(' ');
            for (int i = 0; i < depts.Length; i++)
            {
                if (depts[i] == ID)
                {

                    var name = dataGridView2.Rows[Convert.ToInt32(ID) - 1].Cells[1].Value.ToString();
                    var surname = dataGridView2.Rows[Convert.ToInt32(ID) - 1].Cells[2].Value.ToString();
                    var patron = dataGridView2.Rows[Convert.ToInt32(ID) - 1].Cells[3].Value.ToString();
                    var adress = dataGridView2.Rows[Convert.ToInt32(ID) - 1].Cells[4].Value.ToString();
                    var film = "";
                    var date1 = "";
                    var date2 = "";
                    for (int k = 0; k < dataGridView3.Rows.Count; k++)
                    {
                        if (dataGridView3.Rows[k].Cells[3].Value.ToString() == ID)
                        {
                            int a = Convert.ToInt32(dataGridView3.Rows[k].Cells[4].Value);
                            for (int j = 0; j < dataGridView1.Rows.Count; j++)
                            {
                                if (a == Convert.ToInt32(dataGridView1.Rows[j].Cells[0].Value))
                                {
                                    film += dataGridView1.Rows[j].Cells[1].Value.ToString();
                                    date1 += dataGridView3.Rows[k].Cells[1].Value.ToString();
                                    date2 += dataGridView3.Rows[k].Cells[2].Value.ToString();
                                    break;
                                }
                            }
                            break;

                        }
                    }
                    var allname = surname + "у " + name[0] + "." + patron[0] + ".";
                    var obr = "\n\nУважаемый " + name + " " + patron + "!";
                    var pr = "\nУбедительно прошу Вас вернуть фильм " + film + ", который Вы взяли " + date1 + " до " + date2 + ".";
                    var last = "\n\nЗаранее спасибо";
                    var sign = "Владелец видеотеки";
                    var date3 = DateTime.Now.ToShortDateString();


                    string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
                    var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    var font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                    using (var document = new Document())
                    using (var stream = new FileStream("Test.pdf", FileMode.Create))
                    {
                        document.SetPageSize(PageSize.A4.Rotate());
                        PdfWriter writer = PdfWriter.GetInstance(document, stream);
                        document.Open();
                        Paragraph par = new Paragraph(allname, font);
                        par.Alignment = Element.ALIGN_RIGHT;
                        document.Add(par);
                        par = new Paragraph(adress, font);
                        par.Alignment = Element.ALIGN_RIGHT;
                        document.Add(par);
                        par = new Paragraph(obr, font);
                        par.Alignment = Element.ALIGN_CENTER;
                        document.Add(par);

                        par = new Paragraph(pr, font);
                        par.Alignment = Element.ALIGN_CENTER;
                        document.Add(par);
                        par = new Paragraph(last, font);
                        par.Alignment = Element.ALIGN_RIGHT;
                        document.Add(par);
                        par = new Paragraph(sign, font);
                        par.Alignment = Element.ALIGN_RIGHT;
                        document.Add(par);
                        par = new Paragraph(date3, font);
                        par.Alignment = Element.ALIGN_RIGHT;
                        document.Add(par);
                        document.Close();
                    }

                    Process.Start("Test.pdf");

                    break;
                }
            }
        }
    }
}
