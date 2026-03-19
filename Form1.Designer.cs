namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            output_window = new ListBox();
            input_window = new TextBox();
            Btn_Forwarding = new Button();
            lbl_Count = new Label();
            Btn_Delete = new Button();
            Btn_ClearAll = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("문체부 훈민정음체", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(307, 45);
            label1.TabIndex = 0;
            label1.Text = "Echo Messenger";
            // 
            // output_window
            // 
            output_window.FormattingEnabled = true;
            output_window.Location = new Point(12, 66);
            output_window.Name = "output_window";
            output_window.Size = new Size(546, 264);
            output_window.TabIndex = 1;
            // 
            // input_window
            // 
            input_window.Location = new Point(12, 350);
            input_window.Name = "input_window";
            input_window.Size = new Size(439, 27);
            input_window.TabIndex = 2;
            input_window.KeyDown += input_window_KeyDown;
            // 
            // Btn_Forwarding
            // 
            Btn_Forwarding.BackColor = Color.LawnGreen;
            Btn_Forwarding.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Btn_Forwarding.Location = new Point(457, 338);
            Btn_Forwarding.Name = "Btn_Forwarding";
            Btn_Forwarding.Size = new Size(101, 50);
            Btn_Forwarding.TabIndex = 3;
            Btn_Forwarding.Text = "전송";
            Btn_Forwarding.UseVisualStyleBackColor = false;
            Btn_Forwarding.Click += Btn_Forwarding_Click;
            // 
            // lbl_Count
            // 
            lbl_Count.AutoSize = true;
            lbl_Count.Location = new Point(12, 380);
            lbl_Count.Name = "lbl_Count";
            lbl_Count.Size = new Size(0, 20);
            lbl_Count.TabIndex = 4;
            // 
            // Btn_Delete
            // 
            Btn_Delete.Location = new Point(357, 25);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Size = new Size(94, 29);
            Btn_Delete.TabIndex = 5;
            Btn_Delete.Text = "삭제";
            Btn_Delete.UseVisualStyleBackColor = true;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // Btn_ClearAll
            // 
            Btn_ClearAll.Location = new Point(464, 25);
            Btn_ClearAll.Name = "Btn_ClearAll";
            Btn_ClearAll.Size = new Size(94, 29);
            Btn_ClearAll.TabIndex = 6;
            Btn_ClearAll.Text = "초기화";
            Btn_ClearAll.UseVisualStyleBackColor = true;
            Btn_ClearAll.Click += Btn_ClearAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 409);
            Controls.Add(Btn_ClearAll);
            Controls.Add(Btn_Delete);
            Controls.Add(lbl_Count);
            Controls.Add(Btn_Forwarding);
            Controls.Add(input_window);
            Controls.Add(output_window);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox output_window;
        private TextBox input_window;
        private Button Btn_Forwarding;
        private Label lbl_Count;
        private Button Btn_Delete;
        private Button Btn_ClearAll;
    }
}
