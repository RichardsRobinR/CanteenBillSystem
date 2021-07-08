
namespace CanteenBillSystem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.select_item_ComboBox = new System.Windows.Forms.ComboBox();
            this.price_TextBox = new System.Windows.Forms.TextBox();
            this.quantity_TextBox = new System.Windows.Forms.TextBox();
            this.item_List_TextBox = new System.Windows.Forms.TextBox();
            this.price_List_TextBox = new System.Windows.Forms.TextBox();
            this.quantity_List_TextBox = new System.Windows.Forms.TextBox();
            this.total_List_TextBox = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.total_TextBox = new System.Windows.Forms.TextBox();
            this.add_Items_TextBox = new System.Windows.Forms.TextBox();
            this.select_item_add_Button = new System.Windows.Forms.Button();
            this.admin_panel_GroupBox = new System.Windows.Forms.GroupBox();
            this.add_item_Label = new System.Windows.Forms.Label();
            this.add_price_label = new System.Windows.Forms.Label();
            this.add_price_TextBox = new System.Windows.Forms.TextBox();
            this.price_Label = new System.Windows.Forms.Label();
            this.item_list_ListBox = new System.Windows.Forms.ListBox();
            this.price_list_ListBox = new System.Windows.Forms.ListBox();
            this.quantity_list_ListBox = new System.Windows.Forms.ListBox();
            this.total_list_ListBox = new System.Windows.Forms.ListBox();
            this.admin_panel_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // select_item_ComboBox
            // 
            this.select_item_ComboBox.FormattingEnabled = true;
            this.select_item_ComboBox.Location = new System.Drawing.Point(23, 69);
            this.select_item_ComboBox.Name = "select_item_ComboBox";
            this.select_item_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.select_item_ComboBox.TabIndex = 2;
            this.select_item_ComboBox.SelectedIndexChanged += new System.EventHandler(this.select_item_ComboBox_SelectedIndexChanged);
            // 
            // price_TextBox
            // 
            this.price_TextBox.Location = new System.Drawing.Point(169, 69);
            this.price_TextBox.Name = "price_TextBox";
            this.price_TextBox.Size = new System.Drawing.Size(123, 20);
            this.price_TextBox.TabIndex = 3;
            this.price_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // quantity_TextBox
            // 
            this.quantity_TextBox.Location = new System.Drawing.Point(23, 141);
            this.quantity_TextBox.Name = "quantity_TextBox";
            this.quantity_TextBox.Size = new System.Drawing.Size(121, 20);
            this.quantity_TextBox.TabIndex = 4;
            this.quantity_TextBox.TextChanged += new System.EventHandler(this.quantity_TextBox_TextChanged);
            // 
            // item_List_TextBox
            // 
            this.item_List_TextBox.Location = new System.Drawing.Point(23, 260);
            this.item_List_TextBox.Multiline = true;
            this.item_List_TextBox.Name = "item_List_TextBox";
            this.item_List_TextBox.Size = new System.Drawing.Size(121, 257);
            this.item_List_TextBox.TabIndex = 5;
            this.item_List_TextBox.TextChanged += new System.EventHandler(this.item_List_TextBox_TextChanged);
            // 
            // price_List_TextBox
            // 
            this.price_List_TextBox.Location = new System.Drawing.Point(184, 258);
            this.price_List_TextBox.Multiline = true;
            this.price_List_TextBox.Name = "price_List_TextBox";
            this.price_List_TextBox.Size = new System.Drawing.Size(118, 257);
            this.price_List_TextBox.TabIndex = 6;
            // 
            // quantity_List_TextBox
            // 
            this.quantity_List_TextBox.Location = new System.Drawing.Point(343, 258);
            this.quantity_List_TextBox.Multiline = true;
            this.quantity_List_TextBox.Name = "quantity_List_TextBox";
            this.quantity_List_TextBox.Size = new System.Drawing.Size(119, 257);
            this.quantity_List_TextBox.TabIndex = 7;
            // 
            // total_List_TextBox
            // 
            this.total_List_TextBox.Location = new System.Drawing.Point(496, 258);
            this.total_List_TextBox.Multiline = true;
            this.total_List_TextBox.Name = "total_List_TextBox";
            this.total_List_TextBox.Size = new System.Drawing.Size(119, 233);
            this.total_List_TextBox.TabIndex = 8;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Location = new System.Drawing.Point(169, 111);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(123, 50);
            this.calculate_Button.TabIndex = 9;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total";
            // 
            // total_TextBox
            // 
            this.total_TextBox.Location = new System.Drawing.Point(496, 497);
            this.total_TextBox.Name = "total_TextBox";
            this.total_TextBox.Size = new System.Drawing.Size(119, 20);
            this.total_TextBox.TabIndex = 14;
            this.total_TextBox.TextChanged += new System.EventHandler(this.total_TextBox_TextChanged);
            // 
            // add_Items_TextBox
            // 
            this.add_Items_TextBox.Location = new System.Drawing.Point(16, 53);
            this.add_Items_TextBox.Name = "add_Items_TextBox";
            this.add_Items_TextBox.Size = new System.Drawing.Size(121, 20);
            this.add_Items_TextBox.TabIndex = 15;
            this.add_Items_TextBox.TextChanged += new System.EventHandler(this.add_Items_TextBox_TextChanged);
            // 
            // select_item_add_Button
            // 
            this.select_item_add_Button.Location = new System.Drawing.Point(153, 83);
            this.select_item_add_Button.Name = "select_item_add_Button";
            this.select_item_add_Button.Size = new System.Drawing.Size(123, 50);
            this.select_item_add_Button.TabIndex = 16;
            this.select_item_add_Button.Text = "Add Item";
            this.select_item_add_Button.UseVisualStyleBackColor = true;
            this.select_item_add_Button.Click += new System.EventHandler(this.select_item_add_Button_Click);
            // 
            // admin_panel_GroupBox
            // 
            this.admin_panel_GroupBox.Controls.Add(this.add_item_Label);
            this.admin_panel_GroupBox.Controls.Add(this.add_price_label);
            this.admin_panel_GroupBox.Controls.Add(this.add_price_TextBox);
            this.admin_panel_GroupBox.Controls.Add(this.select_item_add_Button);
            this.admin_panel_GroupBox.Controls.Add(this.add_Items_TextBox);
            this.admin_panel_GroupBox.Location = new System.Drawing.Point(312, 51);
            this.admin_panel_GroupBox.Name = "admin_panel_GroupBox";
            this.admin_panel_GroupBox.Size = new System.Drawing.Size(303, 155);
            this.admin_panel_GroupBox.TabIndex = 17;
            this.admin_panel_GroupBox.TabStop = false;
            this.admin_panel_GroupBox.Text = "Admin Panel ";
            // 
            // add_item_Label
            // 
            this.add_item_Label.AutoSize = true;
            this.add_item_Label.Location = new System.Drawing.Point(13, 26);
            this.add_item_Label.Name = "add_item_Label";
            this.add_item_Label.Size = new System.Drawing.Size(27, 13);
            this.add_item_Label.TabIndex = 18;
            this.add_item_Label.Text = "Item";
            // 
            // add_price_label
            // 
            this.add_price_label.AutoSize = true;
            this.add_price_label.Location = new System.Drawing.Point(13, 83);
            this.add_price_label.Name = "add_price_label";
            this.add_price_label.Size = new System.Drawing.Size(31, 13);
            this.add_price_label.TabIndex = 19;
            this.add_price_label.Text = "Price";
            // 
            // add_price_TextBox
            // 
            this.add_price_TextBox.Location = new System.Drawing.Point(16, 113);
            this.add_price_TextBox.Name = "add_price_TextBox";
            this.add_price_TextBox.Size = new System.Drawing.Size(121, 20);
            this.add_price_TextBox.TabIndex = 17;
            // 
            // price_Label
            // 
            this.price_Label.AutoSize = true;
            this.price_Label.Location = new System.Drawing.Point(166, 51);
            this.price_Label.Name = "price_Label";
            this.price_Label.Size = new System.Drawing.Size(31, 13);
            this.price_Label.TabIndex = 18;
            this.price_Label.Text = "Price";
            // 
            // item_list_ListBox
            // 
            this.item_list_ListBox.FormattingEnabled = true;
            this.item_list_ListBox.Location = new System.Drawing.Point(674, 51);
            this.item_list_ListBox.Name = "item_list_ListBox";
            this.item_list_ListBox.Size = new System.Drawing.Size(120, 251);
            this.item_list_ListBox.TabIndex = 19;
            // 
            // price_list_ListBox
            // 
            this.price_list_ListBox.FormattingEnabled = true;
            this.price_list_ListBox.Location = new System.Drawing.Point(823, 51);
            this.price_list_ListBox.Name = "price_list_ListBox";
            this.price_list_ListBox.Size = new System.Drawing.Size(120, 251);
            this.price_list_ListBox.TabIndex = 20;
            // 
            // quantity_list_ListBox
            // 
            this.quantity_list_ListBox.FormattingEnabled = true;
            this.quantity_list_ListBox.Location = new System.Drawing.Point(976, 51);
            this.quantity_list_ListBox.Name = "quantity_list_ListBox";
            this.quantity_list_ListBox.Size = new System.Drawing.Size(120, 251);
            this.quantity_list_ListBox.TabIndex = 21;
            // 
            // total_list_ListBox
            // 
            this.total_list_ListBox.FormattingEnabled = true;
            this.total_list_ListBox.Location = new System.Drawing.Point(674, 308);
            this.total_list_ListBox.Name = "total_list_ListBox";
            this.total_list_ListBox.Size = new System.Drawing.Size(120, 251);
            this.total_list_ListBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 573);
            this.Controls.Add(this.total_list_ListBox);
            this.Controls.Add(this.quantity_list_ListBox);
            this.Controls.Add(this.price_list_ListBox);
            this.Controls.Add(this.item_list_ListBox);
            this.Controls.Add(this.price_Label);
            this.Controls.Add(this.admin_panel_GroupBox);
            this.Controls.Add(this.total_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.total_List_TextBox);
            this.Controls.Add(this.quantity_List_TextBox);
            this.Controls.Add(this.price_List_TextBox);
            this.Controls.Add(this.item_List_TextBox);
            this.Controls.Add(this.quantity_TextBox);
            this.Controls.Add(this.price_TextBox);
            this.Controls.Add(this.select_item_ComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.admin_panel_GroupBox.ResumeLayout(false);
            this.admin_panel_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox select_item_ComboBox;
        private System.Windows.Forms.TextBox price_TextBox;
        private System.Windows.Forms.TextBox quantity_TextBox;
        private System.Windows.Forms.TextBox item_List_TextBox;
        private System.Windows.Forms.TextBox price_List_TextBox;
        private System.Windows.Forms.TextBox quantity_List_TextBox;
        private System.Windows.Forms.TextBox total_List_TextBox;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox total_TextBox;
        private System.Windows.Forms.TextBox add_Items_TextBox;
        private System.Windows.Forms.Button select_item_add_Button;
        private System.Windows.Forms.GroupBox admin_panel_GroupBox;
        private System.Windows.Forms.TextBox add_price_TextBox;
        private System.Windows.Forms.Label add_item_Label;
        private System.Windows.Forms.Label add_price_label;
        private System.Windows.Forms.Label price_Label;
        private System.Windows.Forms.ListBox item_list_ListBox;
        private System.Windows.Forms.ListBox price_list_ListBox;
        private System.Windows.Forms.ListBox quantity_list_ListBox;
        private System.Windows.Forms.ListBox total_list_ListBox;
    }
}

