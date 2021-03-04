namespace RGR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.режиссерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вРоляхDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.краткаяАннотацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videolibraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.video_libraryDataSet = new RGR.video_libraryDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВзятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fILMidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.арендаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.пользователиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.фильмыTableAdapter = new RGR.video_libraryDataSetTableAdapters.ФильмыTableAdapter();
            this.пользователиTableAdapter = new RGR.video_libraryDataSetTableAdapters.ПользователиTableAdapter();
            this.арендаTableAdapter = new RGR.video_libraryDataSetTableAdapters.АрендаTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videolibraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.жанрDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn,
            this.режиссерDataGridViewTextBoxColumn,
            this.вРоляхDataGridViewTextBoxColumn,
            this.краткаяАннотацияDataGridViewTextBoxColumn,
            this.годDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.фильмыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            // 
            // режиссерDataGridViewTextBoxColumn
            // 
            this.режиссерDataGridViewTextBoxColumn.DataPropertyName = "Режиссер";
            this.режиссерDataGridViewTextBoxColumn.HeaderText = "Режиссер";
            this.режиссерDataGridViewTextBoxColumn.Name = "режиссерDataGridViewTextBoxColumn";
            // 
            // вРоляхDataGridViewTextBoxColumn
            // 
            this.вРоляхDataGridViewTextBoxColumn.DataPropertyName = "В ролях";
            this.вРоляхDataGridViewTextBoxColumn.HeaderText = "В ролях";
            this.вРоляхDataGridViewTextBoxColumn.Name = "вРоляхDataGridViewTextBoxColumn";
            // 
            // краткаяАннотацияDataGridViewTextBoxColumn
            // 
            this.краткаяАннотацияDataGridViewTextBoxColumn.DataPropertyName = "Краткая аннотация";
            this.краткаяАннотацияDataGridViewTextBoxColumn.HeaderText = "Краткая аннотация";
            this.краткаяАннотацияDataGridViewTextBoxColumn.Name = "краткаяАннотацияDataGridViewTextBoxColumn";
            // 
            // годDataGridViewTextBoxColumn
            // 
            this.годDataGridViewTextBoxColumn.DataPropertyName = "Год";
            this.годDataGridViewTextBoxColumn.HeaderText = "Год";
            this.годDataGridViewTextBoxColumn.Name = "годDataGridViewTextBoxColumn";
            // 
            // фильмыBindingSource
            // 
            this.фильмыBindingSource.DataMember = "Фильмы";
            this.фильмыBindingSource.DataSource = this.videolibraryDataSetBindingSource;
            // 
            // videolibraryDataSetBindingSource
            // 
            this.videolibraryDataSetBindingSource.DataSource = this.video_libraryDataSet;
            this.videolibraryDataSetBindingSource.Position = 0;
            // 
            // video_libraryDataSet
            // 
            this.video_libraryDataSet.DataSetName = "video_libraryDataSet";
            this.video_libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.пользователиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(698, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(342, 204);
            this.dataGridView2.TabIndex = 1;
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.videolibraryDataSetBindingSource;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn2,
            this.датаВзятияDataGridViewTextBoxColumn,
            this.датаВозвратаDataGridViewTextBoxColumn,
            this.uSERidDataGridViewTextBoxColumn,
            this.fILMidDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.арендаBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(657, 294);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(396, 146);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // кодDataGridViewTextBoxColumn2
            // 
            this.кодDataGridViewTextBoxColumn2.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn2.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn2.Name = "кодDataGridViewTextBoxColumn2";
            // 
            // датаВзятияDataGridViewTextBoxColumn
            // 
            this.датаВзятияDataGridViewTextBoxColumn.DataPropertyName = "Дата взятия";
            this.датаВзятияDataGridViewTextBoxColumn.HeaderText = "Дата взятия";
            this.датаВзятияDataGridViewTextBoxColumn.Name = "датаВзятияDataGridViewTextBoxColumn";
            // 
            // датаВозвратаDataGridViewTextBoxColumn
            // 
            this.датаВозвратаDataGridViewTextBoxColumn.DataPropertyName = "Дата возврата";
            this.датаВозвратаDataGridViewTextBoxColumn.HeaderText = "Дата возврата";
            this.датаВозвратаDataGridViewTextBoxColumn.Name = "датаВозвратаDataGridViewTextBoxColumn";
            // 
            // uSERidDataGridViewTextBoxColumn
            // 
            this.uSERidDataGridViewTextBoxColumn.DataPropertyName = "USER-id";
            this.uSERidDataGridViewTextBoxColumn.HeaderText = "USER-id";
            this.uSERidDataGridViewTextBoxColumn.Name = "uSERidDataGridViewTextBoxColumn";
            // 
            // fILMidDataGridViewTextBoxColumn
            // 
            this.fILMidDataGridViewTextBoxColumn.DataPropertyName = "FILM-id";
            this.fILMidDataGridViewTextBoxColumn.HeaderText = "FILM-id";
            this.fILMidDataGridViewTextBoxColumn.Name = "fILMidDataGridViewTextBoxColumn";
            // 
            // арендаBindingSource
            // 
            this.арендаBindingSource.DataMember = "Аренда";
            this.арендаBindingSource.DataSource = this.videolibraryDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фильмы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(693, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пользователи ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(652, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Аренда";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 573);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1062, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фильмы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(553, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 94);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить запись";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата Взятия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Film ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "User ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.mm.year";
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(11, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить фильм";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить фильм";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(527, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите через точку с запятой: Название, Жанр, Страна, Режиссер, В ролях, Краткая" +
    " аннотация, Год";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1062, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Данные о пользователях";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // пользователиBindingSource1
            // 
            this.пользователиBindingSource1.DataMember = "Пользователи";
            this.пользователиBindingSource1.DataSource = this.videolibraryDataSetBindingSource;
            // 
            // фильмыTableAdapter
            // 
            this.фильмыTableAdapter.ClearBeforeFill = true;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // арендаTableAdapter
            // 
            this.арендаTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RGR.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(630, 562);
            this.reportViewer1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(694, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Введите ID пользователя";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(716, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.reportViewer2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1062, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Список должников";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "RGR.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(630, 544);
            this.reportViewer2.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(670, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 72);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(329, 46);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(107, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Дата возврата";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videolibraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource videolibraryDataSetBindingSource;
        private video_libraryDataSet video_libraryDataSet;
        private System.Windows.Forms.BindingSource фильмыBindingSource;
        private video_libraryDataSetTableAdapters.ФильмыTableAdapter фильмыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn режиссерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вРоляхDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn краткаяАннотацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private video_libraryDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource арендаBindingSource;
        private video_libraryDataSetTableAdapters.АрендаTableAdapter арендаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВзятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fILMidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource пользователиBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

