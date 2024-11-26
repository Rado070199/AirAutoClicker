namespace AirAutoClicker.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.groupBoxMouse = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelMouse = new System.Windows.Forms.TableLayoutPanel();
            this.labelMouseButton = new System.Windows.Forms.Label();
            this.labelMouseClickType = new System.Windows.Forms.Label();
            this.labelMouseOnOff = new System.Windows.Forms.Label();
            this.comboBoxMouseButton = new System.Windows.Forms.ComboBox();
            this.comboBoxMouseClickType = new System.Windows.Forms.ComboBox();
            this.checkBoxMouseOnOff = new System.Windows.Forms.CheckBox();
            this.groupBoxLetter = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelMark = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLetterOnOff = new System.Windows.Forms.Label();
            this.textBoxMilliseconds = new System.Windows.Forms.TextBox();
            this.comboBoxLetterMark = new System.Windows.Forms.ComboBox();
            this.checkBoxLetterOnOff = new System.Windows.Forms.CheckBox();
            this.groupBoxDigit = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelDigit = new System.Windows.Forms.TableLayoutPanel();
            this.labelDigitMiliseconds = new System.Windows.Forms.Label();
            this.textBoxDigitMiliseconds = new System.Windows.Forms.TextBox();
            this.labelDigitMark = new System.Windows.Forms.Label();
            this.labelDigitOnOff = new System.Windows.Forms.Label();
            this.comboBoxDigitMark = new System.Windows.Forms.ComboBox();
            this.checkBoxDigitOnOff = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.groupBoxMouse.SuspendLayout();
            this.tableLayoutPanelMouse.SuspendLayout();
            this.groupBoxLetter.SuspendLayout();
            this.tableLayoutPanelMark.SuspendLayout();
            this.groupBoxDigit.SuspendLayout();
            this.tableLayoutPanelDigit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelMenu, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxMouse, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxLetter, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxDigit, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(985, 434);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.ColumnCount = 4;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Controls.Add(this.buttonStart, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.buttonStop, 1, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.buttonSaveSettings, 2, 0);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(3, 387);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 1;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(979, 44);
            this.tableLayoutPanelMenu.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.Location = new System.Drawing.Point(3, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(144, 38);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start (F6)";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStop.Location = new System.Drawing.Point(153, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(144, 38);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop (F6)";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveSettings.Location = new System.Drawing.Point(303, 3);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(144, 38);
            this.buttonSaveSettings.TabIndex = 2;
            this.buttonSaveSettings.Text = "Save settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxMouse
            // 
            this.groupBoxMouse.Controls.Add(this.tableLayoutPanelMouse);
            this.groupBoxMouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMouse.Location = new System.Drawing.Point(3, 259);
            this.groupBoxMouse.Name = "groupBoxMouse";
            this.groupBoxMouse.Size = new System.Drawing.Size(979, 122);
            this.groupBoxMouse.TabIndex = 2;
            this.groupBoxMouse.TabStop = false;
            this.groupBoxMouse.Text = "Mouse";
            // 
            // tableLayoutPanelMouse
            // 
            this.tableLayoutPanelMouse.ColumnCount = 2;
            this.tableLayoutPanelMouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelMouse.Controls.Add(this.labelMouseButton, 0, 0);
            this.tableLayoutPanelMouse.Controls.Add(this.labelMouseClickType, 0, 1);
            this.tableLayoutPanelMouse.Controls.Add(this.labelMouseOnOff, 0, 2);
            this.tableLayoutPanelMouse.Controls.Add(this.comboBoxMouseButton, 1, 0);
            this.tableLayoutPanelMouse.Controls.Add(this.comboBoxMouseClickType, 1, 1);
            this.tableLayoutPanelMouse.Controls.Add(this.checkBoxMouseOnOff, 1, 2);
            this.tableLayoutPanelMouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMouse.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanelMouse.Name = "tableLayoutPanelMouse";
            this.tableLayoutPanelMouse.RowCount = 3;
            this.tableLayoutPanelMouse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMouse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMouse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMouse.Size = new System.Drawing.Size(973, 96);
            this.tableLayoutPanelMouse.TabIndex = 0;
            // 
            // labelMouseButton
            // 
            this.labelMouseButton.AutoSize = true;
            this.labelMouseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMouseButton.Location = new System.Drawing.Point(3, 0);
            this.labelMouseButton.Name = "labelMouseButton";
            this.labelMouseButton.Size = new System.Drawing.Size(334, 32);
            this.labelMouseButton.TabIndex = 0;
            this.labelMouseButton.Text = "Button";
            // 
            // labelMouseClickType
            // 
            this.labelMouseClickType.AutoSize = true;
            this.labelMouseClickType.Location = new System.Drawing.Point(3, 32);
            this.labelMouseClickType.Name = "labelMouseClickType";
            this.labelMouseClickType.Size = new System.Drawing.Size(73, 20);
            this.labelMouseClickType.TabIndex = 1;
            this.labelMouseClickType.Text = "Click type";
            // 
            // labelMouseOnOff
            // 
            this.labelMouseOnOff.AutoSize = true;
            this.labelMouseOnOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMouseOnOff.Location = new System.Drawing.Point(3, 64);
            this.labelMouseOnOff.Name = "labelMouseOnOff";
            this.labelMouseOnOff.Size = new System.Drawing.Size(334, 32);
            this.labelMouseOnOff.TabIndex = 2;
            this.labelMouseOnOff.Text = "On / Off";
            // 
            // comboBoxMouseButton
            // 
            this.comboBoxMouseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxMouseButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMouseButton.FormattingEnabled = true;
            this.comboBoxMouseButton.Location = new System.Drawing.Point(343, 3);
            this.comboBoxMouseButton.Name = "comboBoxMouseButton";
            this.comboBoxMouseButton.Size = new System.Drawing.Size(627, 28);
            this.comboBoxMouseButton.TabIndex = 3;
            // 
            // comboBoxMouseClickType
            // 
            this.comboBoxMouseClickType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxMouseClickType.FormattingEnabled = true;
            this.comboBoxMouseClickType.Location = new System.Drawing.Point(343, 35);
            this.comboBoxMouseClickType.Name = "comboBoxMouseClickType";
            this.comboBoxMouseClickType.Size = new System.Drawing.Size(627, 28);
            this.comboBoxMouseClickType.TabIndex = 4;
            // 
            // checkBoxMouseOnOff
            // 
            this.checkBoxMouseOnOff.AutoSize = true;
            this.checkBoxMouseOnOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxMouseOnOff.Location = new System.Drawing.Point(343, 67);
            this.checkBoxMouseOnOff.Name = "checkBoxMouseOnOff";
            this.checkBoxMouseOnOff.Size = new System.Drawing.Size(627, 26);
            this.checkBoxMouseOnOff.TabIndex = 9;
            this.checkBoxMouseOnOff.UseVisualStyleBackColor = true;
            // 
            // groupBoxLetter
            // 
            this.groupBoxLetter.Controls.Add(this.tableLayoutPanelMark);
            this.groupBoxLetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLetter.Location = new System.Drawing.Point(3, 131);
            this.groupBoxLetter.Name = "groupBoxLetter";
            this.groupBoxLetter.Size = new System.Drawing.Size(979, 122);
            this.groupBoxLetter.TabIndex = 3;
            this.groupBoxLetter.TabStop = false;
            this.groupBoxLetter.Text = "Letter";
            // 
            // tableLayoutPanelMark
            // 
            this.tableLayoutPanelMark.ColumnCount = 2;
            this.tableLayoutPanelMark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelMark.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelMark.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanelMark.Controls.Add(this.labelLetterOnOff, 0, 2);
            this.tableLayoutPanelMark.Controls.Add(this.textBoxMilliseconds, 1, 1);
            this.tableLayoutPanelMark.Controls.Add(this.comboBoxLetterMark, 1, 0);
            this.tableLayoutPanelMark.Controls.Add(this.checkBoxLetterOnOff, 1, 2);
            this.tableLayoutPanelMark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMark.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanelMark.Name = "tableLayoutPanelMark";
            this.tableLayoutPanelMark.RowCount = 3;
            this.tableLayoutPanelMark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelMark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelMark.Size = new System.Drawing.Size(973, 96);
            this.tableLayoutPanelMark.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Milliseconds";
            // 
            // labelLetterOnOff
            // 
            this.labelLetterOnOff.AutoSize = true;
            this.labelLetterOnOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLetterOnOff.Location = new System.Drawing.Point(3, 63);
            this.labelLetterOnOff.Name = "labelLetterOnOff";
            this.labelLetterOnOff.Size = new System.Drawing.Size(334, 33);
            this.labelLetterOnOff.TabIndex = 7;
            this.labelLetterOnOff.Text = "On / Off";
            // 
            // textBoxMilliseconds
            // 
            this.textBoxMilliseconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMilliseconds.Location = new System.Drawing.Point(343, 34);
            this.textBoxMilliseconds.Name = "textBoxMilliseconds";
            this.textBoxMilliseconds.Size = new System.Drawing.Size(627, 27);
            this.textBoxMilliseconds.TabIndex = 9;
            // 
            // comboBoxLetterMark
            // 
            this.comboBoxLetterMark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxLetterMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLetterMark.FormattingEnabled = true;
            this.comboBoxLetterMark.Location = new System.Drawing.Point(343, 3);
            this.comboBoxLetterMark.Name = "comboBoxLetterMark";
            this.comboBoxLetterMark.Size = new System.Drawing.Size(627, 28);
            this.comboBoxLetterMark.TabIndex = 10;
            // 
            // checkBoxLetterOnOff
            // 
            this.checkBoxLetterOnOff.AutoSize = true;
            this.checkBoxLetterOnOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxLetterOnOff.Location = new System.Drawing.Point(343, 66);
            this.checkBoxLetterOnOff.Name = "checkBoxLetterOnOff";
            this.checkBoxLetterOnOff.Size = new System.Drawing.Size(627, 27);
            this.checkBoxLetterOnOff.TabIndex = 11;
            this.checkBoxLetterOnOff.UseVisualStyleBackColor = true;
            // 
            // groupBoxDigit
            // 
            this.groupBoxDigit.Controls.Add(this.tableLayoutPanelDigit);
            this.groupBoxDigit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDigit.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDigit.Name = "groupBoxDigit";
            this.groupBoxDigit.Size = new System.Drawing.Size(979, 122);
            this.groupBoxDigit.TabIndex = 4;
            this.groupBoxDigit.TabStop = false;
            this.groupBoxDigit.Text = "Digit";
            // 
            // tableLayoutPanelDigit
            // 
            this.tableLayoutPanelDigit.ColumnCount = 2;
            this.tableLayoutPanelDigit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelDigit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelDigit.Controls.Add(this.labelDigitMiliseconds, 0, 1);
            this.tableLayoutPanelDigit.Controls.Add(this.textBoxDigitMiliseconds, 1, 1);
            this.tableLayoutPanelDigit.Controls.Add(this.labelDigitMark, 0, 0);
            this.tableLayoutPanelDigit.Controls.Add(this.labelDigitOnOff, 0, 2);
            this.tableLayoutPanelDigit.Controls.Add(this.comboBoxDigitMark, 1, 0);
            this.tableLayoutPanelDigit.Controls.Add(this.checkBoxDigitOnOff, 1, 2);
            this.tableLayoutPanelDigit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDigit.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanelDigit.Name = "tableLayoutPanelDigit";
            this.tableLayoutPanelDigit.RowCount = 3;
            this.tableLayoutPanelDigit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDigit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelDigit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelDigit.Size = new System.Drawing.Size(973, 96);
            this.tableLayoutPanelDigit.TabIndex = 1;
            // 
            // labelDigitMiliseconds
            // 
            this.labelDigitMiliseconds.AutoSize = true;
            this.labelDigitMiliseconds.Location = new System.Drawing.Point(3, 31);
            this.labelDigitMiliseconds.Name = "labelDigitMiliseconds";
            this.labelDigitMiliseconds.Size = new System.Drawing.Size(91, 20);
            this.labelDigitMiliseconds.TabIndex = 2;
            this.labelDigitMiliseconds.Text = "Milliseconds";
            // 
            // textBoxDigitMiliseconds
            // 
            this.textBoxDigitMiliseconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDigitMiliseconds.Location = new System.Drawing.Point(343, 34);
            this.textBoxDigitMiliseconds.Name = "textBoxDigitMiliseconds";
            this.textBoxDigitMiliseconds.Size = new System.Drawing.Size(627, 27);
            this.textBoxDigitMiliseconds.TabIndex = 3;
            // 
            // labelDigitMark
            // 
            this.labelDigitMark.AutoSize = true;
            this.labelDigitMark.Location = new System.Drawing.Point(3, 0);
            this.labelDigitMark.Name = "labelDigitMark";
            this.labelDigitMark.Size = new System.Drawing.Size(42, 20);
            this.labelDigitMark.TabIndex = 4;
            this.labelDigitMark.Text = "Mark";
            // 
            // labelDigitOnOff
            // 
            this.labelDigitOnOff.AutoSize = true;
            this.labelDigitOnOff.Location = new System.Drawing.Point(3, 63);
            this.labelDigitOnOff.Name = "labelDigitOnOff";
            this.labelDigitOnOff.Size = new System.Drawing.Size(63, 20);
            this.labelDigitOnOff.TabIndex = 5;
            this.labelDigitOnOff.Text = "On / Off";
            // 
            // comboBoxDigitMark
            // 
            this.comboBoxDigitMark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDigitMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDigitMark.FormattingEnabled = true;
            this.comboBoxDigitMark.Location = new System.Drawing.Point(343, 3);
            this.comboBoxDigitMark.Name = "comboBoxDigitMark";
            this.comboBoxDigitMark.Size = new System.Drawing.Size(627, 28);
            this.comboBoxDigitMark.TabIndex = 7;
            // 
            // checkBoxDigitOnOff
            // 
            this.checkBoxDigitOnOff.AutoSize = true;
            this.checkBoxDigitOnOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxDigitOnOff.Location = new System.Drawing.Point(343, 66);
            this.checkBoxDigitOnOff.Name = "checkBoxDigitOnOff";
            this.checkBoxDigitOnOff.Size = new System.Drawing.Size(627, 27);
            this.checkBoxDigitOnOff.TabIndex = 8;
            this.checkBoxDigitOnOff.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 434);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "AirAutoClicker";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMenu.ResumeLayout(false);
            this.groupBoxMouse.ResumeLayout(false);
            this.tableLayoutPanelMouse.ResumeLayout(false);
            this.tableLayoutPanelMouse.PerformLayout();
            this.groupBoxLetter.ResumeLayout(false);
            this.tableLayoutPanelMark.ResumeLayout(false);
            this.tableLayoutPanelMark.PerformLayout();
            this.groupBoxDigit.ResumeLayout(false);
            this.tableLayoutPanelDigit.ResumeLayout(false);
            this.tableLayoutPanelDigit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelMenu;
        private Button buttonStart;
        private Button buttonStop;
        private Button buttonSaveSettings;
        private TableLayoutPanel tableLayoutPanelDigit;
        private GroupBox groupBoxMouse;
        private TableLayoutPanel tableLayoutPanelMouse;
        private Label labelMouseButton;
        private Label labelMouseClickType;
        private Label labelMouseOnOff;
        private ComboBox comboBoxMouseButton;
        private ComboBox comboBoxMouseClickType;
        private GroupBox groupBoxLetter;
        private TableLayoutPanel tableLayoutPanelMark;
        private Label label1;
        private Label label3;
        private Label labelLetterOnOff;
        private TextBox textBoxMilliseconds;
        private ComboBox comboBoxLetterMark;
        private GroupBox groupBoxDigit;
        private Label labelDigitMiliseconds;
        private TextBox textBoxDigitMiliseconds;
        private Label labelDigitMark;
        private Label labelDigitOnOff;
        private ComboBox comboBoxDigitMark;
        private CheckBox checkBoxMouseOnOff;
        private CheckBox checkBoxLetterOnOff;
        private CheckBox checkBoxDigitOnOff;
    }
}