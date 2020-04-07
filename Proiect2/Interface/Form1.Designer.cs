namespace Interface
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uploadButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.datecreatedPicker = new System.Windows.Forms.DateTimePicker();
            this.eventLabel = new System.Windows.Forms.Label();
            this.eventBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.landscapeLabel = new System.Windows.Forms.Label();
            this.landscapeBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.itemsTable = new System.Windows.Forms.DataGridView();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Landscape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.countryFilter = new System.Windows.Forms.TextBox();
            this.landscapeFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eventFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.filterButton = new System.Windows.Forms.Button();
            this.messageAdded = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.personsLabel = new System.Windows.Forms.Label();
            this.addPersonText = new System.Windows.Forms.TextBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.filterPersons = new System.Windows.Forms.ListBox();
            this.filterPersonsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.photoCheckbox = new System.Windows.Forms.CheckBox();
            this.videoCheckbox = new System.Windows.Forms.CheckBox();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.itemsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("Comic Sans MS", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(164, 125);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(99, 40);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Blue;
            this.cancelButton.Location = new System.Drawing.Point(554, 350);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 32);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameLabel.Location = new System.Drawing.Point(278, 136);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(0, 19);
            this.filenameLabel.TabIndex = 1;
            // 
            // datecreatedPicker
            // 
            this.datecreatedPicker.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datecreatedPicker.Location = new System.Drawing.Point(326, 168);
            this.datecreatedPicker.Name = "datecreatedPicker";
            this.datecreatedPicker.Size = new System.Drawing.Size(147, 26);
            this.datecreatedPicker.TabIndex = 2;
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLabel.Location = new System.Drawing.Point(167, 282);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(47, 19);
            this.eventLabel.TabIndex = 3;
            this.eventLabel.Text = "Event";
            // 
            // eventBox
            // 
            this.eventBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventBox.Location = new System.Drawing.Point(326, 282);
            this.eventBox.Name = "eventBox";
            this.eventBox.Size = new System.Drawing.Size(147, 26);
            this.eventBox.TabIndex = 4;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(326, 208);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(147, 61);
            this.descriptionBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // landscapeLabel
            // 
            this.landscapeLabel.AutoSize = true;
            this.landscapeLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landscapeLabel.Location = new System.Drawing.Point(167, 333);
            this.landscapeLabel.Name = "landscapeLabel";
            this.landscapeLabel.Size = new System.Drawing.Size(75, 19);
            this.landscapeLabel.TabIndex = 7;
            this.landscapeLabel.Text = "Landscape";
            // 
            // landscapeBox
            // 
            this.landscapeBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landscapeBox.Location = new System.Drawing.Point(329, 333);
            this.landscapeBox.Name = "landscapeBox";
            this.landscapeBox.Size = new System.Drawing.Size(144, 26);
            this.landscapeBox.TabIndex = 8;
            // 
            // countryBox
            // 
            this.countryBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryBox.Location = new System.Drawing.Point(329, 386);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(144, 26);
            this.countryBox.TabIndex = 9;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(167, 389);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(59, 19);
            this.countryLabel.TabIndex = 10;
            this.countryLabel.Text = "Country";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.saveButton.Location = new System.Drawing.Point(548, 214);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 32);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(548, 282);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(91, 32);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // itemsTable
            // 
            this.itemsTable.AllowUserToAddRows = false;
            this.itemsTable.AllowUserToDeleteRows = false;
            this.itemsTable.BackgroundColor = System.Drawing.Color.White;
            this.itemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path,
            this.Id_item,
            this.Description,
            this.Event,
            this.Country,
            this.Landscape});
            this.itemsTable.Location = new System.Drawing.Point(717, 182);
            this.itemsTable.Name = "itemsTable";
            this.itemsTable.ReadOnly = true;
            this.itemsTable.RowHeadersWidth = 51;
            this.itemsTable.RowTemplate.Height = 24;
            this.itemsTable.Size = new System.Drawing.Size(608, 374);
            this.itemsTable.TabIndex = 14;
            this.itemsTable.DoubleClick += new System.EventHandler(this.itemsTable_DoubleClick);
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.MinimumWidth = 6;
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 125;
            // 
            // Id_item
            // 
            this.Id_item.DataPropertyName = "Id_item";
            this.Id_item.HeaderText = "Id_item";
            this.Id_item.MinimumWidth = 6;
            this.Id_item.Name = "Id_item";
            this.Id_item.ReadOnly = true;
            this.Id_item.Visible = false;
            this.Id_item.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // Event
            // 
            this.Event.DataPropertyName = "Event";
            this.Event.HeaderText = "Event";
            this.Event.MinimumWidth = 6;
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            this.Event.Width = 125;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Width = 125;
            // 
            // Landscape
            // 
            this.Landscape.DataPropertyName = "Landscape";
            this.Landscape.HeaderText = "Landscape";
            this.Landscape.MinimumWidth = 6;
            this.Landscape.Name = "Landscape";
            this.Landscape.ReadOnly = true;
            this.Landscape.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1458, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Country";
            // 
            // countryFilter
            // 
            this.countryFilter.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryFilter.Location = new System.Drawing.Point(1543, 403);
            this.countryFilter.Name = "countryFilter";
            this.countryFilter.Size = new System.Drawing.Size(144, 26);
            this.countryFilter.TabIndex = 22;
            // 
            // landscapeFilter
            // 
            this.landscapeFilter.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landscapeFilter.Location = new System.Drawing.Point(1543, 350);
            this.landscapeFilter.Name = "landscapeFilter";
            this.landscapeFilter.Size = new System.Drawing.Size(144, 26);
            this.landscapeFilter.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1458, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Landscape";
            // 
            // eventFilter
            // 
            this.eventFilter.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventFilter.Location = new System.Drawing.Point(1542, 299);
            this.eventFilter.Name = "eventFilter";
            this.eventFilter.Size = new System.Drawing.Size(145, 26);
            this.eventFilter.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1458, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Event";
            // 
            // dateFilter
            // 
            this.dateFilter.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilter.Location = new System.Drawing.Point(1455, 182);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(200, 26);
            this.dateFilter.TabIndex = 15;
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.DarkViolet;
            this.filterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterButton.Location = new System.Drawing.Point(1542, 564);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(113, 46);
            this.filterButton.TabIndex = 24;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // messageAdded
            // 
            this.messageAdded.AutoSize = true;
            this.messageAdded.Location = new System.Drawing.Point(666, 465);
            this.messageAdded.Name = "messageAdded";
            this.messageAdded.Size = new System.Drawing.Size(8, 17);
            this.messageAdded.TabIndex = 25;
            this.messageAdded.Text = "\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Persons";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(171, 175);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(92, 17);
            this.dateLabel.TabIndex = 28;
            this.dateLabel.Text = "Created Date";
            // 
            // personsLabel
            // 
            this.personsLabel.AutoSize = true;
            this.personsLabel.Location = new System.Drawing.Point(171, 476);
            this.personsLabel.Name = "personsLabel";
            this.personsLabel.Size = new System.Drawing.Size(0, 17);
            this.personsLabel.TabIndex = 29;
            // 
            // addPersonText
            // 
            this.addPersonText.Location = new System.Drawing.Point(313, 437);
            this.addPersonText.Name = "addPersonText";
            this.addPersonText.Size = new System.Drawing.Size(181, 22);
            this.addPersonText.TabIndex = 30;
            // 
            // addPersonButton
            // 
            this.addPersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonButton.Location = new System.Drawing.Point(344, 468);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(38, 32);
            this.addPersonButton.TabIndex = 31;
            this.addPersonButton.Text = "+";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // filterPersons
            // 
            this.filterPersons.FormattingEnabled = true;
            this.filterPersons.ItemHeight = 16;
            this.filterPersons.Location = new System.Drawing.Point(1542, 464);
            this.filterPersons.Name = "filterPersons";
            this.filterPersons.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.filterPersons.Size = new System.Drawing.Size(181, 68);
            this.filterPersons.TabIndex = 32;
            // 
            // filterPersonsLabel
            // 
            this.filterPersonsLabel.AutoSize = true;
            this.filterPersonsLabel.Location = new System.Drawing.Point(1459, 464);
            this.filterPersonsLabel.Name = "filterPersonsLabel";
            this.filterPersonsLabel.Size = new System.Drawing.Size(60, 17);
            this.filterPersonsLabel.TabIndex = 33;
            this.filterPersonsLabel.Text = "Persons";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1459, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Type";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(818, 35);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(70, 17);
            this.titleLabel.TabIndex = 37;
            this.titleLabel.Text = "MyPhotos";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Purple;
            this.resetButton.ForeColor = System.Drawing.SystemColors.Control;
            this.resetButton.Location = new System.Drawing.Point(1783, 175);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(85, 44);
            this.resetButton.TabIndex = 38;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Location = new System.Drawing.Point(1667, 175);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(53, 21);
            this.yesRadio.TabIndex = 39;
            this.yesRadio.TabStop = true;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Location = new System.Drawing.Point(1667, 197);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(47, 21);
            this.noRadio.TabIndex = 40;
            this.noRadio.TabStop = true;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            // 
            // photoCheckbox
            // 
            this.photoCheckbox.AutoSize = true;
            this.photoCheckbox.Location = new System.Drawing.Point(1543, 229);
            this.photoCheckbox.Name = "photoCheckbox";
            this.photoCheckbox.Size = new System.Drawing.Size(67, 21);
            this.photoCheckbox.TabIndex = 41;
            this.photoCheckbox.Text = "Photo";
            this.photoCheckbox.UseVisualStyleBackColor = true;
            // 
            // videoCheckbox
            // 
            this.videoCheckbox.AutoSize = true;
            this.videoCheckbox.Location = new System.Drawing.Point(1543, 256);
            this.videoCheckbox.Name = "videoCheckbox";
            this.videoCheckbox.Size = new System.Drawing.Size(66, 21);
            this.videoCheckbox.TabIndex = 42;
            this.videoCheckbox.Text = "Video";
            this.videoCheckbox.UseVisualStyleBackColor = true;
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePersonButton.Location = new System.Drawing.Point(406, 468);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(43, 34);
            this.deletePersonButton.TabIndex = 43;
            this.deletePersonButton.Text = "-";
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(313, 535);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(228, 178);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 44;
            this.picture.TabStop = false;
            // 
            // video
            // 
            this.video.Enabled = true;
            this.video.Location = new System.Drawing.Point(282, 496);
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            this.video.Size = new System.Drawing.Size(337, 277);
            this.video.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1924, 699);
            this.Controls.Add(this.video);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.deletePersonButton);
            this.Controls.Add(this.videoCheckbox);
            this.Controls.Add(this.photoCheckbox);
            this.Controls.Add(this.noRadio);
            this.Controls.Add(this.yesRadio);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filterPersonsLabel);
            this.Controls.Add(this.filterPersons);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.addPersonText);
            this.Controls.Add(this.personsLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.messageAdded);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryFilter);
            this.Controls.Add(this.landscapeFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateFilter);
            this.Controls.Add(this.itemsTable);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.landscapeBox);
            this.Controls.Add(this.landscapeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.eventBox);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.datecreatedPicker);
            this.Controls.Add(this.filenameLabel);
            this.Controls.Add(this.uploadButton);
            this.Name = "Form1";
            this.Text = "MyPhotos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.DateTimePicker datecreatedPicker;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.TextBox eventBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label landscapeLabel;
        private System.Windows.Forms.TextBox landscapeBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView itemsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countryFilter;
        private System.Windows.Forms.TextBox landscapeFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eventFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateFilter;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label messageAdded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label personsLabel;
        private System.Windows.Forms.TextBox addPersonText;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.ListBox filterPersons;
        private System.Windows.Forms.Label filterPersonsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Landscape;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.CheckBox photoCheckbox;
        private System.Windows.Forms.CheckBox videoCheckbox;
        private System.Windows.Forms.Button deletePersonButton;
        private System.Windows.Forms.PictureBox picture;
        private AxWMPLib.AxWindowsMediaPlayer video;
    }
}

