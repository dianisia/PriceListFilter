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
            this.panel1 = new System.Windows.Forms.Panel();
            this.manufactorInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.startFilter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.checkFilterByManufactor.Location = new System.Drawing.Point(3, 12);
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
            this.checkFIlterByName.Location = new System.Drawing.Point(3, 55);
            this.checkFIlterByName.Name = "checkFIlterByName";
            this.checkFIlterByName.Size = new System.Drawing.Size(119, 17);
            this.checkFIlterByName.TabIndex = 2;
            this.checkFIlterByName.Text = "По наименованию";
            this.checkFIlterByName.UseVisualStyleBackColor = true;
            this.checkFIlterByName.CheckedChanged += new System.EventHandler(this.checkFIlterByName_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startFilter);
            this.panel1.Controls.Add(this.nameInput);
            this.panel1.Controls.Add(this.manufactorInput);
            this.panel1.Controls.Add(this.checkFilterByManufactor);
            this.panel1.Controls.Add(this.checkFIlterByName);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 160);
            this.panel1.TabIndex = 3;
            // 
            // manufactorInput
            // 
            this.manufactorInput.Enabled = false;
            this.manufactorInput.Location = new System.Drawing.Point(131, 10);
            this.manufactorInput.Name = "manufactorInput";
            this.manufactorInput.Size = new System.Drawing.Size(428, 20);
            this.manufactorInput.TabIndex = 3;
            // 
            // nameInput
            // 
            this.nameInput.Enabled = false;
            this.nameInput.Location = new System.Drawing.Point(131, 55);
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
            this.startFilter.Location = new System.Drawing.Point(181, 105);
            this.startFilter.Name = "startFilter";
            this.startFilter.Size = new System.Drawing.Size(112, 33);
            this.startFilter.TabIndex = 5;
            this.startFilter.Text = "Фильтровать";
            this.startFilter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 308);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.openFile);
            this.Name = "Form1";
            this.Text = "Фильтр прайслиста";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.CheckBox checkFilterByManufactor;
        private System.Windows.Forms.CheckBox checkFIlterByName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox manufactorInput;
        private System.Windows.Forms.Button startFilter;
        private System.Windows.Forms.Label fileNameLabel;
    }
}

