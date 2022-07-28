using FMUtils.KeyboardHook;
using SimWinInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace StrafeOptimizer
{
    public partial class Window : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }
        
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            return lpPoint;
        }

        private bool wCanStrafe = false;
        private bool aCanStrafe = true;
        private bool sCanStrafe = false;
        private bool dCanStrafe = true;
        private bool wStrafing = false;
        private bool aStrafing = false;
        private bool sStrafing = false;
        private bool dStrafing = false;
        private bool enabled = false;
        private Timer timer;

        private Color enabledColour = Color.Lime;
        private Hook keyboardHook;

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            keyboardHook = new Hook("Strafe Keyboard Hook");
            keyboardHook.KeyDownEvent += KeyDown;
            keyboardHook.KeyUpEvent += KeyUp;
            

            timer = new Timer();
            timer.Tick += new EventHandler(Tick);
            timer.Interval = 1;
            timer.Start();

            speed.Maximum = (decimal)(SystemParameters.VirtualScreenWidth / 10);
            speed.Value = (decimal)(SystemParameters.VirtualScreenWidth / 100);

            wStrafe.BackColor = wCanStrafe ? enabledColour : Color.White;
            aStrafe.BackColor = aCanStrafe ? enabledColour : Color.White;
            sStrafe.BackColor = sCanStrafe ? enabledColour : Color.White;
            dStrafe.BackColor = dCanStrafe ? enabledColour : Color.White;
        }

        private void wStrafe_Click(object sender, EventArgs e)
        {
            wCanStrafe = !wCanStrafe;
            wStrafe.BackColor = wCanStrafe ? enabledColour : Color.White;
        }

        private void aStrafe_Click(object sender, EventArgs e)
        {
            aCanStrafe = !aCanStrafe;
            aStrafe.BackColor = aCanStrafe ? enabledColour : Color.White;
        }

        private void sStrafe_Click(object sender, EventArgs e)
        {
            sCanStrafe = !sCanStrafe;
            sStrafe.BackColor = sCanStrafe ? enabledColour : Color.White;
        }

        private void dStrafe_Click(object sender, EventArgs e)
        {
            dCanStrafe = !dCanStrafe;
            dStrafe.BackColor = dCanStrafe ? enabledColour : Color.White;
        }

        private void enable_Click(object sender, EventArgs e)
        {
            enabled = !enabled;
            enable.BackColor = enabled ? enabledColour : Color.White;
            enable.Text = enabled ? "Disable" : "Enable";
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/darraghd493");
        }
        
        private void KeyDown(KeyboardHookEventArgs e)
        {
            switch (e.Key)
            {
                case Keys.W:
                    if (wCanStrafe)
                    {
                        wStrafing = true;
                    }
                    break;
                case Keys.A:
                    if (aCanStrafe)
                    {
                        aStrafing = true;
                    }
                    break;
                case Keys.S:
                    if (sCanStrafe)
                    {
                        sStrafing = true;
                    }
                    break;
                case Keys.D:
                    if (dCanStrafe)
                    {
                        dStrafing = true;
                    }
                    break;
            }
        }

        private void KeyUp(KeyboardHookEventArgs e)
        {
            switch (e.Key)
            {
                case Keys.W:
                    wStrafing = false;
                    break;
                case Keys.A:
                    aStrafing = false;
                    break;
                case Keys.S:
                    sStrafing = false;
                    break;
                case Keys.D:
                    dStrafing = false;
                    break;
            }
        }

        private void Tick(object sender, EventArgs e)
        {
            double strafeDirection = 0;

            if (!enabled)
                return;

            if (aStrafing)
            {
                strafeDirection -= Double.Parse(speed.Value.ToString());
            }

            if (dStrafing)
            {
                strafeDirection += Double.Parse(speed.Value.ToString());
            }

            if (wStrafing)
            {
                if (strafeDirection != 0)
                {
                    strafeDirection = strafeDirection / 2;
                }
            }

            if (sStrafing)
            {
                if (strafeDirection != 0)
                {
                    strafeDirection = strafeDirection / 2;
                }
            }

            if (wStrafing && sStrafing)
            {
                strafeDirection = 0;
            }

            Point from = GetCursorPosition();
            Point to = new Point((int)(from.X + strafeDirection / 5), from.Y);
            SimMouse.Act(SimMouse.Action.MoveOnly, to.X, to.Y);
        }
    }
}
