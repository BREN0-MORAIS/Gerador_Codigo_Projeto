﻿
namespace Gerador_Codigo
{
    partial class FormEscolherBanco
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDatabase = new System.Windows.Forms.Button();
            this.clbDatabase = new System.Windows.Forms.CheckedListBox();
            this.clbTable = new System.Windows.Forms.CheckedListBox();
            this.btnTable = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            this.dgvResultado = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnCarregarColunas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatabase
            // 
            this.btnDatabase.Location = new System.Drawing.Point(12, 12);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(232, 23);
            this.btnDatabase.TabIndex = 0;
            this.btnDatabase.Text = "Carregar Banco de Dados";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // clbDatabase
            // 
            this.clbDatabase.FormattingEnabled = true;
            this.clbDatabase.Location = new System.Drawing.Point(12, 41);
            this.clbDatabase.Name = "clbDatabase";
            this.clbDatabase.Size = new System.Drawing.Size(232, 562);
            this.clbDatabase.TabIndex = 1;
            // 
            // clbTable
            // 
            this.clbTable.FormattingEnabled = true;
            this.clbTable.Location = new System.Drawing.Point(260, 41);
            this.clbTable.Name = "clbTable";
            this.clbTable.Size = new System.Drawing.Size(232, 562);
            this.clbTable.TabIndex = 3;
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(260, 12);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(232, 23);
            this.btnTable.TabIndex = 2;
            this.btnTable.Text = "Carregar Tabelas";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateBatchSize = 0;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AccessibleName = "Table";
            this.dgvResultado.AllowEditing = false;
            this.dgvResultado.AllowFiltering = true;
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dgvResultado.Location = new System.Drawing.Point(499, 41);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dgvResultado.SerializationController = null;
            this.dgvResultado.ShowHeaderToolTip = true;
            this.dgvResultado.ShowRowHeader = true;
            this.dgvResultado.ShowSortNumbers = true;
            this.dgvResultado.ShowToolTip = true;
            this.dgvResultado.Size = new System.Drawing.Size(895, 562);
            this.dgvResultado.TabIndex = 11;
            // 
            // btnCarregarColunas
            // 
            this.btnCarregarColunas.Location = new System.Drawing.Point(499, 12);
            this.btnCarregarColunas.Name = "btnCarregarColunas";
            this.btnCarregarColunas.Size = new System.Drawing.Size(895, 23);
            this.btnCarregarColunas.TabIndex = 12;
            this.btnCarregarColunas.Text = "Carregar Tabelas";
            this.btnCarregarColunas.UseVisualStyleBackColor = true;
            this.btnCarregarColunas.Click += new System.EventHandler(this.btnCarregarColunas_Click);
            // 
            // FormEscolherBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 616);
            this.Controls.Add(this.btnCarregarColunas);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.clbTable);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.clbDatabase);
            this.Controls.Add(this.btnDatabase);
            this.Name = "FormEscolherBanco";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEscolherBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.CheckedListBox clbDatabase;
        private System.Windows.Forms.CheckedListBox clbTable;
        private System.Windows.Forms.Button btnTable;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvResultado;
        private System.Windows.Forms.Button btnCarregarColunas;
    }
}

