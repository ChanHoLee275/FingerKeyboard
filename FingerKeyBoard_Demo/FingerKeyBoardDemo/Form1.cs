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

namespace FingerKeyBoardDemo
{
    public partial class Form1 : Form
    {
        int shift = 0;
        const byte VK_A = 0x41;
        const byte VK_B = 0x42;
        const byte VK_C = 0x43;
        const byte VK_D = 0x44;
        const byte VK_E = 0x45;
        const byte VK_F = 0x46;
        const byte VK_G = 0x47;
        const byte VK_H = 0x48;
        const byte VK_I = 0x49;
        const byte VK_J = 0x4A;
        const byte VK_K = 0x4B;
        const byte VK_L = 0x4C;
        const byte VK_M = 0x4D;
        const byte VK_N = 0x4E;
        const byte VK_O = 0x4F;
        const byte VK_P = 0x50;
        const byte VK_Q = 0x51;
        const byte VK_R = 0x52;
        const byte VK_S = 0x53;
        const byte VK_T = 0x54;
        const byte VK_U = 0x55;
        const byte VK_V = 0x56;
        const byte VK_W = 0x57;
        const byte VK_X = 0x58;
        const byte VK_Y = 0x59;
        const byte VK_Z = 0x5A;

        const byte VK_OEM_COMMA = 0xBC; // ,
        const byte VK_OEM_PERIOD = 0xBE; // .
        const byte VK_OEM_1 = 0xBA;
        const byte VK_BACK = 0x08;
        const byte VK_RETURN = 0x0D;
        const byte VK_SPACE = 0x20;
        const byte VK_LWIN = 0x5B;
        const byte VK_HANGUL = 0x15;
        const byte VK_SHIFT = 0x10;

        private const long WM_NOACTIVATE = 0x8000000L;


        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | (int)WM_NOACTIVATE;
                return cp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_Q, shift);
            shift = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_W, shift);
            shift = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_E, shift);
            shift = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_R, shift);
            shift = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_T, shift);
            shift = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_Y, shift); shift = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_U, shift); shift = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_I, shift); shift = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_O, shift); shift = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_P, shift); shift = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_A, shift); shift = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_S, shift); shift = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_D, shift); shift = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_F, shift); shift = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_G, shift); shift = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_H, shift); shift = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_J, shift); shift = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_K, shift); shift = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_L, shift); shift = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_OEM_1, shift); shift = 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_Z, shift); shift = 0;
        }

        private void button22_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_X, shift); shift = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_C, shift);
            shift = 0;

        }

        private void button24_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_V, shift); shift = 0;
        }

        private void button25_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_B, shift); shift = 0;
        }

        private void button26_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_N, shift); shift = 0;
        }

        private void button27_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_M, shift); shift = 0;
        }

        private void button28_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_OEM_COMMA, shift); shift = 0;
        }

        private void button29_Click(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_OEM_PERIOD, shift); shift = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BackSpace(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_BACK, 0);
        }

        private void ENTER(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_RETURN, 0);
        }

        private void WINDOW(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_LWIN, 0);
        }

        private void SPACE(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_SPACE, 0);
        }

        private void Hangul(object sender, EventArgs e)
        {

            KeyBoardInput.KeyClick(VK_HANGUL, 0);
        }

        private void SHIFT(object sender, EventArgs e)
        {
            shift = 1;
        }

    }
}
