namespace Hello_world_win
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
            btn_hello = new Button();
            lbl_hello = new Label();
            btn_color = new Button();
            SuspendLayout();
            // 
            // btn_hello
            // 
            btn_hello.Location = new Point(0, 0);
            btn_hello.Name = "btn_hello";
            btn_hello.Size = new Size(75, 23);
            btn_hello.TabIndex = 0;
            btn_hello.Text = "hello";
            btn_hello.UseVisualStyleBackColor = true;
            btn_hello.Click += button1_Click;
            // 
            // lbl_hello
            // 
            lbl_hello.AutoSize = true;
            lbl_hello.Location = new Point(60, 107);
            lbl_hello.Name = "lbl_hello";
            lbl_hello.Size = new Size(0, 15);
            lbl_hello.TabIndex = 1;
            // 
            // btn_color
            // 
            btn_color.Location = new Point(125, 0);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(144, 23);
            btn_color.TabIndex = 2;
            btn_color.Text = "Change Color";
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 331);
            Controls.Add(btn_color);
            Controls.Add(lbl_hello);
            Controls.Add(btn_hello);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_hello;
        private Label lbl_hello;
        private Button btn_color;
    }
}