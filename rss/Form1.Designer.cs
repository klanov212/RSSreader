namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBoxAvsnitt = new System.Windows.Forms.ListBox();
            this.comboBoxFrekvens = new System.Windows.Forms.ComboBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.lstBoxKategori = new System.Windows.Forms.ListBox();
            this.lstViewFeed = new System.Windows.Forms.ListView();
            this.columnAvsnitt = new System.Windows.Forms.ColumnHeader();
            this.columnNamn = new System.Windows.Forms.ColumnHeader();
            this.columnFrekvens = new System.Windows.Forms.ColumnHeader();
            this.columnKategori = new System.Windows.Forms.ColumnHeader();
            this.txtBoxURL = new System.Windows.Forms.TextBox();
            this.txtBoxKategori = new System.Windows.Forms.TextBox();
            this.btnNyFeed = new System.Windows.Forms.Button();
            this.btnAndraFeed = new System.Windows.Forms.Button();
            this.btnTaBortFeed = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.btnAndraKategori = new System.Windows.Forms.Button();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblFrekvens = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.lblPodcastBeskrivning = new System.Windows.Forms.Label();
            this.lblAvsinttsBeskrivning = new System.Windows.Forms.Label();
            this.txtBoxBeskrivning = new System.Windows.Forms.RichTextBox();
            this.txtBoxNamn = new System.Windows.Forms.TextBox();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblFeed = new System.Windows.Forms.Label();
            this.btnAllaKategorier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxAvsnitt
            // 
            this.lstBoxAvsnitt.FormattingEnabled = true;
            this.lstBoxAvsnitt.ItemHeight = 25;
            this.lstBoxAvsnitt.Location = new System.Drawing.Point(32, 492);
            this.lstBoxAvsnitt.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxAvsnitt.Name = "lstBoxAvsnitt";
            this.lstBoxAvsnitt.Size = new System.Drawing.Size(624, 179);
            this.lstBoxAvsnitt.TabIndex = 0;
            this.lstBoxAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lstBoxAvsnitt_SelectedIndexChanged);
            // 
            // comboBoxFrekvens
            // 
            this.comboBoxFrekvens.FormattingEnabled = true;
            this.comboBoxFrekvens.Items.AddRange(new object[] {
            "10 sek",
            "30 sek",
            "1 min"});
            this.comboBoxFrekvens.Location = new System.Drawing.Point(271, 328);
            this.comboBoxFrekvens.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFrekvens.Name = "comboBoxFrekvens";
            this.comboBoxFrekvens.Size = new System.Drawing.Size(206, 33);
            this.comboBoxFrekvens.TabIndex = 1;
            this.comboBoxFrekvens.Text = "Uppdateringsfrekvens";
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(495, 328);
            this.comboBoxKategori.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(162, 33);
            this.comboBoxKategori.TabIndex = 2;
            this.comboBoxKategori.Text = "Välj kategori";
            // 
            // lstBoxKategori
            // 
            this.lstBoxKategori.FormattingEnabled = true;
            this.lstBoxKategori.ItemHeight = 25;
            this.lstBoxKategori.Location = new System.Drawing.Point(702, 32);
            this.lstBoxKategori.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxKategori.Name = "lstBoxKategori";
            this.lstBoxKategori.Size = new System.Drawing.Size(385, 254);
            this.lstBoxKategori.TabIndex = 3;
            this.lstBoxKategori.SelectedIndexChanged += new System.EventHandler(this.lstBoxKategori_SelectedIndexChanged);
            // 
            // lstViewFeed
            // 
            this.lstViewFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAvsnitt,
            this.columnNamn,
            this.columnFrekvens,
            this.columnKategori});
            this.lstViewFeed.FullRowSelect = true;
            this.lstViewFeed.GridLines = true;
            this.lstViewFeed.Location = new System.Drawing.Point(32, 32);
            this.lstViewFeed.Margin = new System.Windows.Forms.Padding(2);
            this.lstViewFeed.Name = "lstViewFeed";
            this.lstViewFeed.Size = new System.Drawing.Size(624, 254);
            this.lstViewFeed.TabIndex = 4;
            this.lstViewFeed.UseCompatibleStateImageBehavior = false;
            this.lstViewFeed.View = System.Windows.Forms.View.Details;
            this.lstViewFeed.SelectedIndexChanged += new System.EventHandler(this.lstViewFeed_SelectedIndexChanged);
            // 
            // columnAvsnitt
            // 
            this.columnAvsnitt.Text = "Avsnitt";
            this.columnAvsnitt.Width = 90;
            // 
            // columnNamn
            // 
            this.columnNamn.Text = "Namn";
            this.columnNamn.Width = 200;
            // 
            // columnFrekvens
            // 
            this.columnFrekvens.Text = "Frekvens";
            this.columnFrekvens.Width = 150;
            // 
            // columnKategori
            // 
            this.columnKategori.Text = "Kategori";
            this.columnKategori.Width = 184;
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Location = new System.Drawing.Point(32, 329);
            this.txtBoxURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.PlaceholderText = "Klistra in url här";
            this.txtBoxURL.Size = new System.Drawing.Size(232, 31);
            this.txtBoxURL.TabIndex = 5;
            // 
            // txtBoxKategori
            // 
            this.txtBoxKategori.Location = new System.Drawing.Point(702, 374);
            this.txtBoxKategori.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxKategori.Name = "txtBoxKategori";
            this.txtBoxKategori.PlaceholderText = "Skriv in den kategori du vill lägga till här";
            this.txtBoxKategori.Size = new System.Drawing.Size(385, 31);
            this.txtBoxKategori.TabIndex = 6;
            // 
            // btnNyFeed
            // 
            this.btnNyFeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNyFeed.Location = new System.Drawing.Point(271, 412);
            this.btnNyFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnNyFeed.Name = "btnNyFeed";
            this.btnNyFeed.Size = new System.Drawing.Size(112, 34);
            this.btnNyFeed.TabIndex = 7;
            this.btnNyFeed.Text = "Ny...";
            this.btnNyFeed.UseVisualStyleBackColor = true;
            this.btnNyFeed.Click += new System.EventHandler(this.btnNyFeed_Click);
            // 
            // btnAndraFeed
            // 
            this.btnAndraFeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAndraFeed.Location = new System.Drawing.Point(408, 412);
            this.btnAndraFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnAndraFeed.Name = "btnAndraFeed";
            this.btnAndraFeed.Size = new System.Drawing.Size(112, 34);
            this.btnAndraFeed.TabIndex = 8;
            this.btnAndraFeed.Text = "Ändra";
            this.btnAndraFeed.UseVisualStyleBackColor = true;
            this.btnAndraFeed.Click += new System.EventHandler(this.btnAndraFeed_Click);
            // 
            // btnTaBortFeed
            // 
            this.btnTaBortFeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaBortFeed.Location = new System.Drawing.Point(544, 412);
            this.btnTaBortFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBortFeed.Name = "btnTaBortFeed";
            this.btnTaBortFeed.Size = new System.Drawing.Size(112, 34);
            this.btnTaBortFeed.TabIndex = 9;
            this.btnTaBortFeed.Text = "Ta bort...";
            this.btnTaBortFeed.UseVisualStyleBackColor = true;
            this.btnTaBortFeed.Click += new System.EventHandler(this.btnTaBortFeed_Click);
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaBortKategori.Location = new System.Drawing.Point(976, 412);
            this.btnTaBortKategori.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(112, 34);
            this.btnTaBortKategori.TabIndex = 12;
            this.btnTaBortKategori.Text = "Ta Bort...";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // btnAndraKategori
            // 
            this.btnAndraKategori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAndraKategori.Location = new System.Drawing.Point(840, 412);
            this.btnAndraKategori.Margin = new System.Windows.Forms.Padding(2);
            this.btnAndraKategori.Name = "btnAndraKategori";
            this.btnAndraKategori.Size = new System.Drawing.Size(112, 34);
            this.btnAndraKategori.TabIndex = 11;
            this.btnAndraKategori.Text = "Ändra";
            this.btnAndraKategori.UseVisualStyleBackColor = true;
            this.btnAndraKategori.Click += new System.EventHandler(this.btnAndraKategori_Click);
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNyKategori.Location = new System.Drawing.Point(702, 412);
            this.btnNyKategori.Margin = new System.Windows.Forms.Padding(2);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(112, 34);
            this.btnNyKategori.TabIndex = 10;
            this.btnNyKategori.Text = "Ny...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            this.btnNyKategori.Click += new System.EventHandler(this.btnNyKategori_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblURL.Location = new System.Drawing.Point(28, 298);
            this.lblURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(51, 25);
            this.lblURL.TabIndex = 13;
            this.lblURL.Text = "URL:";
            // 
            // lblFrekvens
            // 
            this.lblFrekvens.AutoSize = true;
            this.lblFrekvens.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFrekvens.Location = new System.Drawing.Point(268, 298);
            this.lblFrekvens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrekvens.Name = "lblFrekvens";
            this.lblFrekvens.Size = new System.Drawing.Size(205, 25);
            this.lblFrekvens.TabIndex = 14;
            this.lblFrekvens.Text = "Uppspelningsfrekvens:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKategori.Location = new System.Drawing.Point(495, 298);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(90, 25);
            this.lblKategori.TabIndex = 15;
            this.lblKategori.Text = "Kategori:";
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKategorier.Location = new System.Drawing.Point(699, 5);
            this.lblKategorier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(108, 25);
            this.lblKategorier.TabIndex = 16;
            this.lblKategorier.Text = "Kategorier:";
            // 
            // lblPodcastBeskrivning
            // 
            this.lblPodcastBeskrivning.AutoSize = true;
            this.lblPodcastBeskrivning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPodcastBeskrivning.Location = new System.Drawing.Point(28, 465);
            this.lblPodcastBeskrivning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodcastBeskrivning.Name = "lblPodcastBeskrivning";
            this.lblPodcastBeskrivning.Size = new System.Drawing.Size(186, 25);
            this.lblPodcastBeskrivning.TabIndex = 17;
            this.lblPodcastBeskrivning.Text = "Podcast #: Avsnitt: #";
            // 
            // lblAvsinttsBeskrivning
            // 
            this.lblAvsinttsBeskrivning.AutoSize = true;
            this.lblAvsinttsBeskrivning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvsinttsBeskrivning.Location = new System.Drawing.Point(702, 468);
            this.lblAvsinttsBeskrivning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvsinttsBeskrivning.Name = "lblAvsinttsBeskrivning";
            this.lblAvsinttsBeskrivning.Size = new System.Drawing.Size(186, 25);
            this.lblAvsinttsBeskrivning.TabIndex = 19;
            this.lblAvsinttsBeskrivning.Text = "Podcast #: Avsnitt: #";
            // 
            // txtBoxBeskrivning
            // 
            this.txtBoxBeskrivning.Location = new System.Drawing.Point(702, 492);
            this.txtBoxBeskrivning.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxBeskrivning.Name = "txtBoxBeskrivning";
            this.txtBoxBeskrivning.Size = new System.Drawing.Size(385, 179);
            this.txtBoxBeskrivning.TabIndex = 20;
            this.txtBoxBeskrivning.Text = "";
            // 
            // txtBoxNamn
            // 
            this.txtBoxNamn.Location = new System.Drawing.Point(32, 415);
            this.txtBoxNamn.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNamn.Name = "txtBoxNamn";
            this.txtBoxNamn.PlaceholderText = "Skriv in namn här";
            this.txtBoxNamn.Size = new System.Drawing.Size(232, 31);
            this.txtBoxNamn.TabIndex = 21;
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNamn.Location = new System.Drawing.Point(28, 384);
            this.lblNamn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(68, 25);
            this.lblNamn.TabIndex = 22;
            this.lblNamn.Text = "Namn:";
            // 
            // lblFeed
            // 
            this.lblFeed.AutoSize = true;
            this.lblFeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFeed.Location = new System.Drawing.Point(32, 5);
            this.lblFeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeed.Name = "lblFeed";
            this.lblFeed.Size = new System.Drawing.Size(57, 25);
            this.lblFeed.TabIndex = 23;
            this.lblFeed.Text = "Feed:";
            // 
            // btnAllaKategorier
            // 
            this.btnAllaKategorier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAllaKategorier.Location = new System.Drawing.Point(768, 298);
            this.btnAllaKategorier.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllaKategorier.Name = "btnAllaKategorier";
            this.btnAllaKategorier.Size = new System.Drawing.Size(258, 34);
            this.btnAllaKategorier.TabIndex = 24;
            this.btnAllaKategorier.Text = "Se alla feeds";
            this.btnAllaKategorier.UseVisualStyleBackColor = true;
            this.btnAllaKategorier.Click += new System.EventHandler(this.btnAllaKategorier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1100, 690);
            this.Controls.Add(this.btnAllaKategorier);
            this.Controls.Add(this.lblFeed);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.txtBoxNamn);
            this.Controls.Add(this.txtBoxBeskrivning);
            this.Controls.Add(this.lblAvsinttsBeskrivning);
            this.Controls.Add(this.lblPodcastBeskrivning);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblFrekvens);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnAndraKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.btnTaBortFeed);
            this.Controls.Add(this.btnAndraFeed);
            this.Controls.Add(this.btnNyFeed);
            this.Controls.Add(this.txtBoxKategori);
            this.Controls.Add(this.txtBoxURL);
            this.Controls.Add(this.lstViewFeed);
            this.Controls.Add(this.lstBoxKategori);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.comboBoxFrekvens);
            this.Controls.Add(this.lstBoxAvsnitt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "RSS-reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstBoxAvsnitt;
        private ComboBox comboBoxFrekvens;
        private ComboBox comboBoxKategori;
        private ListBox lstBoxKategori;
        private ListView lstViewFeed;
        private TextBox txtBoxURL;
        private TextBox txtBoxKategori;
        private Button btnNyFeed;
        private Button btnAndraFeed;
        private Button btnTaBortFeed;
        private Button btnTaBortKategori;
        private Button btnAndraKategori;
        private Button btnNyKategori;
        private Label lblURL;
        private Label lblFrekvens;
        private Label lblKategori;
        private Label lblKategorier;
        private ColumnHeader columnAvsnitt;
        private ColumnHeader columnNamn;
        private ColumnHeader columnFrekvens;
        private ColumnHeader columnKategori;
        private Label lblPodcastBeskrivning;
        private Label lblAvsinttsBeskrivning;
        private RichTextBox txtBoxBeskrivning;
        private TextBox txtBoxNamn;
        private Label lblNamn;
        private Label lblFeed;
        private Button btnAllaKategorier;
    }
}