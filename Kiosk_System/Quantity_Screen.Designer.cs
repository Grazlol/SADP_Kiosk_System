namespace Kiosk_System
{
    partial class Quantity_Screen
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.proceed_btn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addqty = new System.Windows.Forms.Button();
            this.label_price = new System.Windows.Forms.Label();
            this.subqty = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.labelqty = new System.Windows.Forms.Label();
            this.food_item1 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Choose Quantity";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.Coral;
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(11, 3);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(492, 547);
            this.panel6.TabIndex = 18;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SeaShell;
            this.panel9.Controls.Add(this.button2);
            this.panel9.Controls.Add(this.proceed_btn);
            this.panel9.ForeColor = System.Drawing.Color.Crimson;
            this.panel9.Location = new System.Drawing.Point(16, 470);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(457, 65);
            this.panel9.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 51);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // proceed_btn
            // 
            this.proceed_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed_btn.Location = new System.Drawing.Point(250, 7);
            this.proceed_btn.Name = "proceed_btn";
            this.proceed_btn.Size = new System.Drawing.Size(198, 51);
            this.proceed_btn.TabIndex = 20;
            this.proceed_btn.Text = "Add to Order";
            this.proceed_btn.UseVisualStyleBackColor = true;
            this.proceed_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.Color.SeaShell;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.addqty);
            this.panel7.Controls.Add(this.label_price);
            this.panel7.Controls.Add(this.subqty);
            this.panel7.Controls.Add(this.label_name);
            this.panel7.Controls.Add(this.labelqty);
            this.panel7.Controls.Add(this.food_item1);
            this.panel7.Location = new System.Drawing.Point(16, 72);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(457, 392);
            this.panel7.TabIndex = 21;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(84, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 33);
            this.label2.TabIndex = 70;
            this.label2.Text = "₱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(187, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 61;
            this.label4.Text = "Quantity:";
            // 
            // addqty
            // 
            this.addqty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addqty.Location = new System.Drawing.Point(257, 333);
            this.addqty.Name = "addqty";
            this.addqty.Size = new System.Drawing.Size(27, 25);
            this.addqty.TabIndex = 58;
            this.addqty.Text = "+";
            this.addqty.UseVisualStyleBackColor = true;
            this.addqty.Click += new System.EventHandler(this.add_quantity);
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.ForeColor = System.Drawing.Color.Crimson;
            this.label_price.Location = new System.Drawing.Point(113, 277);
            this.label_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(74, 28);
            this.label_price.TabIndex = 24;
            this.label_price.Text = "Price";
            // 
            // subqty
            // 
            this.subqty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subqty.Location = new System.Drawing.Point(180, 333);
            this.subqty.Name = "subqty";
            this.subqty.Size = new System.Drawing.Size(27, 25);
            this.subqty.TabIndex = 60;
            this.subqty.Text = "-";
            this.subqty.UseVisualStyleBackColor = true;
            this.subqty.Click += new System.EventHandler(this.sub_quantity);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.Crimson;
            this.label_name.Location = new System.Drawing.Point(115, 225);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(222, 43);
            this.label_name.TabIndex = 14;
            this.label_name.Text = "Food Name";
            // 
            // labelqty
            // 
            this.labelqty.AutoSize = true;
            this.labelqty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelqty.ForeColor = System.Drawing.Color.Crimson;
            this.labelqty.Location = new System.Drawing.Point(221, 333);
            this.labelqty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelqty.Name = "labelqty";
            this.labelqty.Size = new System.Drawing.Size(21, 22);
            this.labelqty.TabIndex = 59;
            this.labelqty.Text = "1";
            // 
            // food_item1
            // 
            this.food_item1.BackColor = System.Drawing.Color.SeaShell;
            this.food_item1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.food_item1.Location = new System.Drawing.Point(128, 23);
            this.food_item1.Margin = new System.Windows.Forms.Padding(2);
            this.food_item1.Name = "food_item1";
            this.food_item1.Size = new System.Drawing.Size(200, 200);
            this.food_item1.TabIndex = 19;
            // 
            // Quantity_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 561);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Quantity_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel food_item1;
        private System.Windows.Forms.Button proceed_btn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label labelqty;
        private System.Windows.Forms.Button addqty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button subqty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

