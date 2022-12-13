using booklibrary.Abstractions;
using booklibrary.Commands;
using booklibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booklibrary.ViewModel
{
    public  class LibrarianViewModel:BaseViewModel
    {
        private IRepository<Book> _bookRepo;
        public RelayCommand ShowCommand { get; set; }
        public RelayCommand UpdateCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand InsertCommand { get; set; }
        private ObservableCollection<Book> allBooks;

        public ObservableCollection<Book> AllBooks
        {
            get { return allBooks; }
            set { allBooks = value; OnPropertyChanged(); }
        }
        public LibrarianViewModel(IRepository<Book> bookRepo)
        {

            _bookRepo = bookRepo;

            ShowCommand = new RelayCommand(l =>
            {
                AllBooks = _bookRepo.GetAllData();
            });

            UpdateCommand = new RelayCommand(l =>
            {

            });

            DeleteCommand = new RelayCommand(l =>
            {

            });

            InsertCommand = new RelayCommand(l =>
            {

            });
        }
    }
}
