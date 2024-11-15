using BookManager.Models;
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

namespace Books.View
{
    /// <summary>
    /// Логика взаимодействия для MakeBooks.xaml
    /// </summary>
    public partial class MakeBooks : Window
    {
        public Book Book { get; private set; }
        public MakeBooks(Book book = null)
        {
            InitializeComponent();


            if (book != null)
            {
                Book = book;
                TitleTextBox.Text = book.Title;
                AuthorTextBox.Text = book.Author;
                YearTextBox.Text = book.Year.ToString();
                GenreTextBox.Text = book.Genre;
                PagesTextBox.Text = book.PageCount.ToString();
            }
            else
            {
                Book = new Book();
            }

        }
        private void SaveBook(object sender, RoutedEventArgs e)
        {
            Book.Title = TitleTextBox.Text;
            Book.Author = AuthorTextBox.Text;
            Book.Year = Int32.Parse(YearTextBox.Text);
            Book.Genre = GenreTextBox.Text;
            Book.PageCount = Int32.Parse(PagesTextBox.Text);
            DialogResult = true;
            this.Close();
        }

        private void CancelEditing(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }

}

