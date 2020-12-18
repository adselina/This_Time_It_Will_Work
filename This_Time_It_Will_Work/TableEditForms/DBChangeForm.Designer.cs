
namespace This_Time_It_Will_Work
{
    partial class DBChangeForm
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
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.TableNameTextBox = new System.Windows.Forms.TextBox();
            this.buttonDeleteTable = new System.Windows.Forms.Button();
            this.buttonCreateConnection = new System.Windows.Forms.Button();
            this.buttonAddAttribute = new System.Windows.Forms.Button();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.NonKeyItemsListbox = new System.Windows.Forms.ListBox();
            this.KeyItemsListbox = new System.Windows.Forms.ListBox();
            this.ChooseAsKeyButton = new System.Windows.Forms.Button();
            this.DropFromKeyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeKeyButton = new System.Windows.Forms.Button();
            this.ConnectionsListBox = new System.Windows.Forms.ListBox();
            this.DeleteConnectionButton = new System.Windows.Forms.Button();
            this.AllAttrsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteAttrButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 455);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 37);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTable.Location = new System.Drawing.Point(50, 79);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(148, 38);
            this.buttonAddTable.TabIndex = 2;
            this.buttonAddTable.Text = "Добавить таблицу";
            this.buttonAddTable.UseVisualStyleBackColor = true;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // TableNameTextBox
            // 
            this.TableNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableNameTextBox.Location = new System.Drawing.Point(12, 49);
            this.TableNameTextBox.Name = "TableNameTextBox";
            this.TableNameTextBox.Size = new System.Drawing.Size(222, 24);
            this.TableNameTextBox.TabIndex = 3;
            this.TableNameTextBox.TextChanged += new System.EventHandler(this.TableNameTextBox_TextChanged);
            this.TableNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TableNameTextBox_KeyPress);
            // 
            // buttonDeleteTable
            // 
            this.buttonDeleteTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteTable.Location = new System.Drawing.Point(300, 128);
            this.buttonDeleteTable.Name = "buttonDeleteTable";
            this.buttonDeleteTable.Size = new System.Drawing.Size(139, 38);
            this.buttonDeleteTable.TabIndex = 4;
            this.buttonDeleteTable.Text = "Удалить таблицу";
            this.buttonDeleteTable.UseVisualStyleBackColor = true;
            this.buttonDeleteTable.Click += new System.EventHandler(this.buttonDeleteTable_Click);
            // 
            // buttonCreateConnection
            // 
            this.buttonCreateConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateConnection.Location = new System.Drawing.Point(12, 154);
            this.buttonCreateConnection.Name = "buttonCreateConnection";
            this.buttonCreateConnection.Size = new System.Drawing.Size(223, 41);
            this.buttonCreateConnection.TabIndex = 5;
            this.buttonCreateConnection.Text = "Установить связь между двумя таблицами";
            this.buttonCreateConnection.UseVisualStyleBackColor = true;
            this.buttonCreateConnection.Click += new System.EventHandler(this.buttonCreateConnection_Click);
            // 
            // buttonAddAttribute
            // 
            this.buttonAddAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddAttribute.Location = new System.Drawing.Point(445, 128);
            this.buttonAddAttribute.Name = "buttonAddAttribute";
            this.buttonAddAttribute.Size = new System.Drawing.Size(142, 38);
            this.buttonAddAttribute.TabIndex = 7;
            this.buttonAddAttribute.Text = "Добавить атрибут";
            this.buttonAddAttribute.UseVisualStyleBackColor = true;
            this.buttonAddAttribute.Click += new System.EventHandler(this.buttonAddAttribute_Click);
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(300, 98);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(287, 24);
            this.comboBoxTables.TabIndex = 8;
            this.comboBoxTables.TextChanged += new System.EventHandler(this.comboBoxTables_TextChanged);
            this.comboBoxTables.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTables_KeyPress);
            // 
            // NonKeyItemsListbox
            // 
            this.NonKeyItemsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NonKeyItemsListbox.FormattingEnabled = true;
            this.NonKeyItemsListbox.ItemHeight = 16;
            this.NonKeyItemsListbox.Location = new System.Drawing.Point(309, 203);
            this.NonKeyItemsListbox.Name = "NonKeyItemsListbox";
            this.NonKeyItemsListbox.Size = new System.Drawing.Size(90, 84);
            this.NonKeyItemsListbox.TabIndex = 9;
            this.NonKeyItemsListbox.SelectedIndexChanged += new System.EventHandler(this.NonKeyItemsListbox_SelectedIndexChanged);
            // 
            // KeyItemsListbox
            // 
            this.KeyItemsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyItemsListbox.FormattingEnabled = true;
            this.KeyItemsListbox.ItemHeight = 16;
            this.KeyItemsListbox.Location = new System.Drawing.Point(487, 203);
            this.KeyItemsListbox.Name = "KeyItemsListbox";
            this.KeyItemsListbox.Size = new System.Drawing.Size(90, 84);
            this.KeyItemsListbox.TabIndex = 10;
            this.KeyItemsListbox.SelectedIndexChanged += new System.EventHandler(this.KeyItemsListbox_SelectedIndexChanged);
            // 
            // ChooseAsKeyButton
            // 
            this.ChooseAsKeyButton.Location = new System.Drawing.Point(406, 227);
            this.ChooseAsKeyButton.Name = "ChooseAsKeyButton";
            this.ChooseAsKeyButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseAsKeyButton.TabIndex = 11;
            this.ChooseAsKeyButton.Text = ">>";
            this.ChooseAsKeyButton.UseVisualStyleBackColor = true;
            this.ChooseAsKeyButton.Click += new System.EventHandler(this.ChooseAsKeyButton_Click);
            // 
            // DropFromKeyButton
            // 
            this.DropFromKeyButton.Location = new System.Drawing.Point(406, 256);
            this.DropFromKeyButton.Name = "DropFromKeyButton";
            this.DropFromKeyButton.Size = new System.Drawing.Size(75, 23);
            this.DropFromKeyButton.TabIndex = 12;
            this.DropFromKeyButton.Text = "<<";
            this.DropFromKeyButton.UseVisualStyleBackColor = true;
            this.DropFromKeyButton.Click += new System.EventHandler(this.DropFromKeyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(306, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Атрибуты таблицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(458, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Первичный ключ";
            // 
            // ChangeKeyButton
            // 
            this.ChangeKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeKeyButton.Location = new System.Drawing.Point(334, 304);
            this.ChangeKeyButton.Name = "ChangeKeyButton";
            this.ChangeKeyButton.Size = new System.Drawing.Size(223, 41);
            this.ChangeKeyButton.TabIndex = 15;
            this.ChangeKeyButton.Text = "Применить изменения в составе первичного ключа";
            this.ChangeKeyButton.UseVisualStyleBackColor = true;
            this.ChangeKeyButton.Click += new System.EventHandler(this.ChangeKeyButton_Click);
            // 
            // ConnectionsListBox
            // 
            this.ConnectionsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectionsListBox.FormattingEnabled = true;
            this.ConnectionsListBox.ItemHeight = 16;
            this.ConnectionsListBox.Location = new System.Drawing.Point(12, 237);
            this.ConnectionsListBox.Name = "ConnectionsListBox";
            this.ConnectionsListBox.Size = new System.Drawing.Size(223, 132);
            this.ConnectionsListBox.TabIndex = 16;
            this.ConnectionsListBox.SelectedIndexChanged += new System.EventHandler(this.ConnectionsListBox_SelectedIndexChanged);
            // 
            // DeleteConnectionButton
            // 
            this.DeleteConnectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteConnectionButton.Location = new System.Drawing.Point(12, 375);
            this.DeleteConnectionButton.Name = "DeleteConnectionButton";
            this.DeleteConnectionButton.Size = new System.Drawing.Size(223, 41);
            this.DeleteConnectionButton.TabIndex = 17;
            this.DeleteConnectionButton.Text = "Удалить выбранную связь";
            this.DeleteConnectionButton.UseVisualStyleBackColor = true;
            this.DeleteConnectionButton.Click += new System.EventHandler(this.DeleteConnectionButton_Click);
            // 
            // AllAttrsListBox
            // 
            this.AllAttrsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllAttrsListBox.FormattingEnabled = true;
            this.AllAttrsListBox.ItemHeight = 16;
            this.AllAttrsListBox.Location = new System.Drawing.Point(647, 98);
            this.AllAttrsListBox.Name = "AllAttrsListBox";
            this.AllAttrsListBox.Size = new System.Drawing.Size(235, 196);
            this.AllAttrsListBox.TabIndex = 18;
            this.AllAttrsListBox.SelectedIndexChanged += new System.EventHandler(this.AllAttrsListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(377, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Выберите таблицу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(694, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Список атрибутов";
            // 
            // DeleteAttrButton
            // 
            this.DeleteAttrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAttrButton.Location = new System.Drawing.Point(647, 303);
            this.DeleteAttrButton.Name = "DeleteAttrButton";
            this.DeleteAttrButton.Size = new System.Drawing.Size(235, 41);
            this.DeleteAttrButton.TabIndex = 21;
            this.DeleteAttrButton.Text = "Удалить атрибут";
            this.DeleteAttrButton.UseVisualStyleBackColor = true;
            this.DeleteAttrButton.Click += new System.EventHandler(this.DeleteAttrButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(71, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Список связей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(27, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Задайте имя новой таблицы";
            // 
            // DBChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 504);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteAttrButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AllAttrsListBox);
            this.Controls.Add(this.DeleteConnectionButton);
            this.Controls.Add(this.ConnectionsListBox);
            this.Controls.Add(this.ChangeKeyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DropFromKeyButton);
            this.Controls.Add(this.ChooseAsKeyButton);
            this.Controls.Add(this.KeyItemsListbox);
            this.Controls.Add(this.NonKeyItemsListbox);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.buttonAddAttribute);
            this.Controls.Add(this.buttonCreateConnection);
            this.Controls.Add(this.buttonDeleteTable);
            this.Controls.Add(this.TableNameTextBox);
            this.Controls.Add(this.buttonAddTable);
            this.Controls.Add(this.buttonBack);
            this.Name = "DBChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBChangeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DBChangeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddTable;
        private System.Windows.Forms.TextBox TableNameTextBox;
        private System.Windows.Forms.Button buttonDeleteTable;
        private System.Windows.Forms.Button buttonCreateConnection;
        private System.Windows.Forms.Button buttonAddAttribute;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.ListBox NonKeyItemsListbox;
        private System.Windows.Forms.ListBox KeyItemsListbox;
        private System.Windows.Forms.Button ChooseAsKeyButton;
        private System.Windows.Forms.Button DropFromKeyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChangeKeyButton;
        private System.Windows.Forms.ListBox ConnectionsListBox;
        private System.Windows.Forms.Button DeleteConnectionButton;
        private System.Windows.Forms.ListBox AllAttrsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteAttrButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}