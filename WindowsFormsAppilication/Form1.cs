using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<Item> itemList;
        int id;

        public Form1()
        {
            InitializeComponent();
            itemList = new List<Item>() { 
                new Item(101,"Chair",20,6500.99f),
                new Item(102,"Desk",10,7500.99f),
                new Item(103,"Bed",30,9500.99f),
                new Item(104,"Table",5,4500.99f),
                new Item(105,"Arm Chair",9,5500.99f)
            };
        }

        void changePanel(String pname)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    Panel p = c as Panel;
                    if (p.Name.Equals(pname))
                        p.Visible = true;
                    else
                        p.Visible = false;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changePanel("panel1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changePanel("panel2");
            listBox1.Items.Clear();
            foreach (Item i in itemList)
                listBox1.Items.Add(i);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Item i in itemList)
            {
                if (i.ItemName.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changePanel("panel3");
            List<int> idList = new List<int>();
            foreach (Item i in itemList)
            {
                idList.Add(i.ItemId);
            }
            idList.Sort();
            id = idList[idList.Count - 1] + 1;
            textBox2.Text = "" + id;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            itemList.Add(new Item(id, textBox3.Text, 
                int.Parse(textBox4.Text), float.Parse(textBox5.Text)));
            MessageBox.Show("Record Inserted !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changePanel("panel4");
            comboBox1.Items.Clear();
            foreach (Item i in itemList)
                comboBox1.Items.Add(i);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item i = (Item)comboBox1.SelectedItem;
            label12.Text = "" + i.ItemId;
            label13.Text = i.ItemName;
            label14.Text = "" + i.Quantity;
            label15.Text = "" + i.Price;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Item i = (Item)comboBox1.SelectedItem;
            itemList.Remove(i);
            MessageBox.Show("Item Removed!");
            button3_Click(sender,e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changePanel("panel5");
            comboBox2.Items.Clear();
            foreach (Item i in itemList)
                comboBox2.Items.Add(i);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item i = (Item)comboBox2.SelectedItem;
            textBox6.Text = i.ItemName;
            textBox7.Text = "" + i.Quantity;
            textBox8.Text = "" + i.Price;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Item i = (Item)comboBox2.SelectedItem;
            i.ItemName = textBox6.Text;
            i.Quantity=int.Parse(textBox7.Text);
            i.Price = float.Parse(textBox8.Text);
            MessageBox.Show("Record Updated!");
            button4_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            changePanel("panel6");
            listBox2.Items.Clear();
            foreach (Item i in itemList)
                listBox2.Items.Add(i);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            itemList.Sort(new SortByPrice());
            listBox2.Items.Clear();
            foreach (Item i in itemList)
                listBox2.Items.Add(i);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            itemList.Sort();
            listBox2.Items.Clear();
            foreach (Item i in itemList)
                listBox2.Items.Add(i);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
