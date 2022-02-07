namespace Laba_4
{
    partial class Search_In_BD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSelectUnit = new System.Windows.Forms.Label();
            this.comboBoxSelectUnit = new System.Windows.Forms.ComboBox();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dataGridSearchToys = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelPriceProd = new System.Windows.Forms.Panel();
            this.checkBoxDateSearch = new System.Windows.Forms.CheckBox();
            this.dateSearch = new System.Windows.Forms.DateTimePicker();
            this.labelDateCreate = new System.Windows.Forms.Label();
            this.panelNameProd = new System.Windows.Forms.Panel();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.labelNameProd = new System.Windows.Forms.Label();
            this.checkBoxSearchName = new System.Windows.Forms.CheckBox();
            this.dataGridSearchClothes = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchToys)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelPriceProd.SuspendLayout();
            this.panelNameProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchClothes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 41);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmdSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(635, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 41);
            this.panel4.TabIndex = 3;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(20, 10);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 0;
            this.cmdSearch.Text = "Поиск";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 41);
            this.panel3.TabIndex = 2;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(25, 10);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Отмена";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSelectUnit);
            this.panel1.Controls.Add(this.comboBoxSelectUnit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 45);
            this.panel1.TabIndex = 2;
            // 
            // labelSelectUnit
            // 
            this.labelSelectUnit.AutoSize = true;
            this.labelSelectUnit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectUnit.Location = new System.Drawing.Point(12, 12);
            this.labelSelectUnit.Name = "labelSelectUnit";
            this.labelSelectUnit.Size = new System.Drawing.Size(64, 22);
            this.labelSelectUnit.TabIndex = 1;
            this.labelSelectUnit.Text = "Отдел";
            // 
            // comboBoxSelectUnit
            // 
            this.comboBoxSelectUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectUnit.FormattingEnabled = true;
            this.comboBoxSelectUnit.Location = new System.Drawing.Point(157, 12);
            this.comboBoxSelectUnit.Name = "comboBoxSelectUnit";
            this.comboBoxSelectUnit.Size = new System.Drawing.Size(261, 21);
            this.comboBoxSelectUnit.TabIndex = 0;
            this.comboBoxSelectUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectUnit_SelectedIndexChanged);
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.SystemColors.Control;
            this.panelDataGrid.Controls.Add(this.dataGridSearchClothes);
            this.panelDataGrid.Controls.Add(this.dataGridSearchToys);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 170);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(750, 135);
            this.panelDataGrid.TabIndex = 3;
            // 
            // dataGridSearchToys
            // 
            this.dataGridSearchToys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchToys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSearchToys.Location = new System.Drawing.Point(0, 0);
            this.dataGridSearchToys.Name = "dataGridSearchToys";
            this.dataGridSearchToys.Size = new System.Drawing.Size(750, 135);
            this.dataGridSearchToys.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.Control;
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.panel5);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(0, 45);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(750, 125);
            this.panelSearch.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(134, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "х строк";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результат:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panelPriceProd);
            this.panel5.Controls.Add(this.panelNameProd);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(750, 73);
            this.panel5.TabIndex = 0;
            // 
            // panelPriceProd
            // 
            this.panelPriceProd.Controls.Add(this.checkBoxDateSearch);
            this.panelPriceProd.Controls.Add(this.dateSearch);
            this.panelPriceProd.Controls.Add(this.labelDateCreate);
            this.panelPriceProd.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPriceProd.Location = new System.Drawing.Point(375, 0);
            this.panelPriceProd.Name = "panelPriceProd";
            this.panelPriceProd.Size = new System.Drawing.Size(375, 73);
            this.panelPriceProd.TabIndex = 1;
            // 
            // checkBoxDateSearch
            // 
            this.checkBoxDateSearch.AutoSize = true;
            this.checkBoxDateSearch.Location = new System.Drawing.Point(10, 16);
            this.checkBoxDateSearch.Name = "checkBoxDateSearch";
            this.checkBoxDateSearch.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDateSearch.TabIndex = 2;
            this.checkBoxDateSearch.UseVisualStyleBackColor = true;
            this.checkBoxDateSearch.CheckedChanged += new System.EventHandler(this.checkBoxDateSearch_CheckedChanged);
            // 
            // dateSearch
            // 
            this.dateSearch.Enabled = false;
            this.dateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearch.Location = new System.Drawing.Point(148, 38);
            this.dateSearch.Name = "dateSearch";
            this.dateSearch.Size = new System.Drawing.Size(200, 20);
            this.dateSearch.TabIndex = 1;
            // 
            // labelDateCreate
            // 
            this.labelDateCreate.AutoSize = true;
            this.labelDateCreate.Enabled = false;
            this.labelDateCreate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDateCreate.Location = new System.Drawing.Point(6, 36);
            this.labelDateCreate.Name = "labelDateCreate";
            this.labelDateCreate.Size = new System.Drawing.Size(136, 22);
            this.labelDateCreate.TabIndex = 0;
            this.labelDateCreate.Text = "Дата создания";
            // 
            // panelNameProd
            // 
            this.panelNameProd.Controls.Add(this.checkBoxSearchName);
            this.panelNameProd.Controls.Add(this.textBoxSearchName);
            this.panelNameProd.Controls.Add(this.labelNameProd);
            this.panelNameProd.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNameProd.Location = new System.Drawing.Point(0, 0);
            this.panelNameProd.Name = "panelNameProd";
            this.panelNameProd.Size = new System.Drawing.Size(375, 73);
            this.panelNameProd.TabIndex = 0;
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(148, 38);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(224, 20);
            this.textBoxSearchName.TabIndex = 3;
            // 
            // labelNameProd
            // 
            this.labelNameProd.AutoSize = true;
            this.labelNameProd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNameProd.Location = new System.Drawing.Point(3, 36);
            this.labelNameProd.Name = "labelNameProd";
            this.labelNameProd.Size = new System.Drawing.Size(139, 22);
            this.labelNameProd.TabIndex = 2;
            this.labelNameProd.Text = "Наименование";
            // 
            // checkBoxSearchName
            // 
            this.checkBoxSearchName.AutoSize = true;
            this.checkBoxSearchName.Checked = true;
            this.checkBoxSearchName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSearchName.Location = new System.Drawing.Point(7, 16);
            this.checkBoxSearchName.Name = "checkBoxSearchName";
            this.checkBoxSearchName.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSearchName.TabIndex = 4;
            this.checkBoxSearchName.UseVisualStyleBackColor = true;
            this.checkBoxSearchName.CheckedChanged += new System.EventHandler(this.checkBoxSearchName_CheckedChanged);
            // 
            // dataGridSearchClothes
            // 
            this.dataGridSearchClothes.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridSearchClothes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchClothes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSearchClothes.Location = new System.Drawing.Point(0, 0);
            this.dataGridSearchClothes.Name = "dataGridSearchClothes";
            this.dataGridSearchClothes.Size = new System.Drawing.Size(750, 135);
            this.dataGridSearchClothes.TabIndex = 1;
            // 
            // Search_In_BD
            // 
            this.AcceptButton = this.cmdSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(750, 346);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Search_In_BD";
            this.Text = "Поиск в Базе Данных";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchToys)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panelPriceProd.ResumeLayout(false);
            this.panelPriceProd.PerformLayout();
            this.panelNameProd.ResumeLayout(false);
            this.panelNameProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchClothes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSelectUnit;
        private System.Windows.Forms.ComboBox comboBoxSelectUnit;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView dataGridSearchToys;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelPriceProd;
        private System.Windows.Forms.Label labelDateCreate;
        private System.Windows.Forms.Panel panelNameProd;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Label labelNameProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxDateSearch;
        private System.Windows.Forms.DateTimePicker dateSearch;
        private System.Windows.Forms.CheckBox checkBoxSearchName;
        private System.Windows.Forms.DataGridView dataGridSearchClothes;
    }
}