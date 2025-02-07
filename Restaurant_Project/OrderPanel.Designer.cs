namespace Restaurant_Project
{
    partial class OrderPanel
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
            label1 = new Label();
            cmb_menu = new ComboBox();
            label2 = new Label();
            cmb_food = new ComboBox();
            label3 = new Label();
            txt_price = new TextBox();
            dg_list = new DataGridView();
            btn_addFood = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_list).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 39);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // cmb_menu
            // 
            cmb_menu.FormattingEnabled = true;
            cmb_menu.Location = new Point(114, 36);
            cmb_menu.Name = "cmb_menu";
            cmb_menu.Size = new Size(194, 28);
            cmb_menu.TabIndex = 1;
            cmb_menu.Click += cmb_menu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 95);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "Food";
            // 
            // cmb_food
            // 
            cmb_food.FormattingEnabled = true;
            cmb_food.Location = new Point(114, 92);
            cmb_food.Name = "cmb_food";
            cmb_food.Size = new Size(194, 28);
            cmb_food.TabIndex = 3;
            cmb_food.Click += cmb_food_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 150);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // txt_price
            // 
            txt_price.Location = new Point(114, 147);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(125, 27);
            txt_price.TabIndex = 5;
            // 
            // dg_list
            // 
            dg_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_list.Location = new Point(37, 238);
            dg_list.Name = "dg_list";
            dg_list.RowHeadersWidth = 51;
            dg_list.Size = new Size(456, 200);
            dg_list.TabIndex = 6;
            // 
            // btn_addFood
            // 
            btn_addFood.BackColor = SystemColors.ActiveCaption;
            btn_addFood.Location = new Point(114, 190);
            btn_addFood.Name = "btn_addFood";
            btn_addFood.Size = new Size(125, 29);
            btn_addFood.TabIndex = 7;
            btn_addFood.Text = "Add";
            btn_addFood.UseVisualStyleBackColor = false;
            btn_addFood.Click += btn_addFood_Click;
            // 
            // OrderPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_addFood);
            Controls.Add(dg_list);
            Controls.Add(txt_price);
            Controls.Add(label3);
            Controls.Add(cmb_food);
            Controls.Add(label2);
            Controls.Add(cmb_menu);
            Controls.Add(label1);
            Name = "OrderPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderPanel";
            Load += OrderPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dg_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmb_menu;
        private Label label2;
        private ComboBox cmb_food;
        private Label label3;
        private TextBox txt_price;
        private DataGridView dg_list;
        private Button btn_addFood;
    }
}