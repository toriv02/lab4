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
                switch(rnd.Next()%3)// ��������� ��������� ����� �� 0 �� 2 (�� ������� �� ������� �� 3)
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
            if (this.fruitsList.Count == 0) txtOut.Text = "������� ���,��� Q_Q";
            else
            {
                // ����� ������ �����
                var fruit = this.fruitsList[0];
                // ��� ��� �� ����������, ������ ��� �� ����� ���� �������� ��������� �� ������� � ������
                // ��� �������� ��������� ������, ��� ��� ���� ������ �������, ����� ��� ���
                this.fruitsList.RemoveAt(0);
                // �� � ������ ��������� ���������� ��� �����
                txtOut.Text =fruit.GetInfo();
                // ������� ���������� � ���������� ������ �� �����
                ShowInfo();
            }
        }
        // ������� ������� ���������� � ���������� ������� �� �����
        private void ShowInfo()
        {
            //������ �������� ��� ������ ���
            int mandarinsCount = 0;
            int grapesCount = 0;
            int WatermelonCount = 0;
            //�������� �� ����� ������
            foreach (var fruit in this.fruitsList)
            {
                if (fruit is Mandarin) { mandarinsCount++; }
                else if (fruit is Grapes) { grapesCount++; }
                else if (fruit is Watermelon) { WatermelonCount++; }
            }
            // � �� � ������� ��� ��� ���� �� �����
            txtInfo.Text = "�����\t�����\t�����"; // ����� ������, ����� ������ �� �����
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", mandarinsCount, grapesCount, WatermelonCount);

        }
    }
}
