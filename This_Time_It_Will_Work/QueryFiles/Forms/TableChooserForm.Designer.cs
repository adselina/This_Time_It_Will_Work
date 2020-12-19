
namespace QueryMaker
{
    partial class TableChooserForm
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
            this.TablesComboBox = new System.Windows.Forms.ComboBox();
            this.MainTableLabel = new System.Windows.Forms.Label();
            this.AllConnectedTablesListBox = new System.Windows.Forms.ListBox();
            this.ChosenConnectedTablesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShiftTableToLeftButton = new System.Windows.Forms.Button();
            this.ShiftTableToRightButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.AllColumnsListBox = new System.Windows.Forms.ListBox();
            this.AllColumnsLabel = new System.Windows.Forms.Label();
            this.ChosenColumnsLabel = new System.Windows.Forms.Label();
            this.ChosenColumnsListBox = new System.Windows.Forms.ListBox();
            this.ShiftColumnToLeftbutton = new System.Windows.Forms.Button();
            this.ShiftColumnToRightButton = new System.Windows.Forms.Button();
            this.ConnectedTablesGroupBox = new System.Windows.Forms.GroupBox();
            this.ColumnsGroupBox = new System.Windows.Forms.GroupBox();
            this.ConnectedTablesGroupBox.SuspendLayout();
            this.ColumnsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablesComboBox
            // 
            this.TablesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablesComboBox.FormattingEnabled = true;
            this.TablesComboBox.Location = new System.Drawing.Point(15, 31);
            this.TablesComboBox.Name = "TablesComboBox";
            this.TablesComboBox.Size = new System.Drawing.Size(136, 21);
            this.TablesComboBox.TabIndex = 0;
            this.TablesComboBox.SelectedIndexChanged += new System.EventHandler(this.TablesComboBox_SelectedIndexChanged);
            // 
            // MainTableLabel
            // 
            this.MainTableLabel.AutoSize = true;
            this.MainTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTableLabel.Location = new System.Drawing.Point(12, 12);
            this.MainTableLabel.Name = "MainTableLabel";
            this.MainTableLabel.Size = new System.Drawing.Size(123, 16);
            this.MainTableLabel.TabIndex = 1;
            this.MainTableLabel.Text = "Главная таблица:";
            // 
            // AllConnectedTablesListBox
            // 
            this.AllConnectedTablesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllConnectedTablesListBox.FormattingEnabled = true;
            this.AllConnectedTablesListBox.Location = new System.Drawing.Point(6, 40);
            this.AllConnectedTablesListBox.Name = "AllConnectedTablesListBox";
            this.AllConnectedTablesListBox.Size = new System.Drawing.Size(192, 82);
            this.AllConnectedTablesListBox.TabIndex = 3;
            this.AllConnectedTablesListBox.SelectedIndexChanged += new System.EventHandler(this.AllConnectedTablesListBox_SelectedIndexChanged);
            // 
            // ChosenConnectedTablesListBox
            // 
            this.ChosenConnectedTablesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChosenConnectedTablesListBox.FormattingEnabled = true;
            this.ChosenConnectedTablesListBox.Location = new System.Drawing.Point(254, 40);
            this.ChosenConnectedTablesListBox.Name = "ChosenConnectedTablesListBox";
            this.ChosenConnectedTablesListBox.Size = new System.Drawing.Size(192, 82);
            this.ChosenConnectedTablesListBox.TabIndex = 4;
            this.ChosenConnectedTablesListBox.SelectedIndexChanged += new System.EventHandler(this.ChosenConnectedTablesListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Все связанные таблицы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(251, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выбранные связанные таблицы:";
            // 
            // ShiftTableToLeftButton
            // 
            this.ShiftTableToLeftButton.Location = new System.Drawing.Point(204, 83);
            this.ShiftTableToLeftButton.Name = "ShiftTableToLeftButton";
            this.ShiftTableToLeftButton.Size = new System.Drawing.Size(44, 39);
            this.ShiftTableToLeftButton.TabIndex = 17;
            this.ShiftTableToLeftButton.Text = "<<";
            this.ShiftTableToLeftButton.UseVisualStyleBackColor = true;
            this.ShiftTableToLeftButton.Click += new System.EventHandler(this.ShiftToLeftButton_Click);
            // 
            // ShiftTableToRightButton
            // 
            this.ShiftTableToRightButton.Location = new System.Drawing.Point(204, 40);
            this.ShiftTableToRightButton.Name = "ShiftTableToRightButton";
            this.ShiftTableToRightButton.Size = new System.Drawing.Size(44, 39);
            this.ShiftTableToRightButton.TabIndex = 16;
            this.ShiftTableToRightButton.Text = ">>";
            this.ShiftTableToRightButton.UseVisualStyleBackColor = true;
            this.ShiftTableToRightButton.Click += new System.EventHandler(this.ShiftToRightButton_Click);
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoButton.Enabled = false;
            this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoButton.Location = new System.Drawing.Point(401, 378);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(88, 26);
            this.GoButton.TabIndex = 18;
            this.GoButton.Text = "Далее";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // AllColumnsListBox
            // 
            this.AllColumnsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllColumnsListBox.FormattingEnabled = true;
            this.AllColumnsListBox.Location = new System.Drawing.Point(6, 38);
            this.AllColumnsListBox.Name = "AllColumnsListBox";
            this.AllColumnsListBox.Size = new System.Drawing.Size(192, 121);
            this.AllColumnsListBox.TabIndex = 19;
            this.AllColumnsListBox.SelectedIndexChanged += new System.EventHandler(this.AllColumnsListBox_SelectedIndexChanged);
            // 
            // AllColumnsLabel
            // 
            this.AllColumnsLabel.AutoSize = true;
            this.AllColumnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllColumnsLabel.Location = new System.Drawing.Point(6, 19);
            this.AllColumnsLabel.Name = "AllColumnsLabel";
            this.AllColumnsLabel.Size = new System.Drawing.Size(90, 15);
            this.AllColumnsLabel.TabIndex = 20;
            this.AllColumnsLabel.Text = "Все атрибуты:";
            // 
            // ChosenColumnsLabel
            // 
            this.ChosenColumnsLabel.AutoSize = true;
            this.ChosenColumnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChosenColumnsLabel.Location = new System.Drawing.Point(254, 19);
            this.ChosenColumnsLabel.Name = "ChosenColumnsLabel";
            this.ChosenColumnsLabel.Size = new System.Drawing.Size(137, 15);
            this.ChosenColumnsLabel.TabIndex = 22;
            this.ChosenColumnsLabel.Text = "Выбранные атрибуты:";
            // 
            // ChosenColumnsListBox
            // 
            this.ChosenColumnsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChosenColumnsListBox.FormattingEnabled = true;
            this.ChosenColumnsListBox.Location = new System.Drawing.Point(254, 38);
            this.ChosenColumnsListBox.Name = "ChosenColumnsListBox";
            this.ChosenColumnsListBox.Size = new System.Drawing.Size(192, 121);
            this.ChosenColumnsListBox.TabIndex = 21;
            this.ChosenColumnsListBox.SelectedIndexChanged += new System.EventHandler(this.ChosenColumnsListBox_SelectedIndexChanged);
            // 
            // ShiftColumnToLeftbutton
            // 
            this.ShiftColumnToLeftbutton.Location = new System.Drawing.Point(204, 83);
            this.ShiftColumnToLeftbutton.Name = "ShiftColumnToLeftbutton";
            this.ShiftColumnToLeftbutton.Size = new System.Drawing.Size(44, 39);
            this.ShiftColumnToLeftbutton.TabIndex = 24;
            this.ShiftColumnToLeftbutton.Text = "<<";
            this.ShiftColumnToLeftbutton.UseVisualStyleBackColor = true;
            this.ShiftColumnToLeftbutton.Click += new System.EventHandler(this.ShiftColumnToLeftbutton_Click);
            // 
            // ShiftColumnToRightButton
            // 
            this.ShiftColumnToRightButton.Location = new System.Drawing.Point(204, 38);
            this.ShiftColumnToRightButton.Name = "ShiftColumnToRightButton";
            this.ShiftColumnToRightButton.Size = new System.Drawing.Size(44, 39);
            this.ShiftColumnToRightButton.TabIndex = 23;
            this.ShiftColumnToRightButton.Text = ">>";
            this.ShiftColumnToRightButton.UseVisualStyleBackColor = true;
            this.ShiftColumnToRightButton.Click += new System.EventHandler(this.ShiftColumnToRightButton_Click);
            // 
            // ConnectedTablesGroupBox
            // 
            this.ConnectedTablesGroupBox.Controls.Add(this.AllConnectedTablesListBox);
            this.ConnectedTablesGroupBox.Controls.Add(this.ChosenConnectedTablesListBox);
            this.ConnectedTablesGroupBox.Controls.Add(this.label1);
            this.ConnectedTablesGroupBox.Controls.Add(this.label2);
            this.ConnectedTablesGroupBox.Controls.Add(this.ShiftTableToRightButton);
            this.ConnectedTablesGroupBox.Controls.Add(this.ShiftTableToLeftButton);
            this.ConnectedTablesGroupBox.Enabled = false;
            this.ConnectedTablesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectedTablesGroupBox.Location = new System.Drawing.Point(15, 58);
            this.ConnectedTablesGroupBox.Name = "ConnectedTablesGroupBox";
            this.ConnectedTablesGroupBox.Size = new System.Drawing.Size(473, 133);
            this.ConnectedTablesGroupBox.TabIndex = 25;
            this.ConnectedTablesGroupBox.TabStop = false;
            this.ConnectedTablesGroupBox.Text = "Выбор свзанных таблиц";
            // 
            // ColumnsGroupBox
            // 
            this.ColumnsGroupBox.Controls.Add(this.AllColumnsListBox);
            this.ColumnsGroupBox.Controls.Add(this.AllColumnsLabel);
            this.ColumnsGroupBox.Controls.Add(this.ShiftColumnToLeftbutton);
            this.ColumnsGroupBox.Controls.Add(this.ChosenColumnsListBox);
            this.ColumnsGroupBox.Controls.Add(this.ShiftColumnToRightButton);
            this.ColumnsGroupBox.Controls.Add(this.ChosenColumnsLabel);
            this.ColumnsGroupBox.Enabled = false;
            this.ColumnsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnsGroupBox.Location = new System.Drawing.Point(15, 197);
            this.ColumnsGroupBox.Name = "ColumnsGroupBox";
            this.ColumnsGroupBox.Size = new System.Drawing.Size(473, 165);
            this.ColumnsGroupBox.TabIndex = 26;
            this.ColumnsGroupBox.TabStop = false;
            this.ColumnsGroupBox.Text = "Выбор атрибутов";
            // 
            // TableChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 416);
            this.Controls.Add(this.ColumnsGroupBox);
            this.Controls.Add(this.ConnectedTablesGroupBox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.MainTableLabel);
            this.Controls.Add(this.TablesComboBox);
            this.Name = "TableChooserForm";
            this.Text = "Выбор таблиц и атрибутов";
            this.Load += new System.EventHandler(this.TableChooserForm_Load);
            this.ConnectedTablesGroupBox.ResumeLayout(false);
            this.ConnectedTablesGroupBox.PerformLayout();
            this.ColumnsGroupBox.ResumeLayout(false);
            this.ColumnsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TablesComboBox;
        private System.Windows.Forms.Label MainTableLabel;
        private System.Windows.Forms.ListBox AllConnectedTablesListBox;
        private System.Windows.Forms.ListBox ChosenConnectedTablesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShiftTableToLeftButton;
        private System.Windows.Forms.Button ShiftTableToRightButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ListBox AllColumnsListBox;
        private System.Windows.Forms.Label AllColumnsLabel;
        private System.Windows.Forms.Label ChosenColumnsLabel;
        private System.Windows.Forms.ListBox ChosenColumnsListBox;
        private System.Windows.Forms.Button ShiftColumnToLeftbutton;
        private System.Windows.Forms.Button ShiftColumnToRightButton;
        private System.Windows.Forms.GroupBox ConnectedTablesGroupBox;
        private System.Windows.Forms.GroupBox ColumnsGroupBox;
    }
}