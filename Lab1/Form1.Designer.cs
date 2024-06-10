namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.insertButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.keyLabel = new System.Windows.Forms.Label();
            this.nodesLabel = new System.Windows.Forms.Label();
            this.nodesTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.PreOrderButton = new System.Windows.Forms.Button();
            this.InOrderButton = new System.Windows.Forms.Button();
            this.PostOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertButton.Location = new System.Drawing.Point(679, 59);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(116, 33);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Вставка";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // findButton
            // 
            this.findButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.Location = new System.Drawing.Point(801, 59);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(116, 33);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Поиск";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(801, 98);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 33);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Удаление";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyLabel.Location = new System.Drawing.Point(676, 12);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(45, 16);
            this.keyLabel.TabIndex = 6;
            this.keyLabel.Text = "Ключ";
            // 
            // nodesLabel
            // 
            this.nodesLabel.AutoSize = true;
            this.nodesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nodesLabel.Location = new System.Drawing.Point(82, 440);
            this.nodesLabel.Name = "nodesLabel";
            this.nodesLabel.Size = new System.Drawing.Size(45, 16);
            this.nodesLabel.TabIndex = 7;
            this.nodesLabel.Text = "Узлы";
            // 
            // nodesTextBox
            // 
            this.nodesTextBox.Location = new System.Drawing.Point(85, 470);
            this.nodesTextBox.Name = "nodesTextBox";
            this.nodesTextBox.Size = new System.Drawing.Size(636, 22);
            this.nodesTextBox.TabIndex = 8;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(679, 31);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(76, 22);
            this.keyTextBox.TabIndex = 9;
            // 
            // sumButton
            // 
            this.sumButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumButton.Location = new System.Drawing.Point(679, 98);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(116, 33);
            this.sumButton.TabIndex = 10;
            this.sumButton.Text = "Сумма";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(658, 425);
            this.treeView1.TabIndex = 11;
            // 
            // PreOrderButton
            // 
            this.PreOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PreOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreOrderButton.Location = new System.Drawing.Point(679, 137);
            this.PreOrderButton.Name = "PreOrderButton";
            this.PreOrderButton.Size = new System.Drawing.Size(238, 35);
            this.PreOrderButton.TabIndex = 12;
            this.PreOrderButton.Text = "ABC (PreOrder)";
            this.PreOrderButton.UseVisualStyleBackColor = true;
            this.PreOrderButton.Click += new System.EventHandler(this.PreOrderButton_Click);
            // 
            // InOrderButton
            // 
            this.InOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.InOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InOrderButton.Location = new System.Drawing.Point(679, 178);
            this.InOrderButton.Name = "InOrderButton";
            this.InOrderButton.Size = new System.Drawing.Size(238, 35);
            this.InOrderButton.TabIndex = 13;
            this.InOrderButton.Text = "BAC (InOrder)";
            this.InOrderButton.UseVisualStyleBackColor = true;
            this.InOrderButton.Click += new System.EventHandler(this.InOrderButton_Click);
            // 
            // PostOrderButton
            // 
            this.PostOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PostOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostOrderButton.Location = new System.Drawing.Point(679, 219);
            this.PostOrderButton.Name = "PostOrderButton";
            this.PostOrderButton.Size = new System.Drawing.Size(238, 35);
            this.PostOrderButton.TabIndex = 14;
            this.PostOrderButton.Text = "CAB (PostOrder)";
            this.PostOrderButton.UseVisualStyleBackColor = true;
            this.PostOrderButton.Click += new System.EventHandler(this.PostOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(940, 518);
            this.Controls.Add(this.PostOrderButton);
            this.Controls.Add(this.InOrderButton);
            this.Controls.Add(this.PreOrderButton);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.nodesTextBox);
            this.Controls.Add(this.nodesLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.insertButton);
            this.Name = "Form1";
            this.Text = "Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label nodesLabel;
        private System.Windows.Forms.TextBox nodesTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button PreOrderButton;
        private System.Windows.Forms.Button InOrderButton;
        private System.Windows.Forms.Button PostOrderButton;
    }
}

