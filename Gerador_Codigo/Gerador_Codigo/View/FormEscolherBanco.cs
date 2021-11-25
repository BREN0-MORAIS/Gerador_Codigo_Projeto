using Gerador_Codigo.Controller;
using Gerador_Codigo.Data.Services;
using System;
using System.Windows.Forms;
using View;

namespace Gerador_Codigo
{
    public partial class FormEscolherBanco : Form
    {
        private readonly DatabaseController _controllerDatabase;
        private readonly TableController _controllerTable;
        private readonly IRepositoryDapper _dapper;
        private string _database;
        public FormEscolherBanco()
        {
            InitializeComponent();
            _dapper = new RepositorySqlServerDapper();
            _controllerDatabase = new DatabaseController(_dapper);
            _controllerTable = new TableController(_dapper);
        }

        private void FormEscolherBanco_Load(object sender, EventArgs e)
        {

        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            clbDatabase.DataSource = null;
            var query = _controllerDatabase.ObterTodosNome();
            if (query == null) return;

            clbDatabase.DataSource = query;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            CarregarTabelasBancoDeDados();
        }

        private void CarregarTabelasBancoDeDados()
        {
            clbTable.DataSource = null;
            var query = _controllerTable.ObterTodosNomeTabela(_database);
            if (query == null) return;

            clbTable.DataSource = query;
        }

        private void btnCarregarColunas_Click(object sender, EventArgs e)
        {
            var listaTabela = ManageCheckListBox.LoadDataChecklistbox(clbTable);
            lsbResultado.Items.Clear();
            foreach (var tabela in listaTabela)
            {
                dgvResultado.DataSource = null;
                var query = _controllerTable.ObterTodosNomeColunasTabela(_database, tabela.ToString());
                if (query == null) return;

                foreach (var coluna in query)
                {
                    var texto =$"Tabela: {tabela} - {coluna.NomeDaColuna} - {coluna.TipoDaColuna} - Tipo: {coluna.TipoDaColuna} - Tipo Mapping: {coluna.TipoDaColunaMappingMaxLength}";
                    lsbResultado.Items.Add(texto);
                }
                dgvResultado.DataSource = query;
                dgvResultado.Columns["Id"].Visible = false;
                dgvResultado.Columns["NomeDaTabela"].Visible = false;
            }
           
        }

        private void clbDatabase_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                for (int i = 0; i < clbDatabase.Items.Count; ++i)
                {
                    if (i != e.Index)
                        clbDatabase.SetItemChecked(i, false);
                    else
                    {
                        _database = clbDatabase.Text;
                        CarregarTabelasBancoDeDados();
                    }
                        
                }

                if (clbDatabase.GetItemCheckState(clbDatabase.SelectedIndex) == CheckState.Checked)
                    clbDatabase.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar componente. \n" + ex.Message, "Aviso");
            }
        }
    }
}
