// Models/Book.cs
using System.ComponentModel;

namespace BookManager.Models
{
    public class Book : INotifyPropertyChanged
    {
        private string _title;
        private string _author;
        private int _year;
        private string _genre;
        private int _pageCount;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        public string Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }
        public int Year
        {
            get => _year;
            set
            {
                _year = value;
                OnPropertyChanged(nameof(Year));
            }
        }
        public string Genre
        {
            get => _genre;
            set
            {
                _genre = value;
                OnPropertyChanged(nameof(Genre));
            }
        }
        public int PageCount
        {
            get => _pageCount;
            set
            {
                _pageCount = value;
                OnPropertyChanged(nameof(PageCount));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
