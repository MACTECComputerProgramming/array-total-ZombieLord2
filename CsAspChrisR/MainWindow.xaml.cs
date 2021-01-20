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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CsAspChrisR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonOne_Click(object sender, RoutedEventArgs e)
        {

            ClassTotal();
            AverageOfClass();

        }

        private void AverageOfClass()
        {
            int averageTotal;
            int averageTotal2;
            string[] average = new string[5];

            average[0] = gradeOne.Text;
            average[1] = gradeTwo.Text;
            average[2] = gradeThree.Text;
            average[3] = gradeFour.Text;
            average[4] = gradeFive.Text;

            averageTotal = (int.Parse(gradeOne.Text) + int.Parse(gradeTwo.Text) + int.Parse(gradeThree.Text) + int.Parse(gradeFour.Text) + int.Parse(gradeFive.Text));
            averageTotal2 = averageTotal / 5;

            classAverage.Content = "The class got an average of " + averageTotal2;
        }

        private void ClassTotal()
        {
            int gradesTotal;
            string[] grades = new string[5];

            grades[0] = gradeOne.Text;
            grades[1] = gradeTwo.Text;
            grades[2] = gradeThree.Text;
            grades[3] = gradeFour.Text;
            grades[4] = gradeFive.Text;

            gradesTotal = (int.Parse(gradeOne.Text) + int.Parse(gradeTwo.Text) + int.Parse(gradeThree.Text) + int.Parse(gradeFour.Text) + int.Parse(gradeFive.Text));

            totalGrades.Content = "The total of all grades is " + gradesTotal;
        }
    }
}
