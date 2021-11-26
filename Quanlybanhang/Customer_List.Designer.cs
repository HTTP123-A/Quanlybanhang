
namespace Quanlybanhang
{
    partial class Customer_List
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
            this.components = new System.ComponentModel.Container();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.qlkh_dbDataSet = new Quanlybanhang.qlkh_dbDataSet();
            this.qlkhdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlkh_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlkhdbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 36);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(540, 134);
            this.dgvList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Customer:";
            // 
            // Return
            // 
            this.Return.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Return.Location = new System.Drawing.Point(0, 170);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(564, 53);
            this.Return.TabIndex = 2;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // qlkh_dbDataSet
            // 
            this.qlkh_dbDataSet.DataSetName = "qlkh_dbDataSet";
            this.qlkh_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlkhdbDataSetBindingSource
            // 
            this.qlkhdbDataSetBindingSource.DataSource = this.qlkh_dbDataSet;
            this.qlkhdbDataSetBindingSource.Position = 0;
            // 
            // Customer_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 223);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvList);
            this.Name = "Customer_List";
            this.Text = "Customer List";
            this.Load += new System.EventHandler(this.Customer_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlkh_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlkhdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.BindingSource qlkhdbDataSetBindingSource;
        private qlkh_dbDataSet qlkh_dbDataSet;
    }
}