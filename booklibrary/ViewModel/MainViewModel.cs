using booklibrary.Commands;
using booklibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booklibrary.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public RelayCommand StudentCommand { get; set; }
        public RelayCommand LibrarianCommand { get; set; }
        public MainWindow mainwindow { get; set; }
        public MainViewModel()
        {
            LibrarianCommand = new RelayCommand(l =>
            {
                var librarianWindow = new LibrarianWindow();
                librarianWindow.Show();
                mainwindow.Close();
            });
            StudentCommand = new RelayCommand(l =>
            {
                var studentWindow = new StudentWindow();
                studentWindow.Show();
                mainwindow.Close();
            });
        }
    }
}
