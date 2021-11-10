namespace View
{
    partial class FrmConexao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConexao));
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.groupBar2 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtDatasource = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new Syncfusion.WinForms.Controls.SfButton();
            this.btnConectar = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSalvar = new Syncfusion.WinForms.Controls.SfButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar2)).BeginInit();
            this.groupBar2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(328, 193);
            this.groupBar1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.groupBar1.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.CollapseImage")));
            this.groupBar1.Controls.Add(this.autoLabel1);
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBar1.ExpandButtonToolTip = null;
            this.groupBar1.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar1.ExpandImage")));
            this.groupBar1.ForeColor = System.Drawing.Color.Black;
            this.groupBar1.GroupBarDropDownToolTip = null;
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(0, 0);
            this.groupBar1.MinimizeButtonToolTip = null;
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.NavigationPaneTooltip = null;
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.Size = new System.Drawing.Size(328, 65);
            this.groupBar1.SmartSizeBox = false;
            this.groupBar1.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.groupBar1.TabIndex = 0;
            this.groupBar1.ThemesEnabled = true;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(37, 19);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(245, 29);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Configurar Conexão";
            // 
            // groupBar2
            // 
            this.groupBar2.AllowDrop = true;
            this.groupBar2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBar2.BeforeTouchSize = new System.Drawing.Size(328, 193);
            this.groupBar2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.groupBar2.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupBar2.CollapseImage")));
            this.groupBar2.Controls.Add(this.txtDatabase);
            this.groupBar2.Controls.Add(this.txtDatasource);
            this.groupBar2.Controls.Add(this.label4);
            this.groupBar2.Controls.Add(this.label3);
            this.groupBar2.Controls.Add(this.label2);
            this.groupBar2.Controls.Add(this.label1);
            this.groupBar2.Controls.Add(this.btnSair);
            this.groupBar2.Controls.Add(this.btnConectar);
            this.groupBar2.Controls.Add(this.btnSalvar);
            this.groupBar2.Controls.Add(this.txtPassword);
            this.groupBar2.Controls.Add(this.txtUser);
            this.groupBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar2.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupBar2.ExpandImage")));
            this.groupBar2.ForeColor = System.Drawing.Color.Black;
            this.groupBar2.IndexOnVisibleItems = true;
            this.groupBar2.Location = new System.Drawing.Point(0, 65);
            this.groupBar2.Name = "groupBar2";
            this.groupBar2.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar2.Size = new System.Drawing.Size(328, 193);
            this.groupBar2.SmartSizeBox = false;
            this.groupBar2.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.groupBar2.TabIndex = 1;
            this.groupBar2.ThemesEnabled = true;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(82, 39);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(231, 20);
            this.txtDatabase.TabIndex = 1;
            // 
            // txtDatasource
            // 
            this.txtDatasource.Location = new System.Drawing.Point(82, 6);
            this.txtDatasource.Name = "txtDatasource";
            this.txtDatasource.Size = new System.Drawing.Size(231, 20);
            this.txtDatasource.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Banco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Servidor";
            // 
            // btnSair
            // 
            this.btnSair.AccessibleName = "Button";
            this.btnSair.BackColor = System.Drawing.Color.Gray;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.ImageSize = new System.Drawing.Size(32, 32);
            this.btnSair.Location = new System.Drawing.Point(218, 124);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 61);
            this.btnSair.Style.BackColor = System.Drawing.Color.Gray;
            this.btnSair.Style.ForeColor = System.Drawing.Color.White;
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.AccessibleName = "Button";
            this.btnConectar.BackColor = System.Drawing.Color.Gray;
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConectar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnConectar.Location = new System.Drawing.Point(113, 124);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(99, 61);
            this.btnConectar.Style.BackColor = System.Drawing.Color.Gray;
            this.btnConectar.Style.ForeColor = System.Drawing.Color.White;
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleName = "Button";
            this.btnSalvar.BackColor = System.Drawing.Color.Gray;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnSalvar.Location = new System.Drawing.Point(8, 124);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 61);
            this.btnSalvar.Style.BackColor = System.Drawing.Color.Gray;
            this.btnSalvar.Style.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(82, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '#';
            this.txtPassword.Size = new System.Drawing.Size(231, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(82, 64);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(231, 20);
            this.txtUser.TabIndex = 2;
            // 
            // FrmConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 258);
            this.Controls.Add(this.groupBar2);
            this.Controls.Add(this.groupBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Conexão";
            this.Load += new System.EventHandler(this.FrmConexao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            this.groupBar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar2)).EndInit();
            this.groupBar2.ResumeLayout(false);
            this.groupBar2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Controls.SfButton btnSair;
        private Syncfusion.WinForms.Controls.SfButton btnConectar;
        private Syncfusion.WinForms.Controls.SfButton btnSalvar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDatasource;
        private System.Windows.Forms.TextBox txtDatabase;
    }
}