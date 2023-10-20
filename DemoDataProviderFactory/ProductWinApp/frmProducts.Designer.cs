namespace ProductWinApp
{
    partial class frmProducts
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
            btnViewProducts = new Button();
            btnViewCategories = new Button();
            dgvData = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnViewProducts
            // 
            btnViewProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewProducts.Location = new Point(178, 55);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(163, 29);
            btnViewProducts.TabIndex = 0;
            btnViewProducts.Text = "View Products";
            btnViewProducts.UseVisualStyleBackColor = true;
            btnViewProducts.Click += btnViewProducts_Click;
            // 
            // btnViewCategories
            // 
            btnViewCategories.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewCategories.Location = new Point(479, 55);
            btnViewCategories.Name = "btnViewCategories";
            btnViewCategories.Size = new Size(163, 29);
            btnViewCategories.TabIndex = 1;
            btnViewCategories.Text = "View Categories";
            btnViewCategories.UseVisualStyleBackColor = true;
            btnViewCategories.Click += btnViewCategories_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(78, 112);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.Size = new Size(654, 242);
            dgvData.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(368, 373);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(dgvData);
            Controls.Add(btnViewCategories);
            Controls.Add(btnViewProducts);
            Name = "frmProducts";
            Text = "frmProducts";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewProducts;
        private Button btnViewCategories;
        private DataGridView dgvData;
        private Button btnClose;
    }
}