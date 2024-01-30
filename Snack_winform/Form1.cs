namespace Snack_winform
{
    public partial class Form1 : Form
    {
        RandNum randnum;


        public Form1()
        {
            InitializeComponent();
            CreateNum();
            ScanNum();
        }

        private void Enter_Click(object? sender, EventArgs e)
        {
            if (InputText.Text != "")
            {
                OutputText.AppendText("����� : " + InputText.Text + "\r\n");
                ReceiveNum();
                InputText.Text = "";
            }
        }

        private void CreateNum()
        {
            randnum = new RandNum();
            OutputText.AppendText("���ڰ� �����Ǿ����ϴ�. (1000-9999 ������ ��)\r\n");
        }

        private void ScanNum()
        {
            int num = randnum.SetNum;
            //MessageBox.Show(randnum.GetCalcResult(num));
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            randnum.CreateNum();
            int num = randnum.SetNum;
        }

        private void End_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextboxDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && InputText.Text != "")
            {
                OutputText.AppendText("����� : " + InputText.Text + "\r\n");
                ReceiveNum();
                InputText.Text = "";
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            int num = randnum.SetNum;
            OutputText.AppendText("������ : " + num + "�Դϴ�.\r\n");
            randnum.CreateNum();
        }

        private void ReceiveNum()
        {
            int text = Convert.ToInt32(InputText.Text);
            randnum.SetNum = text;
            randnum.CompareResult();
            int ball = randnum.GetBall;
            int strike = randnum.GetStrike;
            if (InputText.Text.Trim().Length != 4)
            {
                OutputText.AppendText("4�ڸ� ���ڸ� �Է����ּ���.\r\n");
            }
            else
            {
                if(strike == 4)
                {
                    OutputText.AppendText("�����Դϴ�~\r\n");
                    randnum.CreateNum();
                    OutputText.AppendText("�� ���� ����~\r\n");
                }
                else
                {
                    if(strike == 0 && ball == 0)
                    {
                        OutputText.AppendText("�ƿ�! \r\n");
                    }
                    else
                    {
                        OutputText.AppendText(strike + " ��Ʈ����ũ, " + ball + " �� \r\n");
                    }
                }
            }
        }
    }
}
