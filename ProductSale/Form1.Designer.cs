namespace ProductSale
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
            this.inputLB = new System.Windows.Forms.Label();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.discountLB = new System.Windows.Forms.Label();
            this.totalcostLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputLB
            // 
            this.inputLB.Location = new System.Drawing.Point(34, 13);
            this.inputLB.Name = "inputLB";
            this.inputLB.Size = new System.Drawing.Size(138, 34);
            this.inputLB.TabIndex = 0;
            this.inputLB.Text = "Input how many packages you want to buy, $99 each.";
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(37, 50);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(100, 20);
            this.inputTB.TabIndex = 1;
            this.inputTB.TextChanged += new System.EventHandler(this.inputTB_TextChanged);
            // 
            // discountLB
            // 
            this.discountLB.AutoSize = true;
            this.discountLB.Location = new System.Drawing.Point(178, 34);
            this.discountLB.Name = "discountLB";
            this.discountLB.Size = new System.Drawing.Size(102, 13);
            this.discountLB.TabIndex = 2;
            this.discountLB.Text = "Your discount is: 0%";
            // 
            // totalcostLB
            // 
            this.totalcostLB.AutoSize = true;
            this.totalcostLB.Location = new System.Drawing.Point(178, 57);
            this.totalcostLB.Name = "totalcostLB";
            this.totalcostLB.Size = new System.Drawing.Size(91, 13);
            this.totalcostLB.TabIndex = 3;
            this.totalcostLB.Text = "Your total cost is: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 142);
            this.Controls.Add(this.totalcostLB);
            this.Controls.Add(this.discountLB);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.inputLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLB;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Label discountLB;
        private System.Windows.Forms.Label totalcostLB;
    }
}

