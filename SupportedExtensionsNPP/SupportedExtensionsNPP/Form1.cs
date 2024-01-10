using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupportedExtensionsNPP
{
    public partial class Form1 : Form
    {
        string[] supportedExtensions = { "Notepad", "ms ini/inf", "c, c++, objc", "java, c#, pascal", "web script", "public script", "property script", "fortran, TeX, SQL", "misc" };
        string[][] extensions = new string[][]
        {
            new string[] { ".txt", ".log" },
            new string[] { ".ini", ".inf" },
            new string[] { ".h", ".hh", ".hpp", ".hxx", ".c", ".cpp", ".cxx", ".cc", ".m", ".mm", ".vcxproj", ".vcproj", ".props", ".vsprops", ".manifest" },
            new string[] { ".java", ".cs", ".pas", ".pp", ".inc" },
            new string[] { ".html", ".htm", ".shtml", ".shtm", ".hta", ".asp", ".aspx", ".css", ".js", ".json", ".jsm", ".jsp", ".php", ".php3", ".php4", ".php5", ".phps", ".phpt", ".phtml", ".xml", ".xhtml", ".xht", ".xul", ".kml", ".xaml", ".xsml" },
            new string[] { ".sh", ".bsh", ".bash", ".bat", ".cmd", ".nsi", ".nsh", ".lua", ".pl", ".pm", ".py" },
            new string[] { ".rc", ".as", ".mx", ".vb", ".vbs" },
            new string[] { ".f", ".for", ".f90", ".f95", ".f2k", ".tex", ".sql" },
            new string[] { ".nfo", ".mak" }
        };
        //string[] notepad = { ".txt", ".log" };
        //string[] msIniInf = { ".ini", ".inf" };
        //string[] cCppObjc = { ".h", ".hh", ".hpp", ".hxx", ".c", ".cpp", ".cxx", ".cc", ".m", ".mm", ".vcxproj", ".vcproj", ".props", ".vsprops", ".manifest" };
        //string[] javaCsPascal = { ".java", ".cs", ".pas", ".pp", ".inc" };
        //string[] webScript = { ".html", ".htm", ".shtml", ".shtm", ".hta", ".asp", ".aspx", ".css", ".js", ".json", ".jsm", ".jsp", ".php", ".php3", ".php4", ".php5", ".phps", ".phpt", ".phtml", ".xml", ".xhtml", ".xht", ".xul", ".kml", ".xaml", ".xsml" };
        //string[] publicScript = { ".sh", ".bsh", ".bash", ".bat", ".cmd", ".nsi", ".nsh", ".lua", ".pl", ".pm", ".py" };
        //string[] propertyScript = { ".rc", ".as", ".mx", ".vb", ".vbs" };
        //string[] fortranTexSql = { ".f", ".for", ".f90", ".f95", ".f2k", ".tex", ".sql" };
        //string[] misc = { ".nfo", ".mak" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string supportedExt in supportedExtensions)
            {
                listBox1.Items.Add(supportedExt);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (listBox1.Text == "Notepad")
            {
                foreach (string note in extensions[0])
                {
                    listBox2.Items.Add(note);
                    if (listBox3.Items.Contains(note))
                    {
                        listBox2.Items.Remove(note);
                    }
                }
            }
            else if (listBox1.Text == "ms ini/inf")
            {
                foreach (string msIni in extensions[1])
                {
                    if (!listBox3.Items.Contains(msIni))
                    {
                        listBox2.Items.Add(msIni);
                    }
                }
            }
            else if (listBox1.Text == "c, c++, objc")
            {
                foreach (string cCpp in extensions[2])
                {
                    if (!listBox3.Items.Contains(cCpp))
                    {
                        listBox2.Items.Add(cCpp);
                    }
                }
            }
            else if (listBox1.Text == "java, c#, pascal")
            {
                foreach (string javaCs in extensions[3])
                {
                    if (!listBox3.Items.Contains(javaCs))
                    {
                        listBox2.Items.Add(javaCs);
                    }
                }
            }
            else if (listBox1.Text == "web script")
            {
                foreach (string web in extensions[4])
                {
                    if (!listBox3.Items.Contains(web))
                    {
                        listBox2.Items.Add(web);
                    }
                }
            }
            else if (listBox1.Text == "public script")
            {
                foreach (string public1 in extensions[5])
                {
                    if (!listBox3.Items.Contains(public1))
                    {
                        listBox2.Items.Add(public1);
                    }
                }
            }
            else if (listBox1.Text == "property script")
            {
                foreach (string property1 in extensions[6])
                {
                    if (!listBox3.Items.Contains(property1))
                    {
                        listBox2.Items.Add(property1);
                    }
                }
            }
            else if (listBox1.Text == "fortran, TeX, SQL")
            {
                foreach (string fortranTex in extensions[7])
                {
                    if (!listBox3.Items.Contains(fortranTex))
                    {
                        listBox2.Items.Add(fortranTex);
                    }
                }
            }
            else if (listBox1.Text == "misc")
            {
                foreach (string m in extensions[8])
                {
                    if (!listBox3.Items.Contains(m))
                    {
                        listBox2.Items.Add(m);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox3.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string[] extension in extensions)
            {
                
            }
        }
    }
}
