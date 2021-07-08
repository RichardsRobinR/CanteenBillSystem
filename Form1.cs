using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenBillSystem
{
    public partial class Form1 : Form
    {
       // int price;
        int total = 0;
        int quantitytotal = 0;
        //int[] pricearray = new int[20] {};
        ArrayList pricearraylist = new ArrayList() { 10, 20, 30, 40 };

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.select_item_ComboBox.Items.Add("Chocolate");
            this.select_item_ComboBox.Items.Add("Lays");
            this.select_item_ComboBox.Items.Add("Coke");
            this.select_item_ComboBox.Items.Add("Cup Noodles");
        }

        private void item_List_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void select_item_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // getprice(this.select_item_ComboBox.SelectedIndex);
            getpricev2();
        }

       /* public void getprice(int choice)
        {

            switch(choice)
            {
                case 0:
                    price = 10;
                    this.price_TextBox.Text = price.ToString();
                    break;

                case 1:
                    price = 20;
                    this.price_TextBox.Text = price.ToString();
                    break;

                case 2:
                    price = 30;
                    this.price_TextBox.Text = price.ToString();
                    break;

                case 3:
                    price = 40;
                    this.price_TextBox.Text = price.ToString();
                    break;

                default:
                    break;

            }


            
        }*/


        public void getpricev2()
        {
            for(int i=0;i< pricearraylist.Count;i++)
            {
               if( i == this.select_item_ComboBox.SelectedIndex)
                {
                    this.price_TextBox.Text = pricearraylist[i].ToString();
                }
            }
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            if (this.select_item_ComboBox.Text != "" && this.price_TextBox.Text != "" && this.quantity_TextBox.Text != "")
                displayData(int.Parse(this.quantity_TextBox.Text));
        }

        public void displayData(int quantity)
        {



            for (int i = 0; i < pricearraylist.Count; i++)
            {


                if (i == this.select_item_ComboBox.SelectedIndex)
                {
                    quantitytotal = (int)pricearraylist[i] * quantity;
                    // price list
                    this.price_List_TextBox.Text = this.price_List_TextBox.Text + pricearraylist[i] + Environment.NewLine;
                }

            }
            // int quantitytotal = price * quantity;

            // item list
            this.item_List_TextBox.Text = this.item_List_TextBox.Text + this.select_item_ComboBox.SelectedItem as string + Environment.NewLine;

            // price list
            //this.price_List_TextBox.Text = this.price_List_TextBox.Text + price + Environment.NewLine;


            // quantity list
            this.quantity_List_TextBox.Text = this.quantity_List_TextBox.Text + quantity + Environment.NewLine;

            // quantity total list
            this.total_List_TextBox.Text = this.total_List_TextBox.Text + quantitytotal + Environment.NewLine;


            // total calculation
            total = total + quantitytotal;

            this.total_TextBox.Text = total.ToString();

            this.select_item_ComboBox.Text = "";
            this.price_TextBox.Text = "";
            this.quantity_TextBox.Text = "";
           
        }

        private void total_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Items_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // add button
        private void select_item_add_Button_Click(object sender, EventArgs e)
        {
            if (this.add_Items_TextBox.Text != "" && this.add_price_TextBox.Text != "" )
            {
                this.select_item_ComboBox.Items.Add(this.add_Items_TextBox.Text);
                this.pricearraylist.Add(int.Parse(this.add_price_TextBox.Text));

                MessageBox.Show("Item Added");

                this.add_Items_TextBox.Text = "";
                this.add_price_TextBox.Text = "";
            }
                
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quantity_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
