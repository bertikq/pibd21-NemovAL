namespace ulstuEgov
{
    partial class FormBusTerminal
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
            this.groupBoxGetCar = new System.Windows.Forms.GroupBox();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.getCar = new System.Windows.Forms.Button();
            this.maskedTextBoxIndex = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTerminal = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.selectAuto = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            this.groupBoxGetCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGetCar
            // 
            this.groupBoxGetCar.Controls.Add(this.pictureBoxTake);
            this.groupBoxGetCar.Controls.Add(this.getCar);
            this.groupBoxGetCar.Controls.Add(this.maskedTextBoxIndex);
            this.groupBoxGetCar.Controls.Add(this.label1);
            this.groupBoxGetCar.Location = new System.Drawing.Point(511, 248);
            this.groupBoxGetCar.Name = "groupBoxGetCar";
            this.groupBoxGetCar.Size = new System.Drawing.Size(277, 188);
            this.groupBoxGetCar.TabIndex = 3;
            this.groupBoxGetCar.TabStop = false;
            this.groupBoxGetCar.Text = "Забрать машину";
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(6, 97);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(277, 85);
            this.pictureBoxTake.TabIndex = 3;
            this.pictureBoxTake.TabStop = false;
            // 
            // getCar
            // 
            this.getCar.Location = new System.Drawing.Point(68, 69);
            this.getCar.Name = "getCar";
            this.getCar.Size = new System.Drawing.Size(113, 23);
            this.getCar.TabIndex = 2;
            this.getCar.Text = "Забрать";
            this.getCar.UseVisualStyleBackColor = true;
            this.getCar.Click += new System.EventHandler(this.GetCar_Click);
            // 
            // maskedTextBoxIndex
            // 
            this.maskedTextBoxIndex.Location = new System.Drawing.Point(118, 41);
            this.maskedTextBoxIndex.Name = "maskedTextBoxIndex";
            this.maskedTextBoxIndex.Size = new System.Drawing.Size(63, 22);
            this.maskedTextBoxIndex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место :";
            // 
            // pictureBoxTerminal
            // 
            this.pictureBoxTerminal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxTerminal.Location = new System.Drawing.Point(0, 30);
            this.pictureBoxTerminal.Name = "pictureBoxTerminal";
            this.pictureBoxTerminal.Size = new System.Drawing.Size(511, 420);
            this.pictureBoxTerminal.TabIndex = 0;
            this.pictureBoxTerminal.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(517, 37);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(149, 212);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.ListBoxLevels_SelectedIndexChanged);
            // 
            // selectAuto
            // 
            this.selectAuto.Location = new System.Drawing.Point(672, 201);
            this.selectAuto.Name = "selectAuto";
            this.selectAuto.Size = new System.Drawing.Size(116, 41);
            this.selectAuto.TabIndex = 5;
            this.selectAuto.Text = "Заказать авто";
            this.selectAuto.UseVisualStyleBackColor = true;
            this.selectAuto.Click += new System.EventHandler(this.SelectAuto_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 30);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "«txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "«txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(672, 163);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(116, 32);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // FormBusTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.selectAuto);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBoxGetCar);
            this.Controls.Add(this.pictureBoxTerminal);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormBusTerminal";
            this.Text = "FormBusTerminal";
            this.groupBoxGetCar.ResumeLayout(false);
            this.groupBoxGetCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTerminal;
        private System.Windows.Forms.GroupBox groupBoxGetCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.Button getCar;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button selectAuto;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}