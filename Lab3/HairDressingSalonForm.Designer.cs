using System.ComponentModel;

namespace lab3
{
    partial class HairDressingSalonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.salonNumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.servicePriceTextBox = new System.Windows.Forms.TextBox();
            this.haircutsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salonNumberBox
            // 
            this.salonNumberBox.Location = new System.Drawing.Point(138, 9);
            this.salonNumberBox.Name = "salonNumberBox";
            this.salonNumberBox.Size = new System.Drawing.Size(244, 22);
            this.salonNumberBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер перукарні";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поточна дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вартість додаткових послуг";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // servicePriceTextBox
            // 
            this.servicePriceTextBox.Location = new System.Drawing.Point(208, 88);
            this.servicePriceTextBox.Name = "servicePriceTextBox";
            this.servicePriceTextBox.Size = new System.Drawing.Size(174, 22);
            this.servicePriceTextBox.TabIndex = 2;
            // 
            // haircutsListBox
            // 
            this.haircutsListBox.FormattingEnabled = true;
            this.haircutsListBox.HorizontalScrollbar = true;
            this.haircutsListBox.ItemHeight = 16;
            this.haircutsListBox.Location = new System.Drawing.Point(15, 178);
            this.haircutsListBox.Name = "haircutsListBox";
            this.haircutsListBox.ScrollAlwaysVisible = true;
            this.haircutsListBox.Size = new System.Drawing.Size(669, 212);
            this.haircutsListBox.TabIndex = 6;
            this.haircutsListBox.SelectedIndexChanged += new System.EventHandler(this.hairdressersListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Виконані зачіски";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(237, 133);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(145, 38);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Додати";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(388, 132);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(145, 39);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Редагувати";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(365, 396);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(148, 42);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "Зберегти і закрити";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(519, 396);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(165, 42);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Скасувати і закрити";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // HairDressingSalonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.haircutsListBox);
            this.Controls.Add(this.servicePriceTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salonNumberBox);
            this.Name = "HairDressingSalonForm";
            this.Text = "Створення/оновлення перукарні";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HairDressingSalonForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ListBox haircutsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox salonNumberBox;
        private System.Windows.Forms.TextBox servicePriceTextBox;

        #endregion
    }
}