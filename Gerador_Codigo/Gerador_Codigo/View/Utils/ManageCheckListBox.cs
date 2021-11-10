using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
	public static class ManageCheckListBox
    {

        #region Método responsável por [RETORNAR UM ARRAY COM OS ITENS SELECIONADOS DO CHECKEDLISTBOX]
        public static ArrayList LoadDataChecklistbox(CheckedListBox checkedList)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i <= checkedList.Items.Count - 1; i++)
            {
                if (checkedList.GetItemChecked(i))
                {
                    arrayList.Add(checkedList.Items[i].ToString());
                }
            }
            return arrayList;
        }

		public static List<string> LoadDataChecklistboxAll(CheckedListBox checkedList)
		{
			List<string> list = new List<string>();

            foreach (var item in checkedList.Items)
            {
				list.Add(item.ToString());
            }
			return list;
		}

		public static List<string> GetListStringLoadDataChecklistbox(CheckedListBox checkedList)
		{
			List<string> listString = new List<string>();
			for (int i = 0; i <= checkedList.Items.Count - 1; i++)
			{
				if (checkedList.GetItemChecked(i))
				{
					listString.Add(checkedList.Items[i].ToString());
				}
			}
			return listString;
		}
		#endregion

		/// <summary>
		/// Método para ativar ou desativar a opção do CheckedListBox
		/// </summary>
		/// <param name="CheckList">Informe o CheckedListBox para selecionar ou deselecionar as opções</param>
		/// <param name="Valor">(True) Seleciona e (False) Deseleciona</param>
		#region Método para ativar ou desativar checklist
		public static void SelectCheckListBox(CheckedListBox CheckList, bool Valor)
		{
			try
			{
				for (int i = 0; i <= CheckList.Items.Count - 1; i++)
				{
					// Se for true seleciona todos os objetos
					if (Valor == true)
						CheckList.SetItemChecked(i, true);
					else
						// Se for false tira seleção de todos dos objetos
						CheckList.SetItemChecked(i, false);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion

		#region Método responsável por [CARREGAR O NOME DOS PROPRIETÁRIOS PESQUISA]
		public static void SearchTextCheckedListBox(CheckedListBox clbPesquisa, string texto)
		{
			int index = clbPesquisa.FindString(texto.ToUpper());

			if (index < 0) return;
			clbPesquisa.SetSelected(index, true);
		}
		#endregion
	}
}
