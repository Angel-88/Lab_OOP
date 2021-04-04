namespace Delegates2
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
			this.ButtonTransparency = new System.Windows.Forms.Button();
			this.ButtonBackGround = new System.Windows.Forms.Button();
			this.ButtonHelloWorld = new System.Windows.Forms.Button();
			this.ButtonSetOfActions = new System.Windows.Forms.Button();
			this.CheckBoxTransparency = new System.Windows.Forms.CheckBox();
			this.CheckBoxBackgroundColor = new System.Windows.Forms.CheckBox();
			this.CheckBoxHelloWorld = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnTransparency
			// 
			this.ButtonTransparency.Location = new System.Drawing.Point(18, 12);
			this.ButtonTransparency.Name = "btnTransparency";
			this.ButtonTransparency.Size = new System.Drawing.Size(79, 26);
			this.ButtonTransparency.TabIndex = 0;
			this.ButtonTransparency.Text = "Прозорість";
			this.ButtonTransparency.UseVisualStyleBackColor = true;
			this.ButtonTransparency.Click += new System.EventHandler(this.ButtonTransparency_Click);
			// 
			// btnBackgroundColor
			// 
			this.ButtonBackGround.Location = new System.Drawing.Point(151, 12);
			this.ButtonBackGround.Name = "btnBackgroundColor";
			this.ButtonBackGround.Size = new System.Drawing.Size(75, 25);
			this.ButtonBackGround.TabIndex = 1;
			this.ButtonBackGround.Text = "Колір тла";
			this.ButtonBackGround.UseVisualStyleBackColor = true;
			this.ButtonBackGround.Click += new System.EventHandler(this.ButtonBackGround_Click);
			// 
			// btnHelloWorld
			// 
			this.ButtonHelloWorld.Location = new System.Drawing.Point(280, 12);
			this.ButtonHelloWorld.Name = "btnHelloWorld";
			this.ButtonHelloWorld.Size = new System.Drawing.Size(77, 25);
			this.ButtonHelloWorld.TabIndex = 2;
			this.ButtonHelloWorld.Text = "Hello World";
			this.ButtonHelloWorld.UseVisualStyleBackColor = true;
			this.ButtonHelloWorld.Click += new System.EventHandler(this.ButtonHelloWorld_Click);
			// 
			// btnSetOfActions
			// 
			this.ButtonSetOfActions.Location = new System.Drawing.Point(67, 54);
			this.ButtonSetOfActions.Name = "btnSetOfActions";
			this.ButtonSetOfActions.Size = new System.Drawing.Size(242, 23);
			this.ButtonSetOfActions.TabIndex = 3;
			this.ButtonSetOfActions.Text = "Супермегакнопка";
			this.ButtonSetOfActions.UseVisualStyleBackColor = true;
			this.ButtonSetOfActions.Click += new System.EventHandler(this.ButtonSetOfActions_Click);
			// 
			// checkBoxTransparency
			// 
			this.CheckBoxTransparency.Location = new System.Drawing.Point(67, 92);
			this.CheckBoxTransparency.Name = "checkBoxTransparency";
			this.CheckBoxTransparency.Size = new System.Drawing.Size(241, 21);
			this.CheckBoxTransparency.TabIndex = 4;
			this.CheckBoxTransparency.Text = "Супермегакнопка поглинає Прозорість";
			this.CheckBoxTransparency.UseVisualStyleBackColor = true;
			this.CheckBoxTransparency.Click += new System.EventHandler(this.CheckBoxTransparency_Click);
			// 
			// checkBoxBackgroundColor
			// 
			this.CheckBoxBackgroundColor.Location = new System.Drawing.Point(68, 119);
			this.CheckBoxBackgroundColor.Name = "checkBoxBackgroundColor";
			this.CheckBoxBackgroundColor.Size = new System.Drawing.Size(241, 21);
			this.CheckBoxBackgroundColor.TabIndex = 5;
			this.CheckBoxBackgroundColor.Text = "Супермегакнопка поглинає Колір тла";
			this.CheckBoxBackgroundColor.UseVisualStyleBackColor = true;
			this.CheckBoxBackgroundColor.Click += new System.EventHandler(this.CheckBoxBackgroundColor_Click);
			// 
			// checkBoxHelloWorld
			// 
			this.CheckBoxHelloWorld.Location = new System.Drawing.Point(67, 146);
			this.CheckBoxHelloWorld.Name = "checkBoxHelloWorld";
			this.CheckBoxHelloWorld.Size = new System.Drawing.Size(241, 21);
			this.CheckBoxHelloWorld.TabIndex = 6;
			this.CheckBoxHelloWorld.Text = "Супермегакнопка поглинає Hello World";
			this.CheckBoxHelloWorld.UseVisualStyleBackColor = true;
			this.CheckBoxHelloWorld.Click += new System.EventHandler(this.CheckBoxHelloWorld_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(369, 287);
			this.Controls.Add(this.CheckBoxHelloWorld);
			this.Controls.Add(this.CheckBoxBackgroundColor);
			this.Controls.Add(this.CheckBoxTransparency);
			this.Controls.Add(this.ButtonSetOfActions);
			this.Controls.Add(this.ButtonHelloWorld);
			this.Controls.Add(this.ButtonBackGround);
			this.Controls.Add(this.ButtonTransparency);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button ButtonBackGround;
        private System.Windows.Forms.Button ButtonHelloWorld;
        private System.Windows.Forms.Button ButtonSetOfActions;
        private System.Windows.Forms.Button ButtonTransparency;
        private System.Windows.Forms.CheckBox CheckBoxBackgroundColor;
        private System.Windows.Forms.CheckBox CheckBoxHelloWorld;
        private System.Windows.Forms.CheckBox CheckBoxTransparency;

        #endregion
    }
}