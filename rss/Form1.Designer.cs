namespace rss
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
            this.btnSparaFeed = new System.Windows.Forms.Button();
            this.btnTaBortFeed = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblFrekvens = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.lblPodcastBeskrivning = new System.Windows.Forms.Label();
            this.lblAvsinttsBeskrivning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxAvsnitt
            // 
            this.lstBoxAvsnitt.FormattingEnabled = true;
            this.lstBoxAvsnitt.ItemHeight = 25;
            this.lstBoxAvsnitt.Location = new System.Drawing.Point(32, 433);
            this.lstBoxAvsnitt.Name = "lstBoxAvsnitt";
            this.lstBoxAvsnitt.Size = new System.Drawing.Size(624, 179);
            this.lstBoxAvsnitt.TabIndex = 0;
            // 
            // comboBoxFrekvens
            // 
            this.comboBoxFrekvens.FormattingEnabled = true;
            this.comboBoxFrekvens.Location = new System.Drawing.Point(271, 327);
            this.comboBoxFrekvens.Name = "comboBoxFrekvens";
            this.comboBoxFrekvens.Size = new System.Drawing.Size(207, 33);
            this.comboBoxFrekvens.TabIndex = 1;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(495, 327);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(161, 33);
            this.comboBoxKategori.TabIndex = 2;
            // 
            // lstBoxKategori
            // 
            this.lstBoxKategori.FormattingEnabled = true;
            this.lstBoxKategori.ItemHeight = 25;
            this.lstBoxKategori.Location = new System.Drawing.Point(703, 75);
            this.lstBoxKategori.Name = "lstBoxKategori";
            this.lstBoxKategori.Size = new System.Drawing.Size(385, 204);
            this.lstBoxKategori.TabIndex = 3;
            // 
            // lstViewFeed
            // 
            this.lstViewFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAvsnitt,
            this.columnNamn,
            this.columnFrekvens,
            this.columnKategori});
            this.lstViewFeed.Location = new System.Drawing.Point(32, 75);
            this.lstViewFeed.Name = "lstViewFeed";
            this.lstViewFeed.Size = new System.Drawing.Size(624, 204);
            this.lstViewFeed.TabIndex = 4;
            this.lstViewFeed.UseCompatibleStateImageBehavior = false;
            this.lstViewFeed.View = System.Windows.Forms.View.Details;
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
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(232, 31);
            this.txtBoxURL.TabIndex = 5;
            // 
            // txtBoxKategori
            // 
            this.txtBoxKategori.Location = new System.Drawing.Point(703, 309);
            this.txtBoxKategori.Name = "txtBoxKategori";
            this.txtBoxKategori.Size = new System.Drawing.Size(385, 31);
            this.txtBoxKategori.TabIndex = 6;
            // 
            // btnNyFeed
            // 
            this.btnNyFeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNyFeed.Location = new System.Drawing.Point(271, 378);
            this.btnNyFeed.Name = "btnNyFeed";
            this.btnNyFeed.Size = new System.Drawing.Size(112, 34);
            this.btnNyFeed.TabIndex = 7;
            this.btnNyFeed.Text = "Ny...";
            this.btnNyFeed.UseVisualStyleBackColor = true;
            // 
            // btnSparaFeed
            // 
            this.btnSparaFeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSparaFeed.Location = new System.Drawing.Point(408, 378);
            this.btnSparaFeed.Name = "btnSparaFeed";
            this.btnSparaFeed.Size = new System.Drawing.Size(112, 34);
            this.btnSparaFeed.TabIndex = 8;
            this.btnSparaFeed.Text = "Spara";
            this.btnSparaFeed.UseVisualStyleBackColor = true;
            // 
            // btnTaBortFeed
            // 
            this.btnTaBortFeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaBortFeed.Location = new System.Drawing.Point(544, 378);
            this.btnTaBortFeed.Name = "btnTaBortFeed";
            this.btnTaBortFeed.Size = new System.Drawing.Size(112, 34);
            this.btnTaBortFeed.TabIndex = 9;
            this.btnTaBortFeed.Text = "Ta bort...";
            this.btnTaBortFeed.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaBortKategori.Location = new System.Drawing.Point(976, 346);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(112, 34);
            this.btnTaBortKategori.TabIndex = 12;
            this.btnTaBortKategori.Text = "Ta Bort...";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSparaKategori.Location = new System.Drawing.Point(840, 346);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(112, 34);
            this.btnSparaKategori.TabIndex = 11;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNyKategori.Location = new System.Drawing.Point(703, 346);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(112, 34);
            this.btnNyKategori.TabIndex = 10;
            this.btnNyKategori.Text = "Ny...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblURL.Location = new System.Drawing.Point(28, 298);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(51, 25);
            this.lblURL.TabIndex = 13;
            this.lblURL.Text = "URL:";
            // 
            // lblFrekvens
            // 
            this.lblFrekvens.AutoSize = true;
            this.lblFrekvens.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFrekvens.Location = new System.Drawing.Point(267, 297);
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
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(90, 25);
            this.lblKategori.TabIndex = 15;
            this.lblKategori.Text = "Kategori:";
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKategorier.Location = new System.Drawing.Point(699, 47);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(108, 25);
            this.lblKategorier.TabIndex = 16;
            this.lblKategorier.Text = "Kategorier:";
            // 
            // lblPodcastBeskrivning
            // 
            this.lblPodcastBeskrivning.AutoSize = true;
            this.lblPodcastBeskrivning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPodcastBeskrivning.Location = new System.Drawing.Point(27, 405);
            this.lblPodcastBeskrivning.Name = "lblPodcastBeskrivning";
            this.lblPodcastBeskrivning.Size = new System.Drawing.Size(186, 25);
            this.lblPodcastBeskrivning.TabIndex = 17;
            this.lblPodcastBeskrivning.Text = "Podcast #: Avsnitt: #";
            // 
            // lblAvsinttsBeskrivning
            // 
            this.lblAvsinttsBeskrivning.AutoSize = true;
            this.lblAvsinttsBeskrivning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvsinttsBeskrivning.Location = new System.Drawing.Point(703, 429);
            this.lblAvsinttsBeskrivning.Name = "lblAvsinttsBeskrivning";
            this.lblAvsinttsBeskrivning.Size = new System.Drawing.Size(186, 25);
            this.lblAvsinttsBeskrivning.TabIndex = 19;
            this.lblAvsinttsBeskrivning.Text = "Podcast #: Avsnitt: #";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1100, 648);
            this.Controls.Add(this.lblAvsinttsBeskrivning);
            this.Controls.Add(this.lblPodcastBeskrivning);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblFrekvens);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.btnTaBortFeed);
            this.Controls.Add(this.btnSparaFeed);
            this.Controls.Add(this.btnNyFeed);
            this.Controls.Add(this.txtBoxKategori);
            this.Controls.Add(this.txtBoxURL);
            this.Controls.Add(this.lstViewFeed);
            this.Controls.Add(this.lstBoxKategori);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.comboBoxFrekvens);
            this.Controls.Add(this.lstBoxAvsnitt);
            this.Name = "Form1";
            this.Text = "RSS-reader";
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
        private Button btnSparaFeed;
        private Button btnTaBortFeed;
        private Button btnTaBortKategori;
        private Button btnSparaKategori;
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
    }
}