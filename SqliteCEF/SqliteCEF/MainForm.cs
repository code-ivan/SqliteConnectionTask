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
        SQLiteConnector dbConnection = SQLiteConnector.Instance();

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
                DbRoot.Text = openFileDialog1.FileName;
            }
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            if(DbRoot.Text != string.Empty)
            {
                try
                {
                    string root = DbRoot.Text;
                    dbConnection.Root = root;
                    if (dbConnection.IsConnect())
                    {
                        Connect_Button.Enabled = false;
                        Close_Button.Enabled = true;
                        CreateCef_Button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");
                    }
                }
                catch(Exception message)
                {
                    MessageBox.Show(message.Message);
                }
            }
        
        }

        private void CreateCef_Button_Click(object sender, EventArgs e)
        {

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Close();
                Connect_Button.Enabled = true;
                Close_Button.Enabled = false;
                CreateCef_Button.Enabled = false;
            }
            catch(Exception message)
            {
                MessageBox.Show(message.Message);
            }
            
        }
    }
}
