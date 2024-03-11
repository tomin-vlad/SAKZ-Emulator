using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAKZ_Emulator
{
    public partial class Form : System.Windows.Forms.Form
    {
        bool status = false; // Статус работы программы
        BitArray bits = new BitArray(16); // Биты кода состояния

        public Form()
        {
            InitializeComponent();

            // Заполнение полей формы
            COMList();
            comboBoxSpeed.SelectedIndex = 9;
            comboBoxBits.SelectedIndex = 1;
            comboBoxParity.SelectedIndex = 2;
            comboBoxStopBit.SelectedIndex = 1;
            comboBoxType.SelectedIndex = 0;

            //byte[] temp = { 0x01, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x08, 0x09, 0x10 };
            //Console.WriteLine(CRC16(temp));
        }

        // Сканирование списка доступных COM-портов
        public void COMList()
        {
            string[] coms = SerialPort.GetPortNames().ToArray();
            Array.Sort(coms);
            comboBoxCOM.Items.AddRange(coms);
            if (coms.Count() > 0) comboBoxCOM.SelectedIndex = 0;
        }

        // Кнопка обновления списка COM-портов
        private void buttonCOMUpdate_Click(object sender, EventArgs e)
        {
            comboBoxCOM.Items.Clear();
            COMList();
        }

        // Функция открытия COM-порта
        public bool Connect()
        {
            serialPort.PortName = comboBoxCOM.Text;
            serialPort.BaudRate = Convert.ToInt32(comboBoxSpeed.Text);
            serialPort.DataBits = Convert.ToInt16(comboBoxBits.Text);
            switch (comboBoxParity.Text)
            {
                case "None":
                    serialPort.Parity = Parity.None;
                    break;
                case "Odd":
                    serialPort.Parity = Parity.Odd;
                    break;
                case "Even":
                    serialPort.Parity = Parity.Even;
                    break;
                case "Mark":
                    serialPort.Parity = Parity.Mark;
                    break;
                case "Space":
                    serialPort.Parity = Parity.Space;
                    break;
            }
            switch (comboBoxStopBit.Text)
            {
                case "None":
                    serialPort.StopBits = StopBits.None;
                    break;
                case "1":
                    serialPort.StopBits = StopBits.One;
                    break;
                case "1.5":
                    serialPort.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    serialPort.StopBits = StopBits.Two;
                    break;
            }

            try
            {
                serialPort.Open();
                strToLog("Порт '" + serialPort.PortName + "' открыт.");
                return true;
            }
            catch (Exception err)
            {
                strToLog("Ошибка: " + err.Message);
                return false;
            }
        }

        // Функция закрытия COM-порта
        public bool Disconnect()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.DiscardInBuffer();
                    serialPort.DiscardOutBuffer();
                    serialPort.Close();
                    serialPort.Dispose();
                    
                }
                strToLog("Порт '" + serialPort.PortName + "' закрыт.");
                return true;
            }
            catch (Exception err)
            {
                strToLog("Ошибка: " + err.Message);
            }
            return false;
        }

        // Функция расчета контрольной суммы CRC16
        static ushort CRC16(byte[] pDataBytes)
        {
            ushort crc = 0xffff;
            ushort polynom = 0xa001;

            for (int i = 0; i < pDataBytes.Length; i++)
            {
                crc ^= pDataBytes[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x01) == 0x01)
                    {
                        crc >>= 1;
                        crc ^= polynom;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }
            return reverseBytes(crc);
        }

        // Функция перестановки байт местами
        static ushort reverseBytes(ushort bytes)
        {
            return (ushort)((bytes >> 8) | (bytes << 8));
        }

        // Кнопка запуска программы
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!status)
            {
                if (Connect())
                {
                    // Программа запущена
                    buttonStart.Text = "Стоп";
                    comboBoxCOM.Enabled = buttonCOMUpdate.Enabled = comboBoxSpeed.Enabled =
                    comboBoxBits.Enabled = comboBoxParity.Enabled = comboBoxStopBit.Enabled =
                    checkBoxLog.Enabled = false;
                    Console.WriteLine("Запущена");
                    status = !status;
                }
            }
            else
            {
                if (Disconnect())
                {
                    // Программа остановлена
                    buttonStart.Text = "Старт";
                    comboBoxCOM.Enabled = buttonCOMUpdate.Enabled = comboBoxSpeed.Enabled =
                    comboBoxBits.Enabled = comboBoxParity.Enabled = comboBoxStopBit.Enabled =
                    checkBoxLog.Enabled = true;
                    Console.WriteLine("Остановлена");
                    status = !status;
                }
            }
        }

        // Формирование кода состояния по чекбоксам
        public int codeBitsToInt()
        {
            var checkboxes = tabPageParams.Controls.OfType<CheckBox>().Where(x => x.Name.StartsWith("checkBoxBit")).OrderBy(l => l.Name);

            int i = 0;
            foreach (var ch in checkboxes)
                bits[i++] = ch.Checked ? true : false;

            int value = 0;
            for (int k = 0; k < bits.Count; k++)
                if (bits[k]) value += Convert.ToInt32(Math.Pow(2, k));

            return value;
        }

        // Формирование чекбоксов по коду состояния
        public void codeIntToBits(ushort value)
        {
            bool[] bits = new bool[16];
            for (int i = 0; i < 16; i++) bits[i] = Convert.ToBoolean((value >> i) & 1);

            var checkboxes = tabPageParams.Controls.OfType<CheckBox>().Where(x => x.Name.StartsWith("checkBoxBit")).OrderBy(l => l.Name);
            int k = 0;
            foreach (var ch in checkboxes)
                ch.Checked = bits[k++];
        }

        // Событие клика по чекбоксу кода состояния
        private void checkBoxBit_Click(object sender, EventArgs e)
        {
            numericUpDownCode.Value = codeBitsToInt();
        }

        // Событие изменения поля кода состояния
        private void numericUpDownCode_KeyUp(object sender, KeyEventArgs e)
        {
            codeIntToBits(Convert.ToUInt16(numericUpDownCode.Value));
        }

        // Функция формирования строки для лога
        public void strToLog(string str)
        {
            if (checkBoxLog.Checked)
            {
                string dt = string.Format("{0} {1}:{2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), DateTime.Now.Millisecond);
                richTextBoxLog.BeginInvokeIfRequired(() => richTextBoxLog.AppendText(dt + " [" + serialPort.PortName + "]: " + str + "\r\n"));
                richTextBoxLog.BeginInvokeIfRequired(() => richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length);
                richTextBoxLog.BeginInvokeIfRequired(() => richTextBoxLog.ScrollToCaret());
            }
        }

        // Функция приведения строки байт к удобочитаемому виду
        string strBytes(byte[] buf, int bytes)
        {
            string str_bytes = "";
            for (int i = 0; i < bytes; i++)
            {
                if (buf[i] > 0x0F) str_bytes = str_bytes + " " + Convert.ToString(buf[i], 16).ToUpper();
                if (buf[i] < 0x0F) str_bytes = str_bytes + " 0" + Convert.ToString(buf[i], 16).ToUpper();
            }
            return str_bytes;
        }

        // Кнопка очистки лога обмена
        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
        }

        // Функция обработки запросов из COM-порта
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = serialPort.BytesToRead;
            byte[] buf = new byte[bytes];
            serialPort.Read(buf, 0, bytes);
            strToLog("RX <-- " + strBytes(buf, bytes));

            if (bytes >= 4)
            {
                byte[] data = new byte[bytes - 2];
                ushort[] crc_tmp = new ushort[1];
                Buffer.BlockCopy(buf, bytes - 2, crc_tmp, 0, 2);
                ushort crc = reverseBytes(crc_tmp[0]);
                Array.Copy(buf, 0, data, 0, bytes - 2);

                if (crc == CRC16(data))
                {
                    switch (data[1])
                    {
                        case 3:
                            break;
                        case 10:
                            break;
                        default:
                            byte[] response = new byte[5];
                            response[0] = data[0];
                            response[1] = data[1];
                            var bitArray = new BitArray(response);
                            bitArray.Set(15, true);
                            bitArray.CopyTo(response, 0);
                            response[2] = 1;

                            Console.WriteLine(response[1]);

                            //response[0] = data[0];
                            //response[1] = (byte)data[1];

                            break;
                    }
                }
                else
                {
                    strToLog("TX -->> Ошибка: Неверная контрольная сумма CRC16.");
                }
            }
            else
            {
                strToLog("TX -->> Ошибка: Кол-во байт в запросе меньше 4.");
            }

            //serialPort.Write(buf, 0, 6);
        }

        private void richTextBoxLog_TextChanged(object sender, EventArgs e)
        {
            if (richTextBoxLog.Lines.Count() > 100)
            {
                richTextBoxLog.Text = richTextBoxLog.Text.Remove(richTextBoxLog.GetFirstCharIndexFromLine(0), richTextBoxLog.Lines[0].Length + 1);
            }
        }

        // Закрываем COM-порт при завершении программы
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }
    }

    public static class Extensions
    {
        public static void BeginInvokeIfRequired(this ISynchronizeInvoke obj, Action action)
        {
            if (obj.InvokeRequired)
                obj.BeginInvoke(action, new object[0]);
            else
                action();
        }
    }
}
