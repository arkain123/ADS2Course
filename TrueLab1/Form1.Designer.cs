namespace TrueLab1
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
            this.stringLabel = new System.Windows.Forms.Label();
            this.substringLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.mianGroupBox = new System.Windows.Forms.GroupBox();
            this.KMPButton = new System.Windows.Forms.RadioButton();
            this.BMHButton = new System.Windows.Forms.RadioButton();
            this.straightMethodButton = new System.Windows.Forms.RadioButton();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.substringTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.compTextBox = new System.Windows.Forms.TextBox();
            this.compLabel = new System.Windows.Forms.Label();
            this.mianGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stringLabel
            // 
            this.stringLabel.AutoSize = true;
            this.stringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stringLabel.Location = new System.Drawing.Point(71, 32);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Size = new System.Drawing.Size(85, 25);
            this.stringLabel.TabIndex = 0;
            this.stringLabel.Text = "Строка";
            // 
            // substringLabel
            // 
            this.substringLabel.AutoSize = true;
            this.substringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.substringLabel.Location = new System.Drawing.Point(71, 128);
            this.substringLabel.Name = "substringLabel";
            this.substringLabel.Size = new System.Drawing.Size(122, 25);
            this.substringLabel.TabIndex = 1;
            this.substringLabel.Text = "Подстрока";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(71, 246);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(120, 25);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Результат";
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.Location = new System.Drawing.Point(603, 69);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(125, 46);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Поиск";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // mianGroupBox
            // 
            this.mianGroupBox.Controls.Add(this.KMPButton);
            this.mianGroupBox.Controls.Add(this.BMHButton);
            this.mianGroupBox.Controls.Add(this.straightMethodButton);
            this.mianGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mianGroupBox.Location = new System.Drawing.Point(558, 165);
            this.mianGroupBox.Name = "mianGroupBox";
            this.mianGroupBox.Size = new System.Drawing.Size(200, 128);
            this.mianGroupBox.TabIndex = 4;
            this.mianGroupBox.TabStop = false;
            this.mianGroupBox.Text = "Алгоритм поиска";
            // 
            // KMPButton
            // 
            this.KMPButton.AutoSize = true;
            this.KMPButton.Location = new System.Drawing.Point(17, 60);
            this.KMPButton.Name = "KMPButton";
            this.KMPButton.Size = new System.Drawing.Size(68, 24);
            this.KMPButton.TabIndex = 2;
            this.KMPButton.TabStop = true;
            this.KMPButton.Text = "КМП";
            this.KMPButton.UseVisualStyleBackColor = true;
            // 
            // BMHButton
            // 
            this.BMHButton.AutoSize = true;
            this.BMHButton.Location = new System.Drawing.Point(17, 86);
            this.BMHButton.Name = "BMHButton";
            this.BMHButton.Size = new System.Drawing.Size(68, 24);
            this.BMHButton.TabIndex = 1;
            this.BMHButton.TabStop = true;
            this.BMHButton.Text = "БМХ";
            this.BMHButton.UseVisualStyleBackColor = true;
            // 
            // straightMethodButton
            // 
            this.straightMethodButton.AutoSize = true;
            this.straightMethodButton.Location = new System.Drawing.Point(17, 34);
            this.straightMethodButton.Name = "straightMethodButton";
            this.straightMethodButton.Size = new System.Drawing.Size(95, 24);
            this.straightMethodButton.TabIndex = 0;
            this.straightMethodButton.TabStop = true;
            this.straightMethodButton.Text = "Прямой";
            this.straightMethodButton.UseVisualStyleBackColor = true;
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(76, 60);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(476, 22);
            this.stringTextBox.TabIndex = 5;
            // 
            // substringTextBox
            // 
            this.substringTextBox.Location = new System.Drawing.Point(76, 156);
            this.substringTextBox.Name = "substringTextBox";
            this.substringTextBox.Size = new System.Drawing.Size(169, 22);
            this.substringTextBox.TabIndex = 6;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(76, 273);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(169, 22);
            this.resultTextBox.TabIndex = 7;
            // 
            // compTextBox
            // 
            this.compTextBox.Location = new System.Drawing.Point(271, 273);
            this.compTextBox.Name = "compTextBox";
            this.compTextBox.Size = new System.Drawing.Size(115, 22);
            this.compTextBox.TabIndex = 8;
            // 
            // compLabel
            // 
            this.compLabel.AutoSize = true;
            this.compLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compLabel.Location = new System.Drawing.Point(266, 246);
            this.compLabel.Name = "compLabel";
            this.compLabel.Size = new System.Drawing.Size(120, 25);
            this.compLabel.TabIndex = 9;
            this.compLabel.Text = "Сравнения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.compLabel);
            this.Controls.Add(this.compTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.substringTextBox);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.mianGroupBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.substringLabel);
            this.Controls.Add(this.stringLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mianGroupBox.ResumeLayout(false);
            this.mianGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.Label substringLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.GroupBox mianGroupBox;
        private System.Windows.Forms.RadioButton KMPButton;
        private System.Windows.Forms.RadioButton BMHButton;
        private System.Windows.Forms.RadioButton straightMethodButton;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.TextBox substringTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox compTextBox;
        private System.Windows.Forms.Label compLabel;
    }
}

