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
                switch(rnd.Next()%3)// ��������� ��������� ����� �� 0 �� 2 (�� ������� �� ������� �� 3)
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
            if (this.weathersList.Count == 0) txtOut.Text = "������ ���,��� Q_Q";
            else
            {
                // ����� ������ �����
                var weather = this.weathersList[0];
                // ��� ��� �� ����������, ������ ��� �� ����� ���� �������� ��������� �� ������� � ������
                // ��� �������� ��������� ������, ��� ��� ���� ������ �������, ����� ��� ���
                this.weathersList.RemoveAt(0);
                // �� � ������ ��������� ���������� ��� �����
                txtOut.Text =weather.GetInfo();
                // ������� ���������� � ���������� ������ �� �����
                ShowInfo();
            }
        }
        // ������� ������� ���������� � ���������� ������� �� �����
        private void ShowInfo()
        {
            //������ �������� ��� ������ ���
            int sunsCount = 0;
            int rainssCount = 0;
            int snowCount = 0;
            //�������� �� ����� ������
            foreach (var Weather in this.weathersList)
            {
                if (Weather is Sun) { sunsCount++; }
                else if (Weather is Rain) { rainssCount++; }
                else if (Weather is Snow) { snowCount++; }
            }
            // � �� � ������� ��� ��� ���� �� �����
            txtInfo.Text = "C�����\t�����\t����"; // ����� ������, ����� ������ �� �����
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", sunsCount, rainssCount, snowCount);

        }
    }
}
