using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Levisploit
{
    public partial class Form1 : Form
    {
        // FONT PRESETUP
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        // FONT PRESETUP END

        public Form1()
        {
            // FONT SETUP
            byte[] fontData = Properties.Resources.font;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.font.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.font.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            // FONT SETUP END //

            // DIRECTORYS SETUP
            if (!Directory.Exists(@Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts")))
            {
                Directory.CreateDirectory("scripts");
                System.Diagnostics.Process.Start("discord:///invite-proxy/418434272530137088");
            }
            if (!Directory.Exists(@Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "autoexec")))
            {
                Directory.CreateDirectory("autoexec");
                System.Diagnostics.Process.Start("discord:///invite-proxy/418434272530137088");
            }
            if (!Directory.Exists(@Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Monaco")))
            {
                MessageBox.Show("Incorrect installation!", "Please put the Monaco folder into the same folder as Levisploit.exe!");
            }
            if (File.Exists(@Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Levisploit.old")))
            {
                File.Delete(@Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Levisploit.old"));
            }
            // DIRECTORYS SETUP END //
            

            InitializeComponent();
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                string friendlyName = AppDomain.CurrentDomain.FriendlyName;
                bool flag2 = registryKey.GetValue(friendlyName) == null;
                if (flag2)
                {
                    registryKey.SetValue(friendlyName, 11001, RegistryValueKind.DWord);
                }
                registryKey = null;
                friendlyName = null;
            }
            catch (Exception)
            {
            }
            MonacoTextbox.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));

            MonacoTextbox.Document.InvokeScript("SetTheme", new string[]
{
                   "Dark"
});
            addBase();
            addMath();
            addGlobalNS();
            addGlobalV();
            addGlobalF();
            MonacoTextbox.Document.InvokeScript("SetText", new object[]
            {
                 ""
            });
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
        // DRAGGABLE END
        

        // MONACO PRESETUP

        private string defPath = Application.StartupPath + "//Monaco//";

        private void addIntel(string label, string kind, string detail, string insertText)
        {
            string text = "\"" + label + "\"";
            string text2 = "\"" + kind + "\"";
            string text3 = "\"" + detail + "\"";
            string text4 = "\"" + insertText + "\"";
            MonacoTextbox.Document.InvokeScript("AddIntellisense", new object[]
            {
                label,
                kind,
                detail,
                insertText
            });
        }

        private void addGlobalF()
        {
            string[] array = File.ReadAllLines(this.defPath + "//globalf.txt");
            foreach (string text in array)
            {
                bool flag = text.Contains(':');
                if (flag)
                {
                    this.addIntel(text, "Function", text, text.Substring(1));
                }
                else
                {
                    this.addIntel(text, "Function", text, text);
                }
            }
        }

        private void addGlobalV()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalv.txt"))
            {
                this.addIntel(text, "Variable", text, text);
            }
        }

        private void addGlobalNS()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalns.txt"))
            {
                this.addIntel(text, "Class", text, text);
            }
        }

        private void addMath()
        {
            foreach (string text in File.ReadLines(this.defPath + "//classfunc.txt"))
            {
                this.addIntel(text, "Method", text, text);
            }
        }

        private void addBase()
        {
            foreach (string text in File.ReadLines(this.defPath + "//base.txt"))
            {
                this.addIntel(text, "Keyword", text, text);
            }
        }

        // MONACO PRESETUP END //

        // MONACO THEME SETUP

        private async void MonacoTextbox_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            await Task.Delay(1);
            MonacoTextbox.Document.InvokeScript("SetTheme", new string[] { "Dark" });
            addBase();
            addMath();
            addGlobalNS();
            addGlobalV();
            addGlobalF();
            MonacoTextbox.Document.InvokeScript("SetText", new object[]
            {""});
        }

        // MONACO THEME SETUP END //

        // CUSTOM MONACO FUNCTIONS

        public void setTextBox(string text)
        {
            MonacoTextbox.Document.InvokeScript("SetText", new object[] { text });
        }

        private string getText()
        {
            HtmlDocument document = MonacoTextbox.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();

            return script;
        }

        // CUSTOM MONACO FUNCTIONS END //

        // CUSTOM EXPLOIT FUNCTIONS
        public void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();
        }

        public void Execute(string script)
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                NamedPipes.LuaPipe(script);
            }
            else
            {
                MessageBox.Show($"Attach Levisploit before executing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void Inject()
        {
            Functions.Inject();
        }

        // CUSTOM EXPLOIT FUNCTIONS END //
        bool attached = false;
        private void statusTimer_Tick(object sender, EventArgs e)
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                if (!attached)
                {
                    DirectoryInfo dinfo = new DirectoryInfo(@Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "autoexec"));
                    var Files = dinfo.GetFiles("*.txt").Concat(dinfo.GetFiles("*.lua"));
                    foreach (FileInfo file in Files)
                    {
                        string var = @Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "autoexec");
                        Execute(File.ReadAllText(@Path.Combine(var, file.Name)));
                    }
                    attached = true;
                }
            }
            else
            {
                attached = false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            Execute(getText());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            setTextBox("");
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Text files|*.txt|Lua files|*.lua";
                openFileDialog1.Title = "Open a script file.";
                openFileDialog1.InitialDirectory = @Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts");
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    setTextBox(File.ReadAllText(openFileDialog1.FileName));
                }
            }
        }

        private void executeFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files|*.txt|Lua files|*.lua";
            openFileDialog1.Title = "Execute a script file.";
            openFileDialog1.InitialDirectory = @Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts");
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Execute(File.ReadAllText(openFileDialog1.FileName));
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Text files|*.txt|Lua files|*.lua";
            sfd.Title = "Save your script.";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.Write(getText());
                }
            }
        }

        private void scriptListButton_Click(object sender, EventArgs e)
        { 
            var scriptListForm = (Form)Application.OpenForms["Form2"];
            if (scriptListForm == null)
            {
                scriptListForm = new Form2(this);
                scriptListForm.Show();
            }
            else
            {
                scriptListForm.Close();
                scriptListForm = new Form2(this);
                scriptListForm.Show();
            }
        }


        private void scriptHubButton_Click(object sender, EventArgs e)
        {
            var scriptHubForm = (Form)Application.OpenForms["Form3"];
            if (scriptHubForm == null)
            {
                scriptHubForm = new Form3(this);
                scriptHubForm.Show();
            }
            else
            {
                scriptHubForm.Close();
                scriptHubForm = new Form3(this);
                scriptHubForm.Show();
            }
        }


        private void openSettingsButton_Click(object sender, EventArgs e)
        {
            var settingsForm = (Form)Application.OpenForms["Form4"];
            if (settingsForm == null)
            {
                settingsForm = new Form4(this);
                settingsForm.Show();
            }
            else
            {
                settingsForm.Close();
                settingsForm = new Form4(this);
                settingsForm.Show();
            }
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
        var t = new Task(() => Inject());

        t.Start();
        }


        public async Task FadeToColor(int r, int g, int b, Control c)
        {

            while (c.ForeColor.R > r)
            {
                c.ForeColor = Color.FromArgb(c.ForeColor.R - 1, c.ForeColor.G, c.ForeColor.B);
                await Task.Delay(10);
            }
            while (c.ForeColor.R < r)
            {
                c.ForeColor = Color.FromArgb(c.ForeColor.R + 1, c.ForeColor.G, c.ForeColor.B);
                await Task.Delay(10);
            }

            while (c.ForeColor.G > g)
            {
                c.ForeColor = Color.FromArgb(c.ForeColor.R, c.ForeColor.G - 1, c.ForeColor.B);
                await Task.Delay(10);
            }
            while (c.ForeColor.G < g)
            {
                c.ForeColor = Color.FromArgb(c.ForeColor.R, c.ForeColor.G + 1, c.ForeColor.B);
                await Task.Delay(10);
            }

            while (c.ForeColor.B > b)
            {
                c.ForeColor = Color.FromArgb(c.ForeColor.R, c.ForeColor.G, c.ForeColor.B - 1);
                await Task.Delay(10);
            }
            while (c.ForeColor.B < b)
            {
                c.ForeColor = Color.FromArgb(c.ForeColor.R, c.ForeColor.G, c.ForeColor.B + 1);
                await Task.Delay(10);
            }
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<Control> allControls = GetAllControls(this);
            allControls.ForEach(k => k.Font = new System.Drawing.Font(fonts.Families[0], k.Font.Size));

            while (true)
            {
                await FadeToColor(255, 200, 200, titleLabel);
                await FadeToColor(255, 255, 200, titleLabel);
                await FadeToColor(200, 255, 200, titleLabel);
                await FadeToColor(200, 255, 255, titleLabel);
                await FadeToColor(200, 200, 255, titleLabel);
                await FadeToColor(255, 200, 255, titleLabel);
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
