namespace WindowsFormsApp1
{
    partial class CreationFormReceipts
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxModelNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCountGoods = new System.Windows.Forms.NumericUpDown();
            this.buttonAddReceipts = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxModelNames);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownCountGoods);
            this.groupBox1.Controls.Add(this.buttonAddReceipts);
            this.groupBox1.Location = new System.Drawing.Point(13, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(320, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Модель";
            // 
            // comboBoxModelNames
            // 
            this.comboBoxModelNames.FormattingEnabled = true;
            this.comboBoxModelNames.Location = new System.Drawing.Point(24, 64);
            this.comboBoxModelNames.Name = "comboBoxModelNames";
            this.comboBoxModelNames.Size = new System.Drawing.Size(270, 33);
            this.comboBoxModelNames.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во товара";
            // 
            // numericUpDownCountGoods
            // 
            this.numericUpDownCountGoods.Location = new System.Drawing.Point(24, 146);
            this.numericUpDownCountGoods.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountGoods.Name = "numericUpDownCountGoods";
            this.numericUpDownCountGoods.Size = new System.Drawing.Size(270, 30);
            this.numericUpDownCountGoods.TabIndex = 4;
            this.numericUpDownCountGoods.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAddReceipts
            // 
            this.buttonAddReceipts.Location = new System.Drawing.Point(35, 209);
            this.buttonAddReceipts.Name = "buttonAddReceipts";
            this.buttonAddReceipts.Size = new System.Drawing.Size(249, 41);
            this.buttonAddReceipts.TabIndex = 0;
            this.buttonAddReceipts.Text = "Добавить";
            this.buttonAddReceipts.UseVisualStyleBackColor = true;
            this.buttonAddReceipts.Click += new System.EventHandler(this.buttonAddReceipts_Click);
            // 
            // CreationFormReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 287);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreationFormReceipts";
            this.Text = "Создание поступления";
            this.Load += new System.EventHandler(this.CreationFormReceipts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownCountGoods;
        private System.Windows.Forms.Button buttonAddReceipts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxModelNames;
    }
}