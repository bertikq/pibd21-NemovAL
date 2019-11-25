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
            this.parkingBaseBus = new System.Windows.Forms.Button();
            this.parkingBusWithAccord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.getCar = new System.Windows.Forms.Button();
            this.maskedTextBoxIndex = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTerminal = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // parkingBaseBus
            // 
            this.parkingBaseBus.Location = new System.Drawing.Point(672, 40);
            this.parkingBaseBus.Name = "parkingBaseBus";
            this.parkingBaseBus.Size = new System.Drawing.Size(116, 68);
            this.parkingBaseBus.TabIndex = 1;
            this.parkingBaseBus.Text = "Припарковать автобус";
            this.parkingBaseBus.UseVisualStyleBackColor = true;
            this.parkingBaseBus.Click += new System.EventHandler(this.ParkingBaseBus_Click);
            // 
            // parkingBusWithAccord
            // 
            this.parkingBusWithAccord.Location = new System.Drawing.Point(672, 142);
            this.parkingBusWithAccord.Name = "parkingBusWithAccord";
            this.parkingBusWithAccord.Size = new System.Drawing.Size(116, 68);
            this.parkingBusWithAccord.TabIndex = 2;
            this.parkingBusWithAccord.Text = "Припарковать автобус с гармошкой";
            this.parkingBusWithAccord.UseVisualStyleBackColor = true;
            this.parkingBusWithAccord.Click += new System.EventHandler(this.ParkingBusWithAccord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTake);
            this.groupBox1.Controls.Add(this.getCar);
            this.groupBox1.Controls.Add(this.maskedTextBoxIndex);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(511, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать машину";
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
            this.pictureBoxTerminal.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTerminal.Name = "pictureBoxTerminal";
            this.pictureBoxTerminal.Size = new System.Drawing.Size(511, 450);
            this.pictureBoxTerminal.TabIndex = 0;
            this.pictureBoxTerminal.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(517, 5);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(149, 244);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.ListBoxLevels_SelectedIndexChanged);
            // 
            // FormBusTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.parkingBusWithAccord);
            this.Controls.Add(this.parkingBaseBus);
            this.Controls.Add(this.pictureBoxTerminal);
            this.Name = "FormBusTerminal";
            this.Text = "FormBusTerminal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTerminal;
        private System.Windows.Forms.Button parkingBaseBus;
        private System.Windows.Forms.Button parkingBusWithAccord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.Button getCar;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}