
namespace lab3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.salonsListBox = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salonsListBox
            // 
            this.salonsListBox.FormattingEnabled = true;
            this.salonsListBox.HorizontalScrollbar = true;
            this.salonsListBox.ItemHeight = 16;
            this.salonsListBox.Location = new System.Drawing.Point(12, 12);
            this.salonsListBox.Name = "salonsListBox";
            this.salonsListBox.ScrollAlwaysVisible = true;
            this.salonsListBox.Size = new System.Drawing.Size(776, 372);
            this.salonsListBox.TabIndex = 0;
            this.salonsListBox.SelectedIndexChanged += new System.EventHandler(this.salonsListBox_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 392);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(261, 46);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Додати";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(279, 392);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(261, 46);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Редагувати";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.salonsListBox);
            this.Name = "MainForm";
            this.Text = "Перелік перукарень";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ListBox salonsListBox;

        #endregion
    }
}

