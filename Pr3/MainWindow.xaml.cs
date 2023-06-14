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

namespace Pr3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> players;
        List<Questions> questions;
        string b;
        int g;
        public MainWindow()
        {
            InitializeComponent();
            players = new List<Player>()
            {
                new Player("Первый игрок", 0)
            };
            Update();
            questions = new List<Questions>()
            {
                new Questions ("Какой город является самым северным городом России?","Певек",100),
                new Questions ("Какой город является самым старым в России?","Керчь",200),
                new Questions ("Какой город является колыбелью космонавтики?","Калуга",300),
                new Questions ("В каком городе находится самый древний сохранившийся кремль?","Великий Новгород",400),
                new Questions ("Какой город является самой западной точкой России?","Калининград",500),

                new Questions ("Где живёт Баба-Яга?","Избушка на курьих ножках",100),
                new Questions ("Как в сказках называют скатерть, которая сама накрывает на стол?","Самобранка",200),
                new Questions ("Кто сделал Буратино?","Папа Карло",300),
                new Questions ("Откуда получилось старику выловить золотую рыбку?","Из моря",400),
                new Questions ("Сколько голов было у Змея-Горыныча?","Три",500),

                new Questions ("Сколько основных отраслей насчитывает машиностроение?","12",100),
                new Questions ("Какой главный отраслевой фактор машиностроения?","Транспортные связи",200),
                new Questions ("Где в России сосредоточено производство оборудования для чёрной металлургии?","В Екатеринбурге",300),
                new Questions ("Где в России сосредоточено судостроение?","В Санкт-Петербурге",400),
                new Questions ("В каком городе выпускают атомные подводные лодки?","В Северодвинске",500),

                new Questions ("Как можно закаливаться на природе?","Водные процедуры",100),
                new Questions ("Как называется спортивный бег на большие дистанции?","Марафон",200),
                new Questions ("Как называют человека, который зимой купается в проруби?","Морж",300),
                new Questions ("Полезно ли жевать жвачку вместо чистки зубов?","нет",400),
                new Questions ("Как долго нужно чистить зубы?","Две минуты",500)
            };
        }
        public void Update()
        {
            players = players.ToList();
            list_1.ItemsSource = players;
        }

        private void list_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Save_player_Click(object sender, RoutedEventArgs e)
        {
            if (text_1.Text == null || text_1.Text == "")
            {
                MessageBox.Show("Впишите имя игрока");
            }
            else
            {
                players.Add(new Player(text_1.Text, 0));
                Update();
            }
        }

        private void bt_check_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Text_answers.Text == b)
                {
                    if (list_1.SelectedItem == null)
                    { }
                    int h = 0;
                    int j = g;
                    var k = players.FindIndex(u => u == list_1.SelectedItem);
                    players[k].Point = players[k].Point + j;
                    Update();
                }
                Text_questions.Text = "";
                Text_answers.Text = "";
                Update();
            }
            catch (System.Exception)
            {
                Text_questions.Text = "";
                Text_answers.Text = "";
                MessageBox.Show("Вы не выбрали игрока");
            }
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            bt1.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[0].question;
            b = questions[0].answer;
            g = questions[0].Point;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            bt2.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[1].question;
            b = questions[1].answer;
            g = questions[1].Point;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            bt3.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[2].question;
            b = questions[2].answer;
            g = questions[2].Point;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            bt4.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[3].question;
            b = questions[3].answer;
            g = questions[3].Point;
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            bt5.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[4].question;
            b = questions[4].answer;
            g = questions[4].Point;
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            bt6.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[5].question;
            b = questions[5].answer;
            g = questions[5].Point;
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            bt7.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[6].question;
            b = questions[6].answer;
            g = questions[6].Point;
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            bt8.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[7].question;
            b = questions[7].answer;
            g = questions[7].Point;
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            bt9.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[8].question;
            b = questions[8].answer;
            g = questions[8].Point;
        }

        private void bt10_Click(object sender, RoutedEventArgs e)
        {
            bt10.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[9].question;
            b = questions[9].answer;
            g = questions[9].Point;
        }

        private void bt11_Click(object sender, RoutedEventArgs e)
        {
            bt11.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[10].question;
            b = questions[10].answer;
            g = questions[10].Point;
        }

        private void bt12_Click(object sender, RoutedEventArgs e)
        {
            bt12.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[11].question;
            b = questions[11].answer;
            g = questions[11].Point;
        }

        private void bt13_Click(object sender, RoutedEventArgs e)
        {
            bt13.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[12].question;
            b = questions[12].answer;
            g = questions[12].Point;
        }

        private void bt14_Click(object sender, RoutedEventArgs e)
        {
            bt14.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[13].question;
            b = questions[13].answer;
            g = questions[13].Point;
        }

        private void bt15_Click(object sender, RoutedEventArgs e)
        {
            bt15.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[14].question;
            b = questions[14].answer;
            g = questions[14].Point;
        }

        private void bt16_Click(object sender, RoutedEventArgs e)
        {
            bt16.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[15].question;
            b = questions[15].answer;
            g = questions[15].Point;
        }

        private void bt17_Click(object sender, RoutedEventArgs e)
        {
            bt17.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[16].question;
            b = questions[16].answer;
            g = questions[16].Point;
        }

        private void bt18_Click(object sender, RoutedEventArgs e)
        {
            bt18.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[17].question;
            b = questions[17].answer;
            g = questions[17].Point;
        }

        private void bt19_Click(object sender, RoutedEventArgs e)
        {
            bt19.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[18].question;
            b = questions[18].answer;
            g = questions[18].Point;
        }

        private void bt20_Click(object sender, RoutedEventArgs e)
        {
            bt20.Visibility = Visibility.Collapsed;
            Text_questions.Text = questions[19].question;
            b = questions[19].answer;
            g = questions[19].Point;
        }

        private void The_best_Click(object sender, RoutedEventArgs e)
        {
            Player player1 = players[0];
            foreach (var l in players)
            {
                if (player1.Point < l.Point) player1 = l;
            }
            MessageBox.Show(player1.Name, " Победитель");
        }
    }
}

    
