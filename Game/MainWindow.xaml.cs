using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using static System.Net.Mime.MediaTypeNames;

namespace Game
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int всегожизней = 0;
        int жизни = 0;
        int вирус = 0;
        int какойлист = 1;
        int мойопыт = 0;
        int моимонеты = 0;

        int АнтизаразаСредняя = 0;
        int АнтизаразаБольшая = 0;

        Random Рандом = new Random();
        int опыт = 0;
        int монеты = 0;

        public string[] ВсеГерои = new string[25] { "Азур", "Мира", "Мемили", "Мику", "Эшли", "Ламони-Сам", "Ариша", "Нами", "Изабела", "Прахила", "Лин", "Алдунир", "Мяуша", "Элина", "Микирги", "Мейлин", "Никарги", "Шамбарги", "Аликур", "Лимиса", "Кира", "Сузуми", "Фроди", "Малинка", "ПУСТО" };
        public string[] МоиГерои = new string[25];

        //1 Азур
        int сила1 = 17;
        int уровень1 = 1;

        //2 Мира
        int сила2 = 55;
        int уровень2 = 1;

        //3 Мемили
        int сила3 = 5;
        int уровень3 = 1;

        //4 Мику
        int сила4 = 22;
        int уровень4 = 1;

        //5 Эшли
        int лечение5 = 25;
        int уровень5 = 1;

        //6 Ламони-Сам
        int лечение6 = 10;
        int уровень6 = 1;

        //7 Ариша
        int сила7 = 75;
        int уровень7 = 1;

        //8 Нами
        int сила8 = 30;
        int уровень8 = 1;

        //9 Изабела
        int сила9 = 33;
        int лечение9 = 1;
        int уровень9 = 1;

        //10 Прахила
        int сила10 = 43;
        int уровень10 = 1;

        //11 Лин
        int сила11 = 15;
        int уровень11 = 1;

        //12 Алдунир
        int сила12 = 100;
        int уровень12 = 1;

        //13 Мяуша
        int сила13 = 10;
        int уровень13 = 1;

        //14 Элина
        int сила14 = 13;
        int лечение14 = 8;
        int уровень14 = 1;

        //15 Микирги
        int сила15 = 30;
        int уровень15 = 1;

        //16 Мейлин
        int лечение16 = 30;
        int уровень16 = 1;

        //17 Никарги
        int сила17 = 47;
        int уровень17 = 1;

        //18 Шамбарги
        int сила18 = 32;
        int уровень18 = 1;

        //19 Аликур
        int сила19 = 86;
        int уровень19 = 1;

        //20 Лимиса
        int сила20 = 10;
        int лечение20 = 11;
        int уровень20 = 1;

        //21 Кира
        int сила21 = 21;
        int уровень21 = 1;

        //22 Сузуми
        int сила22 = 16;
        int уровень22 = 1;

        //23 Фроди
        int сила23 = 26;
        int уровень23 = 1;

        //24 Малинка
        int сила24 = 5;
        int лечение24 = 20;
        int уровень24 = 1;

        int ХодыГород = 0; //Нечетные - Ход игрок; Четные - Ход бота
        int ХодыАтакаКакогоГерояГород = 0;
        int ХодыЗаком = 0; //Нечетные - Ход игрок; Четные - Ход бота
        int ХодыАтакаКакогоГерояЗамок = 0;
        int ХодыПоздемелье = 0; //Нечетные - Ход игрок; Четные - Ход бота
        int ХодыАтакаКакогоГерояПодземелье = 0;
        int ХодыРазвалины = 0; //Нечетные - Ход игрок; Четные - Ход бота
        int ХодыАтакаКакогоГерояРазвалины = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBoxResult ms = MessageBox.Show($"Получен новый герой: {ВсеГерои[0]}", "Начало игры", MessageBoxButton.OK, MessageBoxImage.Information);
            if (MessageBoxResult.OK == ms)
            {
                MessageBox.Show($"Доступна новая локация: {Город.Content}\nЗамок откроется на 35 ур.\nРазвалины откроются на 80 ур.\nПодземелье откроется на 120 ур.", "Начало игры", MessageBoxButton.OK, MessageBoxImage.Information);
                ЗакрытГерой1.Visibility = Visibility.Hidden;
                Город.IsEnabled = true;
                МоиГерои[0] = ВсеГерои[0];
                МоиГерои[24] = ВсеГерои[24];
                всегожизней += Convert.ToInt32(ЖизниГерой1.Value);
                жизни += всегожизней;
                Жизни.Maximum = всегожизней;
                Жизни.Value = всегожизней;
                LvlГерой1.Text = "Lvl " + уровень1.ToString();

                АнтизаразаСредняя += 5;
                АнтизаразаСр.Text = АнтизаразаСредняя + " шт.";
            }
            ОпытГерой1.Maximum = 500; //1 Азур
            ОпытГерой2.Maximum = 500; //2 Мира
            ОпытГерой3.Maximum = 500; //3 Мемили
            ОпытГерой4.Maximum = 500; //4 Мику
            ОпытГерой5.Maximum = 500; //5 Эшли
            ОпытГерой6.Maximum = 500; //6 Ламони-Сам
            ОпытГерой7.Maximum = 500; //7 Ариша
            ОпытГерой8.Maximum = 500; //8 Нами
            ОпытГерой9.Maximum = 500; //9 Изабела
            ОпытГерой10.Maximum = 500; //10 Прахила
            ОпытГерой11.Maximum = 500; //11 Лин
            ОпытГерой12.Maximum = 500; //12 Алдунир
            ОпытГерой13.Maximum = 500; //13 Мяуша
            ОпытГерой14.Maximum = 500; //14 Элина
            ОпытГерой15.Maximum = 500; //15 Микирги
            ОпытГерой16.Maximum = 500; //16 Мейлин
            ОпытГерой17.Maximum = 500; //17 Никарги
            ОпытГерой18.Maximum = 500; //18 Шамбарги
            ОпытГерой19.Maximum = 500; //19 Аликур
            ОпытГерой20.Maximum = 500; //20 Лимиса
            ОпытГерой21.Maximum = 500; //21 Кира
            ОпытГерой22.Maximum = 500; //22 Сузуми
            ОпытГерой23.Maximum = 500; //23 Фроди
            ОпытГерой24.Maximum = 500; //24 Малинка
        }

        //ЖИЗНИ-И-ВИРУС----------------------------------------------------------------------------------------------
        private void Жизни_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {жизни}/{всегожизней}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Жизни.ToolTip = toolTip;
        }

        private void Вирус_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = $"Заражение - {вирус}/{Вирус.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Вирус.ToolTip = toolTip;
        }

        //АнтизаразаИнфо----------------------------------------------------------------------------------------------
        private void БолАнтизаразаИнфо_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = $"Заражение: -100", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            СрАнтизаразаИнфо.ToolTip = toolTip;
        }

        private void СрАнтизаразаИнфо_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = $"Заражение: -500", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            БолАнтизаразаИнфо.ToolTip = toolTip;
        }

        //ЛИСТЫ-С-ГЕРОЯМИ---------------------------------------------------------------------------------------------
        private void ЛистВ_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ЛистП.IsEnabled)
            {
                какойлист -= 1;
                КакойЛист.Text = какойлист.ToString();
                if (какойлист == 3)
                {
                    List1.Visibility = Visibility.Hidden;
                    List2.Visibility = Visibility.Hidden;
                    List3.Visibility = Visibility.Visible;
                }
                else if (какойлист == 2)
                {
                    List1.Visibility = Visibility.Hidden;
                    List2.Visibility = Visibility.Visible;
                    List3.Visibility = Visibility.Hidden;
                }
                else if (какойлист <= 1)
                {
                    List1.Visibility = Visibility.Visible;
                    List2.Visibility = Visibility.Hidden;
                    List3.Visibility = Visibility.Hidden;
                    какойлист = 1;
                    КакойЛист.Text = какойлист.ToString();
                }
            }
        }

        private void ЛистП_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ЛистВ.IsEnabled)
            {
                какойлист += 1;
                КакойЛист.Text = какойлист.ToString();
                if (какойлист == 1)
                {
                    List1.Visibility = Visibility.Visible;
                    List2.Visibility = Visibility.Hidden;
                    List3.Visibility = Visibility.Hidden;
                }
                else if (какойлист == 2)
                {
                    List1.Visibility = Visibility.Hidden;
                    List2.Visibility = Visibility.Visible;
                    List3.Visibility = Visibility.Hidden;
                }
                else if (какойлист >= 3)
                {
                    List1.Visibility = Visibility.Hidden;
                    List2.Visibility = Visibility.Hidden;
                    List3.Visibility = Visibility.Visible;
                    какойлист = 3;
                    КакойЛист.Text = какойлист.ToString();
                }
            }
        }

        //ГОРОДА-КНОПКИ---------------------------------------------------------------------------------------------
        private void Лес_Click(object sender, RoutedEventArgs e)
        {
            СЛес.Visibility = Visibility.Visible;
            СГород.Visibility = Visibility.Hidden;
            СЗамок.Visibility = Visibility.Hidden;
            СПодземелье.Visibility = Visibility.Hidden;
            СРазвалины.Visibility = Visibility.Hidden;
            СМагазин.Visibility = Visibility.Hidden;
        }

        private void Город_Click(object sender, RoutedEventArgs e)
        {
            СЛес.Visibility = Visibility.Hidden;
            СГород.Visibility = Visibility.Visible;
            СЗамок.Visibility = Visibility.Hidden;
            СПодземелье.Visibility = Visibility.Hidden;
            СРазвалины.Visibility = Visibility.Hidden;
            СМагазин.Visibility = Visibility.Hidden;
        }

        private void Замок_Click(object sender, RoutedEventArgs e)
        {
            СЛес.Visibility = Visibility.Hidden;
            СГород.Visibility = Visibility.Hidden;
            СЗамок.Visibility = Visibility.Visible;
            СПодземелье.Visibility = Visibility.Hidden;
            СРазвалины.Visibility = Visibility.Hidden;
            СМагазин.Visibility = Visibility.Hidden;
        }

        private void Подземелье_Click(object sender, RoutedEventArgs e)
        {
            СЛес.Visibility = Visibility.Hidden;
            СГород.Visibility = Visibility.Hidden;
            СЗамок.Visibility = Visibility.Hidden;
            СПодземелье.Visibility = Visibility.Visible;
            СРазвалины.Visibility = Visibility.Hidden;
            СМагазин.Visibility = Visibility.Hidden;
        }

        private void Развалины_Click(object sender, RoutedEventArgs e)
        {
            СЛес.Visibility = Visibility.Hidden;
            СГород.Visibility = Visibility.Hidden;
            СЗамок.Visibility = Visibility.Hidden;
            СПодземелье.Visibility = Visibility.Hidden;
            СРазвалины.Visibility = Visibility.Visible;
            СМагазин.Visibility = Visibility.Hidden;
        }

        private void Магазин_Click(object sender, RoutedEventArgs e)
        {
            СЛес.Visibility = Visibility.Hidden;
            СГород.Visibility = Visibility.Hidden;
            СЗамок.Visibility = Visibility.Hidden;
            СПодземелье.Visibility = Visibility.Hidden;
            СРазвалины.Visibility = Visibility.Hidden;
            СМагазин.Visibility = Visibility.Visible;
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        { Close(); }

        //ГОРОД-АТАКА-ВЫБОР-ГЕРОЕВ-СПИСОК------------------------------------------------------------------------------------------
        private void СписокГероев1_MouseEnter(object sender, MouseEventArgs e)
        {
            //ГЕРОИ-----------------------
            СписокГероев1.ItemsSource = МоиГерои;
            //1
            if (СписокГероев1.Text == ВсеГерои[0].ToString() & СписокГероев2.Text != ВсеГерои[0].ToString() & ЖизниГерой1.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (1).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой1.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой1.Value;
            }
            //2
            else if (СписокГероев1.Text == ВсеГерои[1].ToString() & СписокГероев2.Text != ВсеГерои[1].ToString() & ЖизниГерой2.Value != 0 &  Герой2_Скин1.Visibility == Visibility.Visible & Герой2_Скин2.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (9).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой2.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой2.Value;
            }
            else if (СписокГероев1.Text == ВсеГерои[1].ToString() & СписокГероев2.Text != ВсеГерои[1].ToString() & ЖизниГерой2.Value != 0 & Герой2_Скин2.Visibility == Visibility.Visible & Герой2_Скин1.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (19).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой2.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой2.Value;
            }
            //3
            else if (СписокГероев1.Text == ВсеГерои[2].ToString() & СписокГероев2.Text != ВсеГерои[2].ToString() & ЖизниГерой2.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (21).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой3.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой3.Value;
            }
            //4
            else if (СписокГероев1.Text == ВсеГерои[3].ToString() & СписокГероев2.Text != ВсеГерои[3].ToString() & ЖизниГерой4.Value != 0 & Герой4_Скин1.Visibility == Visibility.Visible & Герой4_Скин2.Visibility == Visibility.Hidden & Герой4_Скин3.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (44).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой4.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой4.Value;
            }
            else if (СписокГероев1.Text == ВсеГерои[3].ToString() & СписокГероев2.Text != ВсеГерои[3].ToString() & ЖизниГерой4.Value != 0 & Герой4_Скин2.Visibility == Visibility.Visible & Герой4_Скин1.Visibility == Visibility.Hidden & Герой4_Скин3.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (45).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой4.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой4.Value;
            }
            else if (СписокГероев1.Text == ВсеГерои[3].ToString() & СписокГероев2.Text != ВсеГерои[3].ToString() & ЖизниГерой4.Value != 0 & Герой4_Скин3.Visibility == Visibility.Visible & Герой4_Скин1.Visibility == Visibility.Hidden & Герой4_Скин2.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (47).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой4.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой4.Value;
            }
            //5
            if (СписокГероев1.Text == ВсеГерои[4].ToString() & СписокГероев2.Text != ВсеГерои[4].ToString() & ЖизниГерой5.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (59).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой5.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой5.Value;
            }
            //6
            if (СписокГероев1.Text == ВсеГерои[5].ToString() & СписокГероев2.Text != ВсеГерои[5].ToString() & ЖизниГерой6.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (5).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой6.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой6.Value;
            }
            //7
            if (СписокГероев1.Text == ВсеГерои[6].ToString() & СписокГероев2.Text != ВсеГерои[6].ToString() & ЖизниГерой7.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (11).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой7.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой7.Value;
            }
            //8
            if (СписокГероев1.Text == ВсеГерои[7].ToString() & СписокГероев2.Text != ВсеГерои[7].ToString() & ЖизниГерой8.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (24).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой8.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой8.Value;
            }
            //9
            if (СписокГероев1.Text == ВсеГерои[8].ToString() & СписокГероев2.Text != ВсеГерои[9].ToString() & ЖизниГерой9.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (51).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой9.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой9.Value;
            }
            //10
            if (СписокГероев1.Text == ВсеГерои[9].ToString() & СписокГероев2.Text != ВсеГерои[9].ToString() & ЖизниГерой10.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (52).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой10.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой10.Value;
            }
            //11
            if (СписокГероев1.Text == ВсеГерои[10].ToString() & СписокГероев2.Text != ВсеГерои[10].ToString() & ЖизниГерой11.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (6).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой11.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой11.Value;
            }
            //12
            if (СписокГероев1.Text == ВсеГерои[11].ToString() & СписокГероев2.Text != ВсеГерои[11].ToString() & ЖизниГерой12.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой12.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой12.Value;
            }
            //13
            else if (СписокГероев1.Text == ВсеГерои[12].ToString() & СписокГероев2.Text != ВсеГерои[12].ToString() & ЖизниГерой13.Value != 0 & Герой13_Скин1.Visibility == Visibility.Visible & Герой13_Скин2.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (33).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой2.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой2.Value;
            }
            else if (СписокГероев1.Text == ВсеГерои[12].ToString() & СписокГероев2.Text != ВсеГерои[12].ToString() & ЖизниГерой13.Value != 0 & Герой13_Скин2.Visibility == Visibility.Visible & Герой13_Скин1.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (49).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой13.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой13.Value;
            }
            //14
            if (СписокГероев1.Text == ВсеГерои[13].ToString() & СписокГероев2.Text != ВсеГерои[13].ToString() & ЖизниГерой14.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой14.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой14.Value;
            }
            //15
            if (СписокГероев1.Text == ВсеГерои[14].ToString() & СписокГероев2.Text != ВсеГерои[14].ToString() & ЖизниГерой15.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой15.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой16.Value;
            }
            //16
            if (СписокГероев1.Text == ВсеГерои[15].ToString() & СписокГероев2.Text != ВсеГерои[15].ToString() & ЖизниГерой16.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой16.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой16.Value;
            }
            //17
            if (СписокГероев1.Text == ВсеГерои[16].ToString() & СписокГероев2.Text != ВсеГерои[16].ToString() & ЖизниГерой17.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой17.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой17.Value;
            }
            //18
            if (СписокГероев1.Text == ВсеГерои[17].ToString() & СписокГероев2.Text != ВсеГерои[17].ToString() & ЖизниГерой18.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой18.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой18.Value;
            }
            //19
            if (СписокГероев1.Text == ВсеГерои[18].ToString() & СписокГероев2.Text != ВсеГерои[18].ToString() & ЖизниГерой19.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой19.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой19.Value;
            }
            //20
            if (СписокГероев1.Text == ВсеГерои[19].ToString() & СписокГероев2.Text != ВсеГерои[19].ToString() & ЖизниГерой20.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой20.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой20.Value;
            }
            //21
            if (СписокГероев1.Text == ВсеГерои[20].ToString() & СписокГероев2.Text != ВсеГерои[20].ToString() & ЖизниГерой21.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой21.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой21.Value;
            }
            //22
            if (СписокГероев1.Text == ВсеГерои[21].ToString() & СписокГероев2.Text != ВсеГерои[21].ToString() & ЖизниГерой22.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой22.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой22.Value;
            }
            //23
            if (СписокГероев1.Text == ВсеГерои[22].ToString() & СписокГероев2.Text != ВсеГерои[22].ToString() & ЖизниГерой23.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой23.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой23.Value;
            }
            //24
            if (СписокГероев1.Text == ВсеГерои[23].ToString() & СписокГероев2.Text != ВсеГерои[23].ToString() & ЖизниГерой24.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой24.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой24.Value;
            }

            //ОШИБКА-ОДИНАКОВЫХ-ГЕРОЕВ--------------------
            else if (СписокГероев1.Text == ВсеГерои[0].ToString() & СписокГероев2.Text == ВсеГерои[0].ToString() | СписокГероев1.Text == ВсеГерои[12].ToString() & СписокГероев2.Text == ВсеГерои[12].ToString()
                   | СписокГероев1.Text == ВсеГерои[1].ToString() & СписокГероев2.Text == ВсеГерои[1].ToString() | СписокГероев1.Text == ВсеГерои[13].ToString() & СписокГероев2.Text == ВсеГерои[13].ToString()
                   | СписокГероев1.Text == ВсеГерои[2].ToString() & СписокГероев2.Text == ВсеГерои[2].ToString() | СписокГероев1.Text == ВсеГерои[14].ToString() & СписокГероев2.Text == ВсеГерои[14].ToString()
                   | СписокГероев1.Text == ВсеГерои[3].ToString() & СписокГероев2.Text == ВсеГерои[3].ToString() | СписокГероев1.Text == ВсеГерои[15].ToString() & СписокГероев2.Text == ВсеГерои[15].ToString()
                   | СписокГероев1.Text == ВсеГерои[4].ToString() & СписокГероев2.Text == ВсеГерои[4].ToString() | СписокГероев1.Text == ВсеГерои[16].ToString() & СписокГероев2.Text == ВсеГерои[16].ToString()
                   | СписокГероев1.Text == ВсеГерои[5].ToString() & СписокГероев2.Text == ВсеГерои[5].ToString() | СписокГероев1.Text == ВсеГерои[17].ToString() & СписокГероев2.Text == ВсеГерои[17].ToString()
                   | СписокГероев1.Text == ВсеГерои[6].ToString() & СписокГероев2.Text == ВсеГерои[6].ToString() | СписокГероев1.Text == ВсеГерои[18].ToString() & СписокГероев2.Text == ВсеГерои[18].ToString()
                   | СписокГероев1.Text == ВсеГерои[7].ToString() & СписокГероев2.Text == ВсеГерои[7].ToString() | СписокГероев1.Text == ВсеГерои[19].ToString() & СписокГероев2.Text == ВсеГерои[19].ToString()
                   | СписокГероев1.Text == ВсеГерои[8].ToString() & СписокГероев2.Text == ВсеГерои[8].ToString() | СписокГероев1.Text == ВсеГерои[20].ToString() & СписокГероев2.Text == ВсеГерои[20].ToString()
                   | СписокГероев1.Text == ВсеГерои[9].ToString() & СписокГероев2.Text == ВсеГерои[9].ToString() | СписокГероев1.Text == ВсеГерои[21].ToString() & СписокГероев2.Text == ВсеГерои[21].ToString()
                   | СписокГероев1.Text == ВсеГерои[10].ToString() & СписокГероев2.Text == ВсеГерои[10].ToString() | СписокГероев1.Text == ВсеГерои[22].ToString() & СписокГероев2.Text == ВсеГерои[23].ToString()
                   | СписокГероев1.Text == ВсеГерои[11].ToString() & СписокГероев2.Text == ВсеГерои[11].ToString() | СписокГероев1.Text == ВсеГерои[23].ToString() & СписокГероев2.Text == ВсеГерои[23].ToString())
            {
                MessageBox.Show("Нельзя использовать одного и того же героя!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                СписокГероев1.Text = "ПУСТО";
            }
            else if (СписокГероев1.Text == "ПУСТО")
            {
                АтакаГерой1.Source = null;
                ЖизниГеройБой1.Visibility = Visibility.Hidden;
                Атака1.Visibility = Visibility.Hidden;
                ЖизниГеройБой1.Maximum = 0;
            }
        }

        private void СписокГероев2_MouseEnter(object sender, MouseEventArgs e)
        {
            //ГЕРОИ-----------------------
            СписокГероев2.ItemsSource = МоиГерои;
            //1
            if (СписокГероев2.Text == МоиГерои[0].ToString() & СписокГероев1.Text != МоиГерои[0].ToString())
            {
                АтакаГерой2.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (1).gif") as ImageSource;
                ЖизниГеройБой2.Visibility = Visibility.Visible;
                Атака2.Visibility = Visibility.Visible;
                ЖизниГеройБой2.Maximum = ЖизниГерой1.Maximum;
                ЖизниГеройБой2.Value = ЖизниГерой1.Value;
            }
            //2
            else if (СписокГероев2.Text == ВсеГерои[1].ToString() & СписокГероев1.Text != ВсеГерои[1].ToString() & ЖизниГерой2.Value != 0 & Герой2_Скин1.Visibility == Visibility.Visible & Герой2_Скин2.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (9).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой2.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой2.Value;
            }
            else if (СписокГероев2.Text == ВсеГерои[1].ToString() & СписокГероев1.Text != ВсеГерои[1].ToString() & ЖизниГерой2.Value != 0 & Герой2_Скин2.Visibility == Visibility.Visible & Герой2_Скин1.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (19).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой2.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой2.Value;
            }
            //3
            else if (СписокГероев2.Text == ВсеГерои[2].ToString() & СписокГероев1.Text != ВсеГерои[2].ToString() & ЖизниГерой2.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (21).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой3.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой3.Value;
            }
            //4
            else if (СписокГероев2.Text == ВсеГерои[3].ToString() & СписокГероев1.Text != ВсеГерои[3].ToString() & ЖизниГерой4.Value != 0 & Герой4_Скин1.Visibility == Visibility.Visible & Герой4_Скин2.Visibility == Visibility.Hidden & Герой4_Скин3.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (44).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой4.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой4.Value;
            }
            else if (СписокГероев2.Text == ВсеГерои[3].ToString() & СписокГероев1.Text != ВсеГерои[3].ToString() & ЖизниГерой4.Value != 0 & Герой4_Скин2.Visibility == Visibility.Visible & Герой4_Скин1.Visibility == Visibility.Hidden & Герой4_Скин3.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (45).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой4.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой4.Value;
            }
            else if (СписокГероев2.Text == ВсеГерои[3].ToString() & СписокГероев1.Text != ВсеГерои[3].ToString() & ЖизниГерой4.Value != 0 & Герой4_Скин3.Visibility == Visibility.Visible & Герой4_Скин1.Visibility == Visibility.Hidden & Герой4_Скин2.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (47).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой4.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой4.Value;
            }
            //5
            if (СписокГероев2.Text == ВсеГерои[4].ToString() & СписокГероев1.Text != ВсеГерои[4].ToString() & ЖизниГерой5.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (59).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой5.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой5.Value;
            }
            //6
            if (СписокГероев2.Text == ВсеГерои[5].ToString() & СписокГероев1.Text != ВсеГерои[5].ToString() & ЖизниГерой6.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (5).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой6.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой6.Value;
            }
            //7
            if (СписокГероев2.Text == ВсеГерои[6].ToString() & СписокГероев1.Text != ВсеГерои[6].ToString() & ЖизниГерой7.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (11).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой7.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой7.Value;
            }
            //8
            if (СписокГероев2.Text == ВсеГерои[7].ToString() & СписокГероев1.Text != ВсеГерои[7].ToString() & ЖизниГерой8.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (24).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой8.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой8.Value;
            }
            //9
            if (СписокГероев2.Text == ВсеГерои[8].ToString() & СписокГероев1.Text != ВсеГерои[9].ToString() & ЖизниГерой9.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (51).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой9.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой9.Value;
            }
            //10
            if (СписокГероев2.Text == ВсеГерои[9].ToString() & СписокГероев1.Text != ВсеГерои[9].ToString() & ЖизниГерой10.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (52).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой10.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой10.Value;
            }
            //11
            if (СписокГероев2.Text == ВсеГерои[10].ToString() & СписокГероев1.Text != ВсеГерои[10].ToString() & ЖизниГерой11.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (6).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой11.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой11.Value;
            }
            //12
            if (СписокГероев2.Text == ВсеГерои[11].ToString() & СписокГероев1.Text != ВсеГерои[11].ToString() & ЖизниГерой12.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой12.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой12.Value;
            }
            //13
            else if (СписокГероев2.Text == ВсеГерои[12].ToString() & СписокГероев1.Text != ВсеГерои[12].ToString() & ЖизниГерой13.Value != 0 & Герой13_Скин1.Visibility == Visibility.Visible & Герой13_Скин2.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (33).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой2.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой2.Value;
            }
            else if (СписокГероев2.Text == ВсеГерои[12].ToString() & СписокГероев1.Text != ВсеГерои[12].ToString() & ЖизниГерой13.Value != 0 & Герой13_Скин2.Visibility == Visibility.Visible & Герой13_Скин1.Visibility == Visibility.Hidden)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (49).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой13.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой13.Value;
            }
            //14
            if (СписокГероев2.Text == ВсеГерои[13].ToString() & СписокГероев1.Text != ВсеГерои[13].ToString() & ЖизниГерой14.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой14.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой14.Value;
            }
            //15
            if (СписокГероев2.Text == ВсеГерои[14].ToString() & СписокГероев1.Text != ВсеГерои[14].ToString() & ЖизниГерой15.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой15.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой16.Value;
            }
            //16
            if (СписокГероев2.Text == ВсеГерои[15].ToString() & СписокГероев1.Text != ВсеГерои[15].ToString() & ЖизниГерой16.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой16.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой16.Value;
            }
            //17
            if (СписокГероев2.Text == ВсеГерои[16].ToString() & СписокГероев1.Text != ВсеГерои[16].ToString() & ЖизниГерой17.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой17.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой17.Value;
            }
            //18
            if (СписокГероев2.Text == ВсеГерои[17].ToString() & СписокГероев1.Text != ВсеГерои[17].ToString() & ЖизниГерой18.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой18.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой18.Value;
            }
            //19
            if (СписокГероев2.Text == ВсеГерои[18].ToString() & СписокГероев1.Text != ВсеГерои[18].ToString() & ЖизниГерой19.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой19.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой19.Value;
            }
            //20
            if (СписокГероев2.Text == ВсеГерои[19].ToString() & СписокГероев1.Text != ВсеГерои[19].ToString() & ЖизниГерой20.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой20.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой20.Value;
            }
            //21
            if (СписокГероев2.Text == ВсеГерои[20].ToString() & СписокГероев1.Text != ВсеГерои[20].ToString() & ЖизниГерой21.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой21.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой21.Value;
            }
            //22
            if (СписокГероев2.Text == ВсеГерои[21].ToString() & СписокГероев1.Text != ВсеГерои[21].ToString() & ЖизниГерой22.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой22.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой22.Value;
            }
            //23
            if (СписокГероев2.Text == ВсеГерои[22].ToString() & СписокГероев1.Text != ВсеГерои[22].ToString() & ЖизниГерой23.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой23.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой23.Value;
            }
            //24
            if (СписокГероев2.Text == ВсеГерои[23].ToString() & СписокГероев1.Text != ВсеГерои[23].ToString() & ЖизниГерой24.Value != 0)
            {
                АтакаГерой1.Source = (new ImageSourceConverter()).ConvertFromString("O:/Моё/Game/Game/Res/1 (20).gif") as ImageSource;
                ЖизниГеройБой1.Visibility = Visibility.Visible;
                Атака1.Visibility = Visibility.Visible;
                ЖизниГеройБой1.Maximum = ЖизниГерой24.Maximum;
                ЖизниГеройБой1.Value = ЖизниГерой24.Value;
            }
            //ОШИБКА-ОДИНАКОВЫХ-ГЕРОЕВ--------------------
            else if (СписокГероев2.Text == ВсеГерои[0].ToString() & СписокГероев1.Text == ВсеГерои[0].ToString() | СписокГероев2.Text == ВсеГерои[12].ToString() & СписокГероев1.Text == ВсеГерои[12].ToString()
                | СписокГероев2.Text == ВсеГерои[1].ToString() & СписокГероев1.Text == ВсеГерои[1].ToString() | СписокГероев2.Text == ВсеГерои[13].ToString() & СписокГероев1.Text == ВсеГерои[13].ToString()
                | СписокГероев2.Text == ВсеГерои[2].ToString() & СписокГероев1.Text == ВсеГерои[2].ToString() | СписокГероев2.Text == ВсеГерои[14].ToString() & СписокГероев1.Text == ВсеГерои[14].ToString()
                | СписокГероев2.Text == ВсеГерои[3].ToString() & СписокГероев1.Text == ВсеГерои[3].ToString() | СписокГероев2.Text == ВсеГерои[15].ToString() & СписокГероев1.Text == ВсеГерои[15].ToString()
                | СписокГероев2.Text == ВсеГерои[4].ToString() & СписокГероев1.Text == ВсеГерои[4].ToString() | СписокГероев2.Text == ВсеГерои[16].ToString() & СписокГероев1.Text == ВсеГерои[16].ToString()
                | СписокГероев2.Text == ВсеГерои[5].ToString() & СписокГероев1.Text == ВсеГерои[5].ToString() | СписокГероев2.Text == ВсеГерои[17].ToString() & СписокГероев1.Text == ВсеГерои[17].ToString()
                | СписокГероев2.Text == ВсеГерои[6].ToString() & СписокГероев1.Text == ВсеГерои[6].ToString() | СписокГероев2.Text == ВсеГерои[18].ToString() & СписокГероев1.Text == ВсеГерои[18].ToString()
                | СписокГероев2.Text == ВсеГерои[7].ToString() & СписокГероев1.Text == ВсеГерои[7].ToString() | СписокГероев2.Text == ВсеГерои[19].ToString() & СписокГероев1.Text == ВсеГерои[19].ToString()
                | СписокГероев2.Text == ВсеГерои[8].ToString() & СписокГероев1.Text == ВсеГерои[8].ToString() | СписокГероев2.Text == ВсеГерои[20].ToString() & СписокГероев1.Text == ВсеГерои[20].ToString()
                | СписокГероев2.Text == ВсеГерои[9].ToString() & СписокГероев1.Text == ВсеГерои[9].ToString() | СписокГероев2.Text == ВсеГерои[21].ToString() & СписокГероев1.Text == ВсеГерои[21].ToString()
                | СписокГероев2.Text == ВсеГерои[10].ToString() & СписокГероев1.Text == ВсеГерои[10].ToString() | СписокГероев2.Text == ВсеГерои[22].ToString() & СписокГероев1.Text == ВсеГерои[22].ToString()
                | СписокГероев2.Text == ВсеГерои[11].ToString() & СписокГероев1.Text == ВсеГерои[11].ToString() | СписокГероев2.Text == ВсеГерои[23].ToString() & СписокГероев1.Text == ВсеГерои[23].ToString())
            {
                MessageBox.Show("Нельзя использовать одного и того же героя!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                СписокГероев2.Text = "ПУСТО";
            }
            else if (СписокГероев2.Text == "ПУСТО")
            {
                АтакаГерой2.Source = null;
                ЖизниГеройБой2.Visibility = Visibility.Hidden;
                Атака2.Visibility = Visibility.Hidden;
                ЖизниГеройБой2.Maximum = 0;
            }
        }

        //ИНФОРМАЦИЯ-О-ГЕРОЯХ-И-МОНСТРАХ-----------------------------------------------------------------------------------------
        private void Герой1_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[0]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой1.Value}/{ЖизниГерой1.Maximum}\nСила - {сила1}\nНовый уровень: {ОпытГерой1.Value}/{ОпытГерой1.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой1.ToolTip = toolTip;
        }

        private void Герой2_Скин1_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[1]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой2.Value}/{ЖизниГерой2.Maximum}\nСила - {сила2}\nНовый уровень: {ОпытГерой2.Value}/{ОпытГерой2.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой2_Скин1.ToolTip = toolTip;
            Герой2_Скин2.ToolTip = toolTip;
            ЗакрытГерой2.ToolTip = toolTip;
        }

        private void Герой3_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[2]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой3.Value}/{ЖизниГерой3.Maximum}\nСила - {сила3}\nНовый уровень: {ОпытГерой3.Value}/{ОпытГерой3.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой3.ToolTip = toolTip;
            ЗакрытГерой3.ToolTip = toolTip;
        }

        private void Герой4_Скин1_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[3]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой4.Value}/{ЖизниГерой4.Maximum}\nСила - {сила4}\nНовый уровень: {ОпытГерой4.Value}/{ОпытГерой4.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой4_Скин1.ToolTip = toolTip;
            Герой4_Скин2.ToolTip = toolTip;
            ЗакрытГерой4.ToolTip = toolTip;
        }

        private void Герой5_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[4]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой5.Value}/{ЖизниГерой5.Maximum}\nЛечение - {лечение5}\nНовый уровень: {ОпытГерой5.Value}/{ОпытГерой5.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой5.ToolTip = toolTip;
            ЗакрытГерой5.ToolTip = toolTip;
        }

        private void Герой6_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[5]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой6.Value}/{ЖизниГерой6.Maximum}\nЛечение - {лечение6}\nНовый уровень: {ОпытГерой6.Value}/{ОпытГерой6.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой6.ToolTip = toolTip;
            ЗакрытГерой6.ToolTip = toolTip;
        }

        private void Герой7_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[6]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой7.Value}/{ЖизниГерой7.Maximum}\nСила - {сила7}\nНовый уровень: {ОпытГерой7.Value}/{ОпытГерой7.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой7.ToolTip = toolTip;
            ЗакрытГерой7.ToolTip = toolTip;
        }

        private void Герой8_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[7]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой8.Value}/{ЖизниГерой8.Maximum}\nСила - {сила8}\nНовый уровень: {ОпытГерой8.Value}/{ОпытГерой8.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой8.ToolTip = toolTip;
            ЗакрытГерой8.ToolTip = toolTip;
        }

        private void Герой9_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[8]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой9.Value}/{ЖизниГерой9.Maximum}\nСила - {сила9}\nЛечение - {лечение9}\nНовый уровень: {ОпытГерой9.Value}/{ОпытГерой9.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой9.ToolTip = toolTip;
            ЗакрытГерой9.ToolTip = toolTip;
        }

        private void Герой10_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[9]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой10.Value}/{ЖизниГерой10.Maximum}\nСила - {сила10}\nНовый уровень: {ОпытГерой10.Value}/{ОпытГерой10.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой10.ToolTip = toolTip;
            ЗакрытГерой10.ToolTip = toolTip;
        }

        private void Герой11_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[10]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой11.Value}/{ЖизниГерой11.Maximum}\nСила - {сила11}\nНовый уровень: {ОпытГерой11.Value}/{ОпытГерой11.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой11.ToolTip = toolTip;
            ЗакрытГерой11.ToolTip = toolTip;
        }

        private void Герой12_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[11]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой12.Value}/{ЖизниГерой12.Maximum}\nСила - {сила12}\nНовый уровень: {ОпытГерой12.Value}/{ОпытГерой12.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой12.ToolTip = toolTip;
            ЗакрытГерой12.ToolTip = toolTip;
        }

        private void Герой13_Скин1_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[12]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой13.Value}/{ЖизниГерой13.Maximum}\nСила - {сила13}\nНовый уровень: {ОпытГерой13.Value}/{ОпытГерой13.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой13_Скин1.ToolTip = toolTip;
            Герой13_Скин2.ToolTip = toolTip;
            ЗакрытГерой13.ToolTip = toolTip;
        }

        private void Герой14_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[13]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой14.Value}/{ЖизниГерой14.Maximum}\nСила - {сила14}\nЛечение - {лечение14}\nНовый уровень: {ОпытГерой14.Value}/{ОпытГерой14.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой14.ToolTip = toolTip;
            ЗакрытГерой14.ToolTip = toolTip;
        }

        private void Герой15_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[14]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой15.Value}/{ЖизниГерой15.Maximum}\nСила - {сила15}\nНовый уровень: {ОпытГерой15.Value}/{ОпытГерой15.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой15.ToolTip = toolTip;
            ЗакрытГерой15.ToolTip = toolTip;
        }

        private void Герой16_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[15]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой16.Value}/{ЖизниГерой16.Maximum}\nЛечение - {лечение16}\nНовый уровень: {ОпытГерой16.Value}/{ОпытГерой16.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой16.ToolTip = toolTip;
            ЗакрытГерой16.ToolTip = toolTip;
        }

        private void Герой17_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[16]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой17.Value}/{ЖизниГерой17.Maximum}\nСила - {сила17}\nНовый уровень: {ОпытГерой17.Value}/{ОпытГерой17.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой17.ToolTip = toolTip;
            ЗакрытГерой17.ToolTip = toolTip;
        }

        private void Герой18_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[17]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой18.Value}/{ЖизниГерой18.Maximum}\nСила - {сила18}\nНовый уровень: {ОпытГерой18.Value}/{ОпытГерой18.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой18.ToolTip = toolTip;
            ЗакрытГерой18.ToolTip = toolTip;
        }

        private void Герой19_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[18]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой19.Value}/{ЖизниГерой19.Maximum}\nСила - {сила19}\nНовый уровень: {ОпытГерой19.Value}/{ОпытГерой19.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой19.ToolTip = toolTip;
            ЗакрытГерой19.ToolTip = toolTip;
        }

        private void Герой20_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[19]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой20.Value}/{ЖизниГерой20.Maximum}\nСила - {сила20}\nЛечение - {лечение20}\nНовый уровень: {ОпытГерой20.Value}/{ОпытГерой20.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой20.ToolTip = toolTip;
            ЗакрытГерой20.ToolTip = toolTip;
        }

        private void Герой21_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[20]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой21.Value}/{ЖизниГерой21.Maximum}\nСила - {сила21}\nНовый уровень: {ОпытГерой21.Value}/{ОпытГерой21.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой21.ToolTip = toolTip;
            ЗакрытГерой21.ToolTip = toolTip;
        }

        private void Герой22_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[21]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой22.Value}/{ЖизниГерой22.Maximum}\nСила - {сила22}\nНовый уровень: {ОпытГерой22.Value}/{ОпытГерой22.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой22.ToolTip = toolTip;
            ЗакрытГерой22.ToolTip = toolTip;
        }

        private void Герой23_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[22]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой23.Value}/{ЖизниГерой23.Maximum}\nСила - {сила23}\nНовый уровень: {ОпытГерой23.Value}/{ОпытГерой23.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой23.ToolTip = toolTip;
            ЗакрытГерой23.ToolTip = toolTip;
        }

        private void Герой24_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = $"{ВсеГерои[23]}", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = $"Здоровье - {ЖизниГерой24.Value}/{ЖизниГерой24.Maximum}\nСила - {сила24}\nЛечение - {лечение24}\nНовый уровень: {ОпытГерой24.Value}/{ОпытГерой24.Maximum}", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            Герой24.ToolTip = toolTip;
            ЗакрытГерой24.ToolTip = toolTip;
        }

        //МОНСТРЫ-ГОРОД-ОПИСАНИЕ----------------------------------------------------------------------------------------
        private void МонстрГород1_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = "Жужилерик", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = "Здоровье - 5000\nСила - 5\nЗаражение - 1", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            МонстрГород1.ToolTip = toolTip;
        }

        private void МонстрГород2_MouseEnter(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { TextAlignment = TextAlignment.Center, Text = "Жужилерик", FontSize = 20 });
            toolTipPanel.Children.Add(new TextBlock { Text = "Здоровье - 2500\nСила - 30\nЗаражение - 0", FontSize = 16 });
            toolTip.Content = toolTipPanel;
            МонстрГород2.ToolTip = toolTip;
        }

        //ИГРА-ГОРОД-----------------------------------------------------------------------------------------
        private void Атака1_Click(object sender, RoutedEventArgs e)
        {
            ХодыГород += 1;
            if (ХодыГород == 1 | ХодыГород == 4 | ХодыГород == 5 | ХодыГород == 7) //Игрок------------------------------------------
            {
                if (СМонстр1.Visibility == Visibility.Visible & СМонстр2.Visibility == Visibility.Hidden)
                {
                    ЖизниMонстр1.Value -= сила1;
                    if (ЖизниMонстр1.Value <= 0)
                    {
                        опыт += Рандом.Next(50, 150);
                        ОпытГород.Text = опыт.ToString();
                        монеты += Рандом.Next(10, 100);
                        МонетыГород.Text = монеты.ToString() + " ₣";

                        СМонстр1.Visibility = Visibility.Hidden;
                        СМонстр2.Visibility = Visibility.Visible;
                        ЖизниMонстр2.Value = ЖизниMонстр2.Maximum;
                    }
                }
                else if (СМонстр2.Visibility == Visibility.Visible & СМонстр1.Visibility == Visibility.Hidden)
                {
                    ЖизниMонстр2.Value -= сила1;
                    if (ЖизниMонстр2.Value <= 0)
                    {
                        опыт += Рандом.Next(70, 170);
                        ОпытГород.Text = опыт.ToString();
                        монеты += Рандом.Next(30, 130);
                        МонетыГород.Text = монеты.ToString() + " ₣";

                        СМонстр1.Visibility = Visibility.Visible;
                        СМонстр2.Visibility = Visibility.Hidden;
                        ЖизниMонстр1.Value = ЖизниMонстр1.Maximum;
                    }
                }
            }
            else if (ХодыГород == 3 | ХодыГород == 6 | ХодыГород == 9) //Бот------------------------------------------
            {
                if (СМонстр1.Visibility == Visibility.Visible & СМонстр2.Visibility == Visibility.Hidden)
                {
                    ХодыАтакаКакогоГерояГород = Рандом.Next(1, 2);
                    if (ХодыАтакаКакогоГерояГород == 1 & СписокГероев1.Text != ВсеГерои[24])
                    {
                        if (СписокГероев1.Text == МоиГерои[0])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой1.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[1])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой2.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[2])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой3.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[3])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой4.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[4])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой5.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[5])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой6.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[6])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой7.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[7])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой8.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[8])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой9.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[9])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой10.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[10])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой11.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[11])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой12.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[12])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой13.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[13])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой14.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[14])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой15.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[15])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой16.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[16])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой17.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[17])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой18.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[18])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой19.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[19])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой20.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[20])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой21.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[21])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой22.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[22])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой23.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев1.Text == МоиГерои[23])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой24.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }
                    }
                    else if(ХодыАтакаКакогоГерояГород == 2 & СписокГероев2.Text != ВсеГерои[24])
                    {
                        if (СписокГероев2.Text == МоиГерои[0])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой1.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[1])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой2.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[2])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой3.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[3])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой4.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[4])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой5.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[5])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой6.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[6])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой7.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[7])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой8.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[8])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой9.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[9])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой10.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[10])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой11.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[11])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой12.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[12])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой13.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[13])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой14.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[14])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой15.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[15])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой16.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[16])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой17.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[17])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой18.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[18])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой19.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[19])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой20.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[20])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой21.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[21])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой22.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[22])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой23.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }

                        else if (СписокГероев2.Text == МоиГерои[23])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой24.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; вирус += 1; Вирус.Value = вирус; }
                    }
                    else if (ХодыАтакаКакогоГерояГород == 1 & СписокГероев1.Text == ВсеГерои[24] | ХодыАтакаКакогоГерояГород == 2 & СписокГероев2.Text == ВсеГерои[24])
                    { }
                }
                else if (СМонстр2.Visibility == Visibility.Visible & СМонстр1.Visibility == Visibility.Hidden)
                {
                    ХодыАтакаКакогоГерояГород = Рандом.Next(1, 2);
                    if (ХодыАтакаКакогоГерояГород == 1 & СписокГероев1.Text != ВсеГерои[24])
                    {
                        if (СписокГероев1.Text == МоиГерои[0])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой1.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[1])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой2.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[2])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой3.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[3])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой4.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[4])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой5.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[5])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой6.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[6])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой7.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[7])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой8.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[8])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой9.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[9])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой10.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[10])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой11.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[11])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой12.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[12])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой13.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[13])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой14.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[14])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой15.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[15])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой16.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[16])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой17.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[17])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой18.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[18])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой19.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[19])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой20.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[20])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой21.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[21])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой22.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[22])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой23.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев1.Text == МоиГерои[23])
                        { ЖизниГеройБой1.Value -= 5; ЖизниГерой24.Value = ЖизниГеройБой1.Value; жизни -= 5; Жизни.Value = жизни; }
                    }
                    else if (ХодыАтакаКакогоГерояГород == 2 & СписокГероев2.Text != ВсеГерои[24])
                    {
                        if (СписокГероев2.Text == МоиГерои[0])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой1.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[1])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой2.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[2])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой3.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[3])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой4.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[4])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой5.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[5])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой6.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[6])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой7.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[7])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой8.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[8])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой9.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[9])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой10.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[10])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой11.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[11])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой12.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[12])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой13.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[13])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой14.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[14])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой15.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[15])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой16.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[16])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой17.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[17])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой18.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[18])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой19.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[19])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой20.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[20])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой21.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[21])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой22.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[22])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой23.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[23])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой24.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }
                    }
                    else if (ХодыАтакаКакогоГерояГород == 1 & СписокГероев1.Text == ВсеГерои[24] | ХодыАтакаКакогоГерояГород == 2 & СписокГероев2.Text == ВсеГерои[24] )
                    { }
                }
            }
            if (ХодыГород >= 9)
            {
                ХодыГород = 0;
            }
            if (СписокГероев1.Text == "ПУСТО" | ЖизниГеройБой1.Value <= 0)
            {
                АтакаГерой1.Source = null;
                ЖизниГеройБой1.Visibility = Visibility.Hidden;
                Атака1.Visibility = Visibility.Hidden;
                ЖизниГеройБой1.Maximum = 0;
                СписокГероев1.Text = "ПУСТО";
                MessageBox.Show("Герой #1 погиб в бою...", "Смерть", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (СписокГероев2.Text != "" & СписокГероев2.Text != "ПУСТО" & ЖизниГеройБой2.Value == 0)
            {
                АтакаГерой2.Source = null;
                ЖизниГеройБой2.Visibility = Visibility.Hidden;
                Атака2.Visibility = Visibility.Hidden;
                ЖизниГеройБой2.Maximum = 0;
                СписокГероев2.Text = "ПУСТО";
                MessageBox.Show("Герой #2 погиб в бою...", "Смерть", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if ( Жизни.Value == 0)
            {
                MessageBoxResult Смерть = MessageBox.Show("Ты потерял(а) всех героев и погиб(ла)!\nХотите начать с начала?", "Окончательная смерть", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (MessageBoxResult.No == Смерть)
                {
                    Close();
                }
                else
                {
                    Process.Start(Process.GetCurrentProcess().MainModule.FileName);
                    System.Windows.Application.Current.Shutdown();
                }
            }
            if (Вирус.Value == Вирус.Maximum)
            {
                MessageBoxResult Смерть = MessageBox.Show("Ты погиб(ла) от заражения!\nХотите начать с начала?", "Окончательная смерть", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (MessageBoxResult.No == Смерть)
                {
                    Close();
                }
                else
                {
                    Process.Start(Process.GetCurrentProcess().MainModule.FileName);
                    System.Windows.Application.Current.Shutdown();
                }
            }
        }

        private void Атака2_Click(object sender, RoutedEventArgs e)
        {
            ХодыГород += 1;
            ХодыАтакаКакогоГерояГород = Рандом.Next(1, 3);
            if (ХодыГород == 2 | ХодыГород == 5 | ХодыГород == 8) //Игрок------------------------------------------
            {
                if (СМонстр1.Visibility == Visibility.Visible & СМонстр2.Visibility == Visibility.Hidden)
                {
                    ЖизниMонстр1.Value -= сила1;
                    if (ЖизниMонстр1.Value <= 0)
                    {
                        опыт += Рандом.Next(50, 150);
                        ОпытГород.Text = опыт.ToString();
                        монеты += Рандом.Next(10, 100);
                        МонетыГород.Text = монеты.ToString() + " ₣";

                        СМонстр1.Visibility = Visibility.Hidden;
                        СМонстр2.Visibility = Visibility.Visible;
                        ЖизниMонстр2.Value = ЖизниMонстр2.Maximum;
                    }
                }
                else if (СМонстр2.Visibility == Visibility.Visible & СМонстр1.Visibility == Visibility.Hidden)
                {
                    ЖизниMонстр2.Value -= сила1;
                    if (ЖизниMонстр2.Value <= 0)
                    {
                        опыт += Рандом.Next(70, 170);
                        ОпытГород.Text = опыт.ToString();
                        монеты += Рандом.Next(30, 130);
                        МонетыГород.Text = монеты.ToString() + " ₣";

                        СМонстр1.Visibility = Visibility.Visible;
                        СМонстр2.Visibility = Visibility.Hidden;
                        ЖизниMонстр1.Value = ЖизниMонстр1.Maximum;
                    }
                }
            }
            else if (ХодыГород == 3 | ХодыГород == 6 | ХодыГород == 9) //Бот------------------------------------------
            {
                if (СМонстр1.Visibility == Visibility.Visible & СМонстр2.Visibility == Visibility.Hidden)
                {
                    if (ХодыАтакаКакогоГерояГород == 1 & СписокГероев2.Text != "ПУСТО" & СписокГероев2.Text != "")
                    {
                        if (СписокГероев2.Text == МоиГерои[0])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой1.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[1])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой2.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[2])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой3.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[3])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой4.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[4])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой5.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[5])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой6.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[6])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой7.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[7])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой8.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[8])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой9.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[9])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой10.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[10])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой11.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[11])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой12.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[12])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой13.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[13])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой14.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[14])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой15.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[15])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой16.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[16])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой17.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[17])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой18.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[18])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой19.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[19])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой20.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[20])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой21.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[21])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой22.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[22])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой23.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[23])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой24.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }
                    }
                    else if (ХодыАтакаКакогоГерояГород == 2 & СписокГероев2.Text != "ПУСТО" & СписокГероев2.Text != "")
                    {
                        if (СписокГероев2.Text == МоиГерои[0])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой1.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[1])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой2.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[2])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой3.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[3])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой4.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[4])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой5.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[5])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой6.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[6])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой7.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[7])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой8.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[8])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой9.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[9])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой10.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[10])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой11.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[11])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой12.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[12])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой13.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[13])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой14.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[14])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой15.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[15])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой16.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[16])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой17.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[17])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой18.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[18])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой19.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[19])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой20.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[20])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой21.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[21])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой22.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[22])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой23.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[23])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой24.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }
                    }
                    else if (ХодыАтакаКакогоГерояГород == 1 & СписокГероев1.Text != "ПУСТО" & СписокГероев1.Text != "" | ХодыАтакаКакогоГерояГород == 2 & СписокГероев2.Text != "ПУСТО" & СписокГероев2.Text != "")
                    { }
                }
                else if (СМонстр2.Visibility == Visibility.Visible & СМонстр1.Visibility == Visibility.Hidden)
                {
                    if (ХодыАтакаКакогоГерояГород == 1 & СписокГероев2.Text != "ПУСТО" & СписокГероев2.Text != "")
                    {
                        if (СписокГероев2.Text == МоиГерои[0])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой1.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[1])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой2.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[2])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой3.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[3])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой4.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[4])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой5.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[5])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой6.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[6])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой7.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[7])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой8.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[8])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой9.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[9])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой10.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[10])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой11.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[11])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой12.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[12])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой13.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[13])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой14.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[14])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой15.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[15])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой16.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[16])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой17.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[17])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой18.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[18])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой19.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[19])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой20.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[20])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой21.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[21])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой22.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[22])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой23.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[23])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой24.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }
                    }
                    else if (ХодыАтакаКакогоГерояГород == 2 & СписокГероев2.Text != "ПУСТО" & СписокГероев2.Text != "")
                    {
                        if (СписокГероев2.Text == МоиГерои[0])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой1.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[1])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой2.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[2])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой3.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[3])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой4.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[4])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой5.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[5])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой6.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[6])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой7.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[7])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой8.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[8])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой9.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[9])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой10.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[10])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой11.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[11])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой12.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[12])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой13.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[13])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой14.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[14])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой15.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[15])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой16.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[16])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой17.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[17])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой18.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[18])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой19.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[19])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой20.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[20])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой21.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[21])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой22.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[22])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой23.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }

                        else if (СписокГероев2.Text == МоиГерои[23])
                        { ЖизниГеройБой2.Value -= 5; ЖизниГерой24.Value = ЖизниГеройБой2.Value; жизни -= 5; Жизни.Value = жизни; }
                    }
                    else if (ХодыАтакаКакогоГерояГород == 1 & СписокГероев1.Text != "ПУСТО" & СписокГероев1.Text != "" | ХодыАтакаКакогоГерояГород == 2 & СписокГероев2.Text != "ПУСТО" & СписокГероев2.Text != "")
                    { }
                }
            }
            if (ХодыГород >= 9)
            {
                ХодыГород = 0;
            }
            if (СписокГероев2.Text == "ПУСТО" | ЖизниГеройБой2.Value <= 0)
            {
                АтакаГерой2.Source = null;
                ЖизниГеройБой2.Visibility = Visibility.Hidden;
                Атака2.Visibility = Visibility.Hidden;
                ЖизниГеройБой2.Maximum = 0;
                СписокГероев2.Text = "ПУСТО";
                MessageBox.Show("Герой #2 погиб в бою...", "Смерть", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (СписокГероев1.Text != "" & СписокГероев1.Text != "ПУСТО" & ЖизниГеройБой1.Value == 0)
            {
                АтакаГерой1.Source = null;
                ЖизниГеройБой1.Visibility = Visibility.Hidden;
                Атака1.Visibility = Visibility.Hidden;
                ЖизниГеройБой1.Maximum = 0;
                СписокГероев1.Text = "ПУСТО";
                MessageBox.Show("Герой #1 погиб в бою...", "Смерть", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (Жизни.Value == 0)
            {
                MessageBoxResult Смерть = MessageBox.Show("Ты потерял(а) всех героев и погиб(ла)!\nХотите начать с начала?", "Окончательная смерть", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (MessageBoxResult.No == Смерть)
                {
                    Close();
                }
                else
                {
                    Process.Start(Process.GetCurrentProcess().MainModule.FileName);
                    System.Windows.Application.Current.Shutdown();
                }
            }
        }

        private void ЗабратьОпытИМонетыГород_Click(object sender, RoutedEventArgs e)
        {
            моимонеты += монеты;
            Фикрики.Text = моимонеты.ToString() + " ₣";
            мойопыт += опыт;

            if (ЗакрытГерой1.Visibility == Visibility.Hidden)
            {
                ОпытГерой1.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой2.Visibility == Visibility.Hidden)
            {
                ОпытГерой2.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой3.Visibility == Visibility.Hidden)
            {
                ОпытГерой3.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой4.Visibility == Visibility.Hidden)
            {
                ОпытГерой4.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой5.Visibility == Visibility.Hidden)
            {
                ОпытГерой5.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой6.Visibility == Visibility.Hidden)
            {
                ОпытГерой6.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой7.Visibility == Visibility.Hidden)
            {
                ОпытГерой7.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой8.Visibility == Visibility.Hidden)
            {
                ОпытГерой8.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой9.Visibility == Visibility.Hidden)
            {
                ОпытГерой9.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой10.Visibility == Visibility.Hidden)
            {
                ОпытГерой10.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой11.Visibility == Visibility.Hidden)
            {
                ОпытГерой11.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой12.Visibility == Visibility.Hidden)
            {
                ОпытГерой12.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой13.Visibility == Visibility.Hidden)
            {
                ОпытГерой13.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой14.Visibility == Visibility.Hidden)
            {
                ОпытГерой14.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой15.Visibility == Visibility.Hidden)
            {
                ОпытГерой15.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой16.Visibility == Visibility.Hidden)
            {
                ОпытГерой16.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой17.Visibility == Visibility.Hidden)
            {
                ОпытГерой17.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой18.Visibility == Visibility.Hidden)
            {
                ОпытГерой18.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой19.Visibility == Visibility.Hidden)
            {
                ОпытГерой19.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой20.Visibility == Visibility.Hidden)
            {
                ОпытГерой20.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой21.Visibility == Visibility.Hidden)
            {
                ОпытГерой21.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой22.Visibility == Visibility.Hidden)
            {
                ОпытГерой22.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой23.Visibility == Visibility.Hidden)
            {
                ОпытГерой1.Value += Convert.ToInt32(ОпытГород.Text);
            }
            if (ЗакрытГерой24.Visibility == Visibility.Hidden)
            {
                ОпытГерой24.Value += Convert.ToInt32(ОпытГород.Text);
            }

            //Вирус.Maximum += 100;
            //Вирус.Maximum += 200;
            //Вирус.Maximum += 200;
            //Вирус.Maximum += 500;
            //Вирус.Maximum += 1000;
            //Вирус.Maximum += 1000;
            //Вирус.Maximum += 1000;
            //Вирус.Maximum += 1000;
            //Вирус.Maximum += 2000;
            //Вирус.Maximum += 2000;
            //Вирус.Maximum += 5000;
            //Вирус.Maximum += 5000;
            //Вирус.Maximum += 11000;
            //Всего: +30000

            //1
            if (ОпытГерой1.Value == 500 & уровень1 < 20)// Ур 1 - 20
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; жизни = всегожизней; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 500 & уровень1 == 20)
            { ОпытГерой1.Value = 0; ОпытГерой1.Maximum = 1500; сила1 += 5; ЖизниГерой1.Maximum += 200; ЖизниГерой1.Value = ЖизниГерой1.Maximum; уровень1 += 1; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }

            else if (ОпытГерой1.Value == 1500 & уровень1 > 20 & уровень1 < 30)// Ур 20 - 30
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 1500 & уровень1 == 30)
            { ОпытГерой1.Value = 0; ОпытГерой1.Maximum = 4000; сила1 += 5; ЖизниГерой1.Maximum += 200; ЖизниГерой1.Value = ЖизниГерой1.Maximum; уровень1 += 1; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }

            else if (ОпытГерой1.Value == 4000 & уровень1 > 30 & уровень1 < 60)// Ур 30 - 60
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 4000 & уровень1 == 60)
            { ОпытГерой1.Value = 0; ОпытГерой1.Maximum = 7000; сила1 += 5; ЖизниГерой1.Maximum += 200; ЖизниГерой1.Value = ЖизниГерой1.Maximum; уровень1 += 1; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }

            else if (ОпытГерой1.Value == 7000 & уровень1 > 60 & уровень1 < 90)// Ур 60 - 90
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 7000 & уровень1 == 90)
            { ОпытГерой1.Value = 0; ОпытГерой1.Maximum = 12000; сила1 += 5; ЖизниГерой1.Maximum += 200; ЖизниГерой1.Value = ЖизниГерой1.Maximum; уровень1 += 1; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }

            else if (ОпытГерой1.Value == 12000 & уровень1 > 90 & уровень1 < 120)// Ур 90 - 120
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 12000 & уровень1 == 120)
            { ОпытГерой1.Value = 0; ОпытГерой1.Maximum = 18000; сила1 += 5; ЖизниГерой1.Maximum += 200; ЖизниГерой1.Value = ЖизниГерой1.Maximum; уровень1 += 1; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }

            else if (ОпытГерой1.Value == 18000 & уровень1 > 120 & уровень1 < 160)// Ур 120 - 160
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 18000 & уровень1 == 160)
            { ОпытГерой1.Value = 0; ОпытГерой1.Maximum = 24000; сила1 += 10; ЖизниГерой1.Maximum += 400; ЖизниГерой1.Value = ЖизниГерой1.Maximum; уровень1 += 1; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }

            else if (ОпытГерой1.Value == 24000 & уровень1 > 160 & уровень1 < 220)// Ур 160 - 220
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 24000 & уровень1 == 220)
            { ОпытГерой1.Value = 0; ОпытГерой1.Maximum = 27000; сила1 += 10; ЖизниГерой1.Maximum += 400; ЖизниГерой1.Value = ЖизниГерой1.Maximum; уровень1 += 1; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }

            else if (ОпытГерой1.Value == 27000 & уровень1 > 220 & уровень1 < 270)// Ур 220 - 270
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 27000 & уровень1 == 270)
            { ОпытГерой1.Value = 0; ОпытГерой1.Maximum = 33000; сила1 += 10; ЖизниГерой1.Maximum += 400; ЖизниГерой1.Value = ЖизниГерой1.Maximum; уровень1 += 1; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }

            else if (ОпытГерой1.Value == 33000 & уровень1 > 270 & уровень1 < 300)// Ур 270 - 300
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 33000 & уровень1 == 300)
            { ОпытГерой1.Value = 0; ОпытГерой1.Maximum = 38000; сила1 += 10; ЖизниГерой1.Maximum += 400; ЖизниГерой1.Value = ЖизниГерой1.Maximum; уровень1 += 1; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }

            else if (ОпытГерой1.Value == 38000 & уровень1 > 300 & уровень1 < 360)// Ур 300 - 360
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 38000 & уровень1 == 360)
            { ОпытГерой1.Value = 0; ОпытГерой1.Maximum = 43000; сила1 += 20; ЖизниГерой1.Maximum += 600; ЖизниГерой1.Value = ЖизниГерой1.Maximum; уровень1 += 1; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }

            else if (ОпытГерой1.Value == 43000 & уровень1 > 360 & уровень1 < 410)// Ур 360 - 410
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 43000 & уровень1 == 410)
            { ОпытГерой1.Value = 0; ОпытГерой1.Maximum = 46000; сила1 += 20; ЖизниГерой1.Maximum += 600; ЖизниГерой1.Value = ЖизниГерой1.Maximum; уровень1 += 1; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }

            else if (ОпытГерой1.Value == 46000 & уровень1 > 410 & уровень1 < 460)// Ур 410 - 460
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 46000 & уровень1 == 460)
            { ОпытГерой1.Value = 0; ОпытГерой1.Maximum = 49000; сила1 += 20; ЖизниГерой1.Maximum += 600; ЖизниГерой1.Value = ЖизниГерой1.Maximum; уровень1 += 1; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }

            else if (ОпытГерой1.Value == 49000 & уровень1 > 460 & уровень1 < 500)// Ур 460 - 500
            { ОпытГерой1.Value = 0; уровень1 += 1; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); }
            else if (ОпытГерой1.Value == 49000 & уровень1 == 500)
            { уровень1 = 500; сила1 += 30; ЖизниГерой1.Maximum += 1000; ЖизниГерой1.Value = ЖизниГерой1.Maximum; LvlГерой1.Text = "Lvl " + уровень1.ToString(); MessageBox.Show($"{ВсеГерои[0]} достиг мах уровня!", "Ура!", MessageBoxButton.OK, MessageBoxImage.Information); }
           
            //2
            if (ОпытГерой2.Value == 500 & уровень2 < 20)// Ур 1 - 20
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 500 & уровень2 == 20)
            { ОпытГерой2.Value = 0; ОпытГерой2.Maximum = 1500; сила1 += 5; ЖизниГерой2.Maximum += 200; ЖизниГерой2.Value = ЖизниГерой2.Maximum; уровень2 += 1; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }

            else if (ОпытГерой2.Value == 1500 & уровень2 > 20 & уровень2 < 30)// Ур 20 - 30
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 1500 & уровень2 == 30)
            { ОпытГерой2.Value = 0; ОпытГерой2.Maximum = 4000; сила1 += 5; ЖизниГерой2.Maximum += 200; ЖизниГерой2.Value = ЖизниГерой2.Maximum; уровень2 += 1; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }

            else if (ОпытГерой2.Value == 4000 & уровень2 > 30 & уровень2 < 60)// Ур 30 - 60
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 4000 & уровень2 == 60)
            { ОпытГерой2.Value = 0; ОпытГерой2.Maximum = 7000; сила1 += 5; ЖизниГерой2.Maximum += 200; ЖизниГерой2.Value = ЖизниГерой2.Maximum; уровень2 += 1; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }

            else if (ОпытГерой2.Value == 7000 & уровень2 > 60 & уровень2 < 90)// Ур 60 - 90
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 7000 & уровень2 == 90)
            { ОпытГерой2.Value = 0; ОпытГерой2.Maximum = 12000; сила1 += 5; ЖизниГерой2.Maximum += 200; ЖизниГерой2.Value = ЖизниГерой2.Maximum; уровень2 += 1; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }

            else if (ОпытГерой2.Value == 12000 & уровень2 > 90 & уровень2 < 120)// Ур 90 - 120
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 12000 & уровень2 == 120)
            { ОпытГерой2.Value = 0; ОпытГерой2.Maximum = 18000; сила1 += 5; ЖизниГерой2.Maximum += 200; ЖизниГерой2.Value = ЖизниГерой2.Maximum; уровень2 += 1; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }

            else if (ОпытГерой2.Value == 18000 & уровень2 > 120 & уровень2 < 160)// Ур 120 - 160
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 18000 & уровень2 == 160)
            { ОпытГерой2.Value = 0; ОпытГерой2.Maximum = 24000; сила1 += 10; ЖизниГерой2.Maximum += 400; ЖизниГерой2.Value = ЖизниГерой2.Maximum; уровень2 += 1; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }

            else if (ОпытГерой2.Value == 24000 & уровень2 > 160 & уровень2 < 220)// Ур 160 - 220
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 24000 & уровень2 == 220)
            { ОпытГерой2.Value = 0; ОпытГерой2.Maximum = 27000; сила1 += 10; ЖизниГерой2.Maximum += 400; ЖизниГерой2.Value = ЖизниГерой2.Maximum; уровень2 += 1; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }

            else if (ОпытГерой2.Value == 27000 & уровень2 > 220 & уровень2 < 270)// Ур 220 - 270
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 27000 & уровень2 == 270)
            { ОпытГерой2.Value = 0; ОпытГерой2.Maximum = 33000; сила1 += 10; ЖизниГерой2.Maximum += 400; ЖизниГерой2.Value = ЖизниГерой2.Maximum; уровень2 += 1; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }

            else if (ОпытГерой2.Value == 33000 & уровень2 > 270 & уровень2 < 300)// Ур 270 - 300
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 33000 & уровень2 == 300)
            { ОпытГерой2.Value = 0; ОпытГерой2.Maximum = 38000; сила1 += 10; ЖизниГерой2.Maximum += 400; ЖизниГерой2.Value = ЖизниГерой2.Maximum; уровень2 += 1; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }

            else if (ОпытГерой2.Value == 38000 & уровень2 > 300 & уровень2 < 360)// Ур 300 - 360
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 38000 & уровень2 == 360)
            { ОпытГерой2.Value = 0; ОпытГерой2.Maximum = 43000; сила1 += 20; ЖизниГерой2.Maximum += 600; ЖизниГерой2.Value = ЖизниГерой2.Maximum; уровень2 += 1; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }

            else if (ОпытГерой2.Value == 43000 & уровень2 > 360 & уровень2 < 410)// Ур 360 - 410
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 43000 & уровень2 == 410)
            { ОпытГерой2.Value = 0; ОпытГерой2.Maximum = 46000; сила1 += 20; ЖизниГерой2.Maximum += 600; ЖизниГерой2.Value = ЖизниГерой2.Maximum; уровень2 += 1; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }

            else if (ОпытГерой2.Value == 46000 & уровень2 > 410 & уровень2 < 460)// Ур 410 - 460
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 46000 & уровень2 == 460)
            { ОпытГерой2.Value = 0; ОпытГерой2.Maximum = 49000; сила1 += 20; ЖизниГерой2.Maximum += 600; ЖизниГерой2.Value = ЖизниГерой2.Maximum; уровень2 += 1; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }

            else if (ОпытГерой2.Value == 49000 & уровень2 > 460 & уровень2 < 500)// Ур 460 - 500
            { ОпытГерой2.Value = 0; уровень2 += 1; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); }
            else if (ОпытГерой2.Value == 49000 & уровень2 == 500)
            { уровень2 = 500; сила1 += 30; ЖизниГерой2.Maximum += 1000; ЖизниГерой2.Value = ЖизниГерой2.Maximum; LvlГерой2.Text = "Lvl " + уровень2.ToString(); MessageBox.Show($"{ВсеГерои[1]} достиг мах уровня!", "Ура!", MessageBoxButton.OK, MessageBoxImage.Information); }

            //3
            if (ОпытГерой3.Value == 500 & уровень3 < 20)// Ур 1 - 20
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой2.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 500 & уровень3 == 20)
            { ОпытГерой3.Value = 0; ОпытГерой3.Maximum = 1500; сила1 += 5; ЖизниГерой3.Maximum += 200; ЖизниГерой3.Value = ЖизниГерой3.Maximum; уровень3 += 1; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }

            else if (ОпытГерой3.Value == 1500 & уровень3 > 20 & уровень3 < 30)// Ур 20 - 30
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 1500 & уровень3 == 30)
            { ОпытГерой3.Value = 0; ОпытГерой3.Maximum = 4000; сила1 += 5; ЖизниГерой3.Maximum += 200; ЖизниГерой3.Value = ЖизниГерой3.Maximum; уровень3 += 1; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }

            else if (ОпытГерой3.Value == 4000 & уровень3 > 30 & уровень3 < 60)// Ур 30 - 60
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 4000 & уровень3 == 60)
            { ОпытГерой3.Value = 0; ОпытГерой3.Maximum = 7000; сила1 += 5; ЖизниГерой3.Maximum += 200; ЖизниГерой3.Value = ЖизниГерой3.Maximum; уровень3 += 1; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }

            else if (ОпытГерой3.Value == 7000 & уровень3 > 60 & уровень3 < 90)// Ур 60 - 90
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 7000 & уровень3 == 90)
            { ОпытГерой3.Value = 0; ОпытГерой3.Maximum = 12000; сила1 += 5; ЖизниГерой3.Maximum += 200; ЖизниГерой3.Value = ЖизниГерой3.Maximum; уровень3 += 1; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }

            else if (ОпытГерой3.Value == 12000 & уровень3 > 90 & уровень3 < 120)// Ур 90 - 120
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 12000 & уровень3 == 120)
            { ОпытГерой3.Value = 0; ОпытГерой3.Maximum = 18000; сила1 += 5; ЖизниГерой3.Maximum += 200; ЖизниГерой3.Value = ЖизниГерой3.Maximum; уровень3 += 1; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }

            else if (ОпытГерой3.Value == 18000 & уровень3 > 120 & уровень3 < 160)// Ур 120 - 160
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 18000 & уровень3 == 160)
            { ОпытГерой3.Value = 0; ОпытГерой3.Maximum = 24000; сила1 += 10; ЖизниГерой3.Maximum += 400; ЖизниГерой3.Value = ЖизниГерой3.Maximum; уровень3 += 1; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }

            else if (ОпытГерой3.Value == 24000 & уровень3 > 160 & уровень3 < 220)// Ур 160 - 220
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 24000 & уровень3 == 220)
            { ОпытГерой3.Value = 0; ОпытГерой3.Maximum = 27000; сила1 += 10; ЖизниГерой3.Maximum += 400; ЖизниГерой3.Value = ЖизниГерой3.Maximum; уровень3 += 1; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }

            else if (ОпытГерой3.Value == 27000 & уровень3 > 220 & уровень3 < 270)// Ур 220 - 270
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 27000 & уровень3 == 270)
            { ОпытГерой3.Value = 0; ОпытГерой3.Maximum = 33000; сила1 += 10; ЖизниГерой3.Maximum += 400; ЖизниГерой3.Value = ЖизниГерой3.Maximum; уровень3 += 1; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }

            else if (ОпытГерой3.Value == 33000 & уровень3 > 270 & уровень3 < 300)// Ур 270 - 300
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 33000 & уровень3 == 300)
            { ОпытГерой3.Value = 0; ОпытГерой3.Maximum = 38000; сила1 += 10; ЖизниГерой3.Maximum += 400; ЖизниГерой3.Value = ЖизниГерой3.Maximum; уровень3 += 1; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }

            else if (ОпытГерой3.Value == 38000 & уровень3 > 300 & уровень3 < 360)// Ур 300 - 360
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 38000 & уровень3 == 360)
            { ОпытГерой3.Value = 0; ОпытГерой3.Maximum = 43000; сила1 += 20; ЖизниГерой3.Maximum += 600; ЖизниГерой3.Value = ЖизниГерой3.Maximum; уровень3 += 1; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }

            else if (ОпытГерой3.Value == 43000 & уровень3 > 360 & уровень3 < 410)// Ур 360 - 410
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 43000 & уровень3 == 410)
            { ОпытГерой3.Value = 0; ОпытГерой3.Maximum = 46000; сила1 += 20; ЖизниГерой3.Maximum += 600; ЖизниГерой3.Value = ЖизниГерой3.Maximum; уровень3 += 1; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }

            else if (ОпытГерой3.Value == 46000 & уровень3 > 410 & уровень3 < 460)// Ур 410 - 460
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 46000 & уровень3 == 460)
            { ОпытГерой3.Value = 0; ОпытГерой3.Maximum = 49000; сила1 += 20; ЖизниГерой3.Maximum += 600; ЖизниГерой3.Value = ЖизниГерой3.Maximum; уровень3 += 1; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }

            else if (ОпытГерой3.Value == 49000 & уровень3 > 460 & уровень3 < 500)// Ур 460 - 500
            { ОпытГерой3.Value = 0; уровень3 += 1; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); }
            else if (ОпытГерой3.Value == 49000 & уровень3 == 500)
            { уровень3 = 500; сила1 += 30; ЖизниГерой3.Maximum += 1000; ЖизниГерой3.Value = ЖизниГерой3.Maximum; LvlГерой3.Text = "Lvl " + уровень3.ToString(); MessageBox.Show($"{ВсеГерои[2]} достиг мах уровня!", "Ура!", MessageBoxButton.OK, MessageBoxImage.Information); }

            //4


            //5


            //6


            //7


            //8


            //9


            //10


            //11


            //12


            //13


            //14


            //15


            //16


            //17


            //18


            //19


            //20


            //21


            //22


            //23


            //24


            монеты = 0;
            опыт = 0;
            ОпытГород.Text = 0.ToString();
            МонетыГород.Text = 0.ToString() + " ₣";
        }

        private void ЛечитьВирус_Click(object sender, RoutedEventArgs e)
        {
            if (z1.IsChecked == true & АнтизаразаСредняя > 0)
            {
                if (вирус > 0)
                {
                    АнтизаразаСредняя -= 1;
                    вирус -= 100;
                    if (вирус <= 0)
                    {
                        вирус = 0;
                    }
                    Вирус.Value = вирус;
                    АнтизаразаСр.Text = АнтизаразаСредняя + " шт.";
                }
                else if (вирус <= 0)
                {
                    MessageBox.Show("Вы здоровы!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else if (z1.IsChecked == true & АнтизаразаСредняя <= 0)
            {
               MessageBox.Show("Нет данного вида антизаразы!\nЕе можно купить в магазине.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (z2.IsChecked == true & АнтизаразаБольшая > 0)
            {
                if (вирус > 0)
                {
                    АнтизаразаБольшая -= 1;
                    вирус -= 500;
                    if (вирус <= 0)
                    {
                        вирус = 0;
                    }
                    Вирус.Value = вирус;
                    АнтизаразаБол.Text = АнтизаразаБольшая + " шт.";
                }
                else if (вирус <= 0)
                {
                    MessageBox.Show("Вы здоровы!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else if (z2.IsChecked == true & АнтизаразаБольшая <= 0)
            {
                MessageBox.Show("Нет данного вида антизаразы!\nЕе можно купить в магазине.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void z1_Click(object sender, RoutedEventArgs e)
        {
            if (z1.IsChecked == true)
            {
                СрАнтизаразаИнфо.Foreground = Brushes.LightGray;
                БолАнтизаразаИнфо.Foreground = Brushes.White;
            }
        }

        private void z2_Click(object sender, RoutedEventArgs e)
        {
            if (z2.IsChecked == true)
            {
                БолАнтизаразаИнфо.Foreground = Brushes.LightGray;
                СрАнтизаразаИнфо.Foreground = Brushes.White;
            }
        }
    }
}