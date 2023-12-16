namespace WindowsFormsApp1
{
    partial class EditingFormReceipts
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.employeeIdLabel = new System.Windows.Forms.Label();
            this.modelIdLabel = new System.Windows.Forms.Label();
            this.showAdditionalInformationCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.labelEmployeeJobTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEmployeeNames = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxModel = new System.Windows.Forms.GroupBox();
            this.labelModelCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxModelNames = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendarDateReceipt = new System.Windows.Forms.MonthCalendar();
            this.receiptIdLabel = new System.Windows.Forms.Label();
            this.buttonDeleteReceipt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCountGoods = new System.Windows.Forms.NumericUpDown();
            this.buttonEditReceipt = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.groupBoxEmployee.SuspendLayout();
            this.groupBoxModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.employeeIdLabel);
            this.groupBox.Controls.Add(this.buttonEditReceipt);
            this.groupBox.Controls.Add(this.buttonDeleteReceipt);
            this.groupBox.Controls.Add(this.modelIdLabel);
            this.groupBox.Controls.Add(this.showAdditionalInformationCheckBox);
            this.groupBox.Controls.Add(this.groupBoxEmployee);
            this.groupBox.Controls.Add(this.groupBoxModel);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.monthCalendarDateReceipt);
            this.groupBox.Controls.Add(this.receiptIdLabel);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.numericUpDownCountGoods);
            this.groupBox.Location = new System.Drawing.Point(13, 5);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox.Size = new System.Drawing.Size(565, 347);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Введите данные";
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Location = new System.Drawing.Point(19, 130);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(181, 25);
            this.employeeIdLabel.TabIndex = 20;
            this.employeeIdLabel.Text = "Код сотрудника: 1";
            // 
            // modelIdLabel
            // 
            this.modelIdLabel.AutoSize = true;
            this.modelIdLabel.Location = new System.Drawing.Point(19, 84);
            this.modelIdLabel.Name = "modelIdLabel";
            this.modelIdLabel.Size = new System.Drawing.Size(148, 25);
            this.modelIdLabel.TabIndex = 19;
            this.modelIdLabel.Text = "Код модели: 1";
            // 
            // showAdditionalInformationCheckBox
            // 
            this.showAdditionalInformationCheckBox.AutoSize = true;
            this.showAdditionalInformationCheckBox.Location = new System.Drawing.Point(24, 176);
            this.showAdditionalInformationCheckBox.Name = "showAdditionalInformationCheckBox";
            this.showAdditionalInformationCheckBox.Size = new System.Drawing.Size(299, 29);
            this.showAdditionalInformationCheckBox.TabIndex = 18;
            this.showAdditionalInformationCheckBox.Text = "Показать доп. информацию";
            this.showAdditionalInformationCheckBox.UseVisualStyleBackColor = true;
            this.showAdditionalInformationCheckBox.CheckedChanged += new System.EventHandler(this.showAdditionaInformationCheckBox_CheckedChanged);
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.labelEmployeeJobTitle);
            this.groupBoxEmployee.Controls.Add(this.label6);
            this.groupBoxEmployee.Controls.Add(this.comboBoxEmployeeNames);
            this.groupBoxEmployee.Controls.Add(this.label9);
            this.groupBoxEmployee.Location = new System.Drawing.Point(12, 428);
            this.groupBoxEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxEmployee.Size = new System.Drawing.Size(540, 116);
            this.groupBoxEmployee.TabIndex = 17;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Сотрудник";
            // 
            // labelEmployeeJobTitle
            // 
            this.labelEmployeeJobTitle.AutoSize = true;
            this.labelEmployeeJobTitle.Location = new System.Drawing.Point(316, 70);
            this.labelEmployeeJobTitle.Name = "labelEmployeeJobTitle";
            this.labelEmployeeJobTitle.Size = new System.Drawing.Size(95, 25);
            this.labelEmployeeJobTitle.TabIndex = 12;
            this.labelEmployeeJobTitle.Text = "Уборщик";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "ФИО сотрудника";
            // 
            // comboBoxEmployeeNames
            // 
            this.comboBoxEmployeeNames.FormattingEnabled = true;
            this.comboBoxEmployeeNames.Location = new System.Drawing.Point(12, 67);
            this.comboBoxEmployeeNames.Name = "comboBoxEmployeeNames";
            this.comboBoxEmployeeNames.Size = new System.Drawing.Size(270, 33);
            this.comboBoxEmployeeNames.TabIndex = 11;
            this.comboBoxEmployeeNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeNames_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Должность:";
            // 
            // groupBoxModel
            // 
            this.groupBoxModel.Controls.Add(this.labelModelCost);
            this.groupBoxModel.Controls.Add(this.label3);
            this.groupBoxModel.Controls.Add(this.comboBoxModelNames);
            this.groupBoxModel.Controls.Add(this.label5);
            this.groupBoxModel.Location = new System.Drawing.Point(12, 302);
            this.groupBoxModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxModel.Name = "groupBoxModel";
            this.groupBoxModel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxModel.Size = new System.Drawing.Size(540, 113);
            this.groupBoxModel.TabIndex = 16;
            this.groupBoxModel.TabStop = false;
            this.groupBoxModel.Text = "Модель";
            this.groupBoxModel.Visible = false;
            this.groupBoxModel.Enter += new System.EventHandler(this.groupBoxModel_Enter);
            // 
            // labelModelCost
            // 
            this.labelModelCost.AutoSize = true;
            this.labelModelCost.Location = new System.Drawing.Point(316, 67);
            this.labelModelCost.Name = "labelModelCost";
            this.labelModelCost.Size = new System.Drawing.Size(78, 25);
            this.labelModelCost.TabIndex = 10;
            this.labelModelCost.Text = "120000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Наименование модели";
            // 
            // comboBoxModelNames
            // 
            this.comboBoxModelNames.FormattingEnabled = true;
            this.comboBoxModelNames.Location = new System.Drawing.Point(12, 64);
            this.comboBoxModelNames.Name = "comboBoxModelNames";
            this.comboBoxModelNames.Size = new System.Drawing.Size(270, 33);
            this.comboBoxModelNames.TabIndex = 8;
            this.comboBoxModelNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxModelNames_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата поступления";
            // 
            // monthCalendarDateReceipt
            // 
            this.monthCalendarDateReceipt.Location = new System.Drawing.Point(360, 71);
            this.monthCalendarDateReceipt.Name = "monthCalendarDateReceipt";
            this.monthCalendarDateReceipt.TabIndex = 13;
            // 
            // receiptIdLabel
            // 
            this.receiptIdLabel.AutoSize = true;
            this.receiptIdLabel.Location = new System.Drawing.Point(19, 37);
            this.receiptIdLabel.Name = "receiptIdLabel";
            this.receiptIdLabel.Size = new System.Drawing.Size(69, 25);
            this.receiptIdLabel.TabIndex = 11;
            this.receiptIdLabel.Text = "Код: 1";
            // 
            // buttonDeleteReceipt
            // 
            this.buttonDeleteReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteReceipt.Location = new System.Drawing.Point(303, 294);
            this.buttonDeleteReceipt.Name = "buttonDeleteReceipt";
            this.buttonDeleteReceipt.Size = new System.Drawing.Size(249, 41);
            this.buttonDeleteReceipt.TabIndex = 10;
            this.buttonDeleteReceipt.Text = "Удалить запись";
            this.buttonDeleteReceipt.UseVisualStyleBackColor = true;
            this.buttonDeleteReceipt.Click += new System.EventHandler(this.buttonDeleteReceipt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во товара";
            // 
            // numericUpDownCountGoods
            // 
            this.numericUpDownCountGoods.Location = new System.Drawing.Point(24, 248);
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
            // buttonEditReceipt
            // 
            this.buttonEditReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditReceipt.Location = new System.Drawing.Point(12, 294);
            this.buttonEditReceipt.Name = "buttonEditReceipt";
            this.buttonEditReceipt.Size = new System.Drawing.Size(249, 41);
            this.buttonEditReceipt.TabIndex = 0;
            this.buttonEditReceipt.Text = "Изменить запись";
            this.buttonEditReceipt.UseVisualStyleBackColor = true;
            this.buttonEditReceipt.Click += new System.EventHandler(this.buttonEditReceipt_Click);
            // 
            // EditingFormReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 363);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditingFormReceipts";
            this.Text = "Редактирование поступления";
            this.Load += new System.EventHandler(this.EditingFormReceipts_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.groupBoxModel.ResumeLayout(false);
            this.groupBoxModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownCountGoods;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label receiptIdLabel;
        private System.Windows.Forms.MonthCalendar monthCalendarDateReceipt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label modelIdLabel;
        private System.Windows.Forms.CheckBox showAdditionalInformationCheckBox;
        private System.Windows.Forms.Label employeeIdLabel;
        private System.Windows.Forms.Label labelEmployeeJobTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEmployeeNames;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelModelCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxModelNames;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.GroupBox groupBox;
        public System.Windows.Forms.Button buttonEditReceipt;
        public System.Windows.Forms.Button buttonDeleteReceipt;
        public System.Windows.Forms.GroupBox groupBoxEmployee;
        public System.Windows.Forms.GroupBox groupBoxModel;
    }
}