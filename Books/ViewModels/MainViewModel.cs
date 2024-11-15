// ViewModels/MainViewModel.cs
using BookManager.Models;
using Books.View;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;


namespace BookManager.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Book> _books;
        public ICommand AddBookCommand { get; }
        public ICommand EditBookCommand { get; }
        public ICommand DeleteBookCommand { get; }
        public ObservableCollection<Book> Books {
            get => _books;
            set
            {
                _books = value;
                OnPropertyChanged(nameof(Books));
            }
        }
        private Book _selectedBook;
        public Book SelectedBook
        {
            get => _selectedBook;
            set
            {
                _selectedBook = value;
                OnPropertyChanged(nameof(SelectedBook));
            }
        }
        public MainViewModel()
        {
            Books = new ObservableCollection<Book>();
        }
        public void AddBook()
        {
            var addBookWindow = new MakeBooks();
            if (addBookWindow.ShowDialog() == true)
            {
                var newBook = addBookWindow.Book;
                if (newBook != null)
                Books.Add(newBook);
            }
        }
        public void EditBook()
        {
            if (SelectedBook != null)
            {
                var addBookWindow = new MakeBooks(SelectedBook);
                if (addBookWindow.ShowDialog() == true)
                {
                    var updatedBook = addBookWindow.Book;
                    SelectedBook = updatedBook;
                }
            }
        }
        public void DeleteBook()
        {
            Books.Remove(SelectedBook);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
