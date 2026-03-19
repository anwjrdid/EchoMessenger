namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Forwarding_Click(object sender, EventArgs e)
        {
            //입력 방어 (공백 제외하고 내용이 있는지 확인)
            if (string.IsNullOrWhiteSpace(input_window.Text))
            {
                return;
            }

            string typed_msg = input_window.Text; // 입력창에 입력된 텍스트를 가져와서 typed_msg 변수에 저장

            output_window.Items.Add(typed_msg); // output_window 리스트박스에 typed_msg를 추가하여 출력창에 메시지를 표시

            input_window.Clear(); // 입력창을 비워서 다음 메시지를 입력할 수 있도록 준비

            //마무리(비우고 포커스)
            input_window.Clear();
            input_window.Focus();
        }

        private void input_window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 눌린 키가 엔터(Enter) 키인지 확인 
            {
                Btn_Forwarding.PerformClick(); // 전송 버튼 클릭 이벤트를 강제로 실행시킴

                e.SuppressKeyPress = true; // 엔터 입력 시 '띵' 소리가 나는 걸 방지 (선택 사항)
            }
        }
    }
}
