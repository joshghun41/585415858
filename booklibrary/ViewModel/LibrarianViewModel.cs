using booklibrary.Abstractions;
using booklibrary.Commands;
using booklibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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

        public TextBox TxtId { get; set; }
        public TextBox TxtName { get; set; }
        public TextBox TxtPages { get; set; }
        public TextBox TxtQuantity { get; set; }

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
                int id = int.Parse(TxtId.Text);
                int pages = int.Parse(TxtPages.Text);
                int quantity = int.Parse(TxtQuantity.Text);
                AllBooks = _bookRepo.GetAllData();
                Book book = new Book
                {
                    Id = id,
                    Name = TxtName.Text,
                    Pages = pages,
                    Quantity = quantity
                };
                _bookRepo.InsertData(book);
            });
        }
    }
}
