namespace Kiosk_System
{
    partial class Checkout_Screen
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DineOut = new System.Windows.Forms.PictureBox();
            this.DineIn = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DineOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DineIn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(350, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 75);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Mode of Service";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(11, 3);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1405, 856);
            this.panel6.TabIndex = 18;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.Color.SeaShell;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.DineOut);
            this.panel7.Controls.Add(this.DineIn);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1399, 850);
            this.panel7.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(392, 528);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Eat your Burger";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(0, 696);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 151);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1399, 163);
            this.panel2.TabIndex = 19;
            // 
            // DineOut
            // 
            this.DineOut.BackColor = System.Drawing.Color.SeaShell;
            this.DineOut.BackgroundImage = global::Kiosk_System.Properties.Resources._3;
            this.DineOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DineOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DineOut.Location = new System.Drawing.Point(815, 326);
            this.DineOut.Margin = new System.Windows.Forms.Padding(2);
            this.DineOut.Name = "DineOut";
            this.DineOut.Size = new System.Drawing.Size(200, 200);
            this.DineOut.TabIndex = 15;
            this.DineOut.TabStop = false;
            this.DineOut.Click += new System.EventHandler(this.DineOut_Click);
            // 
            // DineIn
            // 
            this.DineIn.BackColor = System.Drawing.Color.SeaShell;
            this.DineIn.BackgroundImage = global::Kiosk_System.Properties.Resources._2;
            this.DineIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DineIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DineIn.Location = new System.Drawing.Point(427, 326);
            this.DineIn.Margin = new System.Windows.Forms.Padding(2);
            this.DineIn.Name = "DineIn";
            this.DineIn.Size = new System.Drawing.Size(200, 200);
            this.DineIn.TabIndex = 14;
            this.DineIn.TabStop = false;
            this.DineIn.Click += new System.EventHandler(this.DineIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(473, 565);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "here!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(866, 565);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 37);
            this.label5.TabIndex = 22;
            this.label5.Text = "to go!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(771, 528);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "Have your Burger";
            // 
            // Checkout_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1427, 870);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Checkout_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DineOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DineIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox DineOut;
        private System.Windows.Forms.PictureBox DineIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

