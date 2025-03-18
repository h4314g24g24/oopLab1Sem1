namespace oopLab1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstTransport = new System.Windows.Forms.ListBox();
            this.btnSave_Click = new System.Windows.Forms.Button();
            this.btnLoad_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(21, 30);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(40, 13);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Марка";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(24, 60);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 1;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(21, 105);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(59, 13);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Швидкість";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(24, 136);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 3;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(21, 192);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(68, 13);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "Вмістимість";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(24, 237);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtCapacity.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(21, 283);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(26, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Тип";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Car",
            "Bus ",
            "Bicycle"});
            this.cmbType.Location = new System.Drawing.Point(17, 322);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 7;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(35, 390);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(0, 13);
            this.lblExtra.TabIndex = 8;
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(17, 383);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(100, 20);
            this.txtExtra.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(242, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Додати транспорт";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(242, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Очистити список";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstTransport
            // 
            this.lstTransport.FormattingEnabled = true;
            this.lstTransport.Location = new System.Drawing.Point(242, 150);
            this.lstTransport.Name = "lstTransport";
            this.lstTransport.Size = new System.Drawing.Size(515, 225);
            this.lstTransport.TabIndex = 12;
            this.lstTransport.SelectedIndexChanged += new System.EventHandler(this.lstTransport_SelectedIndexChanged);
            // 
            // btnSave_Click
            // 
            this.btnSave_Click.Location = new System.Drawing.Point(599, 30);
            this.btnSave_Click.Name = "btnSave_Click";
            this.btnSave_Click.Size = new System.Drawing.Size(75, 23);
            this.btnSave_Click.TabIndex = 13;
            this.btnSave_Click.Text = "Save data";
            this.btnSave_Click.UseVisualStyleBackColor = true;
            this.btnSave_Click.Click += new System.EventHandler(this.btnSave_Click_Click);
            // 
            // btnLoad_Click
            // 
            this.btnLoad_Click.Location = new System.Drawing.Point(599, 95);
            this.btnLoad_Click.Name = "btnLoad_Click";
            this.btnLoad_Click.Size = new System.Drawing.Size(75, 23);
            this.btnLoad_Click.TabIndex = 14;
            this.btnLoad_Click.Text = "Load data";
            this.btnLoad_Click.UseVisualStyleBackColor = true;
            this.btnLoad_Click.Click += new System.EventHandler(this.btnLoad_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(769, 504);
            this.Controls.Add(this.btnLoad_Click);
            this.Controls.Add(this.btnSave_Click);
            this.Controls.Add(this.lstTransport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Name = "Form1";
            this.Text = " Factory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstTransport;
        private System.Windows.Forms.Button btnSave_Click;
        private System.Windows.Forms.Button btnLoad_Click;
    }
}

