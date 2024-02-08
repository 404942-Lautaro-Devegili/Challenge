namespace Frontend
{
    partial class frmCompras
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvHistCompras = new System.Windows.Forms.DataGridView();
            this.btnOrdenarPorFecha = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnOrdenarPorId = new System.Windows.Forms.Button();
            this.btnOrdenarPorCosto = new System.Windows.Forms.Button();
            this.btnOrdenarPorItems = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaOculta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvHistCompras
            // 
            this.dgvHistCompras.AllowUserToAddRows = false;
            this.dgvHistCompras.AllowUserToDeleteRows = false;
            this.dgvHistCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CantItems,
            this.CostoTotal,
            this.Fecha,
            this.FechaOculta});
            this.dgvHistCompras.Location = new System.Drawing.Point(12, 12);
            this.dgvHistCompras.Name = "dgvHistCompras";
            this.dgvHistCompras.ReadOnly = true;
            this.dgvHistCompras.Size = new System.Drawing.Size(776, 387);
            this.dgvHistCompras.TabIndex = 3;
            // 
            // btnOrdenarPorFecha
            // 
            this.btnOrdenarPorFecha.Location = new System.Drawing.Point(669, 405);
            this.btnOrdenarPorFecha.Name = "btnOrdenarPorFecha";
            this.btnOrdenarPorFecha.Size = new System.Drawing.Size(119, 40);
            this.btnOrdenarPorFecha.TabIndex = 4;
            this.btnOrdenarPorFecha.Text = "Ordenar por Fecha";
            this.btnOrdenarPorFecha.UseVisualStyleBackColor = true;
            this.btnOrdenarPorFecha.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(12, 405);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(119, 40);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar Mayores 1000";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnOrdenarPorId
            // 
            this.btnOrdenarPorId.Location = new System.Drawing.Point(176, 405);
            this.btnOrdenarPorId.Name = "btnOrdenarPorId";
            this.btnOrdenarPorId.Size = new System.Drawing.Size(119, 40);
            this.btnOrdenarPorId.TabIndex = 6;
            this.btnOrdenarPorId.Text = "Ordenar por ID";
            this.btnOrdenarPorId.UseVisualStyleBackColor = true;
            this.btnOrdenarPorId.Click += new System.EventHandler(this.btnOrdenarPorId_Click);
            // 
            // btnOrdenarPorCosto
            // 
            this.btnOrdenarPorCosto.Location = new System.Drawing.Point(496, 405);
            this.btnOrdenarPorCosto.Name = "btnOrdenarPorCosto";
            this.btnOrdenarPorCosto.Size = new System.Drawing.Size(119, 40);
            this.btnOrdenarPorCosto.TabIndex = 7;
            this.btnOrdenarPorCosto.Text = "Ordenar por Costo";
            this.btnOrdenarPorCosto.UseVisualStyleBackColor = true;
            this.btnOrdenarPorCosto.Click += new System.EventHandler(this.btnOrdenarPorCosto_Click);
            // 
            // btnOrdenarPorItems
            // 
            this.btnOrdenarPorItems.Location = new System.Drawing.Point(338, 405);
            this.btnOrdenarPorItems.Name = "btnOrdenarPorItems";
            this.btnOrdenarPorItems.Size = new System.Drawing.Size(119, 40);
            this.btnOrdenarPorItems.TabIndex = 8;
            this.btnOrdenarPorItems.Text = "Ordenar por Cantidad de Items";
            this.btnOrdenarPorItems.UseVisualStyleBackColor = true;
            this.btnOrdenarPorItems.Click += new System.EventHandler(this.btnOrdenarPorItems_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 56;
            // 
            // CantItems
            // 
            this.CantItems.HeaderText = "CantItems";
            this.CantItems.Name = "CantItems";
            this.CantItems.ReadOnly = true;
            this.CantItems.Width = 226;
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "CostoTotal";
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.ReadOnly = true;
            this.CostoTotal.Width = 225;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 195;
            // 
            // FechaOculta
            // 
            this.FechaOculta.HeaderText = "FechaOculta";
            this.FechaOculta.Name = "FechaOculta";
            this.FechaOculta.ReadOnly = true;
            this.FechaOculta.Visible = false;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrdenarPorItems);
            this.Controls.Add(this.btnOrdenarPorCosto);
            this.Controls.Add(this.btnOrdenarPorId);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnOrdenarPorFecha);
            this.Controls.Add(this.dgvHistCompras);
            this.Name = "frmCompras";
            this.Text = "Histórico de Compras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvHistCompras;
        private System.Windows.Forms.Button btnOrdenarPorFecha;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnOrdenarPorId;
        private System.Windows.Forms.Button btnOrdenarPorCosto;
        private System.Windows.Forms.Button btnOrdenarPorItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaOculta;
    }
}

