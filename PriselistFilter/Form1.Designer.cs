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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notIncludeNameInput = new System.Windows.Forms.TextBox();
            this.filterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(12, 28);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(131, 39);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Выбрать файл";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // checkFilterByManufactor
            // 
            this.checkFilterByManufactor.AutoSize = true;
            this.checkFilterByManufactor.Location = new System.Drawing.Point(6, 19);
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
            this.checkFIlterByName.Location = new System.Drawing.Point(6, 63);
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
            this.manufactorInput.Location = new System.Drawing.Point(134, 19);
            this.manufactorInput.Name = "manufactorInput";
            this.manufactorInput.Size = new System.Drawing.Size(428, 20);
            this.manufactorInput.TabIndex = 3;
            // 
            // nameInput
            // 
            this.nameInput.Enabled = false;
            this.nameInput.Location = new System.Drawing.Point(134, 79);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(428, 20);
            this.nameInput.TabIndex = 4;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(177, 42);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 13);
            this.fileNameLabel.TabIndex = 4;
            // 
            // startFilter
            // 
            this.startFilter.Enabled = false;
            this.startFilter.Location = new System.Drawing.Point(134, 204);
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
            this.saveButton.Location = new System.Drawing.Point(324, 204);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 33);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // filterBox
            // 
            this.filterBox.Controls.Add(this.notIncludeNameInput);
            this.filterBox.Controls.Add(this.label2);
            this.filterBox.Controls.Add(this.label1);
            this.filterBox.Controls.Add(this.saveButton);
            this.filterBox.Controls.Add(this.checkFilterByManufactor);
            this.filterBox.Controls.Add(this.startFilter);
            this.filterBox.Controls.Add(this.manufactorInput);
            this.filterBox.Controls.Add(this.nameInput);
            this.filterBox.Controls.Add(this.checkFIlterByName);
            this.filterBox.Location = new System.Drawing.Point(12, 93);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(618, 255);
            this.filterBox.TabIndex = 5;
            this.filterBox.TabStop = false;
            this.filterBox.Text = "Фильтрация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Содержит:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Не содержит:";
            // 
            // notIncludeNameInput
            // 
            this.notIncludeNameInput.Enabled = false;
            this.notIncludeNameInput.Location = new System.Drawing.Point(134, 118);
            this.notIncludeNameInput.Name = "notIncludeNameInput";
            this.notIncludeNameInput.Size = new System.Drawing.Size(428, 20);
            this.notIncludeNameInput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 440);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.openFile);
            this.Name = "Form1";
            this.Text = "Фильтр прайслиста";
            this.filterBox.ResumeLayout(false);
            this.filterBox.PerformLayout();
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
    }
}

