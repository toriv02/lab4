namespace lab4tp
{
     
    public partial class Form1 : Form
    {
        List<Fruit> fruitsList = new List<Fruit>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.fruitsList.Clear();
            var rnd = new Random();
            for (var i=0;i<10;i++)
            {
                switch(rnd.Next()%3)// генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0:
                        this.fruitsList.Add(Mandarin.Generate());
                        break;
                    case 1:
                        this.fruitsList.Add(Grapes.Generate());
                        break;
                    case 2:
                        this.fruitsList.Add(Watermelon.Generate());
                        break;
                }
            }
            ShowInfo();
        }
       
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.fruitsList.Count == 0) txtOut.Text = "Товаров нет,жди Q_Q";
            else
            {
                // взяли первый фрукт
                var fruit = this.fruitsList[0];
                // тут вам не реальность, взятие это на самом деле создание указателя на область в памяти
                // где хранится экземпляр класса, так что если хочешь удалить, делай это сам
                this.fruitsList.RemoveAt(0);
                // ну а теперь предложим покупателю его фрукт
                txtOut.Text =fruit.GetInfo();
                // обновим информацию о количестве товара на форме
                ShowInfo();
            }
        }
        // функция выводит информацию о количестве фруктов на форму
        private void ShowInfo()
        {
            //заведём счётчики под каждый тип
            int mandarinsCount = 0;
            int grapesCount = 0;
            int WatermelonCount = 0;
            //пройдёмся по всему списку
            foreach (var fruit in this.fruitsList)
            {
                if (fruit is Mandarin) { mandarinsCount++; }
                else if (fruit is Grapes) { grapesCount++; }
                else if (fruit is Watermelon) { WatermelonCount++; }
            }
            // а ну и вывести все это надо на форму
            txtInfo.Text = "Мндрн\tВнгрд\tАрбуз"; // буквы экнмлю, чтобы влезло на форму
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", mandarinsCount, grapesCount, WatermelonCount);

        }
    }
}
