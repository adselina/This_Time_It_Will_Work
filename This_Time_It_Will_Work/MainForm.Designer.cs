
namespace This_Time_It_Will_Work
{
    partial class MainForm
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
            this.CreateDbButton = new System.Windows.Forms.Button();
            this.buttonChangeDB = new System.Windows.Forms.Button();
            this.buttonEntries = new System.Windows.Forms.Button();
            this.buttonQueries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateDbButton
            // 
            this.CreateDbButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDbButton.Location = new System.Drawing.Point(86, 138);
            this.CreateDbButton.Name = "CreateDbButton";
            this.CreateDbButton.Size = new System.Drawing.Size(243, 50);
            this.CreateDbButton.TabIndex = 0;
            this.CreateDbButton.Text = "Создать базу данных";
            this.CreateDbButton.UseVisualStyleBackColor = true;
            this.CreateDbButton.Click += new System.EventHandler(this.CreateDbButton_Click);
            // 
            // buttonChangeDB
            // 
            this.buttonChangeDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeDB.Location = new System.Drawing.Point(86, 194);
            this.buttonChangeDB.Name = "buttonChangeDB";
            this.buttonChangeDB.Size = new System.Drawing.Size(243, 50);
            this.buttonChangeDB.TabIndex = 1;
            this.buttonChangeDB.Text = "Редактировать базу данных";
            this.buttonChangeDB.UseVisualStyleBackColor = true;
            this.buttonChangeDB.Click += new System.EventHandler(this.buttonChangeDB_Click);
            // 
            // buttonEntries
            // 
            this.buttonEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEntries.Location = new System.Drawing.Point(86, 250);
            this.buttonEntries.Name = "buttonEntries";
            this.buttonEntries.Size = new System.Drawing.Size(243, 50);
            this.buttonEntries.TabIndex = 2;
            this.buttonEntries.Text = "Работа с записями в бд";
            this.buttonEntries.UseVisualStyleBackColor = true;
            this.buttonEntries.Click += new System.EventHandler(this.buttonEntries_Click);
            // 
            // buttonQueries
            // 
            this.buttonQueries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQueries.Location = new System.Drawing.Point(86, 306);
            this.buttonQueries.Name = "buttonQueries";
            this.buttonQueries.Size = new System.Drawing.Size(243, 50);
            this.buttonQueries.TabIndex = 3;
            this.buttonQueries.Text = "Конструктор запросов";
            this.buttonQueries.UseVisualStyleBackColor = true;
            this.buttonQueries.Click += new System.EventHandler(this.buttonQueries_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 413);
            this.Controls.Add(this.buttonQueries);
            this.Controls.Add(this.buttonEntries);
            this.Controls.Add(this.buttonChangeDB);
            this.Controls.Add(this.CreateDbButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateDbButton;
        private System.Windows.Forms.Button buttonChangeDB;
        private System.Windows.Forms.Button buttonEntries;
        private System.Windows.Forms.Button buttonQueries;
    }
}

