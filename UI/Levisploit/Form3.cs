using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Levisploit
{
    public partial class Form3 : Form
    {
        private Form1 _masterForm;


        // FONT PRESETUP
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        // FONT PRESETUP END

        public Form3(Form1 masterForm)
        {
            InitializeComponent();
            _masterForm = masterForm;
            // FONT SETUP
            byte[] fontData = Properties.Resources.font;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.font.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.font.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            // FONT SETUP END //
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(_masterForm.Location.X - (this.Size.Width + 10), _masterForm.Location.Y);
        }


        // DRAGGABLE
        private bool mouseDown;
        private Point lastLocation;

        private void titleLabel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void titleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void titleLabel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mouseDown = false;
            lastLocation = e.Location;
        }
       
        //DRAGGABLE END

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        

        private void gotoButton_Click(object sender, EventArgs e)
        {
            _masterForm.Execute("local search = '" + targetBox.Text + "'\nlocal player = game.Players:getChildren()\nfor i=1,#player do\nif string.match(string.lower(player[i].Name), string.lower(search)) then\ngame.Players.LocalPlayer.Character:MoveTo(player[i].Character.Head.Position)\nend\nend\n");
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            _masterForm.Execute("local search = '" + targetBox.Text + "'\nlocal player = game.Players:getChildren()\nfor i=1,#player do\nif string.match(string.lower(player[i].Name), string.lower(search)) then\nlocal cam = workspace.CurrentCamera\ncam.CameraSubject = player[i].Character.Humanoid\nend\nend\n");
        }

        private void unviewButton_Click(object sender, EventArgs e)
        {
            _masterForm.Execute("local cam = workspace.CurrentCamera\ncam.CameraSubject = game.Players.LocalPlayer.Character.Humanoid");
        }

        private void toggleHighlightButton_Click(object sender, EventArgs e)
        {
            _masterForm.Execute("local search = '" + targetBox.Text + "'\nlocal player = game.Players:getChildren()\nfor i=1,#player do\nif string.match(string.lower(player[i].Name), string.lower(search)) then\n\nif player[i].Character.HumanoidRootPart:findFirstChild('ESPPart') then\nplayer[i].Character.HumanoidRootPart.ESPPart:remove()\nelse\nlocal ESPPartparent = player[i].Character.HumanoidRootPart\nlocal Box = Instance.new('BoxHandleAdornment', player[i].Character.HumanoidRootPart)\nBox.Name = 'ESPPart'\nBox.Adornee = ESPPartparent\nBox.Size = Vector3.new(4,4,4)\nBox.Color3 = Color3.fromRGB(0, 255, 0)\nBox.AlwaysOnTop = true\nBox.ZIndex = 5\nBox.Transparency = 0.5\nBox.Parent = player[i].Character.HumanoidRootPart\nend\nend\n\nend\n");

        }

        private void WalkSpeedTrackBar_MouseUp(object sender, EventArgs e)
        {
            _masterForm.Execute("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = " + WalkSpeedTrackBar.Value);
        }

        private void JumpPowerTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            _masterForm.Execute("game.Players.LocalPlayer.Character.Humanoid.JumpPower = " + JumpPowerTrackBar.Value);
        }



        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }
        private List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }

        private void versionLabel_Click(object sender, EventArgs e)
        {
        }

        private void killRoblox_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("RobloxPlayerBeta"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
