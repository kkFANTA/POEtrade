
namespace POEtrade
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.categoryTableAdapter = new POEtrade.ABD41_18DataSetTableAdapters.CategoryTableAdapter();
            this.rarityTableAdapter = new POEtrade.ABD41_18DataSetTableAdapters.RarityTableAdapter();
            this.socketTableAdapter = new POEtrade.ABD41_18DataSetTableAdapters.SocketTableAdapter();
            this.colorTableAdapter = new POEtrade.ABD41_18DataSetTableAdapters.ColorTableAdapter();
            this.linkTableAdapter = new POEtrade.ABD41_18DataSetTableAdapters.LinkTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.aBD41_18DataSet1 = new POEtrade.ABD41_18DataSet1();
            this.itemTableAdapter = new POEtrade.ABD41_18DataSet1TableAdapters.ItemTableAdapter();
            this.zxcDataSet = new POEtrade.zxcDataSet();
            this.itemsTableAdapter = new POEtrade.zxcDataSetTableAdapters.ItemsTableAdapter();
            this.categoryTableAdapter1 = new POEtrade.zxcDataSetTableAdapters.CategoryTableAdapter();
            this.aBD41_18DataSet11 = new POEtrade.ABD41_18DataSet1();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rarityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rarityTableAdapter1 = new POEtrade.zxcDataSetTableAdapters.RarityTableAdapter();
            this.socketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socketTableAdapter1 = new POEtrade.zxcDataSetTableAdapters.SocketTableAdapter();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorTableAdapter1 = new POEtrade.zxcDataSetTableAdapters.ColorTableAdapter();
            this.linkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkTableAdapter1 = new POEtrade.zxcDataSetTableAdapters.LinkTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fKItemsRarityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aBD41_18DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBD41_18DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemsRarityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoryBindingSource;
            this.comboBox1.DisplayMember = "category";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "id_category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.rarityBindingSource;
            this.comboBox2.DisplayMember = "rarity";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(280, 206);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "id_rarity";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.socketBindingSource;
            this.comboBox3.DisplayMember = "socket";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(407, 206);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "id_socket";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.linkBindingSource;
            this.comboBox4.DisplayMember = "link";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(26, 256);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 8;
            this.comboBox4.ValueMember = "id_link";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.colorBindingSource;
            this.comboBox5.DisplayMember = "color";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(534, 206);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 7;
            this.comboBox5.ValueMember = "id_color";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(153, 257);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(280, 257);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown2.TabIndex = 10;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // rarityTableAdapter
            // 
            this.rarityTableAdapter.ClearBeforeFill = true;
            // 
            // socketTableAdapter
            // 
            this.socketTableAdapter.ClearBeforeFill = true;
            // 
            // colorTableAdapter
            // 
            this.colorTableAdapter.ClearBeforeFill = true;
            // 
            // linkTableAdapter
            // 
            this.linkTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(26, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 49);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Location = new System.Drawing.Point(183, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 77);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтрация";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Фильтр";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.categoryBindingSource;
            this.comboBox6.DisplayMember = "category";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(8, 18);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 16;
            this.comboBox6.ValueMember = "id_category";
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // aBD41_18DataSet1
            // 
            this.aBD41_18DataSet1.DataSetName = "ABD41_18DataSet1";
            this.aBD41_18DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // zxcDataSet
            // 
            this.zxcDataSet.DataSetName = "zxcDataSet";
            this.zxcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // aBD41_18DataSet11
            // 
            this.aBD41_18DataSet11.DataSetName = "ABD41_18DataSet1";
            this.aBD41_18DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.zxcDataSet;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.zxcDataSet;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.zxcDataSet;
            // 
            // rarityBindingSource
            // 
            this.rarityBindingSource.DataMember = "Rarity";
            this.rarityBindingSource.DataSource = this.zxcDataSet;
            // 
            // rarityTableAdapter1
            // 
            this.rarityTableAdapter1.ClearBeforeFill = true;
            // 
            // socketBindingSource
            // 
            this.socketBindingSource.DataMember = "Socket";
            this.socketBindingSource.DataSource = this.zxcDataSet;
            // 
            // socketTableAdapter1
            // 
            this.socketTableAdapter1.ClearBeforeFill = true;
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataMember = "Color";
            this.colorBindingSource.DataSource = this.zxcDataSet;
            // 
            // colorTableAdapter1
            // 
            this.colorTableAdapter1.ClearBeforeFill = true;
            // 
            // linkBindingSource
            // 
            this.linkBindingSource.DataMember = "Link";
            this.linkBindingSource.DataSource = this.zxcDataSet;
            // 
            // linkTableAdapter1
            // 
            this.linkTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Rarity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Socket";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Link";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Price";
            // 
            // fKItemsRarityBindingSource
            // 
            this.fKItemsRarityBindingSource.DataMember = "FK_Items_Rarity";
            this.fKItemsRarityBindingSource.DataSource = this.rarityBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 424);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox4);
            this.Name = "Form1";
            this.Text = "POE trade";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aBD41_18DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zxcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBD41_18DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemsRarityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private ABD41_18DataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private ABD41_18DataSetTableAdapters.RarityTableAdapter rarityTableAdapter;
        private ABD41_18DataSetTableAdapters.SocketTableAdapter socketTableAdapter;
        private ABD41_18DataSetTableAdapters.ColorTableAdapter colorTableAdapter;
        private ABD41_18DataSetTableAdapters.LinkTableAdapter linkTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox6;
        private ABD41_18DataSet1 aBD41_18DataSet1;
        private ABD41_18DataSet1TableAdapters.ItemTableAdapter itemTableAdapter;
        private zxcDataSet zxcDataSet;
        private zxcDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private zxcDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter1;
        private ABD41_18DataSet1 aBD41_18DataSet11;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.BindingSource rarityBindingSource;
        private zxcDataSetTableAdapters.RarityTableAdapter rarityTableAdapter1;
        private System.Windows.Forms.BindingSource socketBindingSource;
        private zxcDataSetTableAdapters.SocketTableAdapter socketTableAdapter1;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private zxcDataSetTableAdapters.ColorTableAdapter colorTableAdapter1;
        private System.Windows.Forms.BindingSource linkBindingSource;
        private zxcDataSetTableAdapters.LinkTableAdapter linkTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource fKItemsRarityBindingSource;
    }
}

