namespace Task_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(123, 12);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(232, 60);
            this.buttonInit.TabIndex = 0;
            this.buttonInit.Text = " Отобразить первоначальный список";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(123, 323);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(232, 60);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Удалить выбранный элемент";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(123, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 204);
            this.listBox1.TabIndex = 2;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(12, 117);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(94, 110);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "Выбрать несколько элементов";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSelect;
    }
}
