
namespace SAKZ_Emulator
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCOM = new System.Windows.Forms.TabPage();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.labelWork = new System.Windows.Forms.Label();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.labelStopBit = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.labelParity = new System.Windows.Forms.Label();
            this.buttonCOMUpdate = new System.Windows.Forms.Button();
            this.comboBoxBits = new System.Windows.Forms.ComboBox();
            this.labelBits = new System.Windows.Forms.Label();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.labelCOM = new System.Windows.Forms.Label();
            this.tabPageParams = new System.Windows.Forms.TabPage();
            this.labelBit15 = new System.Windows.Forms.Label();
            this.labelBit14 = new System.Windows.Forms.Label();
            this.labelBit13 = new System.Windows.Forms.Label();
            this.labelBit12 = new System.Windows.Forms.Label();
            this.labelBit11 = new System.Windows.Forms.Label();
            this.labelBit10 = new System.Windows.Forms.Label();
            this.labelBit9 = new System.Windows.Forms.Label();
            this.labelBit8 = new System.Windows.Forms.Label();
            this.labelBit7 = new System.Windows.Forms.Label();
            this.labelBit6 = new System.Windows.Forms.Label();
            this.labelBit5 = new System.Windows.Forms.Label();
            this.labelBit4 = new System.Windows.Forms.Label();
            this.labelBit3 = new System.Windows.Forms.Label();
            this.labelBit2 = new System.Windows.Forms.Label();
            this.labelBit1 = new System.Windows.Forms.Label();
            this.labelBit0 = new System.Windows.Forms.Label();
            this.checkBoxBit07 = new System.Windows.Forms.CheckBox();
            this.numericUpDownStep2Value = new System.Windows.Forms.NumericUpDown();
            this.labelStep2Value = new System.Windows.Forms.Label();
            this.numericUpDownStep1Value = new System.Windows.Forms.NumericUpDown();
            this.labelStep1Value = new System.Windows.Forms.Label();
            this.numericUpDownTemp = new System.Windows.Forms.NumericUpDown();
            this.labelTemp = new System.Windows.Forms.Label();
            this.numericUpDownGas = new System.Windows.Forms.NumericUpDown();
            this.labelGas = new System.Windows.Forms.Label();
            this.numericUpDownControl = new System.Windows.Forms.NumericUpDown();
            this.labelControl = new System.Windows.Forms.Label();
            this.checkBoxBit15 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit14 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit13 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit12 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit11 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit10 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit09 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit08 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit06 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit05 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit04 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit03 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit02 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit01 = new System.Windows.Forms.CheckBox();
            this.checkBoxBit00 = new System.Windows.Forms.CheckBox();
            this.numericUpDownCode = new System.Windows.Forms.NumericUpDown();
            this.labelCode = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.numericUpDownSoftware = new System.Windows.Forms.NumericUpDown();
            this.labelSoftware = new System.Windows.Forms.Label();
            this.numericUpDownAddress = new System.Windows.Forms.NumericUpDown();
            this.labelAddress = new System.Windows.Forms.Label();
            this.numericUpDownSerialNumber = new System.Windows.Forms.NumericUpDown();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageCOM.SuspendLayout();
            this.tabPageParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep1Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoftware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageCOM);
            this.tabControl.Controls.Add(this.tabPageParams);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(12, 59);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(575, 412);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageCOM
            // 
            this.tabPageCOM.Controls.Add(this.buttonClearLog);
            this.tabPageCOM.Controls.Add(this.richTextBoxLog);
            this.tabPageCOM.Controls.Add(this.labelWork);
            this.tabPageCOM.Controls.Add(this.checkBoxLog);
            this.tabPageCOM.Controls.Add(this.buttonStart);
            this.tabPageCOM.Controls.Add(this.comboBoxStopBit);
            this.tabPageCOM.Controls.Add(this.labelStopBit);
            this.tabPageCOM.Controls.Add(this.comboBoxParity);
            this.tabPageCOM.Controls.Add(this.labelParity);
            this.tabPageCOM.Controls.Add(this.buttonCOMUpdate);
            this.tabPageCOM.Controls.Add(this.comboBoxBits);
            this.tabPageCOM.Controls.Add(this.labelBits);
            this.tabPageCOM.Controls.Add(this.comboBoxSpeed);
            this.tabPageCOM.Controls.Add(this.labelSpeed);
            this.tabPageCOM.Controls.Add(this.comboBoxCOM);
            this.tabPageCOM.Controls.Add(this.labelCOM);
            this.tabPageCOM.Location = new System.Drawing.Point(4, 25);
            this.tabPageCOM.Name = "tabPageCOM";
            this.tabPageCOM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCOM.Size = new System.Drawing.Size(567, 383);
            this.tabPageCOM.TabIndex = 0;
            this.tabPageCOM.Text = "COM-порт";
            this.tabPageCOM.UseVisualStyleBackColor = true;
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(434, 198);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(115, 30);
            this.buttonClearLog.TabIndex = 15;
            this.buttonClearLog.Text = "Очистить лог";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BackColor = System.Drawing.Color.Black;
            this.richTextBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxLog.ForeColor = System.Drawing.Color.White;
            this.richTextBoxLog.Location = new System.Drawing.Point(18, 235);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxLog.Size = new System.Drawing.Size(531, 142);
            this.richTextBoxLog.TabIndex = 14;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.WordWrap = false;
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // labelWork
            // 
            this.labelWork.AutoSize = true;
            this.labelWork.Location = new System.Drawing.Point(15, 174);
            this.labelWork.Name = "labelWork";
            this.labelWork.Size = new System.Drawing.Size(56, 16);
            this.labelWork.TabIndex = 13;
            this.labelWork.Text = "Работа";
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.AutoSize = true;
            this.checkBoxLog.Checked = true;
            this.checkBoxLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLog.Location = new System.Drawing.Point(18, 204);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(157, 20);
            this.checkBoxLog.TabIndex = 12;
            this.checkBoxLog.Text = "Вывод в лог обмена";
            this.checkBoxLog.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(145, 167);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(155, 30);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Items.AddRange(new object[] {
            "None",
            "1",
            "1.5",
            "2"});
            this.comboBoxStopBit.Location = new System.Drawing.Point(145, 137);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(155, 24);
            this.comboBoxStopBit.TabIndex = 10;
            // 
            // labelStopBit
            // 
            this.labelStopBit.AutoSize = true;
            this.labelStopBit.Location = new System.Drawing.Point(15, 140);
            this.labelStopBit.Name = "labelStopBit";
            this.labelStopBit.Size = new System.Drawing.Size(66, 16);
            this.labelStopBit.TabIndex = 9;
            this.labelStopBit.Text = "Стоп бит";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(145, 107);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(155, 24);
            this.comboBoxParity.TabIndex = 8;
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(15, 110);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(69, 16);
            this.labelParity.TabIndex = 7;
            this.labelParity.Text = "Четность";
            // 
            // buttonCOMUpdate
            // 
            this.buttonCOMUpdate.Location = new System.Drawing.Point(317, 13);
            this.buttonCOMUpdate.Name = "buttonCOMUpdate";
            this.buttonCOMUpdate.Size = new System.Drawing.Size(101, 30);
            this.buttonCOMUpdate.TabIndex = 6;
            this.buttonCOMUpdate.Text = "Обновить";
            this.buttonCOMUpdate.UseVisualStyleBackColor = true;
            this.buttonCOMUpdate.Click += new System.EventHandler(this.buttonCOMUpdate_Click);
            // 
            // comboBoxBits
            // 
            this.comboBoxBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBits.FormattingEnabled = true;
            this.comboBoxBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBoxBits.Location = new System.Drawing.Point(145, 77);
            this.comboBoxBits.Name = "comboBoxBits";
            this.comboBoxBits.Size = new System.Drawing.Size(155, 24);
            this.comboBoxBits.TabIndex = 5;
            // 
            // labelBits
            // 
            this.labelBits.AutoSize = true;
            this.labelBits.Location = new System.Drawing.Point(15, 80);
            this.labelBits.Name = "labelBits";
            this.labelBits.Size = new System.Drawing.Size(82, 16);
            this.labelBits.TabIndex = 4;
            this.labelBits.Text = "Бит данных";
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(145, 47);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(155, 24);
            this.comboBoxSpeed.TabIndex = 3;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(15, 50);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(69, 16);
            this.labelSpeed.TabIndex = 2;
            this.labelSpeed.Text = "Скорость";
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(145, 17);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(155, 24);
            this.comboBoxCOM.TabIndex = 1;
            // 
            // labelCOM
            // 
            this.labelCOM.AutoSize = true;
            this.labelCOM.Location = new System.Drawing.Point(15, 20);
            this.labelCOM.Name = "labelCOM";
            this.labelCOM.Size = new System.Drawing.Size(73, 16);
            this.labelCOM.TabIndex = 0;
            this.labelCOM.Text = "COM-порт";
            // 
            // tabPageParams
            // 
            this.tabPageParams.Controls.Add(this.labelBit15);
            this.tabPageParams.Controls.Add(this.labelBit14);
            this.tabPageParams.Controls.Add(this.labelBit13);
            this.tabPageParams.Controls.Add(this.labelBit12);
            this.tabPageParams.Controls.Add(this.labelBit11);
            this.tabPageParams.Controls.Add(this.labelBit10);
            this.tabPageParams.Controls.Add(this.labelBit9);
            this.tabPageParams.Controls.Add(this.labelBit8);
            this.tabPageParams.Controls.Add(this.labelBit7);
            this.tabPageParams.Controls.Add(this.labelBit6);
            this.tabPageParams.Controls.Add(this.labelBit5);
            this.tabPageParams.Controls.Add(this.labelBit4);
            this.tabPageParams.Controls.Add(this.labelBit3);
            this.tabPageParams.Controls.Add(this.labelBit2);
            this.tabPageParams.Controls.Add(this.labelBit1);
            this.tabPageParams.Controls.Add(this.labelBit0);
            this.tabPageParams.Controls.Add(this.checkBoxBit07);
            this.tabPageParams.Controls.Add(this.numericUpDownStep2Value);
            this.tabPageParams.Controls.Add(this.labelStep2Value);
            this.tabPageParams.Controls.Add(this.numericUpDownStep1Value);
            this.tabPageParams.Controls.Add(this.labelStep1Value);
            this.tabPageParams.Controls.Add(this.numericUpDownTemp);
            this.tabPageParams.Controls.Add(this.labelTemp);
            this.tabPageParams.Controls.Add(this.numericUpDownGas);
            this.tabPageParams.Controls.Add(this.labelGas);
            this.tabPageParams.Controls.Add(this.numericUpDownControl);
            this.tabPageParams.Controls.Add(this.labelControl);
            this.tabPageParams.Controls.Add(this.checkBoxBit15);
            this.tabPageParams.Controls.Add(this.checkBoxBit14);
            this.tabPageParams.Controls.Add(this.checkBoxBit13);
            this.tabPageParams.Controls.Add(this.checkBoxBit12);
            this.tabPageParams.Controls.Add(this.checkBoxBit11);
            this.tabPageParams.Controls.Add(this.checkBoxBit10);
            this.tabPageParams.Controls.Add(this.checkBoxBit09);
            this.tabPageParams.Controls.Add(this.checkBoxBit08);
            this.tabPageParams.Controls.Add(this.checkBoxBit06);
            this.tabPageParams.Controls.Add(this.checkBoxBit05);
            this.tabPageParams.Controls.Add(this.checkBoxBit04);
            this.tabPageParams.Controls.Add(this.checkBoxBit03);
            this.tabPageParams.Controls.Add(this.checkBoxBit02);
            this.tabPageParams.Controls.Add(this.checkBoxBit01);
            this.tabPageParams.Controls.Add(this.checkBoxBit00);
            this.tabPageParams.Controls.Add(this.numericUpDownCode);
            this.tabPageParams.Controls.Add(this.labelCode);
            this.tabPageParams.Controls.Add(this.comboBoxType);
            this.tabPageParams.Controls.Add(this.labelType);
            this.tabPageParams.Controls.Add(this.numericUpDownSoftware);
            this.tabPageParams.Controls.Add(this.labelSoftware);
            this.tabPageParams.Controls.Add(this.numericUpDownAddress);
            this.tabPageParams.Controls.Add(this.labelAddress);
            this.tabPageParams.Controls.Add(this.numericUpDownSerialNumber);
            this.tabPageParams.Controls.Add(this.labelSerialNumber);
            this.tabPageParams.Location = new System.Drawing.Point(4, 25);
            this.tabPageParams.Name = "tabPageParams";
            this.tabPageParams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParams.Size = new System.Drawing.Size(567, 383);
            this.tabPageParams.TabIndex = 1;
            this.tabPageParams.Text = "Параметры";
            this.tabPageParams.UseVisualStyleBackColor = true;
            // 
            // labelBit15
            // 
            this.labelBit15.AutoSize = true;
            this.labelBit15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit15.Location = new System.Drawing.Point(304, 348);
            this.labelBit15.Name = "labelBit15";
            this.labelBit15.Size = new System.Drawing.Size(49, 16);
            this.labelBit15.TabIndex = 52;
            this.labelBit15.Text = "Бит 15";
            // 
            // labelBit14
            // 
            this.labelBit14.AutoSize = true;
            this.labelBit14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit14.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit14.Location = new System.Drawing.Point(304, 322);
            this.labelBit14.Name = "labelBit14";
            this.labelBit14.Size = new System.Drawing.Size(49, 16);
            this.labelBit14.TabIndex = 51;
            this.labelBit14.Text = "Бит 14";
            // 
            // labelBit13
            // 
            this.labelBit13.AutoSize = true;
            this.labelBit13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit13.Location = new System.Drawing.Point(304, 296);
            this.labelBit13.Name = "labelBit13";
            this.labelBit13.Size = new System.Drawing.Size(49, 16);
            this.labelBit13.TabIndex = 50;
            this.labelBit13.Text = "Бит 13";
            // 
            // labelBit12
            // 
            this.labelBit12.AutoSize = true;
            this.labelBit12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit12.Location = new System.Drawing.Point(304, 272);
            this.labelBit12.Name = "labelBit12";
            this.labelBit12.Size = new System.Drawing.Size(49, 16);
            this.labelBit12.TabIndex = 49;
            this.labelBit12.Text = "Бит 12";
            // 
            // labelBit11
            // 
            this.labelBit11.AutoSize = true;
            this.labelBit11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit11.Location = new System.Drawing.Point(304, 246);
            this.labelBit11.Name = "labelBit11";
            this.labelBit11.Size = new System.Drawing.Size(49, 16);
            this.labelBit11.TabIndex = 48;
            this.labelBit11.Text = "Бит 11";
            // 
            // labelBit10
            // 
            this.labelBit10.AutoSize = true;
            this.labelBit10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit10.Location = new System.Drawing.Point(304, 220);
            this.labelBit10.Name = "labelBit10";
            this.labelBit10.Size = new System.Drawing.Size(49, 16);
            this.labelBit10.TabIndex = 47;
            this.labelBit10.Text = "Бит 10";
            // 
            // labelBit9
            // 
            this.labelBit9.AutoSize = true;
            this.labelBit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit9.Location = new System.Drawing.Point(304, 194);
            this.labelBit9.Name = "labelBit9";
            this.labelBit9.Size = new System.Drawing.Size(42, 16);
            this.labelBit9.TabIndex = 46;
            this.labelBit9.Text = "Бит 9";
            // 
            // labelBit8
            // 
            this.labelBit8.AutoSize = true;
            this.labelBit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit8.Location = new System.Drawing.Point(304, 168);
            this.labelBit8.Name = "labelBit8";
            this.labelBit8.Size = new System.Drawing.Size(42, 16);
            this.labelBit8.TabIndex = 45;
            this.labelBit8.Text = "Бит 8";
            // 
            // labelBit7
            // 
            this.labelBit7.AutoSize = true;
            this.labelBit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit7.Location = new System.Drawing.Point(18, 348);
            this.labelBit7.Name = "labelBit7";
            this.labelBit7.Size = new System.Drawing.Size(42, 16);
            this.labelBit7.TabIndex = 44;
            this.labelBit7.Text = "Бит 7";
            // 
            // labelBit6
            // 
            this.labelBit6.AutoSize = true;
            this.labelBit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit6.Location = new System.Drawing.Point(18, 322);
            this.labelBit6.Name = "labelBit6";
            this.labelBit6.Size = new System.Drawing.Size(42, 16);
            this.labelBit6.TabIndex = 43;
            this.labelBit6.Text = "Бит 6";
            // 
            // labelBit5
            // 
            this.labelBit5.AutoSize = true;
            this.labelBit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit5.Location = new System.Drawing.Point(18, 296);
            this.labelBit5.Name = "labelBit5";
            this.labelBit5.Size = new System.Drawing.Size(42, 16);
            this.labelBit5.TabIndex = 42;
            this.labelBit5.Text = "Бит 5";
            // 
            // labelBit4
            // 
            this.labelBit4.AutoSize = true;
            this.labelBit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit4.Location = new System.Drawing.Point(18, 272);
            this.labelBit4.Name = "labelBit4";
            this.labelBit4.Size = new System.Drawing.Size(42, 16);
            this.labelBit4.TabIndex = 41;
            this.labelBit4.Text = "Бит 4";
            // 
            // labelBit3
            // 
            this.labelBit3.AutoSize = true;
            this.labelBit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit3.Location = new System.Drawing.Point(18, 246);
            this.labelBit3.Name = "labelBit3";
            this.labelBit3.Size = new System.Drawing.Size(42, 16);
            this.labelBit3.TabIndex = 40;
            this.labelBit3.Text = "Бит 3";
            // 
            // labelBit2
            // 
            this.labelBit2.AutoSize = true;
            this.labelBit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit2.Location = new System.Drawing.Point(18, 220);
            this.labelBit2.Name = "labelBit2";
            this.labelBit2.Size = new System.Drawing.Size(42, 16);
            this.labelBit2.TabIndex = 39;
            this.labelBit2.Text = "Бит 2";
            // 
            // labelBit1
            // 
            this.labelBit1.AutoSize = true;
            this.labelBit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit1.Location = new System.Drawing.Point(18, 194);
            this.labelBit1.Name = "labelBit1";
            this.labelBit1.Size = new System.Drawing.Size(42, 16);
            this.labelBit1.TabIndex = 38;
            this.labelBit1.Text = "Бит 1";
            // 
            // labelBit0
            // 
            this.labelBit0.AutoSize = true;
            this.labelBit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBit0.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelBit0.Location = new System.Drawing.Point(18, 168);
            this.labelBit0.Name = "labelBit0";
            this.labelBit0.Size = new System.Drawing.Size(42, 16);
            this.labelBit0.TabIndex = 37;
            this.labelBit0.Text = "Бит 0";
            // 
            // checkBoxBit07
            // 
            this.checkBoxBit07.AutoSize = true;
            this.checkBoxBit07.Location = new System.Drawing.Point(69, 347);
            this.checkBoxBit07.Name = "checkBoxBit07";
            this.checkBoxBit07.Size = new System.Drawing.Size(31, 20);
            this.checkBoxBit07.TabIndex = 36;
            this.checkBoxBit07.Text = "-";
            this.checkBoxBit07.UseVisualStyleBackColor = true;
            this.checkBoxBit07.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // numericUpDownStep2Value
            // 
            this.numericUpDownStep2Value.Location = new System.Drawing.Point(447, 129);
            this.numericUpDownStep2Value.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownStep2Value.Name = "numericUpDownStep2Value";
            this.numericUpDownStep2Value.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownStep2Value.TabIndex = 35;
            // 
            // labelStep2Value
            // 
            this.labelStep2Value.AutoSize = true;
            this.labelStep2Value.Location = new System.Drawing.Point(304, 131);
            this.labelStep2Value.Name = "labelStep2Value";
            this.labelStep2Value.Size = new System.Drawing.Size(134, 16);
            this.labelStep2Value.TabIndex = 34;
            this.labelStep2Value.Text = "Значение Порога 2";
            // 
            // numericUpDownStep1Value
            // 
            this.numericUpDownStep1Value.Location = new System.Drawing.Point(447, 100);
            this.numericUpDownStep1Value.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownStep1Value.Name = "numericUpDownStep1Value";
            this.numericUpDownStep1Value.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownStep1Value.TabIndex = 33;
            // 
            // labelStep1Value
            // 
            this.labelStep1Value.AutoSize = true;
            this.labelStep1Value.Location = new System.Drawing.Point(304, 102);
            this.labelStep1Value.Name = "labelStep1Value";
            this.labelStep1Value.Size = new System.Drawing.Size(134, 16);
            this.labelStep1Value.TabIndex = 32;
            this.labelStep1Value.Text = "Значение Порога 1";
            // 
            // numericUpDownTemp
            // 
            this.numericUpDownTemp.Location = new System.Drawing.Point(447, 71);
            this.numericUpDownTemp.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownTemp.Name = "numericUpDownTemp";
            this.numericUpDownTemp.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownTemp.TabIndex = 31;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(304, 73);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(97, 16);
            this.labelTemp.TabIndex = 30;
            this.labelTemp.Text = "Температура";
            // 
            // numericUpDownGas
            // 
            this.numericUpDownGas.Location = new System.Drawing.Point(447, 43);
            this.numericUpDownGas.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownGas.Name = "numericUpDownGas";
            this.numericUpDownGas.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownGas.TabIndex = 29;
            // 
            // labelGas
            // 
            this.labelGas.AutoSize = true;
            this.labelGas.Location = new System.Drawing.Point(304, 45);
            this.labelGas.Name = "labelGas";
            this.labelGas.Size = new System.Drawing.Size(116, 16);
            this.labelGas.TabIndex = 28;
            this.labelGas.Text = "Загазованность";
            // 
            // numericUpDownControl
            // 
            this.numericUpDownControl.Location = new System.Drawing.Point(447, 12);
            this.numericUpDownControl.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownControl.Name = "numericUpDownControl";
            this.numericUpDownControl.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownControl.TabIndex = 27;
            // 
            // labelControl
            // 
            this.labelControl.AutoSize = true;
            this.labelControl.Location = new System.Drawing.Point(304, 14);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(89, 16);
            this.labelControl.TabIndex = 26;
            this.labelControl.Text = "Управление";
            // 
            // checkBoxBit15
            // 
            this.checkBoxBit15.AutoSize = true;
            this.checkBoxBit15.Location = new System.Drawing.Point(358, 347);
            this.checkBoxBit15.Name = "checkBoxBit15";
            this.checkBoxBit15.Size = new System.Drawing.Size(139, 20);
            this.checkBoxBit15.TabIndex = 25;
            this.checkBoxBit15.Text = "Неоткалиброван";
            this.checkBoxBit15.UseVisualStyleBackColor = true;
            this.checkBoxBit15.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit14
            // 
            this.checkBoxBit14.AutoSize = true;
            this.checkBoxBit14.Location = new System.Drawing.Point(358, 321);
            this.checkBoxBit14.Name = "checkBoxBit14";
            this.checkBoxBit14.Size = new System.Drawing.Size(128, 20);
            this.checkBoxBit14.TabIndex = 24;
            this.checkBoxBit14.Text = "Обрыв клапана";
            this.checkBoxBit14.UseVisualStyleBackColor = true;
            this.checkBoxBit14.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit13
            // 
            this.checkBoxBit13.AutoSize = true;
            this.checkBoxBit13.Location = new System.Drawing.Point(358, 295);
            this.checkBoxBit13.Name = "checkBoxBit13";
            this.checkBoxBit13.Size = new System.Drawing.Size(158, 20);
            this.checkBoxBit13.TabIndex = 23;
            this.checkBoxBit13.Text = "Обрыв датчика GAS";
            this.checkBoxBit13.UseVisualStyleBackColor = true;
            this.checkBoxBit13.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit12
            // 
            this.checkBoxBit12.AutoSize = true;
            this.checkBoxBit12.Location = new System.Drawing.Point(358, 271);
            this.checkBoxBit12.Name = "checkBoxBit12";
            this.checkBoxBit12.Size = new System.Drawing.Size(189, 20);
            this.checkBoxBit12.TabIndex = 22;
            this.checkBoxBit12.Text = "Замыкание датчика GAS";
            this.checkBoxBit12.UseVisualStyleBackColor = true;
            this.checkBoxBit12.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit11
            // 
            this.checkBoxBit11.AutoSize = true;
            this.checkBoxBit11.Location = new System.Drawing.Point(358, 245);
            this.checkBoxBit11.Name = "checkBoxBit11";
            this.checkBoxBit11.Size = new System.Drawing.Size(62, 20);
            this.checkBoxBit11.TabIndex = 21;
            this.checkBoxBit11.Text = "nolink";
            this.checkBoxBit11.UseVisualStyleBackColor = true;
            this.checkBoxBit11.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit10
            // 
            this.checkBoxBit10.AutoSize = true;
            this.checkBoxBit10.Location = new System.Drawing.Point(358, 219);
            this.checkBoxBit10.Name = "checkBoxBit10";
            this.checkBoxBit10.Size = new System.Drawing.Size(190, 20);
            this.checkBoxBit10.TabIndex = 20;
            this.checkBoxBit10.Text = "Температура не в норме";
            this.checkBoxBit10.UseVisualStyleBackColor = true;
            this.checkBoxBit10.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit09
            // 
            this.checkBoxBit09.AutoSize = true;
            this.checkBoxBit09.Location = new System.Drawing.Point(358, 193);
            this.checkBoxBit09.Name = "checkBoxBit09";
            this.checkBoxBit09.Size = new System.Drawing.Size(140, 20);
            this.checkBoxBit09.TabIndex = 19;
            this.checkBoxBit09.Text = "Внешний контакт";
            this.checkBoxBit09.UseVisualStyleBackColor = true;
            this.checkBoxBit09.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit08
            // 
            this.checkBoxBit08.AutoSize = true;
            this.checkBoxBit08.Location = new System.Drawing.Point(358, 167);
            this.checkBoxBit08.Name = "checkBoxBit08";
            this.checkBoxBit08.Size = new System.Drawing.Size(135, 20);
            this.checkBoxBit08.TabIndex = 18;
            this.checkBoxBit08.Text = "Дымовой датчик";
            this.checkBoxBit08.UseVisualStyleBackColor = true;
            this.checkBoxBit08.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit06
            // 
            this.checkBoxBit06.AutoSize = true;
            this.checkBoxBit06.Location = new System.Drawing.Point(69, 321);
            this.checkBoxBit06.Name = "checkBoxBit06";
            this.checkBoxBit06.Size = new System.Drawing.Size(199, 20);
            this.checkBoxBit06.TabIndex = 17;
            this.checkBoxBit06.Text = "Срабатывание Порог 2 CH";
            this.checkBoxBit06.UseVisualStyleBackColor = true;
            this.checkBoxBit06.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit05
            // 
            this.checkBoxBit05.AutoSize = true;
            this.checkBoxBit05.Location = new System.Drawing.Point(69, 295);
            this.checkBoxBit05.Name = "checkBoxBit05";
            this.checkBoxBit05.Size = new System.Drawing.Size(199, 20);
            this.checkBoxBit05.TabIndex = 16;
            this.checkBoxBit05.Text = "Срабатывание Порог 1 CH";
            this.checkBoxBit05.UseVisualStyleBackColor = true;
            this.checkBoxBit05.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit04
            // 
            this.checkBoxBit04.AutoSize = true;
            this.checkBoxBit04.Location = new System.Drawing.Point(69, 271);
            this.checkBoxBit04.Name = "checkBoxBit04";
            this.checkBoxBit04.Size = new System.Drawing.Size(213, 20);
            this.checkBoxBit04.TabIndex = 15;
            this.checkBoxBit04.Text = "Состояние клапана (закрыт)";
            this.checkBoxBit04.UseVisualStyleBackColor = true;
            this.checkBoxBit04.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit03
            // 
            this.checkBoxBit03.AutoSize = true;
            this.checkBoxBit03.Location = new System.Drawing.Point(69, 245);
            this.checkBoxBit03.Name = "checkBoxBit03";
            this.checkBoxBit03.Size = new System.Drawing.Size(108, 20);
            this.checkBoxBit03.TabIndex = 14;
            this.checkBoxBit03.Text = "Кнопка Тест";
            this.checkBoxBit03.UseVisualStyleBackColor = true;
            this.checkBoxBit03.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit02
            // 
            this.checkBoxBit02.AutoSize = true;
            this.checkBoxBit02.Location = new System.Drawing.Point(69, 219);
            this.checkBoxBit02.Name = "checkBoxBit02";
            this.checkBoxBit02.Size = new System.Drawing.Size(129, 20);
            this.checkBoxBit02.TabIndex = 13;
            this.checkBoxBit02.Text = "Неисправность";
            this.checkBoxBit02.UseVisualStyleBackColor = true;
            this.checkBoxBit02.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit01
            // 
            this.checkBoxBit01.AutoSize = true;
            this.checkBoxBit01.Location = new System.Drawing.Point(69, 193);
            this.checkBoxBit01.Name = "checkBoxBit01";
            this.checkBoxBit01.Size = new System.Drawing.Size(199, 20);
            this.checkBoxBit01.TabIndex = 12;
            this.checkBoxBit01.Text = "Срабатывание Порог 2 CO";
            this.checkBoxBit01.UseVisualStyleBackColor = true;
            this.checkBoxBit01.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // checkBoxBit00
            // 
            this.checkBoxBit00.AutoSize = true;
            this.checkBoxBit00.Location = new System.Drawing.Point(69, 167);
            this.checkBoxBit00.Name = "checkBoxBit00";
            this.checkBoxBit00.Size = new System.Drawing.Size(199, 20);
            this.checkBoxBit00.TabIndex = 11;
            this.checkBoxBit00.Text = "Срабатывание Порог 1 CO";
            this.checkBoxBit00.UseVisualStyleBackColor = true;
            this.checkBoxBit00.Click += new System.EventHandler(this.checkBoxBit_Click);
            // 
            // numericUpDownCode
            // 
            this.numericUpDownCode.Location = new System.Drawing.Point(154, 129);
            this.numericUpDownCode.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownCode.Name = "numericUpDownCode";
            this.numericUpDownCode.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownCode.TabIndex = 9;
            this.numericUpDownCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownCode_KeyUp);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(15, 131);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(102, 16);
            this.labelCode.TabIndex = 8;
            this.labelCode.Text = "Код состояния";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "СЗ-1Е (CH)",
            "СЗ-2Е (CO)"});
            this.comboBoxType.Location = new System.Drawing.Point(154, 97);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(102, 24);
            this.comboBoxType.TabIndex = 7;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(15, 100);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(112, 16);
            this.labelType.TabIndex = 6;
            this.labelType.Text = "Тип устройства";
            // 
            // numericUpDownSoftware
            // 
            this.numericUpDownSoftware.Location = new System.Drawing.Point(154, 69);
            this.numericUpDownSoftware.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownSoftware.Name = "numericUpDownSoftware";
            this.numericUpDownSoftware.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownSoftware.TabIndex = 5;
            // 
            // labelSoftware
            // 
            this.labelSoftware.AutoSize = true;
            this.labelSoftware.Location = new System.Drawing.Point(15, 71);
            this.labelSoftware.Name = "labelSoftware";
            this.labelSoftware.Size = new System.Drawing.Size(78, 16);
            this.labelSoftware.TabIndex = 4;
            this.labelSoftware.Text = "Версия ПО";
            // 
            // numericUpDownAddress
            // 
            this.numericUpDownAddress.Location = new System.Drawing.Point(154, 41);
            this.numericUpDownAddress.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownAddress.Name = "numericUpDownAddress";
            this.numericUpDownAddress.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownAddress.TabIndex = 3;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(15, 43);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(107, 16);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Текущий адрес";
            // 
            // numericUpDownSerialNumber
            // 
            this.numericUpDownSerialNumber.Location = new System.Drawing.Point(154, 12);
            this.numericUpDownSerialNumber.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownSerialNumber.Name = "numericUpDownSerialNumber";
            this.numericUpDownSerialNumber.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownSerialNumber.TabIndex = 1;
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Location = new System.Drawing.Point(15, 14);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(123, 16);
            this.labelSerialNumber.TabIndex = 0;
            this.labelSerialNumber.Text = "Заводской номер";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(156, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(287, 20);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Эмулятор сигнализаторов САКЗ";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubtitle.Location = new System.Drawing.Point(215, 34);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(162, 16);
            this.labelSubtitle.TabIndex = 4;
            this.labelSubtitle.Text = "СЗ-1Е (CH) и СЗ-2Е (CO)";
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 486);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эмулятор сигнализаторов САКЗ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPageCOM.ResumeLayout(false);
            this.tabPageCOM.PerformLayout();
            this.tabPageParams.ResumeLayout(false);
            this.tabPageParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep1Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoftware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCOM;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Label labelCOM;
        private System.Windows.Forms.TabPage tabPageParams;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.Label labelStopBit;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Button buttonCOMUpdate;
        private System.Windows.Forms.ComboBox comboBoxBits;
        private System.Windows.Forms.Label labelBits;
        private System.Windows.Forms.Label labelWork;
        private System.Windows.Forms.CheckBox checkBoxLog;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.NumericUpDown numericUpDownSoftware;
        private System.Windows.Forms.Label labelSoftware;
        private System.Windows.Forms.NumericUpDown numericUpDownAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.NumericUpDown numericUpDownSerialNumber;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.CheckBox checkBoxBit02;
        private System.Windows.Forms.CheckBox checkBoxBit01;
        private System.Windows.Forms.CheckBox checkBoxBit00;
        private System.Windows.Forms.NumericUpDown numericUpDownCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.CheckBox checkBoxBit06;
        private System.Windows.Forms.CheckBox checkBoxBit05;
        private System.Windows.Forms.CheckBox checkBoxBit04;
        private System.Windows.Forms.CheckBox checkBoxBit03;
        private System.Windows.Forms.CheckBox checkBoxBit15;
        private System.Windows.Forms.CheckBox checkBoxBit14;
        private System.Windows.Forms.CheckBox checkBoxBit13;
        private System.Windows.Forms.CheckBox checkBoxBit12;
        private System.Windows.Forms.CheckBox checkBoxBit11;
        private System.Windows.Forms.CheckBox checkBoxBit10;
        private System.Windows.Forms.CheckBox checkBoxBit09;
        private System.Windows.Forms.CheckBox checkBoxBit08;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.NumericUpDown numericUpDownControl;
        private System.Windows.Forms.Label labelControl;
        private System.Windows.Forms.NumericUpDown numericUpDownStep2Value;
        private System.Windows.Forms.Label labelStep2Value;
        private System.Windows.Forms.NumericUpDown numericUpDownStep1Value;
        private System.Windows.Forms.Label labelStep1Value;
        private System.Windows.Forms.NumericUpDown numericUpDownTemp;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.NumericUpDown numericUpDownGas;
        private System.Windows.Forms.Label labelGas;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Label labelBit15;
        private System.Windows.Forms.Label labelBit14;
        private System.Windows.Forms.Label labelBit13;
        private System.Windows.Forms.Label labelBit12;
        private System.Windows.Forms.Label labelBit11;
        private System.Windows.Forms.Label labelBit10;
        private System.Windows.Forms.Label labelBit9;
        private System.Windows.Forms.Label labelBit8;
        private System.Windows.Forms.Label labelBit7;
        private System.Windows.Forms.Label labelBit6;
        private System.Windows.Forms.Label labelBit5;
        private System.Windows.Forms.Label labelBit4;
        private System.Windows.Forms.Label labelBit3;
        private System.Windows.Forms.Label labelBit2;
        private System.Windows.Forms.Label labelBit1;
        private System.Windows.Forms.Label labelBit0;
        private System.Windows.Forms.CheckBox checkBoxBit07;
        private System.IO.Ports.SerialPort serialPort;
    }
}

