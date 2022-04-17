using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMapsWebApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string street = txt_street.Text;
            string city = txt_city.Text;
            string state = txt_state.Text;
            string zip = txt_zip.Text;
            string lat = txt_lat.Text;
            string lon = txt_lon.Text;
            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("https://google.com/maps/place/");

            string[] info = { street, city, state, zip };
            for (int i = 0; i < info.Length; i++)
            {
                if (info[i] != string.Empty)
                {
                    queryAddress.Append($"{info[i]},+");
                }
            }

            if (lat != string.Empty && lon != string.Empty)
            {
                queryAddress.Append($"/@{lat},{lon},18z");
            }

            webBrowser1.Navigate(queryAddress.ToString());
        }
    }
}
