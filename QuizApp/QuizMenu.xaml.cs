using System.Windows;
using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for QuizMenu.xaml
    /// </summary>
    public partial class QuizMenu : UserControl
    {
        public QuizMenu()
        {
            InitializeComponent();
        }

        public void Gameinfo(object sender, RoutedEventArgs e)
        {
            string Message = "Quiz App";
            Message += "\n";
            Message += "Όνομα Προγραμματιστή : Ψαλτάκης Νικόλαος";
            Message += "\n";
            Message += "Η Εφαρμογή δημιουργήθηκε με την γλώσσα προγραμματισμού dot net 7";
            MessageBox.Show(Message, "Πληροφορίες");
        }

        private void showList(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Content = new QuizList();
        }
    }
}
