
namespace QueryMaker
{
    partial class ColumnConditionsForm
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
            this.ColumnsComboBox = new System.Windows.Forms.ComboBox();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.OperatorsComboBox = new System.Windows.Forms.ComboBox();
            this.ConditionsGroupBox = new System.Windows.Forms.GroupBox();
            this.AddConditionButton = new System.Windows.Forms.Button();
            this.DateValueMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConditionsListBox = new System.Windows.Forms.ListBox();
            this.DeleteConditionButton = new System.Windows.Forms.Button();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.CreatedConditionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ConditionsGroupBox.SuspendLayout();
            this.CreatedConditionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColumnsComboBox
            // 
            this.ColumnsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnsComboBox.FormattingEnabled = true;
            this.ColumnsComboBox.Location = new System.Drawing.Point(9, 42);
            this.ColumnsComboBox.Name = "ColumnsComboBox";
            this.ColumnsComboBox.Size = new System.Drawing.Size(172, 21);
            this.ColumnsComboBox.TabIndex = 0;
            this.ColumnsComboBox.SelectedIndexChanged += new System.EventHandler(this.ColumnsComboBox_SelectedIndexChanged);
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnLabel.Location = new System.Drawing.Point(6, 23);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(115, 16);
            this.ColumnLabel.TabIndex = 1;
            this.ColumnLabel.Text = "Выбор атрибута";
            // 
            // OperatorsComboBox
            // 
            this.OperatorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperatorsComboBox.Enabled = false;
            this.OperatorsComboBox.FormattingEnabled = true;
            this.OperatorsComboBox.Location = new System.Drawing.Point(9, 97);
            this.OperatorsComboBox.Name = "OperatorsComboBox";
            this.OperatorsComboBox.Size = new System.Drawing.Size(104, 24);
            this.OperatorsComboBox.TabIndex = 6;
            this.OperatorsComboBox.SelectedIndexChanged += new System.EventHandler(this.OperatorsComboBox_SelectedIndexChanged);
            // 
            // ConditionsGroupBox
            // 
            this.ConditionsGroupBox.Controls.Add(this.AddConditionButton);
            this.ConditionsGroupBox.Controls.Add(this.DateValueMaskedTextBox);
            this.ConditionsGroupBox.Controls.Add(this.ValueTextBox);
            this.ConditionsGroupBox.Controls.Add(this.ColumnLabel);
            this.ConditionsGroupBox.Controls.Add(this.ValueLabel);
            this.ConditionsGroupBox.Controls.Add(this.ColumnsComboBox);
            this.ConditionsGroupBox.Controls.Add(this.label1);
            this.ConditionsGroupBox.Controls.Add(this.OperatorsComboBox);
            this.ConditionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConditionsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ConditionsGroupBox.Name = "ConditionsGroupBox";
            this.ConditionsGroupBox.Size = new System.Drawing.Size(275, 177);
            this.ConditionsGroupBox.TabIndex = 8;
            this.ConditionsGroupBox.TabStop = false;
            this.ConditionsGroupBox.Text = "Составление условия";
            // 
            // AddConditionButton
            // 
            this.AddConditionButton.Enabled = false;
            this.AddConditionButton.Location = new System.Drawing.Point(6, 142);
            this.AddConditionButton.Name = "AddConditionButton";
            this.AddConditionButton.Size = new System.Drawing.Size(137, 24);
            this.AddConditionButton.TabIndex = 12;
            this.AddConditionButton.Text = "Добавить условие";
            this.AddConditionButton.UseVisualStyleBackColor = true;
            this.AddConditionButton.Click += new System.EventHandler(this.AddConditionButton_Click);
            // 
            // DateValueMaskedTextBox
            // 
            this.DateValueMaskedTextBox.Enabled = false;
            this.DateValueMaskedTextBox.Location = new System.Drawing.Point(119, 97);
            this.DateValueMaskedTextBox.Mask = "0000/00/00";
            this.DateValueMaskedTextBox.Name = "DateValueMaskedTextBox";
            this.DateValueMaskedTextBox.Size = new System.Drawing.Size(70, 22);
            this.DateValueMaskedTextBox.TabIndex = 11;
            this.DateValueMaskedTextBox.Visible = false;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Enabled = false;
            this.ValueTextBox.Location = new System.Drawing.Point(119, 97);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(128, 22);
            this.ValueTextBox.TabIndex = 10;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueLabel.Location = new System.Drawing.Point(116, 78);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(73, 16);
            this.ValueLabel.TabIndex = 9;
            this.ValueLabel.Text = "Значение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Оператор";
            // 
            // ConditionsListBox
            // 
            this.ConditionsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConditionsListBox.FormattingEnabled = true;
            this.ConditionsListBox.Location = new System.Drawing.Point(6, 19);
            this.ConditionsListBox.Name = "ConditionsListBox";
            this.ConditionsListBox.Size = new System.Drawing.Size(263, 147);
            this.ConditionsListBox.TabIndex = 9;
            this.ConditionsListBox.SelectedIndexChanged += new System.EventHandler(this.ConditionsListBox_SelectedIndexChanged);
            // 
            // DeleteConditionButton
            // 
            this.DeleteConditionButton.Enabled = false;
            this.DeleteConditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteConditionButton.Location = new System.Drawing.Point(139, 172);
            this.DeleteConditionButton.Name = "DeleteConditionButton";
            this.DeleteConditionButton.Size = new System.Drawing.Size(130, 24);
            this.DeleteConditionButton.TabIndex = 10;
            this.DeleteConditionButton.Text = "Удалить условие";
            this.DeleteConditionButton.UseVisualStyleBackColor = true;
            this.DeleteConditionButton.Click += new System.EventHandler(this.DeleteConditionButton_Click);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteButton.Location = new System.Drawing.Point(12, 195);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(275, 24);
            this.ExecuteButton.TabIndex = 11;
            this.ExecuteButton.Text = "Выполнить запрос";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // CreatedConditionsGroupBox
            // 
            this.CreatedConditionsGroupBox.Controls.Add(this.ConditionsListBox);
            this.CreatedConditionsGroupBox.Controls.Add(this.DeleteConditionButton);
            this.CreatedConditionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedConditionsGroupBox.Location = new System.Drawing.Point(293, 12);
            this.CreatedConditionsGroupBox.Name = "CreatedConditionsGroupBox";
            this.CreatedConditionsGroupBox.Size = new System.Drawing.Size(275, 207);
            this.CreatedConditionsGroupBox.TabIndex = 13;
            this.CreatedConditionsGroupBox.TabStop = false;
            this.CreatedConditionsGroupBox.Text = "Составленные условия";
            // 
            // ColumnConditionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 232);
            this.Controls.Add(this.CreatedConditionsGroupBox);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.ConditionsGroupBox);
            this.Name = "ColumnConditionsForm";
            this.Text = "Составление условий";
            this.Load += new System.EventHandler(this.ColumnConditionsForm_Load);
            this.ConditionsGroupBox.ResumeLayout(false);
            this.ConditionsGroupBox.PerformLayout();
            this.CreatedConditionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ColumnsComboBox;
        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.ComboBox OperatorsComboBox;
        private System.Windows.Forms.GroupBox ConditionsGroupBox;
        private System.Windows.Forms.MaskedTextBox DateValueMaskedTextBox;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddConditionButton;
        private System.Windows.Forms.ListBox ConditionsListBox;
        private System.Windows.Forms.Button DeleteConditionButton;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.GroupBox CreatedConditionsGroupBox;
    }
}