using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public partial class GridView : ContentView
    {
        public GridView()
        {
            InitializeComponent();
        }

        private void scrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            container.ScrollX = e.ScrollX;
        }
    }
}