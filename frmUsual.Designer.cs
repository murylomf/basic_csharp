namespace Fr_Consultoria
{
    partial class frmUsual
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
            this.lstProduto = new System.Windows.Forms.ListView();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInative = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProduto
            // 
            this.lstProduto.HideSelection = false;
            this.lstProduto.Location = new System.Drawing.Point(12, 12);
            this.lstProduto.Name = "lstProduto";
            this.lstProduto.Size = new System.Drawing.Size(281, 295);
            this.lstProduto.TabIndex = 0;
            this.lstProduto.UseCompatibleStateImageBehavior = false;
            this.lstProduto.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(299, 26);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(96, 53);
            this.btnADD.TabIndex = 1;
            this.btnADD.Text = "Adicionar";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(299, 180);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 53);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInative
            // 
            this.btnInative.Location = new System.Drawing.Point(299, 99);
            this.btnInative.Name = "btnInative";
            this.btnInative.Size = new System.Drawing.Size(96, 62);
            this.btnInative.TabIndex = 3;
            this.btnInative.Text = "Inativar";
            this.btnInative.UseVisualStyleBackColor = true;
            this.btnInative.Click += new System.EventHandler(this.btnInative_Click);
            // 
            // frmUsual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 319);
            this.Controls.Add(this.btnInative);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.lstProduto);
            this.Name = "frmUsual";
            this.Text = "frmUsual";
            this.Load += new System.EventHandler(this.frmUsual_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstProduto;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInative;
    }
}