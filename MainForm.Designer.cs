namespace Laba_4
{
    partial class MainForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDepartament = new System.Windows.Forms.Label();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьИзБазыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНаименованиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеСозданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сериализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.десериализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridCloth = new System.Windows.Forms.DataGridView();
            this.dataGridToys = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxToys = new System.Windows.Forms.CheckBox();
            this.cmdViewToys = new System.Windows.Forms.Button();
            this.cmdViewCloth = new System.Windows.Forms.Button();
            this.checkBoxCloth = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCloth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridToys)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdAddProduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1013, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 49);
            this.panel3.TabIndex = 2;
            // 
            // cmdAddProduct
            // 
            this.cmdAddProduct.Location = new System.Drawing.Point(33, 15);
            this.cmdAddProduct.Name = "cmdAddProduct";
            this.cmdAddProduct.Size = new System.Drawing.Size(114, 23);
            this.cmdAddProduct.TabIndex = 1;
            this.cmdAddProduct.Text = "Добавить товар";
            this.cmdAddProduct.UseVisualStyleBackColor = true;
            this.cmdAddProduct.Click += new System.EventHandler(this.cmdAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "SuperMarket";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.labelDepartament);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 49);
            this.panel2.TabIndex = 0;
            // 
            // labelDepartament
            // 
            this.labelDepartament.AutoSize = true;
            this.labelDepartament.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepartament.ForeColor = System.Drawing.Color.Yellow;
            this.labelDepartament.Location = new System.Drawing.Point(369, 9);
            this.labelDepartament.Name = "labelDepartament";
            this.labelDepartament.Size = new System.Drawing.Size(88, 32);
            this.labelDepartament.TabIndex = 3;
            this.labelDepartament.Text = "label3";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.очиститьТаблицуToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // очиститьТаблицуToolStripMenuItem
            // 
            this.очиститьТаблицуToolStripMenuItem.Name = "очиститьТаблицуToolStripMenuItem";
            this.очиститьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.очиститьТаблицуToolStripMenuItem.Text = "Очистить таблицу";
            this.очиститьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.очиститьТаблицуToolStripMenuItem_Click);
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выгрузитьИзБазыДанныхToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // выгрузитьИзБазыДанныхToolStripMenuItem
            // 
            this.выгрузитьИзБазыДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНаименованиюToolStripMenuItem,
            this.поДатеСозданияToolStripMenuItem});
            this.выгрузитьИзБазыДанныхToolStripMenuItem.Name = "выгрузитьИзБазыДанныхToolStripMenuItem";
            this.выгрузитьИзБазыДанныхToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.выгрузитьИзБазыДанныхToolStripMenuItem.Text = "Загрузить из БД";
            // 
            // поНаименованиюToolStripMenuItem
            // 
            this.поНаименованиюToolStripMenuItem.Name = "поНаименованиюToolStripMenuItem";
            this.поНаименованиюToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.поНаименованиюToolStripMenuItem.Text = "По наименованию";
            this.поНаименованиюToolStripMenuItem.Click += new System.EventHandler(this.поНаименованиюToolStripMenuItem_Click);
            // 
            // поДатеСозданияToolStripMenuItem
            // 
            this.поДатеСозданияToolStripMenuItem.Name = "поДатеСозданияToolStripMenuItem";
            this.поДатеСозданияToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.поДатеСозданияToolStripMenuItem.Text = "По дате создания";
            this.поДатеСозданияToolStripMenuItem.Click += new System.EventHandler(this.поДатеСозданияToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.сериализацияToolStripMenuItem,
            this.десериализацияToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сериализацияToolStripMenuItem
            // 
            this.сериализацияToolStripMenuItem.Name = "сериализацияToolStripMenuItem";
            this.сериализацияToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.сериализацияToolStripMenuItem.Text = "Сериализация";
            this.сериализацияToolStripMenuItem.Click += new System.EventHandler(this.сериализацияToolStripMenuItem_Click);
            // 
            // десериализацияToolStripMenuItem
            // 
            this.десериализацияToolStripMenuItem.Name = "десериализацияToolStripMenuItem";
            this.десериализацияToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.десериализацияToolStripMenuItem.Text = "Десериализация";
            this.десериализацияToolStripMenuItem.Click += new System.EventHandler(this.десериализацияToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 426);
            this.panel1.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridCloth);
            this.panel6.Controls.Add(this.dataGridToys);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 49);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1013, 377);
            this.panel6.TabIndex = 4;
            // 
            // dataGridCloth
            // 
            this.dataGridCloth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCloth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCloth.Location = new System.Drawing.Point(0, 0);
            this.dataGridCloth.Name = "dataGridCloth";
            this.dataGridCloth.ReadOnly = true;
            this.dataGridCloth.Size = new System.Drawing.Size(1013, 377);
            this.dataGridCloth.TabIndex = 4;
            this.dataGridCloth.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCloth_CellContentClick);
            // 
            // dataGridToys
            // 
            this.dataGridToys.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.dataGridToys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridToys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridToys.Location = new System.Drawing.Point(0, 0);
            this.dataGridToys.Name = "dataGridToys";
            this.dataGridToys.Size = new System.Drawing.Size(1013, 377);
            this.dataGridToys.TabIndex = 3;
            this.dataGridToys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridToys_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1013, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 377);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.checkBoxToys);
            this.panel4.Controls.Add(this.cmdViewToys);
            this.panel4.Controls.Add(this.cmdViewCloth);
            this.panel4.Controls.Add(this.checkBoxCloth);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 110);
            this.panel4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Отобразить товары:";
            // 
            // checkBoxToys
            // 
            this.checkBoxToys.AutoSize = true;
            this.checkBoxToys.Checked = true;
            this.checkBoxToys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxToys.Enabled = false;
            this.checkBoxToys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxToys.ForeColor = System.Drawing.Color.Red;
            this.checkBoxToys.Location = new System.Drawing.Point(93, 44);
            this.checkBoxToys.Name = "checkBoxToys";
            this.checkBoxToys.Size = new System.Drawing.Size(15, 14);
            this.checkBoxToys.TabIndex = 6;
            this.checkBoxToys.UseVisualStyleBackColor = true;
            // 
            // cmdViewToys
            // 
            this.cmdViewToys.Location = new System.Drawing.Point(12, 39);
            this.cmdViewToys.Name = "cmdViewToys";
            this.cmdViewToys.Size = new System.Drawing.Size(75, 23);
            this.cmdViewToys.TabIndex = 3;
            this.cmdViewToys.Text = "Игрушки";
            this.cmdViewToys.UseVisualStyleBackColor = true;
            this.cmdViewToys.Click += new System.EventHandler(this.cmdViewToys_Click_1);
            // 
            // cmdViewCloth
            // 
            this.cmdViewCloth.Location = new System.Drawing.Point(12, 76);
            this.cmdViewCloth.Name = "cmdViewCloth";
            this.cmdViewCloth.Size = new System.Drawing.Size(75, 23);
            this.cmdViewCloth.TabIndex = 4;
            this.cmdViewCloth.Text = "Одежда";
            this.cmdViewCloth.UseVisualStyleBackColor = true;
            this.cmdViewCloth.Click += new System.EventHandler(this.cmdViewCloth_Click_1);
            // 
            // checkBoxCloth
            // 
            this.checkBoxCloth.AutoSize = true;
            this.checkBoxCloth.Enabled = false;
            this.checkBoxCloth.Location = new System.Drawing.Point(93, 85);
            this.checkBoxCloth.Name = "checkBoxCloth";
            this.checkBoxCloth.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCloth.TabIndex = 5;
            this.checkBoxCloth.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.базаДанныхToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1223, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCloth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridToys)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cmdAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьИзБазыДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сериализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem десериализацияToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.DataGridView dataGridCloth;
        public System.Windows.Forms.DataGridView dataGridToys;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxToys;
        private System.Windows.Forms.Button cmdViewToys;
        private System.Windows.Forms.Button cmdViewCloth;
        private System.Windows.Forms.CheckBox checkBoxCloth;
        private System.Windows.Forms.ToolStripMenuItem очиститьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНаименованиюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеСозданияToolStripMenuItem;
        private System.Windows.Forms.Label labelDepartament;
    }
}

