namespace WinFormsAppCal
{
    partial class Calculator
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
            TxtBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            EightBtn = new Button();
            FiveBtn = new Button();
            TwoBtn = new Button();
            DotBtn = new Button();
            NineBtn = new Button();
            SixBtn = new Button();
            ThreeBtn = new Button();
            EqualBtn = new Button();
            ClearBtn = new Button();
            MinusBtn = new Button();
            DivideBtn = new Button();
            MinusPlusBtn = new Button();
            PlusBtn = new Button();
            MultiplyBtn = new Button();
            ModuloBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBox.Location = new Point(12, 12);
            TxtBox.Name = "TxtBox";
            TxtBox.ReadOnly = true;
            TxtBox.Size = new Size(297, 43);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SevenBtn.Location = new Point(12, 61);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(59, 56);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FourBtn.Location = new Point(12, 115);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(59, 56);
            FourBtn.TabIndex = 1;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OneBtn.Location = new Point(12, 169);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(59, 56);
            OneBtn.TabIndex = 1;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ZeroBtn.Location = new Point(12, 223);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(59, 56);
            ZeroBtn.TabIndex = 1;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += button4_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EightBtn.Location = new Point(68, 61);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(59, 56);
            EightBtn.TabIndex = 1;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FiveBtn.Location = new Point(68, 115);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(59, 56);
            FiveBtn.TabIndex = 1;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TwoBtn.Location = new Point(68, 169);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(59, 56);
            TwoBtn.TabIndex = 1;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DotBtn.Location = new Point(68, 223);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(59, 56);
            DotBtn.TabIndex = 1;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NineBtn.Location = new Point(124, 61);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(59, 56);
            NineBtn.TabIndex = 1;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SixBtn.Location = new Point(124, 115);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(59, 56);
            SixBtn.TabIndex = 1;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ThreeBtn.Location = new Point(124, 169);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(59, 56);
            ThreeBtn.TabIndex = 1;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EqualBtn.Location = new Point(124, 223);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(59, 56);
            EqualBtn.TabIndex = 1;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.Location = new Point(194, 61);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(113, 56);
            ClearBtn.TabIndex = 1;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinusBtn.Location = new Point(194, 115);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(59, 56);
            MinusBtn.TabIndex = 1;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DivideBtn.Location = new Point(194, 169);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(59, 56);
            DivideBtn.TabIndex = 1;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = true;
            DivideBtn.Click += DivideBtn_Click;
            // 
            // MinusPlusBtn
            // 
            MinusPlusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinusPlusBtn.Location = new Point(194, 223);
            MinusPlusBtn.Name = "MinusPlusBtn";
            MinusPlusBtn.Size = new Size(59, 56);
            MinusPlusBtn.TabIndex = 1;
            MinusPlusBtn.Text = "-/+";
            MinusPlusBtn.UseVisualStyleBackColor = true;
            MinusPlusBtn.Click += MinusPlusBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlusBtn.Location = new Point(250, 115);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(59, 56);
            PlusBtn.TabIndex = 1;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MultiplyBtn.Location = new Point(250, 169);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(59, 56);
            MultiplyBtn.TabIndex = 1;
            MultiplyBtn.Text = "x";
            MultiplyBtn.UseVisualStyleBackColor = true;
            MultiplyBtn.Click += MultiplyBtn_Click;
            // 
            // ModuloBtn
            // 
            ModuloBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModuloBtn.Location = new Point(250, 223);
            ModuloBtn.Name = "ModuloBtn";
            ModuloBtn.Size = new Size(59, 56);
            ModuloBtn.TabIndex = 1;
            ModuloBtn.Text = "%";
            ModuloBtn.UseVisualStyleBackColor = true;
            ModuloBtn.Click += ModuloBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 283);
            Controls.Add(ModuloBtn);
            Controls.Add(MinusPlusBtn);
            Controls.Add(EqualBtn);
            Controls.Add(DotBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(DivideBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(TwoBtn);
            Controls.Add(OneBtn);
            Controls.Add(PlusBtn);
            Controls.Add(MinusBtn);
            Controls.Add(ClearBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TxtBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "CALCULATOR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button EightBtn;
        private Button FiveBtn;
        private Button TwoBtn;
        private Button DotBtn;
        private Button NineBtn;
        private Button SixBtn;
        private Button ThreeBtn;
        private Button EqualBtn;
        private Button ClearBtn;
        private Button MinusBtn;
        private Button DivideBtn;
        private Button MinusPlusBtn;
        private Button PlusBtn;
        private Button MultiplyBtn;
        private Button ModuloBtn;
    }
}