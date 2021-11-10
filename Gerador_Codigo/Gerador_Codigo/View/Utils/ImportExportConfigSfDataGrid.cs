using Syncfusion.Pdf;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.WinForms.DataGridConverter.Events;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;
 

namespace View
{
    public abstract class ImportExportConfigSfDataGrid
    {
        #region  Método responsável por [EXPORTAR AS INFORMAÇÕES DO DATAGRID PARA EXCEL]
        public static void ExportExcel(SfDataGrid dgvResultado, string descricao, List<string> list = null)
        {
            var options = new ExcelExportingOptions();
            options.ExcelVersion = ExcelVersion.Excel2013;

            //Excluir as colunas da exportação
            if (list != null)
                options.ExcludeColumns.AddRange(list);  

            var excelEngine = dgvResultado.ExportToExcel(dgvResultado.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];

            SaveFileDialog saveFilterDialog = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 a 2003 Files(*.xls)|*.xls|Excel 2007 a 2010 Files(*.xlsx)|*.xlsx|Excel 2013 a 2019 File(*.xlsx)|*.xlsx",
                FileName = descricao
            };

            if (saveFilterDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream stream = saveFilterDialog.OpenFile())
                {
                    if (saveFilterDialog.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else if (saveFilterDialog.FilterIndex == 2)
                        workBook.Version = ExcelVersion.Excel2010;
                    else
                        workBook.Version = ExcelVersion.Excel2013;
                    workBook.SaveAs(stream);
                }

                //Confirmação da caixa de mensagem para exibir a pasta de trabalho criada.
                if (MessageBox.Show("Deseja abrir o arquivo?", $"Relatório de {descricao}",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Iniciando o arquivo do Excel usando o aplicativo padrão. [MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(saveFilterDialog.FileName);
                }
            }
        }
        #endregion

        #region Método responsável por [EXPORTAR AS INFORMAÇÕES DO DATAGRID PARA PDF]
        public static void ExportPdf(SfDataGrid dgvResultado, string descricao)
        {
            var document = dgvResultado.ExportToPdf();
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files(*.pdf)|*.pdf",
                FileName = descricao                
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = saveFileDialog.OpenFile())
                {
                    document.Save(stream);
                }
                //Confirmação da caixa de mensagem para visualizar o arquivo PDF criado.
                if (MessageBox.Show("Deseja visualizar o arquivo PDF?", $"Relatório de {descricao}", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Iniciando o arquivo PDF usando o aplicativo padrão.
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
        }
        #endregion

        #region Método responsável por [EXPORTAR AS INFORMAÇÕES DO DATAGRID PARA PDF]
        public static void ExportPdfColumns(SfDataGrid dgvResultado, string descricao, List<string> list = null)
        {
            PdfExportingOptions options = new PdfExportingOptions();
            if (list != null)
            {
                //Excluir as colunas da exportação

                options.ExcludeColumns.AddRange(list);
            }
            options.AutoColumnWidth = true;
            options.CellExporting += OnCellExporting;

            var document = dgvResultado.ExportToPdf(options);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files(*.pdf)|*.pdf",
                FileName = descricao
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = saveFileDialog.OpenFile())
                {
                    if (dgvResultado.ColumnCount > 6)
                        document.PageSettings = new PdfPageSettings(PdfPageOrientation.Landscape);

                    document.Save(stream);
                }
                //Confirmação da caixa de mensagem para visualizar o arquivo PDF criado.
                if (MessageBox.Show("Deseja visualizar o arquivo PDF?", $"Relatório de {descricao}", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Iniciando o arquivo PDF usando o aplicativo padrão.
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
        }

        static void OnCellExporting(object sender, DataGridCellPdfExportingEventArgs e)
        {
            // Com base no nome do mapeamento da coluna e no tipo de célula, podemos alterar os valores das células enquanto exportamos para o Excel.
            if (e.CellType == ExportCellType.RecordCell && e.ColumnName == "Id")
            {
                //Se o valor da célula for Ímpar, "Ímpar" será exibido, senão "Par" será exibido
                if (Convert.ToInt16(e.CellValue) % 2 == 0)
                    e.CellValue = "Even";
                else
                    e.CellValue = "Odd";
            }
        }

        #endregion

        #region Método responsável por [EXPORTAR AS INFORMAÇÕES DO DATAGRID PARA CSV]
        public static void ExportCsv(SfDataGrid dgvResultado, string descricao, List<string> list = null)
        {
            var options = new ExcelExportingOptions();
            options.ExcelVersion = ExcelVersion.Excel2013;

            //Excluir as colunas da exportação
            if (list != null)
                options.ExcludeColumns.AddRange(list);

            var excelEngine =    dgvResultado.ExportToExcel(dgvResultado.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];


            SaveFileDialog saveFilterDialog = new SaveFileDialog
            {
                Filter = "CSV (MS-DOS)  Files(*.csv)|*.csv",
                FileName = descricao
            };

            if (saveFilterDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream stream = saveFilterDialog.OpenFile())
                {
                    workBook.SaveAs(stream, ";");
                }

                //Confirmação da caixa de mensagem para exibir a pasta de trabalho criada.
                if (MessageBox.Show("Deseja abrir o arquivo?", $"Arquivo de {descricao}",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    //Abre o Carquivo
                    System.Diagnostics.Process.Start(saveFilterDialog.FileName);
                }
            }
        }
        #endregion

        #region Método responsável por [ENVIAR AS INFORMAÇÕES DO DATAGRID POR EMAIL]
        public static void SendEmail(SfDataGrid dgvResultado, string descricao)
        {
            // Variveis

            string emailRemetente = "suportes@wcogeo.com.br";
            string senha = "Wcogeo122333";
            string emailDestinatario = "suporte@wcogeo.com.br";
            string SMTP = "smtp.wcogeo.com.br";
            string assuntoMensagem = "ASSUNTO DO RELATÓRIO";
            string nomeArquivo = $"{descricao}.xlsx";

            // Monta o Excel
            var options = new ExcelExportingOptions();
            options.ExcelVersion = ExcelVersion.Xlsx;
            var excelEngine = dgvResultado.ExportToExcel(dgvResultado.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];
            workBook.SaveAs(nomeArquivo);

            using (Stream stream = File.Open(nomeArquivo, FileMode.Open))
            {
                workBook.SaveAs(stream);
            }

            //Cria objeto com dados do e-mail.
            System.Net.Mail.MailMessage myMessage = new System.Net.Mail.MailMessage();

            //Define o Campo From e ReplyTo do e-mail.
            myMessage.From = new MailAddress("<" + emailRemetente + ">");

            //Define os destinatários do e-mail.
            myMessage.To.Add("<" + emailDestinatario + ">");

            //Define a prioridade do e-mail
            myMessage.Priority = MailPriority.Normal;

            //Define o formato do e - mail HTML(caso não queira HTML alocar valor false)
            myMessage.IsBodyHtml = true;

            myMessage.Subject = assuntoMensagem;

            // Carrega o anexo com a planilha salva.
            Attachment anexo = new Attachment(nomeArquivo);
            myMessage.Attachments.Add(anexo);

            myMessage.Body = "Enviando email de Teste";
            //myMessage.Body = new StreamReader(nomeArquivo).ReadToEnd();

            //Para evitar problemas com caracteres "estranhos", configuramos o Charset para "ISO-8859-1"
            myMessage.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            myMessage.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");

            //Cria objeto com os dados do SMTP
            SmtpClient client = new SmtpClient(SMTP, 587);

            client.Credentials = new System.Net.NetworkCredential(emailRemetente, senha);
            client.Host = SMTP;
            client.Port = 587;

            int count = 0;

            while (count < 3)
            {
                try
                {
                    client.Send(myMessage);
                    count = 3;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, $"Enviado",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(String.Format("Enviando o email - {0}", count.ToString()));
                    Thread.Sleep(60000);
                    count++;
                }
                finally
                {
                    // excluímos o objeto de e - mail da memória
                    client.Dispose();
                }
            }
            MessageBox.Show("Email enviado com sucesso!", $"Enviado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion

        #region Método responsável por [CARREGAR ARQUIVO EXCEL EM DATAGRID]
        public static void ImportExcel(SfDataGrid dgvResultado, string descricao)
        {

        }
        #endregion

        #region Método responsável por [CONFIGURAR AS CORES DAS LINHAS DO DATAGRID]
        public static void ConfigureLine(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowData == null || e.RowType != RowType.DefaultRow)
                return;

            if (e.RowIndex % 2 == 0)
            {
                e.Style.BackColor = Color.FromArgb(192, 192, 192);
                e.Style.TextColor = Color.Black;
            }
        }
        #endregion

        #region Método responsável por [CAPTURAR AS INFORMAÇÕES DO SfDataGrid E RETORNAR UMA LISTA]
        public static class GetDataGrids<T> where T : class
        {
            public static List<T> GetDynamic(SfDataGrid dgvResultado)
            {
                if (dgvResultado.RowCount ==0) return null;

                var listObject = new List<T>();
                foreach (var record in dgvResultado.View.Records)
                    listObject.Add(record.Data as T);

                return listObject;
            }
        }
        #endregion
    }
}
