namespace Pizza
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
            this.radioCrust1 = new System.Windows.Forms.RadioButton();
            this.radioCrust2 = new System.Windows.Forms.RadioButton();
            this.radioCrust3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioSize1 = new System.Windows.Forms.RadioButton();
            this.radioSize2 = new System.Windows.Forms.RadioButton();
            this.radioSize3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.order = new System.Windows.Forms.Label();
            this.order2 = new System.Windows.Forms.Label();
            this.order3 = new System.Windows.Forms.Label();
            this.order1Input = new System.Windows.Forms.Label();
            this.order2Input = new System.Windows.Forms.Label();
            this.order3Input = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(55, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crust";
            // 
            // radioCrust1
            // 
            this.radioCrust1.AutoSize = true;
            this.radioCrust1.Location = new System.Drawing.Point(24, 25);
            this.radioCrust1.Name = "radioCrust1";
            this.radioCrust1.Size = new System.Drawing.Size(86, 17);
            this.radioCrust1.TabIndex = 1;
            this.radioCrust1.TabStop = true;
            this.radioCrust1.Text = "Stuffed Crust";
            this.radioCrust1.UseVisualStyleBackColor = true;
            this.radioCrust1.CheckedChanged += new System.EventHandler(this.radioCrust1_CheckedChanged);
            // 
            // radioCrust2
            // 
            this.radioCrust2.AutoSize = true;
            this.radioCrust2.Location = new System.Drawing.Point(206, 25);
            this.radioCrust2.Name = "radioCrust2";
            this.radioCrust2.Size = new System.Drawing.Size(58, 17);
            this.radioCrust2.TabIndex = 2;
            this.radioCrust2.TabStop = true;
            this.radioCrust2.Text = "Sicilian";
            this.radioCrust2.UseVisualStyleBackColor = true;
            this.radioCrust2.CheckedChanged += new System.EventHandler(this.radioCrust2_CheckedChanged);
            // 
            // radioCrust3
            // 
            this.radioCrust3.AutoSize = true;
            this.radioCrust3.Location = new System.Drawing.Point(363, 25);
            this.radioCrust3.Name = "radioCrust3";
            this.radioCrust3.Size = new System.Drawing.Size(73, 17);
            this.radioCrust3.TabIndex = 3;
            this.radioCrust3.TabStop = true;
            this.radioCrust3.Text = "Thin Crust";
            this.radioCrust3.UseVisualStyleBackColor = true;
            this.radioCrust3.CheckedChanged += new System.EventHandler(this.radioCrust3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(52, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toppings (Regular = $2.00, * = $3.00)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(58, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Pepperoni";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(58, 166);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Sausage";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(58, 189);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Olives*";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(163, 143);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 17);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Peppers";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(163, 166);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(61, 17);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Bacon*";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(163, 189);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(89, 17);
            this.checkBox6.TabIndex = 10;
            this.checkBox6.Text = "Extra Cheese";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(261, 143);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(60, 17);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.Text = "Caviar*";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(261, 166);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(123, 17);
            this.checkBox8.TabIndex = 12;
            this.checkBox8.Text = "Extra Tomato Sauce";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(261, 189);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(63, 17);
            this.checkBox9.TabIndex = 13;
            this.checkBox9.Text = "Onions*";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(58, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Size (12\" = $9; 18\" = $12; 30\" = $15";
            // 
            // radioSize1
            // 
            this.radioSize1.AutoSize = true;
            this.radioSize1.Location = new System.Drawing.Point(6, 26);
            this.radioSize1.Name = "radioSize1";
            this.radioSize1.Size = new System.Drawing.Size(142, 17);
            this.radioSize1.TabIndex = 15;
            this.radioSize1.TabStop = true;
            this.radioSize1.Text = "Don\'t Wanna Cook (12\")";
            this.radioSize1.UseVisualStyleBackColor = true;
            this.radioSize1.CheckedChanged += new System.EventHandler(this.radioSize1_CheckedChanged);
            // 
            // radioSize2
            // 
            this.radioSize2.AutoSize = true;
            this.radioSize2.Location = new System.Drawing.Point(181, 26);
            this.radioSize2.Name = "radioSize2";
            this.radioSize2.Size = new System.Drawing.Size(101, 17);
            this.radioSize2.TabIndex = 16;
            this.radioSize2.TabStop = true;
            this.radioSize2.Text = "Cheat Day (18\")";
            this.radioSize2.UseVisualStyleBackColor = true;
            this.radioSize2.CheckedChanged += new System.EventHandler(this.radioSize2_CheckedChanged);
            // 
            // radioSize3
            // 
            this.radioSize3.AutoSize = true;
            this.radioSize3.Location = new System.Drawing.Point(313, 26);
            this.radioSize3.Name = "radioSize3";
            this.radioSize3.Size = new System.Drawing.Size(141, 17);
            this.radioSize3.TabIndex = 17;
            this.radioSize3.TabStop = true;
            this.radioSize3.Text = "Friends are Coming (30\")";
            this.radioSize3.UseVisualStyleBackColor = true;
            this.radioSize3.CheckedChanged += new System.EventHandler(this.radioSize3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCrust2);
            this.groupBox1.Controls.Add(this.radioCrust1);
            this.groupBox1.Controls.Add(this.radioCrust3);
            this.groupBox1.Location = new System.Drawing.Point(55, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 66);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSize1);
            this.groupBox2.Controls.Add(this.radioSize2);
            this.groupBox2.Controls.Add(this.radioSize3);
            this.groupBox2.Location = new System.Drawing.Point(55, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 64);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(160, 340);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(61, 13);
            this.order.TabIndex = 23;
            this.order.Text = "Crust Type:";
            // 
            // order2
            // 
            this.order2.AutoSize = true;
            this.order2.Location = new System.Drawing.Point(283, 340);
            this.order2.Name = "order2";
            this.order2.Size = new System.Drawing.Size(54, 13);
            this.order2.TabIndex = 24;
            this.order2.Text = "Toppings:";
            // 
            // order3
            // 
            this.order3.AutoSize = true;
            this.order3.Location = new System.Drawing.Point(415, 340);
            this.order3.Name = "order3";
            this.order3.Size = new System.Drawing.Size(30, 13);
            this.order3.TabIndex = 25;
            this.order3.Text = "Size:";
            // 
            // order1Input
            // 
            this.order1Input.AutoSize = true;
            this.order1Input.Location = new System.Drawing.Point(160, 365);
            this.order1Input.Name = "order1Input";
            this.order1Input.Size = new System.Drawing.Size(37, 13);
            this.order1Input.TabIndex = 26;
            this.order1Input.Text = "          ";
            // 
            // order2Input
            // 
            this.order2Input.AutoSize = true;
            this.order2Input.Location = new System.Drawing.Point(283, 365);
            this.order2Input.Name = "order2Input";
            this.order2Input.Size = new System.Drawing.Size(0, 13);
            this.order2Input.TabIndex = 27;
            // 
            // order3Input
            // 
            this.order3Input.AutoSize = true;
            this.order3Input.Location = new System.Drawing.Point(415, 365);
            this.order3Input.Name = "order3Input";
            this.order3Input.Size = new System.Drawing.Size(0, 13);
            this.order3Input.TabIndex = 28;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(481, 481);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 29;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 527);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.order3Input);
            this.Controls.Add(this.order2Input);
            this.Controls.Add(this.order1Input);
            this.Controls.Add(this.order3);
            this.Controls.Add(this.order2);
            this.Controls.Add(this.order);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Place Your Order!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioCrust1;
        private System.Windows.Forms.RadioButton radioCrust2;
        private System.Windows.Forms.RadioButton radioCrust3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioSize1;
        private System.Windows.Forms.RadioButton radioSize2;
        private System.Windows.Forms.RadioButton radioSize3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label order2;
        private System.Windows.Forms.Label order3;
        private System.Windows.Forms.Label order1Input;
        private System.Windows.Forms.Label order2Input;
        private System.Windows.Forms.Label order3Input;
        private System.Windows.Forms.Button reset;
    }
}

