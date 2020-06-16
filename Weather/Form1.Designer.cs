namespace Weather
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IDInfo = new System.Windows.Forms.RichTextBox();
            this.feels_likeLabel = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.YandexTranslateCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.degLabel = new MetroFramework.Controls.MetroLabel();
            this.speedLabel = new MetroFramework.Controls.MetroLabel();
            this.humidityLabel = new MetroFramework.Controls.MetroLabel();
            this.pressureLabel = new MetroFramework.Controls.MetroLabel();
            this.tempLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.mainLabel = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datetimeLabel = new MetroFramework.Controls.MetroLabel();
            this.countryLabel = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.link = new MetroFramework.Controls.MetroLink();
            this.countryTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.idTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(663, 298);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(114, 45);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Выход";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IDInfo);
            this.groupBox1.Controls.Add(this.feels_likeLabel);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.humidityLabel);
            this.groupBox1.Controls.Add(this.pressureLabel);
            this.groupBox1.Controls.Add(this.tempLabel);
            this.groupBox1.Controls.Add(this.descriptionLabel);
            this.groupBox1.Controls.Add(this.mainLabel);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 229);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weather";
            // 
            // IDInfo
            // 
            this.IDInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDInfo.Location = new System.Drawing.Point(483, 26);
            this.IDInfo.Name = "IDInfo";
            this.IDInfo.ReadOnly = true;
            this.IDInfo.Size = new System.Drawing.Size(265, 100);
            this.IDInfo.TabIndex = 8;
            this.IDInfo.Text = "";
            this.IDInfo.Visible = false;
            // 
            // feels_likeLabel
            // 
            this.feels_likeLabel.AutoSize = true;
            this.feels_likeLabel.Location = new System.Drawing.Point(112, 106);
            this.feels_likeLabel.Name = "feels_likeLabel";
            this.feels_likeLabel.Size = new System.Drawing.Size(65, 20);
            this.feels_likeLabel.TabIndex = 7;
            this.feels_likeLabel.Text = "feels_like";
            this.feels_likeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.YandexTranslateCheckBox);
            this.groupBox2.Controls.Add(this.degLabel);
            this.groupBox2.Controls.Add(this.speedLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(6, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 91);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wnd";
            // 
            // YandexTranslateCheckBox
            // 
            this.YandexTranslateCheckBox.AutoSize = true;
            this.YandexTranslateCheckBox.Location = new System.Drawing.Point(615, 23);
            this.YandexTranslateCheckBox.Name = "YandexTranslateCheckBox";
            this.YandexTranslateCheckBox.Size = new System.Drawing.Size(117, 17);
            this.YandexTranslateCheckBox.TabIndex = 9;
            this.YandexTranslateCheckBox.Text = "YandexTranslate";
            this.YandexTranslateCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.YandexTranslateCheckBox.UseVisualStyleBackColor = true;
            this.YandexTranslateCheckBox.CheckedChanged += new System.EventHandler(this.YandexTranslateCheckBox_CheckedChanged);
            // 
            // degLabel
            // 
            this.degLabel.AutoSize = true;
            this.degLabel.Location = new System.Drawing.Point(6, 54);
            this.degLabel.Name = "degLabel";
            this.degLabel.Size = new System.Drawing.Size(33, 20);
            this.degLabel.TabIndex = 8;
            this.degLabel.Text = "deg";
            this.degLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(6, 23);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(47, 20);
            this.speedLabel.TabIndex = 7;
            this.speedLabel.Text = "speed";
            this.speedLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Location = new System.Drawing.Point(390, 67);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(62, 20);
            this.humidityLabel.TabIndex = 5;
            this.humidityLabel.Text = "humidity";
            this.humidityLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Location = new System.Drawing.Point(390, 26);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(63, 20);
            this.pressureLabel.TabIndex = 4;
            this.pressureLabel.Text = "pressure";
            this.pressureLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(390, 106);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(41, 20);
            this.tempLabel.TabIndex = 3;
            this.tempLabel.Text = "temp";
            this.tempLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(112, 67);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(77, 20);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "description";
            this.descriptionLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(112, 26);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(39, 20);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "main";
            this.mainLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(6, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 0;
            // 
            // datetimeLabel
            // 
            this.datetimeLabel.AutoSize = true;
            this.datetimeLabel.Location = new System.Drawing.Point(23, 318);
            this.datetimeLabel.Name = "datetimeLabel";
            this.datetimeLabel.Size = new System.Drawing.Size(63, 20);
            this.datetimeLabel.TabIndex = 7;
            this.datetimeLabel.Text = "datetime";
            this.datetimeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(23, 298);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(57, 20);
            this.countryLabel.TabIndex = 7;
            this.countryLabel.Text = "country";
            this.countryLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(663, 12);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(114, 45);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Обновить";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(506, 320);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(151, 23);
            this.link.TabIndex = 10;
            this.link.Text = "OpenWeatherMap.org";
            this.link.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.link.Click += new System.EventHandler(this.link_Click_1);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(135, 34);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(199, 23);
            this.countryTextBox.TabIndex = 11;
            this.countryTextBox.Text = "Название города";
            this.countryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countryTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.countryTextBox.Click += new System.EventHandler(this.countryTextBox_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(340, 12);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(114, 45);
            this.metroButton3.TabIndex = 12;
            this.metroButton3.Text = "Найти город";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(460, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(199, 23);
            this.idTextBox.TabIndex = 13;
            this.idTextBox.Text = "ID города";
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.idTextBox.Click += new System.EventHandler(this.idTextBox_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(506, 298);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(153, 25);
            this.metroButton4.TabIndex = 14;
            this.metroButton4.Text = "Help";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 358);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.link);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.datetimeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroButton1);
            this.MaximumSize = new System.Drawing.Size(795, 358);
            this.MinimumSize = new System.Drawing.Size(795, 358);
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Weather";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel mainLabel;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
        private MetroFramework.Controls.MetroLabel tempLabel;
        private MetroFramework.Controls.MetroLabel pressureLabel;
        private MetroFramework.Controls.MetroLabel humidityLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel degLabel;
        private MetroFramework.Controls.MetroLabel speedLabel;
        private MetroFramework.Controls.MetroLabel datetimeLabel;
        private MetroFramework.Controls.MetroLabel countryLabel;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLink link;
        private MetroFramework.Controls.MetroTextBox countryTextBox;
        private MetroFramework.Controls.MetroLabel feels_likeLabel;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox idTextBox;
        private System.Windows.Forms.RichTextBox IDInfo;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroCheckBox YandexTranslateCheckBox;
    }
}

