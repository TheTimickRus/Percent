using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace Percent
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            MainComboBox.SelectedIndex = 0;
        }

        private void InpX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;

            var count = ((MetroTextBox)sender).Text.IndexOf(',', 0);
            if (count != -1 && e.KeyChar == ',')
                e.Handled = true;
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (InpX.Text.Equals("") && InpY.Text.Equals(""))
                return;

            try
            {
                double x = Convert.ToSingle(InpX.Text.Trim()), y = Convert.ToSingle(InpY.Text.Trim());

                switch (MainComboBox.SelectedIndex)
                {
                    case 0:
                    {
                        var tmp = (x * y) / 100;
                        Result.Text = $@"{Math.Round(tmp, 2)}";

                        break;
                    }

                    case 1:
                    {
                        var tmp = (x * 100) / y;
                        Result.Text = $@"{Math.Round(tmp, 2)} %";

                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                MetroFramework.MetroMessageBox.Show(this, exception.Message, "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InpX.Clear();
            InpY.Clear();
            Result.Clear();
        }
    }
}
