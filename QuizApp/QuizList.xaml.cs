using System;
using System.Collections.Generic;
using System.IO;
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
using Path = System.IO.Path;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for QuizList.xaml
    /// </summary>
    public partial class QuizList : UserControl
    {
        public QuizList()
        {
            InitializeComponent();
            loadQuizList();
        }

        private void backBtn(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Content = new QuizMenu();
        }

        private void loadQuizList()
        {
            string folderPath = "Data";
            // Clear the ListBox
            MainList.Items.Clear();
            if (Directory.Exists(folderPath))
            {
                // Get all .dat files in the specified folder
                string[] datFiles = Directory.GetFiles(folderPath, "*.dat");
                if (datFiles is not null)
                {
                    // Add each .dat file to the ListBox
                    foreach (string datFile in datFiles)
                    {
                        
                        MainList.Items.Add(Path.GetFileNameWithoutExtension(datFile));
                    }
                }else
                {
                    MessageBox.Show("Δεν Υπάρχουν Κουιζ στον Φάκελο", "Προσοχη");
                }
            }else
            {
                MessageBox.Show("Δεν Υπάρχει το folder", "Προσοχη");
            }
        }

        private void MainList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selected = MainList.SelectedItem.ToString()!;
            Window window = Window.GetWindow(this);
            window.Content = new PlayGame(selected);
        }
    }
}
