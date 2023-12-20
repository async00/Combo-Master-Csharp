using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Auto_Combo_Master_Flex1zy
{
    public partial class Form1 : Form
    {
        #region DLLIMPORT
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        public static int KEY = 88;
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        bool breakable = false;
        private void button1_Click(object sender, EventArgs e)
        {
            Thread KB = new Thread(Keybind);
            KB.Start();
            label6.Text = "Injected";
            label6.ForeColor = Color.Green;
        }
        private  void Keybind()
        {
            Combo combo = new Combo();
            MessageBox.Show("Hile aktif");
            while (true)
            {
                Thread.Sleep(5);
                int Keystate = GetAsyncKeyState(KEY);
                if (Keystate == 32769)
                {
                    combo.ComboStart();
                }
                if (breakable == true)
                {
                    Application.Exit();
                    break;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            breakable = true;
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
