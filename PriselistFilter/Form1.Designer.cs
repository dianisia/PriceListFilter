namespace PriselistFilter
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.checkFilterByManufactor = new System.Windows.Forms.CheckBox();
            this.checkFIlterByName = new System.Windows.Forms.CheckBox();
            this.manufactorInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.startFilter = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.filterBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterProviderListRadio = new System.Windows.Forms.RadioButton();
            this.filterMyListRadio = new System.Windows.Forms.RadioButton();
            this.notIncludeNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openProviderFile = new System.Windows.Forms.Button();
            this.providerFileName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.markup = new System.Windows.Forms.TextBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filterBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(20, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(185, 39);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Открыть мой прайс-лист";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // checkFilterByManufactor
            // 
            this.checkFilterByManufactor.AutoSize = true;
            this.checkFilterByManufactor.Location = new System.Drawing.Point(14, 69);
            this.checkFilterByManufactor.Name = "checkFilterByManufactor";
            this.checkFilterByManufactor.Size = new System.Drawing.Size(122, 17);
            this.checkFilterByManufactor.TabIndex = 1;
            this.checkFilterByManufactor.Text = "По производителю";
            this.checkFilterByManufactor.UseVisualStyleBackColor = true;
            this.checkFilterByManufactor.CheckedChanged += new System.EventHandler(this.checkFilterByManufactor_CheckedChanged);
            // 
            // checkFIlterByName
            // 
            this.checkFIlterByName.AutoSize = true;
            this.checkFIlterByName.Location = new System.Drawing.Point(14, 113);
            this.checkFIlterByName.Name = "checkFIlterByName";
            this.checkFIlterByName.Size = new System.Drawing.Size(119, 17);
            this.checkFIlterByName.TabIndex = 2;
            this.checkFIlterByName.Text = "По наименованию";
            this.checkFIlterByName.UseVisualStyleBackColor = true;
            this.checkFIlterByName.CheckedChanged += new System.EventHandler(this.checkFIlterByName_CheckedChanged);
            // 
            // manufactorInput
            // 
            this.manufactorInput.Enabled = false;
            this.manufactorInput.Location = new System.Drawing.Point(142, 69);
            this.manufactorInput.Name = "manufactorInput";
            this.manufactorInput.Size = new System.Drawing.Size(428, 20);
            this.manufactorInput.TabIndex = 3;
            // 
            // nameInput
            // 
            this.nameInput.Enabled = false;
            this.nameInput.Location = new System.Drawing.Point(142, 129);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(428, 20);
            this.nameInput.TabIndex = 4;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(222, 25);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(64, 13);
            this.fileNameLabel.TabIndex = 4;
            this.fileNameLabel.Text = "Имя файла";
            // 
            // startFilter
            // 
            this.startFilter.Enabled = false;
            this.startFilter.Location = new System.Drawing.Point(211, 204);
            this.startFilter.Name = "startFilter";
            this.startFilter.Size = new System.Drawing.Size(112, 33);
            this.startFilter.TabIndex = 5;
            this.startFilter.Text = "Фильтровать";
            this.startFilter.UseVisualStyleBackColor = true;
            this.startFilter.Click += new System.EventHandler(this.startFilter_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(424, 204);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 33);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // filterBox
            // 
            this.filterBox.Controls.Add(this.groupBox1);
            this.filterBox.Controls.Add(this.notIncludeNameInput);
            this.filterBox.Controls.Add(this.label2);
            this.filterBox.Controls.Add(this.label1);
            this.filterBox.Controls.Add(this.saveButton);
            this.filterBox.Controls.Add(this.checkFilterByManufactor);
            this.filterBox.Controls.Add(this.startFilter);
            this.filterBox.Controls.Add(this.manufactorInput);
            this.filterBox.Controls.Add(this.nameInput);
            this.filterBox.Controls.Add(this.checkFIlterByName);
            this.filterBox.Location = new System.Drawing.Point(6, 17);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(675, 273);
            this.filterBox.TabIndex = 5;
            this.filterBox.TabStop = false;
            this.filterBox.Text = "Фильтрация";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterProviderListRadio);
            this.groupBox1.Controls.Add(this.filterMyListRadio);
            this.groupBox1.Location = new System.Drawing.Point(11, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 33);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Прайслист для фильтрации";
            // 
            // filterProviderListRadio
            // 
            this.filterProviderListRadio.AutoSize = true;
            this.filterProviderListRadio.Location = new System.Drawing.Point(109, 15);
            this.filterProviderListRadio.Name = "filterProviderListRadio";
            this.filterProviderListRadio.Size = new System.Drawing.Size(89, 17);
            this.filterProviderListRadio.TabIndex = 1;
            this.filterProviderListRadio.TabStop = true;
            this.filterProviderListRadio.Text = "Поставщика";
            this.filterProviderListRadio.UseVisualStyleBackColor = true;
            // 
            // filterMyListRadio
            // 
            this.filterMyListRadio.AutoSize = true;
            this.filterMyListRadio.Location = new System.Drawing.Point(7, 15);
            this.filterMyListRadio.Name = "filterMyListRadio";
            this.filterMyListRadio.Size = new System.Drawing.Size(46, 17);
            this.filterMyListRadio.TabIndex = 0;
            this.filterMyListRadio.TabStop = true;
            this.filterMyListRadio.Text = "Мой";
            this.filterMyListRadio.UseVisualStyleBackColor = true;
            // 
            // notIncludeNameInput
            // 
            this.notIncludeNameInput.Enabled = false;
            this.notIncludeNameInput.Location = new System.Drawing.Point(142, 168);
            this.notIncludeNameInput.Name = "notIncludeNameInput";
            this.notIncludeNameInput.Size = new System.Drawing.Size(428, 20);
            this.notIncludeNameInput.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Не содержит:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Содержит:";
            // 
            // openProviderFile
            // 
            this.openProviderFile.Location = new System.Drawing.Point(20, 57);
            this.openProviderFile.Name = "openProviderFile";
            this.openProviderFile.Size = new System.Drawing.Size(185, 39);
            this.openProviderFile.TabIndex = 6;
            this.openProviderFile.Text = "Открыть прайс-лист поставщика";
            this.openProviderFile.UseVisualStyleBackColor = true;
            this.openProviderFile.Click += new System.EventHandler(this.openProviderFile_Click);
            // 
            // providerFileName
            // 
            this.providerFileName.AutoSize = true;
            this.providerFileName.Location = new System.Drawing.Point(222, 70);
            this.providerFileName.Name = "providerFileName";
            this.providerFileName.Size = new System.Drawing.Size(64, 13);
            this.providerFileName.TabIndex = 7;
            this.providerFileName.Text = "Имя файла";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 353);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filterBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фильтрация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.markup);
            this.tabPage2.Controls.Add(this.compareButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сравнение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // markup
            // 
            this.markup.Location = new System.Drawing.Point(119, 30);
            this.markup.Name = "markup";
            this.markup.Size = new System.Drawing.Size(144, 20);
            this.markup.TabIndex = 2;
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(279, 23);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(106, 33);
            this.compareButton.TabIndex = 0;
            this.compareButton.Text = "Сравнить";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите наценку";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 488);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.providerFileName);
            this.Controls.Add(this.openProviderFile);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.openFile);
            this.Name = "Form1";
            this.Text = "Фильтр прайслиста";
            this.filterBox.ResumeLayout(false);
            this.filterBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.CheckBox checkFilterByManufactor;
        private System.Windows.Forms.CheckBox checkFIlterByName;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox manufactorInput;
        private System.Windows.Forms.Button startFilter;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox filterBox;
        private System.Windows.Forms.TextBox notIncludeNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openProviderFile;
        private System.Windows.Forms.Label providerFileName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton filterProviderListRadio;
        private System.Windows.Forms.RadioButton filterMyListRadio;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.TextBox markup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

