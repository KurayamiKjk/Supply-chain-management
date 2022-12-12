namespace Supply_chain_management_WF
{
    partial class AddProduct
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalPriceDisplay = new System.Windows.Forms.NumericUpDown();
            this.productUnitPriceInput = new System.Windows.Forms.NumericUpDown();
            this.resetAddingBtn = new System.Windows.Forms.Button();
            this.cancleAddingBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.productDescriptionInput = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unavailableRadio = new System.Windows.Forms.RadioButton();
            this.availableRadio = new System.Windows.Forms.RadioButton();
            this.productQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.productUnitDropDown = new System.Windows.Forms.ComboBox();
            this.productNameInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productUnitPriceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(46, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Unit Price :";
            // 
            // totalPriceDisplay
            // 
            this.totalPriceDisplay.DecimalPlaces = 3;
            this.totalPriceDisplay.Enabled = false;
            this.totalPriceDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPriceDisplay.Location = new System.Drawing.Point(77, 369);
            this.totalPriceDisplay.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.totalPriceDisplay.Name = "totalPriceDisplay";
            this.totalPriceDisplay.Size = new System.Drawing.Size(224, 29);
            this.totalPriceDisplay.TabIndex = 17;
            this.totalPriceDisplay.ValueChanged += new System.EventHandler(this.totalPriceDisplay_ValueChanged);
            // 
            // productUnitPriceInput
            // 
            this.productUnitPriceInput.DecimalPlaces = 3;
            this.productUnitPriceInput.Location = new System.Drawing.Point(93, 249);
            this.productUnitPriceInput.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.productUnitPriceInput.Name = "productUnitPriceInput";
            this.productUnitPriceInput.Size = new System.Drawing.Size(224, 23);
            this.productUnitPriceInput.TabIndex = 16;
            this.productUnitPriceInput.ValueChanged += new System.EventHandler(this.productUnitPriceInput_ValueChanged);
            // 
            // resetAddingBtn
            // 
            this.resetAddingBtn.Location = new System.Drawing.Point(318, 356);
            this.resetAddingBtn.Name = "resetAddingBtn";
            this.resetAddingBtn.Size = new System.Drawing.Size(94, 44);
            this.resetAddingBtn.TabIndex = 15;
            this.resetAddingBtn.Text = "Clear";
            this.resetAddingBtn.UseVisualStyleBackColor = true;
            this.resetAddingBtn.Click += new System.EventHandler(this.resetAddingBtn_Click);
            // 
            // cancleAddingBtn
            // 
            this.cancleAddingBtn.Location = new System.Drawing.Point(435, 356);
            this.cancleAddingBtn.Name = "cancleAddingBtn";
            this.cancleAddingBtn.Size = new System.Drawing.Size(94, 44);
            this.cancleAddingBtn.TabIndex = 14;
            this.cancleAddingBtn.Text = "Cancle";
            this.cancleAddingBtn.UseVisualStyleBackColor = true;
            this.cancleAddingBtn.Click += new System.EventHandler(this.cancleAddingBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(548, 356);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(94, 44);
            this.createBtn.TabIndex = 13;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // productDescriptionInput
            // 
            this.productDescriptionInput.Location = new System.Drawing.Point(372, 58);
            this.productDescriptionInput.Multiline = true;
            this.productDescriptionInput.Name = "productDescriptionInput";
            this.productDescriptionInput.PlaceholderText = "About this product...";
            this.productDescriptionInput.Size = new System.Drawing.Size(247, 167);
            this.productDescriptionInput.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 303);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product Id :";
            // 
            // unavailableRadio
            // 
            this.unavailableRadio.AutoSize = true;
            this.unavailableRadio.Location = new System.Drawing.Point(525, 249);
            this.unavailableRadio.Name = "unavailableRadio";
            this.unavailableRadio.Size = new System.Drawing.Size(86, 19);
            this.unavailableRadio.TabIndex = 6;
            this.unavailableRadio.Text = "Unavailable";
            this.unavailableRadio.UseVisualStyleBackColor = true;
            // 
            // availableRadio
            // 
            this.availableRadio.AutoSize = true;
            this.availableRadio.Checked = true;
            this.availableRadio.Location = new System.Drawing.Point(372, 249);
            this.availableRadio.Name = "availableRadio";
            this.availableRadio.Size = new System.Drawing.Size(73, 19);
            this.availableRadio.TabIndex = 5;
            this.availableRadio.TabStop = true;
            this.availableRadio.Text = "Available";
            this.availableRadio.UseVisualStyleBackColor = true;
            // 
            // productQuantityInput
            // 
            this.productQuantityInput.Location = new System.Drawing.Point(93, 202);
            this.productQuantityInput.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.productQuantityInput.Name = "productQuantityInput";
            this.productQuantityInput.Size = new System.Drawing.Size(224, 23);
            this.productQuantityInput.TabIndex = 4;
            this.productQuantityInput.ValueChanged += new System.EventHandler(this.productQuantityInput_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(93, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 23);
            this.textBox1.TabIndex = 0;
            // 
            // productUnitDropDown
            // 
            this.productUnitDropDown.FormattingEnabled = true;
            this.productUnitDropDown.Items.AddRange(new object[] {
            "---Select product unit---",
            "Item",
            "Set"});
            this.productUnitDropDown.Location = new System.Drawing.Point(93, 150);
            this.productUnitDropDown.Name = "productUnitDropDown";
            this.productUnitDropDown.Size = new System.Drawing.Size(224, 23);
            this.productUnitDropDown.TabIndex = 3;
            // 
            // productNameInput
            // 
            this.productNameInput.Location = new System.Drawing.Point(93, 102);
            this.productNameInput.Name = "productNameInput";
            this.productNameInput.Size = new System.Drawing.Size(224, 23);
            this.productNameInput.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.totalPriceDisplay);
            this.panel1.Controls.Add(this.productUnitPriceInput);
            this.panel1.Controls.Add(this.resetAddingBtn);
            this.panel1.Controls.Add(this.cancleAddingBtn);
            this.panel1.Controls.Add(this.createBtn);
            this.panel1.Controls.Add(this.productDescriptionInput);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.unavailableRadio);
            this.panel1.Controls.Add(this.availableRadio);
            this.panel1.Controls.Add(this.productQuantityInput);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.productUnitDropDown);
            this.panel1.Controls.Add(this.productNameInput);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 417);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Description :";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(93, 303);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 48);
            this.panel7.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(7, 240);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(80, 32);
            this.panel6.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(7, 193);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 32);
            this.panel5.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(7, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 32);
            this.panel4.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(7, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 32);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(7, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 32);
            this.panel2.TabIndex = 20;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddProduct";
            this.Text = "New Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productUnitPriceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label6;
        private Label label5;
        private NumericUpDown totalPriceDisplay;
        private NumericUpDown productUnitPriceInput;
        private Button resetAddingBtn;
        private Button cancleAddingBtn;
        private Button createBtn;
        private TextBox productDescriptionInput;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton unavailableRadio;
        private RadioButton availableRadio;
        private NumericUpDown productQuantityInput;
        private TextBox textBox1;
        private ComboBox productUnitDropDown;
        private TextBox productNameInput;
        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label7;
        private Panel panel7;
    }
}