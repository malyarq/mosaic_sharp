
namespace TP
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.WidthWall = new System.Windows.Forms.TextBox();
            this.HeightWall = new System.Windows.Forms.TextBox();
            this.WidthMoz = new System.Windows.Forms.TextBox();
            this.HeightMoz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBox = new System.Windows.Forms.CheckedListBox();
            this.GenerateBt = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(200, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // WidthWall
            // 
            this.WidthWall.AccessibleDescription = "";
            this.WidthWall.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.WidthWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthWall.Location = new System.Drawing.Point(179, 606);
            this.WidthWall.Name = "WidthWall";
            this.WidthWall.Size = new System.Drawing.Size(100, 45);
            this.WidthWall.TabIndex = 1;
            this.WidthWall.Tag = "";
            this.WidthWall.Text = "500";
            this.WidthWall.TextChanged += new System.EventHandler(this.WidthWall_TextChanged);
            // 
            // HeightWall
            // 
            this.HeightWall.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HeightWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightWall.Location = new System.Drawing.Point(179, 679);
            this.HeightWall.Name = "HeightWall";
            this.HeightWall.Size = new System.Drawing.Size(100, 45);
            this.HeightWall.TabIndex = 2;
            this.HeightWall.Tag = "";
            this.HeightWall.Text = "500";
            this.HeightWall.TextChanged += new System.EventHandler(this.HeightWall_TextChanged);
            // 
            // WidthMoz
            // 
            this.WidthMoz.AccessibleDescription = "";
            this.WidthMoz.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.WidthMoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthMoz.Location = new System.Drawing.Point(641, 606);
            this.WidthMoz.Name = "WidthMoz";
            this.WidthMoz.Size = new System.Drawing.Size(100, 45);
            this.WidthMoz.TabIndex = 3;
            this.WidthMoz.Tag = "";
            this.WidthMoz.Text = "10";
            this.WidthMoz.TextChanged += new System.EventHandler(this.WidthMoz_TextChanged);
            // 
            // HeightMoz
            // 
            this.HeightMoz.AccessibleDescription = "";
            this.HeightMoz.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HeightMoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightMoz.Location = new System.Drawing.Point(641, 679);
            this.HeightMoz.Name = "HeightMoz";
            this.HeightMoz.Size = new System.Drawing.Size(100, 45);
            this.HeightMoz.TabIndex = 4;
            this.HeightMoz.Tag = "";
            this.HeightMoz.Text = "10";
            this.HeightMoz.TextChanged += new System.EventHandler(this.HeightMoz_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 679);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Высота";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(494, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ширина";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(500, 679);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Высота";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(564, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 41);
            this.label5.TabIndex = 9;
            this.label5.Text = "Чипы";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(90, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 41);
            this.label6.TabIndex = 10;
            this.label6.Text = "Стена";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // colorBox
            // 
            this.colorBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.colorBox.CheckOnClick = true;
            this.colorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorBox.FormattingEnabled = true;
            this.colorBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colorBox.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Orange",
            "Purple"});
            this.colorBox.Location = new System.Drawing.Point(15, 50);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(150, 497);
            this.colorBox.TabIndex = 13;
            this.colorBox.SelectedValueChanged += new System.EventHandler(this.colorBox_SelectedValueChanged);
            // 
            // GenerateBt
            // 
            this.GenerateBt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GenerateBt.AutoSize = true;
            this.GenerateBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateBt.Location = new System.Drawing.Point(320, 570);
            this.GenerateBt.Name = "GenerateBt";
            this.GenerateBt.Size = new System.Drawing.Size(150, 150);
            this.GenerateBt.TabIndex = 14;
            this.GenerateBt.Text = "Запуск";
            this.GenerateBt.UseVisualStyleBackColor = true;
            this.GenerateBt.Click += new System.EventHandler(this.GenerateBt_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.GenerateBt);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightMoz);
            this.Controls.Add(this.WidthMoz);
            this.Controls.Add(this.HeightWall);
            this.Controls.Add(this.WidthWall);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "Form1";
            this.Text = "Мозайка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox WidthWall;
        private System.Windows.Forms.TextBox HeightWall;
        private System.Windows.Forms.TextBox WidthMoz;
        private System.Windows.Forms.TextBox HeightMoz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.CheckedListBox colorBox;
        public System.Windows.Forms.Button GenerateBt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

