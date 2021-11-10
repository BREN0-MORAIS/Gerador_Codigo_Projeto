using System;
using System.Windows.Forms;

namespace App.View
{
    public static class CheckFields
    {
        public static bool CheckTextBox(string texto, string campo)
        {
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show($@"Atenção, O Campo [ {campo} ] é obrigatório.", "Verificação de Campo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool CheckTextBox(int texto, string campo)
        {
            try
            {
                if (texto == 0)
                {
                    MessageBox.Show($@"Atenção, O Campo [ {campo} ] é obrigatório.", "Verificação de Campo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show($@"Atenção, O Campo [ {campo} ] é obrigatório.", "Verificação de Campo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


        }

        public static bool CheckTextBox(double texto, string campo)
        {
            try
            {
                if (texto == 0)
                {
                    MessageBox.Show($@"Atenção, O Campo [ {campo} ] é obrigatório.", "Verificação de Campo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show($@"Atenção, O Campo [ {campo} ] é obrigatório.", "Verificação de Campo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        public static bool CheckTextBox(string texto, string campo, string texto2, string campo2)
        {
            try
            {
                if (Convert.ToDouble(texto) > Convert.ToDouble(texto2))
                {
                    MessageBox.Show($@"Atenção, O Campo [ {campo} ] não pode ser maior que o [ {campo2} ].", "Verificação de Campo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show($@"Atenção, O Campo [ {campo} ] não pode ser maior que o [ {campo2} ].", "Verificação de Campo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
        public static bool CheckDataGrid(int texto)
        {
            try
            {
                if (texto == 0)
                {
                    MessageBox.Show($@"Atenção, selecione um registro ou carregue as informações.", "Verificação de dado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show($@"Atenção, selecione um registro ou carregue as informações.", "Verificação de dado",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
