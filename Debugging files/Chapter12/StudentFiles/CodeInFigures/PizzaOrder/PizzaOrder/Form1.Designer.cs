namespace PizzaOrder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.onionCheckBox = new System.Windows.Forms.CheckBox();
            this.greenPepperCheckBox = new System.Windows.Forms.CheckBox();
            this.pepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.sausageCheckBox = new System.Windows.Forms.CheckBox();
            this.pickUpRadioButton = new System.Windows.Forms.RadioButton();
            this.deliverRadioButton = new System.Windows.Forms.RadioButton();
            this.dineInRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // onionCheckBox
            // 
            this.onionCheckBox.AutoSize = true;
            this.onionCheckBox.Location = new System.Drawing.Point(32, 102);
            this.onionCheckBox.Name = "onionCheckBox";
            this.onionCheckBox.Size = new System.Drawing.Size(59, 17);
            this.onionCheckBox.TabIndex = 0;
            this.onionCheckBox.Text = "Onions";
            this.onionCheckBox.UseVisualStyleBackColor = true;
            this.onionCheckBox.CheckedChanged += new System.EventHandler(this.onionCheckBox_CheckedChanged);
            // 
            // greenPepperCheckBox
            // 
            this.greenPepperCheckBox.AutoSize = true;
            this.greenPepperCheckBox.Location = new System.Drawing.Point(32, 126);
            this.greenPepperCheckBox.Name = "greenPepperCheckBox";
            this.greenPepperCheckBox.Size = new System.Drawing.Size(91, 17);
            this.greenPepperCheckBox.TabIndex = 1;
            this.greenPepperCheckBox.Text = "Green pepper";
            this.greenPepperCheckBox.UseVisualStyleBackColor = true;
            this.greenPepperCheckBox.CheckedChanged += new System.EventHandler(this.greenPepperCheckBox_CheckedChanged);
            // 
            // pepperoniCheckBox
            // 
            this.pepperoniCheckBox.AutoSize = true;
            this.pepperoniCheckBox.Location = new System.Drawing.Point(32, 150);
            this.pepperoniCheckBox.Name = "pepperoniCheckBox";
            this.pepperoniCheckBox.Size = new System.Drawing.Size(74, 17);
            this.pepperoniCheckBox.TabIndex = 2;
            this.pepperoniCheckBox.Text = "Pepperoni";
            this.pepperoniCheckBox.UseVisualStyleBackColor = true;
            this.pepperoniCheckBox.CheckedChanged += new System.EventHandler(this.pepperoniCheckBox_CheckedChanged);
            // 
            // sausageCheckBox
            // 
            this.sausageCheckBox.AutoSize = true;
            this.sausageCheckBox.Location = new System.Drawing.Point(32, 174);
            this.sausageCheckBox.Name = "sausageCheckBox";
            this.sausageCheckBox.Size = new System.Drawing.Size(68, 17);
            this.sausageCheckBox.TabIndex = 3;
            this.sausageCheckBox.Text = "Sausage";
            this.sausageCheckBox.UseVisualStyleBackColor = true;
            this.sausageCheckBox.CheckedChanged += new System.EventHandler(this.sausageCheckBox_CheckedChanged);
            // 
            // pickUpRadioButton
            // 
            this.pickUpRadioButton.AutoSize = true;
            this.pickUpRadioButton.Location = new System.Drawing.Point(152, 101);
            this.pickUpRadioButton.Name = "pickUpRadioButton";
            this.pickUpRadioButton.Size = new System.Drawing.Size(61, 17);
            this.pickUpRadioButton.TabIndex = 4;
            this.pickUpRadioButton.TabStop = true;
            this.pickUpRadioButton.Text = "Pick-up";
            this.pickUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // deliverRadioButton
            // 
            this.deliverRadioButton.AutoSize = true;
            this.deliverRadioButton.Location = new System.Drawing.Point(152, 125);
            this.deliverRadioButton.Name = "deliverRadioButton";
            this.deliverRadioButton.Size = new System.Drawing.Size(63, 17);
            this.deliverRadioButton.TabIndex = 5;
            this.deliverRadioButton.TabStop = true;
            this.deliverRadioButton.Text = "Delivery";
            this.deliverRadioButton.UseVisualStyleBackColor = true;
            this.deliverRadioButton.CheckedChanged += new System.EventHandler(this.deliverRadioButton_CheckedChanged);
            // 
            // dineInRadioButton
            // 
            this.dineInRadioButton.AutoSize = true;
            this.dineInRadioButton.Location = new System.Drawing.Point(152, 149);
            this.dineInRadioButton.Name = "dineInRadioButton";
            this.dineInRadioButton.Size = new System.Drawing.Size(58, 17);
            this.dineInRadioButton.TabIndex = 6;
            this.dineInRadioButton.TabStop = true;
            this.dineInRadioButton.Text = "Dine in";
            this.dineInRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pizza Order Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select toppings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dining options";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(150, 208);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 20);
            this.outputLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dineInRadioButton);
            this.Controls.Add(this.deliverRadioButton);
            this.Controls.Add(this.pickUpRadioButton);
            this.Controls.Add(this.sausageCheckBox);
            this.Controls.Add(this.pepperoniCheckBox);
            this.Controls.Add(this.greenPepperCheckBox);
            this.Controls.Add(this.onionCheckBox);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox onionCheckBox;
        private System.Windows.Forms.CheckBox greenPepperCheckBox;
        private System.Windows.Forms.CheckBox pepperoniCheckBox;
        private System.Windows.Forms.CheckBox sausageCheckBox;
        private System.Windows.Forms.RadioButton pickUpRadioButton;
        private System.Windows.Forms.RadioButton deliverRadioButton;
        private System.Windows.Forms.RadioButton dineInRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label outputLabel;
    }
}

