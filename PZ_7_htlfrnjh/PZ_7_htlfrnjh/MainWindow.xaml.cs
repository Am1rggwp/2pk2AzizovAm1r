using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PZ_7_htlfrnjh
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        public bool isShowListFiles = false;
        bool isBold;
        bool isUnderline;
        bool isItalic;
        public string semple="Образец";
        public MainWindow()
        {
            InitializeComponent();

            if (isShowListFiles == false)
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\Users\amira\source\repos\Am1rggwp\2pk2AzizovAm1r\PZ_7_htlfrnjh\PZ_7_htlfrnjh\Data\");
                FileInfo[] files = dir.GetFiles("*.txt");
                foreach (FileInfo fi in files)
                {
                    phonesList.Items.Add(fi.ToString());
                }
                isShowListFiles = true;
            }

        }

        private void Button_Click_save(object sender, RoutedEventArgs e)
        {
           
            string r = $"{phonesList.SelectedItem}";
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\amira\source\repos\Am1rggwp\2pk2AzizovAm1r\PZ_7_htlfrnjh\PZ_7_htlfrnjh\Data\" + r);
            streamWriter.WriteLine(txtEditor.Text);
            streamWriter.Close();

            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            cursorPosition.Text = "строка: " + (row + 1) + ", столбец: " + (col + 1) + " Cохранено";

        }

        private void Button_Click_new(object sender, RoutedEventArgs e)
        {

            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
            {
                File.Create(@"C:\Users\amira\source\repos\Am1rggwp\2pk2AzizovAm1r\PZ_7_htlfrnjh\PZ_7_htlfrnjh\Data\" + $"{createFileWindow.FileName}" + ".txt");
                phonesList.Items.Add($"{createFileWindow.FileName}" + ".txt");
            }
            createFileWindow.Close();

        }

        private void Open_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстик (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                StreamReader reader = new StreamReader(fileInfo.Open(FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251));
                txtEditor.Text = reader.ReadToEnd();
                reader.Close();
                return;
            }
            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            cursorPosition.Text = "строка: " + (row + 1) + ", столбец: " + (col + 1) + " Cохранено";

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // не доделано
            string r = $"{phonesList.SelectedItem}";
            if (File.Exists(@"C:\Users\amira\source\repos\Am1rggwp\2pk2AzizovAm1r\PZ_7_htlfrnjh\PZ_7_htlfrnjh\Data\" + r))
            {
                File.Delete(@"C:\Users\amira\source\repos\Am1rggwp\2pk2AzizovAm1r\PZ_7_htlfrnjh\PZ_7_htlfrnjh\Data\" + r);
            }
            
        }

        private void phonesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string r = $"{phonesList.SelectedItem}";
            if (File.Exists(@"C:\Users\amira\source\repos\Am1rggwp\2pk2AzizovAm1r\PZ_7_htlfrnjh\PZ_7_htlfrnjh\Data\" + r))
            {
                txtEditor.Clear();
                FileStream open = new FileStream(@"C:\Users\amira\source\repos\Am1rggwp\2pk2AzizovAm1r\PZ_7_htlfrnjh\PZ_7_htlfrnjh\Data\" + $"{r}", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader file = new StreamReader(open);
                txtEditor.AppendText(file.ReadToEnd());
                file.Close();
            }

            if (isShowListFiles == false)
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\Users\amira\source\repos\Am1rggwp\2pk2AzizovAm1r\PZ_7_htlfrnjh\PZ_7_htlfrnjh\Data\");
                FileInfo[] files = dir.GetFiles("*.txt");
                foreach (FileInfo fi in files)
                {
                    phonesList.Items.Add(fi.ToString());
                }
                isShowListFiles = true;
            }
            FileInfo file1 = new FileInfo(@"C:\Users\amira\source\repos\Am1rggwp\2pk2AzizovAm1r\PZ_7_htlfrnjh\PZ_7_htlfrnjh\Data\" + $"{phonesList.SelectedItem}");
            DataTime.Text = $"{file1.CreationTime}   {file1.Length / 1024} Кб";

            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            cursorPosition.Text = "строка: " + (row + 1) + ", столбец: " + (col + 1) + " Cохранено";

        }

        private void txtEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            cursorPosition.Text = "строка: " + (row + 1) + ", столбец: " + (col + 1) + " Не сохранено";
        }

        private void Button_kursiv_Click(object sender, RoutedEventArgs e)
        {
            if (!isItalic)
                txtEditor.FontStyle = FontStyles.Italic;
            else
                txtEditor.FontStyle = FontStyles.Normal;
            isItalic = !isItalic;
        }

        private void Button_bold_Click_1(object sender, RoutedEventArgs e)
        {

            if (!isBold)
                txtEditor.FontWeight = FontWeights.Bold;
            else
                txtEditor.FontWeight = FontWeights.Normal;
            isBold = !isBold;

        }

        private void Button_Delet_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Clear();
        }

        private void Button_Click_podcher(object sender, RoutedEventArgs e)
        {
            if (this.isUnderline)
            {
                this.txtEditor.TextDecorations.Add(TextDecorations.Underline);
            }
            else
            {
                foreach (var item in TextDecorations.Underline)
                {
                    this.txtEditor.TextDecorations.Remove(item);
                }
            }
            isUnderline = !isUnderline;
        }

        private void txtEditor_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtEditor_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void DataTime_razmer(object sender, KeyEventArgs e)
        {
            FileInfo file1 = new FileInfo(@"C:\Users\amira\source\repos\Am1rggwp\2pk2AzizovAm1r\PZ_7_htlfrnjh\PZ_7_htlfrnjh\Data\" + $"{phonesList.SelectedItem}");
            DataTime.Text = $"{file1.CreationTime}   {file1.Length / 1024} Кб";
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Text = semple;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            semple = txtEditor.Text;
        }

        private void autors_click(object sender, RoutedEventArgs e)
        {
            Autors autors = new Autors();
            autors.Show();
        }

        private void program_click(object sender, RoutedEventArgs e)
        {
            Program program1 = new Program();
            program1.Show();
        }

        
    }
}
