using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LightTalkChatBubble
{
    class CSetLineSpace
    {
        public const int WM_USER = 0x0400;
        public const int EM_GETPARAFORMAT = WM_USER + 61;
        public const int EM_SETPARAFORMAT = WM_USER + 71;
        public const long MAX_TAB_STOPS = 32;
        public const uint PFM_LINESPACING = 0x00000100;
        [StructLayout(LayoutKind.Sequential)]
        private struct PARAFORMAT2
        {
            public int cbSize;
            public uint dwMask;
            public short wNumbering;
            public short wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public short wAlignment;
            public short cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public int[] rgxTabs;
            public int dySpaceBefore;
            public int dySpaceAfter;
            public int dyLineSpacing;
            public short sStyle;
            public byte bLineSpacingRule;
            public byte bOutlineLevel;
            public short wShadingWeight;
            public short wShadingStyle;
            public short wNumberingStart;
            public short wNumberingStyle;
            public short wNumberingTab;
            public short wBorderSpace;
            public short wBorderWidth;
            public short wBorders;
        }

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, ref PARAFORMAT2 lParam);

        /// <summary>
        /// 设置行距
        /// </summary>
        /// <param name="ctl">控件</param>
        /// <param name="dyLineSpacing">间距</param>
        public static void SetLineSpace(Control ctl, int dyLineSpacing)
        {
            PARAFORMAT2 fmt = new PARAFORMAT2();
            fmt.cbSize = Marshal.SizeOf(fmt);
            fmt.bLineSpacingRule = 100;// bLineSpacingRule;
            fmt.dyLineSpacing = dyLineSpacing;
            fmt.dwMask = PFM_LINESPACING;
            try
            {
                SendMessage(new HandleRef(ctl, ctl.Handle), EM_SETPARAFORMAT, 0, ref fmt);
            }
            catch
            {

            }
        }

        public struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, ref Rect lParam);//

        private const int EM_GETRECT = 0x00b2;
        private const int EM_SETRECT = 0x00b3;

        RichTextBox rtb;



        public Rect RichTextBoxMargin
        {
            get
            {
                Rect rect = new Rect();
                SendMessage(rtb.Handle, EM_GETRECT, IntPtr.Zero, ref rect);
                rect.Left += 1;
                rect.Top += 1;
                rect.Right = 1 + rtb.ClientSize.Width - rect.Right;
                rect.Bottom = rtb.ClientSize.Height - rect.Bottom;
                return rect;
            }
            set
            {
                Rect rect;
                rect.Left = rtb.ClientRectangle.Left + value.Left;
                rect.Top = rtb.ClientRectangle.Top + value.Top;
                rect.Right = rtb.ClientRectangle.Right - value.Right;
                rect.Bottom = rtb.ClientRectangle.Bottom - value.Bottom;

                SendMessage(rtb.Handle, EM_SETRECT, IntPtr.Zero, ref rect);
            }

        }

        //设置
        public void setMargin(RichTextBox rtb, int left,int right,int top,int buttom)
        {
            this.rtb = rtb;
            
            Rect rect;
            rect.Left = left;
            rect.Top = top;
            rect.Right = right;
            rect.Bottom = buttom;

            RichTextBoxMargin = rect;
        }
    }
}
