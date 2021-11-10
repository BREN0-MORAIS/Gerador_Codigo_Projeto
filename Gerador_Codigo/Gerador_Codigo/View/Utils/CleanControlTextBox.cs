using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Input;
using System;
using System.Windows.Forms;

namespace View
{
    public static class CleanControlTextBox
    {
        public static void CheckControls(Control.ControlCollection controlInicial)
        {
            foreach (Control item in controlInicial)
            {
                LimpaTextBoxes(item);
                //GetControlButton(item);
                foreach (Control item1 in item.Controls)
                {
                    LimpaTextBoxes(item1);
                    // GetControlButton(item1);
                    //Percorre os grupos de cada tab
                    foreach (Control item2 in item1.Controls)
                    {
                        LimpaTextBoxes(item2);
                        // GetControlButton(item2);
                        foreach (Control item3 in item2.Controls)
                        {
                            LimpaTextBoxes(item3);
                            //  GetControlButton(item3);
                            foreach (Control item4 in item3.Controls)
                            {
                                LimpaTextBoxes(item4);
                                //  GetControlButton(item4);
                                foreach (Control item5 in item4.Controls)
                                {
                                    LimpaTextBoxes(item5);
                                    //GetControlButton(item5);
                                    foreach (Control item6 in item5.Controls)
                                    {
                                        LimpaTextBoxes(item6);
                                        // GetControlButton(item6);
                                        foreach (Control item7 in item6.Controls)
                                        {
                                            LimpaTextBoxes(item7);
                                            // GetControlButton(item7);
                                            foreach (Control item8 in item7.Controls)
                                            {
                                                LimpaTextBoxes(item8);
                                                // GetControlButton(item8);

                                                foreach (Control item9 in item8.Controls)
                                                {
                                                    LimpaTextBoxes(item9);
                                                    //GetControlButton(item9);

                                                    foreach (Control item10 in item9.Controls)
                                                    {
                                                        LimpaTextBoxes(item10);
                                                        // GetControlButton(item10);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
        private static void LimpaTextBoxes(Control item)
        {
            if (item is IntegerTextBox)
                item.Text = "0";
            else
           if (item is DoubleTextBox || item is SfNumericTextBox)
                item.Text = "0.00";
            else
           if (item is TextBox || item is TextBoxExt || item is MaskedEditBox || item is DateTimePicker)
                item.Text = "";
            else
            if (item is ComboBox )
                item.ResetText();
        }
        private static void GetControlButton(Control item)
        {
            if (item is Button || item is ButtonAdv)
                Console.WriteLine($"Nome do Componente : {item.Name}  - Texto do Componente : {item.Text}");

        }
    }
}
