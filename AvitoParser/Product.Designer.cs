namespace AvitoParser
{
    partial class Product
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Gray;
            this.panel.Controls.Add(this.labelPrice);
            this.panel.Controls.Add(this.labelTitle);
            this.panel.Controls.Add(this.buttonOpen);
            this.panel.Controls.Add(this.buttonOK);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(652, 94);
            this.panel.TabIndex = 6;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Silver;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(618, 8);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(28, 30);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "X";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(4, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(41, 20);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Title";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(4, 51);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 20);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price";
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.Silver;
            this.buttonOpen.BackgroundImage = global::AvitoParser.Properties.Resources.expandIcon;
            this.buttonOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOpen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonOpen.Location = new System.Drawing.Point(607, 44);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(39, 37);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(652, 94);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPrice;
    }
}
