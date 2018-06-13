namespace Task_3
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rhtb_field = new System.Windows.Forms.RichTextBox();
            this.lb_header = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_nameFile = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rhtb_field
            // 
            this.rhtb_field.Location = new System.Drawing.Point(12, 43);
            this.rhtb_field.Name = "rhtb_field";
            this.rhtb_field.Size = new System.Drawing.Size(776, 556);
            this.rhtb_field.TabIndex = 0;
            this.rhtb_field.Text = "";
            // 
            // lb_header
            // 
            this.lb_header.AutoSize = true;
            this.lb_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_header.Location = new System.Drawing.Point(12, 9);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(103, 31);
            this.lb_header.TabIndex = 1;
            this.lb_header.Text = "Header";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(144, 14);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_nameFile
            // 
            this.tb_nameFile.Location = new System.Drawing.Point(225, 16);
            this.tb_nameFile.Name = "tb_nameFile";
            this.tb_nameFile.Size = new System.Drawing.Size(145, 20);
            this.tb_nameFile.TabIndex = 3;
            this.tb_nameFile.Tag = "Имя файла";
            this.tb_nameFile.Text = "Имя файла";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(420, 14);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // tb_location
            // 
            this.tb_location.Location = new System.Drawing.Point(501, 16);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(264, 20);
            this.tb_location.TabIndex = 5;
            this.tb_location.Text = "Расположение файла";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.tb_nameFile);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lb_header);
            this.Controls.Add(this.rhtb_field);
            this.Name = "MainForm";
            this.Text = "TextReadder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_header;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.RichTextBox rhtb_field;
        private System.Windows.Forms.TextBox tb_nameFile;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox tb_location;
    }
}

