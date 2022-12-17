using booklibrary.Abstractions;
using booklibrary.DataAccess;
using booklibrary.ViewModel;
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
using System.Xml.Linq;

namespace booklibrary.Views
{
    /// <summary>
    /// Interaction logic for LibrarianWindow.xaml
    /// </summary>
    public partial class LibrarianWindow : Window
    {
        public LibrarianWindow()
        {
            InitializeComponent();
            var bookRepo = new BookRepository();
            var mw = new LibrarianViewModel(bookRepo);
            mw.TxtId = Idtextbox;
            mw.TxtName = Nametextbox;
            mw.TxtPages= Pagestextbox;
            mw.TxtQuantity= Quantitytextbox;
            this.DataContext = mw;
        }
    }
}
