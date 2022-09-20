using CinemaWithMVVM.ViewModels;
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

namespace CinemaWithMVVM.Views.UserControls
{
    /// <summary>
    /// Interaction logic for MovieCellUC.xaml
    /// </summary>
    public partial class MovieCellUC : UserControl
    {
        public MovieCellUC(MovieCellViewModel movieCellViewModel)
        {
            InitializeComponent();
            movieCellViewModel.StarsPanel = starsPanel;
            this.DataContext = movieCellViewModel;
        }
    }
}
