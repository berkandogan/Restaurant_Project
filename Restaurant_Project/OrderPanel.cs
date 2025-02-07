using Restaurant_Project.Context;
using Restaurant_Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Project
{
    public partial class OrderPanel : Form
    {
        DataContext db = new DataContext();
        BindingList<Food> foods { get; set; }
        public OrderPanel()
        {
            InitializeComponent(); 
        }

        private void OrderPanel_Load(object sender, EventArgs e)
        {
            cmb_menu.DataSource = db.Menus.ToList();
            cmb_menu.DisplayMember = "Name";
            cmb_menu.ValueMember = "Id";
            cmb_menu.SelectedIndex = -1;
            foods = new BindingList<Food>();
        }

        private void cmb_menu_Click(object sender, EventArgs e)
        {
            if (cmb_menu.SelectedItem != null)
            {
                int menuId = ((Menu)(cmb_menu.SelectedItem)).Id;
                cmb_food.DataSource = db.MenuFoods.Where(i => i.MenuId == menuId).Select(i => i.Food).ToList();
                cmb_food.DisplayMember = "Name";
                cmb_food.ValueMember = "Id";
            }
        }

        private void cmb_food_Click(object sender, EventArgs e)
        {
            string price = ((Food)cmb_food.SelectedItem).Price.ToString();
            txt_price.Text = price + " TL";
            txt_price.Enabled = false;
        }

        private void btn_addFood_Click(object sender, EventArgs e)
        {
            int foodId = ((Food)cmb_food.SelectedItem).Id;
            var food = db.Foods.Where(i => i.Id == foodId).FirstOrDefault();
            dg_list.DataSource = foods;
            dg_list.Columns["Id"].Visible = false;
            foods.Add(food);
            
        }
    }
}
