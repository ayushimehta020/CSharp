using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileAssociationNPP
{
    public partial class Form1 : Form
    {
        private string[] supportedExtensions = new string[] { "Notepad", "ms ini/inf", "c, c++, objc", "java, c#, pascal", "web script", "public script", "property script", "fortran, TeX, SQL", "misc" };
        private string[] notepad = new string[] { ".txt", ".log" };
        private string[] msIniInf = new string[] { ".ini", ".inf" };
        private string[] cCppObjc = new string[] { ".h", ".hh", ".hpp", ".hxx", ".c", ".cpp", ".cxx", ".cc", ".m", ".mm", ".vcxproj", ".vcproj", ".props", ".vsprops", ".manifest" };
        private string[] javaCsPascal = new string[] { ".java", ".cs", ".pas", ".pp", ".inc" };
        private string[] webScript = new string[] { ".html", ".htm", ".shtml", ".shtm", ".hta", ".asp", ".aspx", ".css", ".js", ".json", ".jsm", ".jsp", ".php", ".php3", ".php4", ".php5", ".phps", ".phpt", ".phtml", ".xml", ".xhtml", ".xht", ".xul", ".kml", ".xaml", ".xsml" };
        private string[] publicScript = new string[] { ".sh", ".bsh", ".bash", ".bat", ".cmd", ".msi", ".msh", ".lua", ".pl", ".pm", ".py" };
        private string[] propertyScript = new string[] { ".rc", ".as", ".mx", ".vb", ".vbs" };
        private string[] fortranTexSql = new string[] { ".f", ".for", ".f90", ".f95", ".f2k", ".tex", ".sql" };
        private string[] misc = new string[] { ".nfo", ".mak" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string supported in supportedExtensions)
            {
                listBox1.Items.Add(supported);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (listBox1.Text == "Notepad")
            {
                display(notepad);
            }
            else if (listBox1.Text == "ms ini/inf")
            {
                display(msIniInf);
            }
            else if (listBox1.Text == "c, c++, objc")
            {
                display(cCppObjc);
            }
            else if (listBox1.Text == "java, c#, pascal")
            {
                display(javaCsPascal);
            }
            else if (listBox1.Text == "web script")
            {
                display(webScript);
            }
            else if (listBox1.Text == "public script")
            {
                display(publicScript);
            }
            else if (listBox1.Text == "property script")
            {
                display(propertyScript);
            }
            else if (listBox1.Text == "fortran, TeX, SQL")
            {
                display(fortranTexSql);
            }
            else if (listBox1.Text == "misc")
            {
                display(misc);
            }
        }

        private string display(string[] res)
        {
            foreach (string res1 in res)
            {
                return Convert.ToString(listBox2.Items.Add(res));
            }
        }
    }
}
