namespace Fr_Consultoria
{
    partial class frmADM
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
            this.fr_consultoriDataSet = new Fr_Consultoria.fr_consultoriDataSet();
            this.frconsultoriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frconsultoriDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fr_consultoriDataSet1 = new Fr_Consultoria.fr_consultoriDataSet1();
            this.tbprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbprodutoTableAdapter = new Fr_Consultoria.fr_consultoriDataSet1TableAdapters.tbprodutoTableAdapter();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fr_consultoriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frconsultoriDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frconsultoriDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fr_consultoriDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fr_consultoriDataSet
            // 
            this.fr_consultoriDataSet.DataSetName = "fr_consultoriDataSet";
            this.fr_consultoriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frconsultoriDataSetBindingSource
            // 
            this.frconsultoriDataSetBindingSource.DataSource = this.fr_consultoriDataSet;
            this.frconsultoriDataSetBindingSource.Position = 0;
            // 
            // frconsultoriDataSetBindingSource1
            // 
            this.frconsultoriDataSetBindingSource1.DataSource = this.fr_consultoriDataSet;
            this.frconsultoriDataSetBindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nmProdutoDataGridViewTextBoxColumn,
            this.idCategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbprodutoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // fr_consultoriDataSet1
            // 
            this.fr_consultoriDataSet1.DataSetName = "fr_consultoriDataSet1";
            this.fr_consultoriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbprodutoBindingSource
            // 
            this.tbprodutoBindingSource.DataMember = "tbproduto";
            this.tbprodutoBindingSource.DataSource = this.fr_consultoriDataSet1;
            // 
            // tbprodutoTableAdapter
            // 
            this.tbprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            // 
            // nmProdutoDataGridViewTextBoxColumn
            // 
            this.nmProdutoDataGridViewTextBoxColumn.DataPropertyName = "nmProduto";
            this.nmProdutoDataGridViewTextBoxColumn.HeaderText = "nmProduto";
            this.nmProdutoDataGridViewTextBoxColumn.Name = "nmProdutoDataGridViewTextBoxColumn";
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            // 
            // frmADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 294);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmADM";
            this.Load += new System.EventHandler(this.frmADM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fr_consultoriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frconsultoriDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frconsultoriDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fr_consultoriDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource frconsultoriDataSetBindingSource;
        private fr_consultoriDataSet fr_consultoriDataSet;
        private System.Windows.Forms.BindingSource frconsultoriDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private fr_consultoriDataSet1 fr_consultoriDataSet1;
        private System.Windows.Forms.BindingSource tbprodutoBindingSource;
        private fr_consultoriDataSet1TableAdapters.tbprodutoTableAdapter tbprodutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
    }
}