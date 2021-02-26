using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
