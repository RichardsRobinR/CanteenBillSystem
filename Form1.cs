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

        ArrayList pricearraylist = new ArrayList() { 10, 20, 30, 40 };
        int sum = 0;
        int count = 0;
        

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
            // item list 
            this.item_list_ListBox.Items.Add(this.select_item_ComboBox.SelectedItem);
            
            // price list
            this.price_list_ListBox.Items.Add(this.price_TextBox.Text);
            
            // quantity list
            this.quantity_list_ListBox.Items.Add(this.quantity_TextBox.Text);
            
            // total list
            this.total_list_ListBox.Items.Add(int.Parse(this.price_TextBox.Text) * int.Parse(this.quantity_TextBox.Text));
           
            //this.totalV2_textbox.Text = (int.Parse(this.totalV2_textbox.Text) + int.Parse(this.total_list_ListBox.Items[i])).ToString();
                
            // implementaion for total amount
            sum = sum + (int)this.total_list_ListBox.Items[count];
            count ++; 
            
            // dieplay the total
            this.totalV2_textbox.Text = sum.ToString();


            // clear
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

        //add button
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
