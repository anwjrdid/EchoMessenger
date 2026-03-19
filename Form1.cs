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
            string typed_msg = input_window.Text; // 입력창에 입력된 텍스트를 가져와서 typed_msg 변수에 저장

            output_window.Items.Add(typed_msg); // output_window 리스트박스에 typed_msg를 추가하여 출력창에 메시지를 표시

            input_window.Clear(); // 입력창을 비워서 다음 메시지를 입력할 수 있도록 준비
        }
    }
}
