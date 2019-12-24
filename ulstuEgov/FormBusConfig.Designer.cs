namespace ulstuEgov
{
    partial class FormBusConfig
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelBusWithAccord = new System.Windows.Forms.Label();
            this.labelBaseBus = new System.Windows.Forms.Label();
            this.pictureBoxCurBus = new System.Windows.Forms.PictureBox();
            this.panelSettingsBus = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurBus)).BeginInit();
            this.panelSettingsBus.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelBusWithAccord);
            this.groupBox.Controls.Add(this.labelBaseBus);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(227, 208);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Тип автобуса";
            // 
            // labelBusWithAccord
            // 
            this.labelBusWithAccord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBusWithAccord.Location = new System.Drawing.Point(14, 119);
            this.labelBusWithAccord.Name = "labelBusWithAccord";
            this.labelBusWithAccord.Size = new System.Drawing.Size(197, 71);
            this.labelBusWithAccord.TabIndex = 1;
            this.labelBusWithAccord.Text = "Автобус с Гармошкой";
            this.labelBusWithAccord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBusWithAccord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBusAccord_MouseDown);
            // 
            // labelBaseBus
            // 
            this.labelBaseBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseBus.Location = new System.Drawing.Point(14, 36);
            this.labelBaseBus.Name = "labelBaseBus";
            this.labelBaseBus.Size = new System.Drawing.Size(197, 71);
            this.labelBaseBus.TabIndex = 0;
            this.labelBaseBus.Text = "Автобус";
            this.labelBaseBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBus_MouseDown);
            // 
            // pictureBoxCurBus
            // 
            this.pictureBoxCurBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCurBus.Location = new System.Drawing.Point(15, 23);
            this.pictureBoxCurBus.Name = "pictureBoxCurBus";
            this.pictureBoxCurBus.Size = new System.Drawing.Size(274, 106);
            this.pictureBoxCurBus.TabIndex = 1;
            this.pictureBoxCurBus.TabStop = false;
            // 
            // panelSettingsBus
            // 
            this.panelSettingsBus.AllowDrop = true;
            this.panelSettingsBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettingsBus.Controls.Add(this.panel12);
            this.panelSettingsBus.Controls.Add(this.panel10);
            this.panelSettingsBus.Controls.Add(this.pictureBoxCurBus);
            this.panelSettingsBus.Location = new System.Drawing.Point(245, 12);
            this.panelSettingsBus.Name = "panelSettingsBus";
            this.panelSettingsBus.Size = new System.Drawing.Size(306, 325);
            this.panelSettingsBus.TabIndex = 2;
            this.panelSettingsBus.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.panelSettingsBus.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            // 
            // panel12
            // 
            this.panel12.AllowDrop = true;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.labelDopColor);
            this.panel12.Location = new System.Drawing.Point(15, 232);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(274, 73);
            this.panel12.TabIndex = 6;
            this.panel12.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.panel12.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.Location = new System.Drawing.Point(3, 3);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(266, 58);
            this.labelDopColor.TabIndex = 0;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.AllowDrop = true;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Location = new System.Drawing.Point(15, 149);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(274, 73);
            this.panel10.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.AllowDrop = true;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.labelMainColor);
            this.panel11.Location = new System.Drawing.Point(-1, -1);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(274, 73);
            this.panel11.TabIndex = 5;
            this.panel11.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.panel11.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.Location = new System.Drawing.Point(3, 3);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(266, 58);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 69);
            this.label3.TabIndex = 0;
            this.label3.Text = "Основной цвет";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Location = new System.Drawing.Point(572, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(181, 325);
            this.groupBoxColors.TabIndex = 3;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(111, 256);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(50, 50);
            this.panelOrange.TabIndex = 3;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Silver;
            this.panelGray.Location = new System.Drawing.Point(22, 256);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(50, 50);
            this.panelGray.TabIndex = 1;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(111, 183);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(50, 50);
            this.panelYellow.TabIndex = 4;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(22, 183);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(50, 50);
            this.panelRed.TabIndex = 1;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(111, 107);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(50, 50);
            this.panelBlue.TabIndex = 5;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(22, 107);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(50, 50);
            this.panelGreen.TabIndex = 1;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(111, 36);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(50, 50);
            this.panelWhite.TabIndex = 2;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(22, 36);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(50, 50);
            this.panelBlack.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(46, 245);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(133, 33);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(46, 285);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 33);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // FormBusConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 350);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelSettingsBus);
            this.Controls.Add(this.groupBox);
            this.Name = "FormBusConfig";
            this.Text = "FormBusConfig";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurBus)).EndInit();
            this.panelSettingsBus.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelBusWithAccord;
        private System.Windows.Forms.Label labelBaseBus;
        private System.Windows.Forms.PictureBox pictureBoxCurBus;
        private System.Windows.Forms.Panel panelSettingsBus;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
    }
}