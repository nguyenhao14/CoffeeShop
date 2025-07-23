using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop.Client.Forms
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (cpbBackground.Value >= 100)
            {
                timerLoading.Stop();
                this.Hide();

                // Chuyển sang form chính
            }
            else
            {
                cpbBackground.Value += 1;
            }
        }


        private void Loading_Load(object sender, EventArgs e)
        {
            timerLoading.Start();
        }

    }
}
