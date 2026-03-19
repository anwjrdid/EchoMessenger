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
            if (input_window.Text.Length > 50) // 메시지 길이 제한 (50자)
            {
                MessageBox.Show("메시지는 50자 이내로 입력해주세요!", "경고");
                return;
            }

            // 앞뒤 공백 제거 (Trim)
            string raw_msg = input_window.Text.Trim();

            // 입력 방어 (공백 제외하고 내용이 있는지 확인)
            if (string.IsNullOrWhiteSpace(raw_msg))
            {
                return;
            }

            string typed_msg = input_window.Text; // 입력창에 입력된 텍스트를 가져와서 typed_msg 변수에 저장

            // 현재 시간 구하기 (yyyy-MM-dd HH:mm:ss 형식)
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // 시간과 메시지 결합해서 리스트박스에 추가
            string final_msg = $"[{time}] {raw_msg}";
            output_window.Items.Add(final_msg);

            // 메시지 개수 업데이트 
            lbl_Count.Text = $"현재 대화: {output_window.Items.Count}개";

            // 마무리 (비우고 포커스)
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

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            // 항목이 선택되어 있는지 확인 (예외 처리) 
            if (output_window.SelectedIndex != -1)
            {
                output_window.Items.RemoveAt(output_window.SelectedIndex);
                // 삭제 후 개수 레이블 업데이트 
                lbl_Count.Text = $"현재 대화: {output_window.Items.Count}개";
            }
            else
            {
                MessageBox.Show("삭제할 메시지를 선택해주세요!");
            }
        }

        private void Btn_ClearAll_Click(object sender, EventArgs e)
        {
            output_window.Items.Clear();
            lbl_Count.Text = "현재 대화: 0개";

        }
    }
}
