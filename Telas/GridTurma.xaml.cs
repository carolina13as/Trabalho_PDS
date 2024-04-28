using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _01_PDS__Trabalho.Telas
{
    /// <summary>
    /// Interação lógica para GridTurma.xam
    /// </summary>
    public partial class GridTurma : Page
    {
        Menu _menu;
        public GridTurma(Menu menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _menu.Open_Page("TurmaPage");
        }
    }
}
