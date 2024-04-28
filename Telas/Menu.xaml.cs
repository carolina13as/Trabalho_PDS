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
using System.Windows.Shapes;

namespace _01_PDS__Trabalho.Telas
{
    /// <summary>
    /// Lógica interna para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
      
        public Menu()
        {
            InitializeComponent();
       
         
        }

        public void Open_Page(string menu)
        {
            switch (menu)
            {
                case "EscolaPage":
                    framePage.NavigationService.Navigate(new EscolaPage(this));
                    break;

                case "GridEscola":
                    framePage.NavigationService.Navigate(new GridEscola(this));
                    break;

                case "CursoPage":
                    framePage.NavigationService.Navigate(new CursoPage(this));
                    break;

                case "GridCurso":
                    framePage.NavigationService.Navigate(new GridCurso(this));
                    break;

                case "TurmaPage":
                    framePage.NavigationService.Navigate(new TurmaPage(this));
                    break;

                case "GridTurma":
                    framePage.NavigationService.Navigate(new GridTurma(this));
                    break;

                case "AlunoPage":
                    framePage.NavigationService.Navigate(new AlunoPage(this));
                    break;

                case "GridAluno":
                    framePage.NavigationService.Navigate(new GridAluno(this));
                    break;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
           Open_Page("AlunoPage");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
            Open_Page("CursoPage");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
          
          Open_Page("TurmaPage");
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Open_Page("EscolaPage");
        }

      
    }
}
