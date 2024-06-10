namespace Lab6
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
            treeView = new TreeView();
            LastNameTextBox = new TextBox();
            label1 = new Label();
            AddButton = new Button();
            MiscTextBox = new TextBox();
            coeffTextBox = new TextBox();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(12, 12);
            treeView.Name = "treeView";
            treeView.Size = new Size(527, 415);
            treeView.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(545, 32);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(243, 27);
            LastNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(545, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 2;
            label1.Text = "Фамилия студента:";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(545, 65);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(243, 29);
            AddButton.TabIndex = 3;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // MiscTextBox
            // 
            MiscTextBox.Location = new Point(545, 172);
            MiscTextBox.Multiline = true;
            MiscTextBox.Name = "MiscTextBox";
            MiscTextBox.ReadOnly = true;
            MiscTextBox.Size = new Size(243, 255);
            MiscTextBox.TabIndex = 4;
            // 
            // coeffTextBox
            // 
            coeffTextBox.Location = new Point(545, 123);
            coeffTextBox.Name = "coeffTextBox";
            coeffTextBox.ReadOnly = true;
            coeffTextBox.Size = new Size(125, 27);
            coeffTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(coeffTextBox);
            Controls.Add(MiscTextBox);
            Controls.Add(AddButton);
            Controls.Add(label1);
            Controls.Add(LastNameTextBox);
            Controls.Add(treeView);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView;
        private TextBox LastNameTextBox;
        private Label label1;
        private Button AddButton;
        private TextBox MiscTextBox;
        private TextBox coeffTextBox;
    }
}
