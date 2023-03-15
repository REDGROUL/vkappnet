namespace vk
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.TextBox();
            this.Hometown = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Photo = new System.Windows.Forms.TextBox();
            this.Video = new System.Windows.Forms.TextBox();
            this.Friends = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.OnOf = new System.Windows.Forms.TextBox();
            this.OnOf2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Firstname
            // 
            this.Firstname.BackColor = System.Drawing.SystemColors.Menu;
            this.Firstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Firstname.Location = new System.Drawing.Point(364, 8);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(305, 29);
            this.Firstname.TabIndex = 2;
            this.Firstname.TextChanged += new System.EventHandler(this.Firstname_TextChanged);
            // 
            // Lastname
            // 
            this.Lastname.BackColor = System.Drawing.SystemColors.Menu;
            this.Lastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lastname.Location = new System.Drawing.Point(364, 43);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(305, 29);
            this.Lastname.TabIndex = 2;
            this.Lastname.TextChanged += new System.EventHandler(this.Lastname_TextChanged);
            // 
            // Sex
            // 
            this.Sex.BackColor = System.Drawing.SystemColors.Menu;
            this.Sex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sex.Location = new System.Drawing.Point(364, 78);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(305, 29);
            this.Sex.TabIndex = 2;
            this.Sex.TextChanged += new System.EventHandler(this.Sex_TextChanged);
            // 
            // Birthday
            // 
            this.Birthday.BackColor = System.Drawing.SystemColors.Menu;
            this.Birthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Birthday.Location = new System.Drawing.Point(364, 113);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(305, 29);
            this.Birthday.TabIndex = 2;
            this.Birthday.TextChanged += new System.EventHandler(this.Birthday_TextChanged);
            // 
            // Hometown
            // 
            this.Hometown.BackColor = System.Drawing.SystemColors.Menu;
            this.Hometown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hometown.Location = new System.Drawing.Point(364, 149);
            this.Hometown.Name = "Hometown";
            this.Hometown.Size = new System.Drawing.Size(305, 29);
            this.Hometown.TabIndex = 2;
            this.Hometown.TextChanged += new System.EventHandler(this.Hometown_TextChanged);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.Menu;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Status.Location = new System.Drawing.Point(364, 184);
            this.Status.Multiline = true;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(305, 49);
            this.Status.TabIndex = 2;
            this.Status.TextChanged += new System.EventHandler(this.Status_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(167, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фото";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(163, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Друзья";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(167, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Видео";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Photo
            // 
            this.Photo.BackColor = System.Drawing.SystemColors.Menu;
            this.Photo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Photo.Location = new System.Drawing.Point(230, 38);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(100, 29);
            this.Photo.TabIndex = 6;
            this.Photo.TextChanged += new System.EventHandler(this.Photo_TextChanged);
            // 
            // Video
            // 
            this.Video.BackColor = System.Drawing.SystemColors.Menu;
            this.Video.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Video.Location = new System.Drawing.Point(230, 73);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(100, 29);
            this.Video.TabIndex = 6;
            this.Video.TextChanged += new System.EventHandler(this.Video_TextChanged);
            // 
            // Friends
            // 
            this.Friends.BackColor = System.Drawing.SystemColors.Menu;
            this.Friends.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Friends.Location = new System.Drawing.Point(230, 108);
            this.Friends.Name = "Friends";
            this.Friends.Size = new System.Drawing.Size(100, 29);
            this.Friends.TabIndex = 6;
            this.Friends.TextChanged += new System.EventHandler(this.Friends_TextChanged);
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ID.Location = new System.Drawing.Point(12, 159);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(159, 23);
            this.ID.TabIndex = 7;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // OnOf
            // 
            this.OnOf.BackColor = System.Drawing.SystemColors.Menu;
            this.OnOf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OnOf.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OnOf.Location = new System.Drawing.Point(162, 8);
            this.OnOf.Name = "OnOf";
            this.OnOf.Size = new System.Drawing.Size(62, 15);
            this.OnOf.TabIndex = 8;
            // 
            // OnOf2
            // 
            this.OnOf2.BackColor = System.Drawing.SystemColors.Menu;
            this.OnOf2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OnOf2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OnOf2.Location = new System.Drawing.Point(230, 8);
            this.OnOf2.Name = "OnOf2";
            this.OnOf2.Size = new System.Drawing.Size(62, 15);
            this.OnOf2.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(709, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(504, 319);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(709, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.OnOf2);
            this.Controls.Add(this.OnOf);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Friends);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Hometown);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public PictureBox pictureBox1;
        public TextBox Firstname;
        public TextBox Lastname;
        public TextBox Sex;
        public TextBox Birthday;
        public TextBox Hometown;
        public TextBox Status;
        private Label label4;
        private Label label6;
        private Label label5;
        public TextBox Photo;
        public TextBox Video;
        public TextBox Friends;
        public TextBox ID;
        public TextBox OnOf;
        public TextBox OnOf2;
        public ListBox listBox1;
        public TextBox textBox1;
        public Button button1;
    }
}