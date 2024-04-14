namespace lab4tp
{
     
    public partial class Form1 : Form
    {
        List<Weather> weathersList = new List<Weather>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.weathersList.Clear();
            var rnd = new Random();
            for (var i=0;i<10;i++)
            {
                switch(rnd.Next()%3)// генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0:
                        this.weathersList.Add(Sun.Generate());
                        break;
                    case 1:
                        this.weathersList.Add(Rain.Generate());
                        break;
                    case 2:
                        this.weathersList.Add(Snow.Generate());
                        break;
                }
            }
            ShowInfo();
        }
       
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.weathersList.Count == 0) txtOut.Text = "Погоды нет,жди Q_Q";
            else
            {
                // взяли первый фрукт
                var weather = this.weathersList[0];
                // тут вам не реальность, взятие это на самом деле создание указателя на область в памяти
                // где хранится экземпляр класса, так что если хочешь удалить, делай это сам
                this.weathersList.RemoveAt(0);
                // ну а теперь предложим покупателю его фрукт
                txtOut.Text =weather.GetInfo();
                // обновим информацию о количестве товара на форме
                ShowInfo();
            }
        }
        // функция выводит информацию о количестве фруктов на форму
        private void ShowInfo()
        {
            //заведём счётчики под каждый тип
            int sunsCount = 0;
            int rainssCount = 0;
            int snowCount = 0;
            //пройдёмся по всему списку
            foreach (var Weather in this.weathersList)
            {
                if (Weather is Sun) { sunsCount++; }
                else if (Weather is Rain) { rainssCount++; }
                else if (Weather is Snow) { snowCount++; }
            }
            // а ну и вывести все это надо на форму
            txtInfo.Text = "Cолнце\tДождь\tСнег"; // буквы экнмлю, чтобы влезло на форму
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", sunsCount, rainssCount, snowCount);

        }
    }
}
