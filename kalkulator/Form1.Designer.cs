namespace kalkulator
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
            label2 = new Label();
            label3 = new Label();
            A = new TextBox();
            B = new TextBox();
            TAMBAH = new Button();
            button3 = new Button();
            C = new TextBox();
            label4 = new Label();
            KURANG = new Button();
            KALI = new Button();
            BAGI = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Hv BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 83);
            label1.Name = "label1";
            label1.Size = new Size(351, 29);
            label1.TabIndex = 0;
            label1.Text = "KALKULATOR SEDERHANA ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 0;
            label2.Text = "NILAI PERTAMA";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 200);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 0;
            label3.Text = "NILAI KEDUA";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label1_Click;
            // 
            // A
            // 
            A.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A.Location = new Point(162, 133);
            A.Multiline = true;
            A.Name = "A";
            A.Size = new Size(139, 45);
            A.TabIndex = 1;
            // 
            // B
            // 
            B.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B.Location = new Point(162, 200);
            B.Multiline = true;
            B.Name = "B";
            B.Size = new Size(139, 45);
            B.TabIndex = 1;
            // 
            // TAMBAH
            // 
            TAMBAH.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TAMBAH.Location = new Point(81, 268);
            TAMBAH.Margin = new Padding(0);
            TAMBAH.Name = "TAMBAH";
            TAMBAH.Size = new Size(75, 56);
            TAMBAH.TabIndex = 2;
            TAMBAH.Text = "+";
            TAMBAH.UseVisualStyleBackColor = true;
            TAMBAH.Click += TAMBAH_Click;
            // 
            // button3
            // 
            button3.Location = new Point(243, 268);
            button3.Name = "button3";
            button3.Size = new Size(75, 118);
            button3.TabIndex = 2;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // C
            // 
            C.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            C.Location = new Point(81, 414);
            C.Multiline = true;
            C.Name = "C";
            C.Size = new Size(332, 66);
            C.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 414);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 0;
            label4.Text = "HASIL";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label1_Click;
            // 
            // KURANG
            // 
            KURANG.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KURANG.Location = new Point(162, 268);
            KURANG.Margin = new Padding(0);
            KURANG.Name = "KURANG";
            KURANG.Size = new Size(75, 56);
            KURANG.TabIndex = 2;
            KURANG.Text = "-";
            KURANG.TextAlign = ContentAlignment.TopCenter;
            KURANG.UseVisualStyleBackColor = true;
            KURANG.Click += KURANG_Click;
            // 
            // KALI
            // 
            KALI.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KALI.Location = new Point(81, 330);
            KALI.Margin = new Padding(0);
            KALI.Name = "KALI";
            KALI.Size = new Size(75, 56);
            KALI.TabIndex = 2;
            KALI.Text = "X";
            KALI.UseVisualStyleBackColor = true;
            KALI.Click += KALI_Click;
            // 
            // BAGI
            // 
            BAGI.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAGI.Location = new Point(162, 330);
            BAGI.Margin = new Padding(0);
            BAGI.Name = "BAGI";
            BAGI.Size = new Size(75, 56);
            BAGI.TabIndex = 2;
            BAGI.Text = "/";
            BAGI.TextAlign = ContentAlignment.TopCenter;
            BAGI.UseVisualStyleBackColor = true;
            BAGI.Click += BAGI_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 492);
            Controls.Add(button3);
            Controls.Add(BAGI);
            Controls.Add(KURANG);
            Controls.Add(KALI);
            Controls.Add(TAMBAH);
            Controls.Add(C);
            Controls.Add(B);
            Controls.Add(A);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox A;
        private TextBox B;
        private Button TAMBAH;
        private Button button3;
        private TextBox C;
        private Label label4;
        private Button KURANG;
        private Button KALI;
        private Button BAGI;
    }
}
