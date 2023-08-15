namespace Zipperoni
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            EnterButton = new Button();
            TextBox = new Label();
            Num1Box = new TextBox();
            Num2Box = new TextBox();
            progressBar = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            comboBox = new ComboBox();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(70, 109);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(147, 36);
            EnterButton.TabIndex = 0;
            EnterButton.Text = "Calculate!";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += button1_Click;
            // 
            // TextBox
            // 
            TextBox.AutoSize = true;
            TextBox.Location = new Point(125, 10);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(35, 15);
            TextBox.TabIndex = 1;
            TextBox.Text = "Hello";
            TextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Num1Box
            // 
            Num1Box.Location = new Point(17, 51);
            Num1Box.Name = "Num1Box";
            Num1Box.Size = new Size(100, 23);
            Num1Box.TabIndex = 2;
            // 
            // Num2Box
            // 
            Num2Box.Location = new Point(170, 51);
            Num2Box.Name = "Num2Box";
            Num2Box.Size = new Size(100, 23);
            Num2Box.TabIndex = 3;
            // 
            // progressBar
            // 
            progressBar.ForeColor = SystemColors.HighlightText;
            progressBar.Location = new Point(17, 80);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(253, 23);
            progressBar.TabIndex = 4;
            progressBar.Click += progressBar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 33);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 33);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Number 2";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // comboBox
            // 
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox.Location = new Point(125, 51);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(37, 23);
            comboBox.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(295, 182);
            Controls.Add(comboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar);
            Controls.Add(Num2Box);
            Controls.Add(Num1Box);
            Controls.Add(TextBox);
            Controls.Add(EnterButton);
            Cursor = Cursors.Arrow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Quantum Calculator";
            Load += Main_Load;
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterButton;
        private Label TextBox;
        private TextBox Num1Box;
        private TextBox Num2Box;
        private ProgressBar progressBar;
        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripTextBox toolStripTextBox1;
        private ComboBox comboBox;
    }
}