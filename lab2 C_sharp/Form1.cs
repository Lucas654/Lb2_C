using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_C_sharp
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
                label2.Text= "Дохід: " + Data.shops[comboBox1.SelectedIndex].IncomeMounth();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
                label2.Text= "Дохід: " + Data.shops[comboBox1.SelectedIndex].IncomeYear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                Data.shops[comboBox1.SelectedIndex]--;
                label3.Text = "Кількість працівників: " + Data.shops[comboBox1.SelectedIndex].numberOfEmloyeers;
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                Data.shops[comboBox1.SelectedIndex]++;
                label3.Text = "Кількість працівників: " + Data.shops[comboBox1.SelectedIndex].numberOfEmloyeers;
            }
            
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "Кількість працівників: " + Data.shops[comboBox1.SelectedIndex].numberOfEmloyeers;
            label8.Text = "Адреса магазину: " + Data.shops[comboBox1.SelectedIndex].shopAdress;
            label9.Text = "Кількість відділів: " + Data.shops[comboBox1.SelectedIndex].numberOfDepart;
            label10.Text = "Кількість найменувань товарів: " + Data.shops[comboBox1.SelectedIndex].numberOfNames;

        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                label4.Text = "Дохід за місяць: " + Data.shops[comboBox1.SelectedIndex][0].ToString();
                label6.Text = "Заробітня платня співробітників: " + Data.shops[comboBox1.SelectedIndex][1].ToString();
                label7.Text = "Витрати на товари: " + Data.shops[comboBox1.SelectedIndex][2].ToString();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
                label5.Text= "Сума річного податку: "+Data.shops[comboBox1.SelectedIndex].nalog().ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                listBox1.Items.Clear();
                foreach (var a in Data.shops)
                listBox1.Items.Add($"Назва автомагазину:{a.nameOfShop}   \nКількість робітників: {a.numberOfEmloyeers}   \nМісячний дохід: {a.averageIncomeShop}");
            }
        }
    }
}
