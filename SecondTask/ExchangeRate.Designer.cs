namespace SecondTask
{
    partial class ExchangeRate
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
            this.dataCurrencyTable = new System.Windows.Forms.DataGridView();
            this.LoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCurrencyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCurrencyTable
            // 
            this.dataCurrencyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCurrencyTable.Location = new System.Drawing.Point(76, 54);
            this.dataCurrencyTable.Name = "dataCurrencyTable";
            this.dataCurrencyTable.Size = new System.Drawing.Size(443, 245);
            this.dataCurrencyTable.TabIndex = 0;
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(249, 12);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(75, 23);
            this.LoadData.TabIndex = 1;
            this.LoadData.Text = "Load Data";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // ExchangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 396);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.dataCurrencyTable);
            this.Name = "ExchangeRate";
            this.Text = "Exchange Rate";
            ((System.ComponentModel.ISupportInitialize)(this.dataCurrencyTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataCurrencyTable;
        private System.Windows.Forms.Button LoadData;
    }
}

