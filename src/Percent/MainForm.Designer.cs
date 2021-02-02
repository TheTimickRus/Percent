namespace Percent
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EnterButton = new MetroFramework.Controls.MetroButton();
            this.MainComboBox = new MetroFramework.Controls.MetroComboBox();
            this.InpX = new MetroFramework.Controls.MetroTextBox();
            this.InpY = new MetroFramework.Controls.MetroTextBox();
            this.Result = new MetroFramework.Controls.MetroTextBox();
            this.ClearButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(288, 127);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(109, 23);
            this.EnterButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Рассчет";
            this.EnterButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.EnterButton.UseSelectable = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // MainComboBox
            // 
            this.MainComboBox.FormattingEnabled = true;
            this.MainComboBox.ItemHeight = 23;
            this.MainComboBox.Items.AddRange(new object[] {
            "Сколько будет X% от числа Y?",
            "Сколько процентов число Х составляет от числа Y?"});
            this.MainComboBox.Location = new System.Drawing.Point(23, 63);
            this.MainComboBox.Name = "MainComboBox";
            this.MainComboBox.Size = new System.Drawing.Size(374, 29);
            this.MainComboBox.Style = MetroFramework.MetroColorStyle.Purple;
            this.MainComboBox.TabIndex = 1;
            this.MainComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainComboBox.UseSelectable = true;
            // 
            // InpX
            // 
            // 
            // 
            // 
            this.InpX.CustomButton.Image = null;
            this.InpX.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.InpX.CustomButton.Name = "";
            this.InpX.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InpX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InpX.CustomButton.TabIndex = 1;
            this.InpX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InpX.CustomButton.UseSelectable = true;
            this.InpX.CustomButton.Visible = false;
            this.InpX.Lines = new string[0];
            this.InpX.Location = new System.Drawing.Point(23, 98);
            this.InpX.MaxLength = 32767;
            this.InpX.Name = "InpX";
            this.InpX.PasswordChar = '\0';
            this.InpX.PromptText = "Введите X";
            this.InpX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InpX.SelectedText = "";
            this.InpX.SelectionLength = 0;
            this.InpX.SelectionStart = 0;
            this.InpX.ShortcutsEnabled = true;
            this.InpX.Size = new System.Drawing.Size(180, 23);
            this.InpX.Style = MetroFramework.MetroColorStyle.Purple;
            this.InpX.TabIndex = 2;
            this.InpX.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InpX.UseSelectable = true;
            this.InpX.WaterMark = "Введите X";
            this.InpX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InpX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.InpX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InpX_KeyPress);
            // 
            // InpY
            // 
            // 
            // 
            // 
            this.InpY.CustomButton.Image = null;
            this.InpY.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.InpY.CustomButton.Name = "";
            this.InpY.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InpY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InpY.CustomButton.TabIndex = 1;
            this.InpY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InpY.CustomButton.UseSelectable = true;
            this.InpY.CustomButton.Visible = false;
            this.InpY.Lines = new string[0];
            this.InpY.Location = new System.Drawing.Point(209, 98);
            this.InpY.MaxLength = 32767;
            this.InpY.Name = "InpY";
            this.InpY.PasswordChar = '\0';
            this.InpY.PromptText = "Введите Y";
            this.InpY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InpY.SelectedText = "";
            this.InpY.SelectionLength = 0;
            this.InpY.SelectionStart = 0;
            this.InpY.ShortcutsEnabled = true;
            this.InpY.Size = new System.Drawing.Size(188, 23);
            this.InpY.Style = MetroFramework.MetroColorStyle.Purple;
            this.InpY.TabIndex = 3;
            this.InpY.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InpY.UseSelectable = true;
            this.InpY.WaterMark = "Введите Y";
            this.InpY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InpY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.InpY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InpX_KeyPress);
            // 
            // Result
            // 
            // 
            // 
            // 
            this.Result.CustomButton.Image = null;
            this.Result.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.Result.CustomButton.Name = "";
            this.Result.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Result.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Result.CustomButton.TabIndex = 1;
            this.Result.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Result.CustomButton.UseSelectable = true;
            this.Result.CustomButton.Visible = false;
            this.Result.Lines = new string[0];
            this.Result.Location = new System.Drawing.Point(23, 127);
            this.Result.MaxLength = 32767;
            this.Result.Name = "Result";
            this.Result.PasswordChar = '\0';
            this.Result.PromptText = "Результат...";
            this.Result.ReadOnly = true;
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Result.SelectedText = "";
            this.Result.SelectionLength = 0;
            this.Result.SelectionStart = 0;
            this.Result.ShortcutsEnabled = true;
            this.Result.Size = new System.Drawing.Size(180, 23);
            this.Result.Style = MetroFramework.MetroColorStyle.Purple;
            this.Result.TabIndex = 4;
            this.Result.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Result.UseSelectable = true;
            this.Result.WaterMark = "Результат...";
            this.Result.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Result.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(209, 127);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(73, 23);
            this.ClearButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ClearButton.UseSelectable = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 171);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.InpY);
            this.Controls.Add(this.InpX);
            this.Controls.Add(this.MainComboBox);
            this.Controls.Add(this.EnterButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Калькулятор %";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton EnterButton;
        private MetroFramework.Controls.MetroComboBox MainComboBox;
        private MetroFramework.Controls.MetroTextBox InpX;
        private MetroFramework.Controls.MetroTextBox InpY;
        private MetroFramework.Controls.MetroTextBox Result;
        private MetroFramework.Controls.MetroButton ClearButton;
    }
}

