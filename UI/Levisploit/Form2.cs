using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Levisploit
{
    public partial class Form2 : Form
    {
        private Form1 _masterForm;

        // FONT PRESETUP
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        // FONT PRESETUP END

        public Form2(Form1 masterForm)
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
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(_masterForm.Location.X + (_masterForm.Width + 10), _masterForm.Location.Y);

            List<Control> allControls = GetAllControls(this);
            allControls.ForEach(k => k.Font = new System.Drawing.Font(fonts.Families[0], k.Font.Size));

            DirectoryInfo dinfo = new DirectoryInfo(@Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts"));
            var Files = dinfo.GetFiles("*.txt").Concat(dinfo.GetFiles("*.lua"));
            foreach (FileInfo file in Files)
            {
                listBox1.Items.Add(file.Name);
            }
        }
        

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string var = @Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts");
                string script = System.IO.File.ReadAllText(@Path.Combine(var, listBox1.SelectedItem.ToString()));

                _masterForm.setTextBox(script);
            }
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
    }
}
