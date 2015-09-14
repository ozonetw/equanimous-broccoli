namespace mindnalytics
{
    partial class GrupoRandom
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Archivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRmvAsset = new System.Windows.Forms.Button();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Archivo});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(89, 66);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(431, 253);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Archivo
            // 
            this.Archivo.Text = "Nombre";
            this.Archivo.Width = 220;
            // 
            // btnRmvAsset
            // 
            this.btnRmvAsset.Location = new System.Drawing.Point(19, 167);
            this.btnRmvAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnRmvAsset.Name = "btnRmvAsset";
            this.btnRmvAsset.Size = new System.Drawing.Size(53, 47);
            this.btnRmvAsset.TabIndex = 47;
            this.btnRmvAsset.Text = "-";
            this.btnRmvAsset.UseVisualStyleBackColor = true;
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(19, 112);
            this.btnAddAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(53, 47);
            this.btnAddAsset.TabIndex = 46;
            this.btnAddAsset.Text = "+";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Narrativa:";
            // 
            // GrupoRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRmvAsset);
            this.Controls.Add(this.btnAddAsset);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GrupoRandom";
            this.Size = new System.Drawing.Size(524, 323);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Archivo;
        private System.Windows.Forms.Button btnRmvAsset;
        private System.Windows.Forms.Button btnAddAsset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
