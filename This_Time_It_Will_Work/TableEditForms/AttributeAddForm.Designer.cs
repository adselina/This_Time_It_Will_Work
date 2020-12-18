
namespace This_Time_It_Will_Work
{
    partial class AttributeAddForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.AttrNametextBox = new System.Windows.Forms.TextBox();
            this.TypescomboBox = new System.Windows.Forms.ComboBox();
            this.StartValueTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UniqueCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateAttrButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CanNullCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 397);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 41);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(12, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(191, 18);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Новый атрибут таблицы X";
            // 
            // AttrNametextBox
            // 
            this.AttrNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttrNametextBox.Location = new System.Drawing.Point(329, 50);
            this.AttrNametextBox.Name = "AttrNametextBox";
            this.AttrNametextBox.Size = new System.Drawing.Size(293, 22);
            this.AttrNametextBox.TabIndex = 2;
            this.AttrNametextBox.TextChanged += new System.EventHandler(this.AttrNametextBox_TextChanged);
            this.AttrNametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AttrNametextBox_KeyPress);
            // 
            // TypescomboBox
            // 
            this.TypescomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypescomboBox.FormattingEnabled = true;
            this.TypescomboBox.Items.AddRange(new object[] {
            "Varchar(255)",
            "Int",
            "Date"});
            this.TypescomboBox.Location = new System.Drawing.Point(329, 89);
            this.TypescomboBox.Name = "TypescomboBox";
            this.TypescomboBox.Size = new System.Drawing.Size(293, 24);
            this.TypescomboBox.TabIndex = 3;
            this.TypescomboBox.TextChanged += new System.EventHandler(this.TypescomboBox_TextChanged);
            this.TypescomboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypescomboBox_KeyPress);
            // 
            // StartValueTextBox
            // 
            this.StartValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartValueTextBox.Location = new System.Drawing.Point(329, 130);
            this.StartValueTextBox.Name = "StartValueTextBox";
            this.StartValueTextBox.Size = new System.Drawing.Size(293, 22);
            this.StartValueTextBox.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(258, 238);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(445, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Наименование атрибута";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(225, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тип атрибута";
            // 
            // UniqueCheckBox
            // 
            this.UniqueCheckBox.AutoSize = true;
            this.UniqueCheckBox.Location = new System.Drawing.Point(465, 175);
            this.UniqueCheckBox.Name = "UniqueCheckBox";
            this.UniqueCheckBox.Size = new System.Drawing.Size(15, 14);
            this.UniqueCheckBox.TabIndex = 12;
            this.UniqueCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(63, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Начальное значение (необязательно)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(170, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Является уникальным";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(114, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Описание атрибута";
            // 
            // CreateAttrButton
            // 
            this.CreateAttrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateAttrButton.Location = new System.Drawing.Point(363, 340);
            this.CreateAttrButton.Name = "CreateAttrButton";
            this.CreateAttrButton.Size = new System.Drawing.Size(222, 43);
            this.CreateAttrButton.TabIndex = 18;
            this.CreateAttrButton.Text = "Добавить атрибут в таблицу";
            this.CreateAttrButton.UseVisualStyleBackColor = true;
            this.CreateAttrButton.Click += new System.EventHandler(this.CreateAttrButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(187, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Может быть пустым";
            // 
            // CanNullCheckBox
            // 
            this.CanNullCheckBox.AutoSize = true;
            this.CanNullCheckBox.Location = new System.Drawing.Point(465, 203);
            this.CanNullCheckBox.Name = "CanNullCheckBox";
            this.CanNullCheckBox.Size = new System.Drawing.Size(15, 14);
            this.CanNullCheckBox.TabIndex = 19;
            this.CanNullCheckBox.UseVisualStyleBackColor = true;
            // 
            // AttributeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CanNullCheckBox);
            this.Controls.Add(this.CreateAttrButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UniqueCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.StartValueTextBox);
            this.Controls.Add(this.TypescomboBox);
            this.Controls.Add(this.AttrNametextBox);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.buttonBack);
            this.Name = "AttributeAddForm";
            this.Text = "AttributeAddForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AttributeAddForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox AttrNametextBox;
        private System.Windows.Forms.ComboBox TypescomboBox;
        private System.Windows.Forms.TextBox StartValueTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox UniqueCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CreateAttrButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CanNullCheckBox;
    }
}