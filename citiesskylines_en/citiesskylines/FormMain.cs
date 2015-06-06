using System;
using System.IO;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ColossalFramework.IO;
using ColossalFramework.Globalization;

namespace CitiesSkylines
{
    delegate void SetTextCallback(string text);
    delegate void SetMaximum(int maximum);
    delegate void SetVisible(bool visible);
    delegate void SetValue(int value);

    public partial class FormMain : Form
    {
        string locale_name = "export";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            version.Focus();
            version.Text = "Ver. 1.3";
        }

        private void button_locale_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "locale File|*.locale";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                locale_path.Text = dialog.FileName;
                locale_name = Path.GetFileNameWithoutExtension(dialog.FileName);
                po_path.Text = Path.GetDirectoryName(dialog.FileName);
            }
        }

        private void button_po_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                po_path.Text = dialog.SelectedPath;
            }
        }

        private void export_ok_Click(object sender, EventArgs e)
        {
            if (File.Exists(locale_path.Text) && Directory.Exists(po_path.Text))
            {
                export_msg.Text = "";
                using (Stream stream = new FileStream(locale_path.Text, FileMode.Open, FileAccess.Read))
                {
                    Locale m_Locale = DataSerializer.Deserialize<Locale>(stream, DataSerializer.Mode.File);
                    Dictionary<Locale.Key, string> m_LocalizedStrings = Utils.GetPrivateField<Dictionary<Locale.Key, string>>(m_Locale, "m_LocalizedStrings");
                    Utils.ExportPOFile(Path.Combine(po_path.Text, locale_name + ".po"), m_LocalizedStrings);
                    export_msg.Text = "export success !";
                }
            }
            else
            {
                export_msg.Text = "file or directory not exist !";
            }
        }

        private void button_localeo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "locale File|*.locale";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                localeo_path.Text = dialog.FileName;
            }
        }

        private void button_ipo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "po File|*.po";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ipo_path.Text = dialog.FileName;
                olocale_path.Text = Path.Combine(Path.GetDirectoryName(dialog.FileName), "export.locale");
            }
        }

        private void button_olocale_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "locale File|*.locale";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                olocale_path.Text = dialog.FileName;
            }
        }

        private void import_ok_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Import));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void SetText(string text)
        {
            import_msg.Text = text;
        }

        private void SetMaximum(int maximum)
        {
            progress.Maximum = maximum;
        }

        private void SetVisible(bool visible)
        {
            progress.Visible = visible;
        }

        private void SetValue(int value)
        {
            progress.Value = value;
        }

        private void Import()
        {
            if (File.Exists(localeo_path.Text) && File.Exists(ipo_path.Text) && Directory.Exists(Path.GetDirectoryName(olocale_path.Text)))
            {
                if (import_msg.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { "" });
                }
                using (Stream stream = new FileStream(localeo_path.Text, FileMode.Open, FileAccess.Read))
                {
                    Locale m_Locale = DataSerializer.Deserialize<Locale>(stream, DataSerializer.Mode.File);
                    Dictionary<Locale.Key, string> m_LocalizedStrings = Utils.GetPrivateField<Dictionary<Locale.Key, string>>(m_Locale, "m_LocalizedStrings");
                    Dictionary<Locale.Key, string> l_LocalizedStrings = new Dictionary<Locale.Key, string>(m_LocalizedStrings);
                    List<string> lines = new List<string>();
                    using (StreamReader file = new StreamReader(ipo_path.Text))
                    {
                        string line;
                        while ((line = file.ReadLine()) != null)
                        {
                            lines.Add(line);
                        }
                    }
                    if (progress.InvokeRequired)
                    {
                        SetMaximum d = new SetMaximum(SetMaximum);
                        this.Invoke(d, new object[] { lines.Count });

                    }
                    if (progress.InvokeRequired)
                    {
                        SetVisible d = new SetVisible(SetVisible);
                        this.Invoke(d, new object[] { true });
                    }
                    Regex regex = new Regex(@"#. ""(.+)\[(.+)\]:(\d+)""|#. ""(.+):(\d+)""");
                    Regex regex_msgid = new Regex(@"msgid ""(.+)""");
                    Regex regex_msgstr = new Regex(@"msgstr ""(.+)""");
                    for (int i = 0; i < lines.Count; i++)
                    {
                        if (progress.InvokeRequired)
                        {
                            SetValue d = new SetValue(SetValue);
                            this.Invoke(d, new object[] { i + 1 });
                        }
                        if (i + 2 < lines.Count && regex.IsMatch(lines[i]))
                        {
                            string m_Identifier = regex.Match(lines[i]).Groups[1].Value.Length != 0 ? regex.Match(lines[i]).Groups[1].Value : regex.Match(lines[i]).Groups[4].Value;
                            string m_Index = regex.Match(lines[i]).Groups[3].Value.Length != 0 ? regex.Match(lines[i]).Groups[3].Value : regex.Match(lines[i]).Groups[5].Value;
                            string m_Key = regex.Match(lines[i]).Groups[2].Value.Length != 0 ? regex.Match(lines[i]).Groups[2].Value : null;
                            string msgid = regex_msgid.Match(lines[i + 1]).Groups[1].Value;
                            string msgstr = regex_msgstr.Match(lines[i + 2]).Groups[1].Value;
                            if (msgid.Length != 0 && msgstr.Length != 0)
                            {
                                Locale.Key key = new Locale.Key();
                                key.m_Identifier = m_Identifier;
                                key.m_Index = int.Parse(m_Index);
                                key.m_Key = m_Key;
                                if (l_LocalizedStrings.ContainsKey(key))
                                {
                                    l_LocalizedStrings.Remove(key);
                                    l_LocalizedStrings.Add(key, msgstr.Replace(@"\r", "\r").Replace(@"\n", "\n"));
                                }
                                else
                                {
                                    l_LocalizedStrings.Add(key, msgstr.Replace(@"\r", "\r").Replace(@"\n", "\n"));
                                }
                            }
                        }
                    }
                    string m_EnglishName = language_e.Text;
                    string m_NativeName = language.Text;
                    if (m_EnglishName.Length != 0)
                    {
                        Utils.SetPrivateField<string>(m_Locale, "m_EnglishName", m_EnglishName);
                    }
                    if (m_NativeName.Length != 0)
                    {
                        Utils.SetPrivateField<string>(m_Locale, "m_NativeName", m_NativeName);
                    }
                    Utils.SetPrivateField<Dictionary<Locale.Key, string>>(m_Locale, "m_LocalizedStrings", l_LocalizedStrings);
                    Utils.ExportFile(olocale_path.Text, m_Locale);
                    if (import_msg.InvokeRequired)
                    {
                        SetTextCallback d = new SetTextCallback(SetText);
                        this.Invoke(d, new object[] { "import success !" });
                    }
                    if (progress.InvokeRequired)
                    {
                        SetVisible d = new SetVisible(SetVisible);
                        this.Invoke(d, new object[] { false });
                    }
                }
            }
            else
            {
                if (import_msg.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { "file or directory not exist !" });
                }
            }
        }
    }
}
