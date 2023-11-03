namespace WinMultiwindow
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            name = new TextBox();
            author = new TextBox();
            price = new TextBox();
            button1 = new Button();
            button2 = new Button();
            year = new TextBox();
            genre = new TextBox();
            isbn = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            return_date = new TextBox();
            label7 = new Label();
            date_of_issue = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-1, 53);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 314);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // name
            // 
            name.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(74, 12);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(187, 30);
            name.TabIndex = 3;
            // 
            // author
            // 
            author.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            author.Location = new Point(74, 53);
            author.Margin = new Padding(3, 4, 3, 4);
            author.Multiline = true;
            author.Name = "author";
            author.Size = new Size(187, 26);
            author.TabIndex = 4;
            // 
            // price
            // 
            price.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            price.Location = new Point(74, 311);
            price.Margin = new Padding(3, 4, 3, 4);
            price.Name = "price";
            price.Size = new Size(187, 30);
            price.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 363);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 40);
            button1.TabIndex = 6;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(187, 363);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(117, 40);
            button2.TabIndex = 7;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // year
            // 
            year.Location = new Point(187, 97);
            year.Name = "year";
            year.Size = new Size(187, 27);
            year.TabIndex = 8;
            // 
            // genre
            // 
            genre.Location = new Point(75, 130);
            genre.Name = "genre";
            genre.Size = new Size(187, 27);
            genre.TabIndex = 9;
            // 
            // isbn
            // 
            isbn.Location = new Point(75, 174);
            isbn.Name = "isbn";
            isbn.Size = new Size(187, 27);
            isbn.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 98);
            label4.Name = "label4";
            label4.Size = new Size(167, 23);
            label4.TabIndex = 11;
            label4.Text = "Year of publication";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 128);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 12;
            label5.Text = "Genre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 178);
            label6.Name = "label6";
            label6.Size = new Size(55, 23);
            label6.TabIndex = 13;
            label6.Text = "ISBN";
            // 
            // return_date
            // 
            return_date.Location = new Point(116, 222);
            return_date.Name = "return_date";
            return_date.Size = new Size(187, 27);
            return_date.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(-1, 223);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 15;
            label7.Text = "Return date";
            // 
            // date_of_issue
            // 
            date_of_issue.Location = new Point(137, 266);
            date_of_issue.Name = "date_of_issue";
            date_of_issue.Size = new Size(187, 27);
            date_of_issue.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 267);
            label8.Name = "label8";
            label8.Size = new Size(119, 23);
            label8.TabIndex = 17;
            label8.Text = "Date of issue";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 422);
            Controls.Add(label8);
            Controls.Add(date_of_issue);
            Controls.Add(label7);
            Controls.Add(return_date);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(isbn);
            Controls.Add(genre);
            Controls.Add(year);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(price);
            Controls.Add(author);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox author;
        private TextBox price;
        private Button button1;
        private Button button2;
        private TextBox year;
        private TextBox genre;
        private TextBox isbn;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox return_date;
        private Label label7;
        private TextBox date_of_issue;
        private Label label8;
    }
}