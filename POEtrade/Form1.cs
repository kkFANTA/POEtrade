using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;

namespace POEtrade
{
    public partial class Form1 : Form
    {
        static string conStr = "Data Source=10.10.0.120;Initial Catalog=zxc;Persist Security Info=True;User ID=abd31_21;Password=123456qwerty.";
        DataContext context = new DataContext(conStr);
        public Form1()
        {
            InitializeComponent();
            Table<Items> Item = context.GetTable<Items>();
            dataGridView1.DataSource = Item.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items it = context.GetTable<Items>().FirstOrDefault(x => x.id_item == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            it.name = textBox1.Text;
            it.category = Convert.ToInt32(comboBox1.SelectedValue);
            it.rarity = Convert.ToInt32(comboBox2.SelectedValue);
            it.socket = Convert.ToInt32(comboBox3.SelectedValue);
            it.color = Convert.ToInt32(comboBox5.SelectedValue);
            it.link = Convert.ToInt32(comboBox4.SelectedValue);
            it.quantity = Convert.ToInt32(numericUpDown1.Value);
            it.price = Convert.ToInt32(numericUpDown2.Value);
            context.SubmitChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zxcDataSet.Link". При необходимости она может быть перемещена или удалена.
            this.linkTableAdapter1.Fill(this.zxcDataSet.Link);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zxcDataSet.Color". При необходимости она может быть перемещена или удалена.
            this.colorTableAdapter1.Fill(this.zxcDataSet.Color);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zxcDataSet.Socket". При необходимости она может быть перемещена или удалена.
            this.socketTableAdapter1.Fill(this.zxcDataSet.Socket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zxcDataSet.Rarity". При необходимости она может быть перемещена или удалена.
            this.rarityTableAdapter1.Fill(this.zxcDataSet.Rarity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aBD41_18DataSet11.Item". При необходимости она может быть перемещена или удалена.
            this.itemTableAdapter.Fill(this.aBD41_18DataSet11.Item);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Items it = context.GetTable<Items>().FirstOrDefault(x => x.id_item == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            it.category = Convert.ToInt32(comboBox1.SelectedValue);
            it.rarity = Convert.ToInt32(comboBox2.SelectedValue);
            it.socket = Convert.ToInt32(comboBox3.SelectedValue);
            it.color = Convert.ToInt32(comboBox5.SelectedValue);
            it.link = Convert.ToInt32(comboBox4.SelectedValue);
            it.quantity = Convert.ToInt32(numericUpDown1.Value);
            it.price = Convert.ToInt32(numericUpDown2.Value);
            context.SubmitChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Items item = context.GetTable<Items>().OrderByDescending(x => x.id_item).FirstOrDefault();
            context.GetTable<Items>().DeleteOnSubmit(item);
            context.SubmitChanges();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var f = context.GetTable<Items>().Where(x => x.name.Contains(textBox2.Text));
            dataGridView1.DataSource = f.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = context.GetTable<Items>().Where(x => x.color == Convert.ToInt32(comboBox6.SelectedValue));
            dataGridView1.DataSource = f.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
