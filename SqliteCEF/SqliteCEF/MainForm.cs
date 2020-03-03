using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqliteCEF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Close_Button.Enabled = false;
            CreateCef_Button.Enabled = false;
        }

        private void Browse_Button_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DbPath.Text = openFileDialog1.FileName;
            }
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            var dbConnection = SQLiteConnector.Instance();

            if (DbPath.Text != string.Empty)
            {
                if (DbPath.Text.Length > 4 && DbPath.Text.Substring(DbPath.Text.Length - 3) == ".db") 
                {
                    try
                    {
                        string root = DbPath.Text;
                        dbConnection.Path = root;
                        if (dbConnection.IsConnect())
                        {
                            Connect_Button.Enabled = false;
                            Browse_Button.Enabled = false;
                            Close_Button.Enabled = true;
                            CreateCef_Button.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Something gone wrong!");
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please, chose database from file explorer!");
                }   
            }
            else
            {
                MessageBox.Show("Please, chose database from file explorer!");
            }

        }

        private void CreateCef_Button_Click(object sender, EventArgs e)
        {
            var dbConnection = SQLiteConnector.Instance();

            if (DbPath.Text != String.Empty)
            {
                if (Query_TextBox.Text != String.Empty)
                {
                    try
                    {
                        CEFFormat cef = dbConnection.Select(Query_TextBox.Text).Result;
                        Cef_textBox.Text = cef.CreateFormat(" ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    queryError.Text = "Enter query first";
                }
            }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            var dbConnection = SQLiteConnector.Instance();
            try
            {
                dbConnection.Close();
                Connect_Button.Enabled = true;
                Browse_Button.Enabled = true;
                Close_Button.Enabled = false;
                CreateCef_Button.Enabled = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Query_TextBox_TextChanged(object sender, EventArgs e)
        {
            queryError.Text = string.Empty;
        }

    }
}
