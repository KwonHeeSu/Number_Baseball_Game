namespace Snack_winform
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
            InputText = new TextBox();
            Enter = new Button();
            OutputText = new TextBox();
            button1 = new Button();
            End = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // InputText
            // 
            InputText.Location = new Point(12, 416);
            InputText.Name = "InputText";
            InputText.Size = new Size(452, 23);
            InputText.TabIndex = 1;
            InputText.KeyDown += TextboxDown;
            // 
            // Enter
            // 
            Enter.Location = new Point(470, 416);
            Enter.Name = "Enter";
            Enter.Size = new Size(48, 24);
            Enter.TabIndex = 2;
            Enter.Text = "입력";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // OutputText
            // 
            OutputText.BackColor = SystemColors.Window;
            OutputText.CausesValidation = false;
            OutputText.Location = new Point(12, 12);
            OutputText.Multiline = true;
            OutputText.Name = "OutputText";
            OutputText.ReadOnly = true;
            OutputText.ScrollBars = ScrollBars.Vertical;
            OutputText.Size = new Size(427, 398);
            OutputText.TabIndex = 4;
            OutputText.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(445, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 5;
            button1.Text = "새 게임";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Reset_Click;
            // 
            // End
            // 
            End.Location = new Point(445, 375);
            End.Name = "End";
            End.Size = new Size(75, 35);
            End.TabIndex = 6;
            End.Text = "종료";
            End.UseVisualStyleBackColor = true;
            End.Click += End_Click;
            // 
            // button2
            // 
            button2.Location = new Point(445, 53);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 7;
            button2.Text = "정답보기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NewGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 450);
            Controls.Add(button2);
            Controls.Add(End);
            Controls.Add(button1);
            Controls.Add(OutputText);
            Controls.Add(Enter);
            Controls.Add(InputText);
            Name = "Form1";
            Text = "숫자 야구 게임";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputText;
        private Button Enter;
        private TextBox OutputText;
        private Button button1;
        private Button End;
        private Button button2;
    }
}
