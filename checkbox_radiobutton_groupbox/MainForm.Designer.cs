namespace checkbox_radiobutton_groupbox
{
    partial class fmMain
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
            this.chFloorMats = new System.Windows.Forms.CheckBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioPink = new System.Windows.Forms.RadioButton();
            this.radioYellow = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.lbDetails = new System.Windows.Forms.Label();
            this.btOrder = new System.Windows.Forms.Button();
            this.checkedBoxRadioOptions = new System.Windows.Forms.CheckedListBox();
            this.lbSound = new System.Windows.Forms.Label();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // chFloorMats
            // 
            this.chFloorMats.AutoSize = true;
            this.chFloorMats.Location = new System.Drawing.Point(13, 13);
            this.chFloorMats.Name = "chFloorMats";
            this.chFloorMats.Size = new System.Drawing.Size(157, 17);
            this.chFloorMats.TabIndex = 0;
            this.chFloorMats.Text = "Запасні коврики для авто";
            this.chFloorMats.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.radioRed);
            this.groupBoxColor.Controls.Add(this.radioPink);
            this.groupBoxColor.Controls.Add(this.radioYellow);
            this.groupBoxColor.Controls.Add(this.radioGreen);
            this.groupBoxColor.Location = new System.Drawing.Point(15, 45);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(209, 82);
            this.groupBoxColor.TabIndex = 6;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = " Колір автомобіля ";
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Location = new System.Drawing.Point(114, 48);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(75, 17);
            this.radioRed.TabIndex = 9;
            this.radioRed.TabStop = true;
            this.radioRed.Text = "Червоний";
            this.radioRed.UseVisualStyleBackColor = true;
            // 
            // radioPink
            // 
            this.radioPink.AutoSize = true;
            this.radioPink.Location = new System.Drawing.Point(114, 25);
            this.radioPink.Name = "radioPink";
            this.radioPink.Size = new System.Drawing.Size(70, 17);
            this.radioPink.TabIndex = 8;
            this.radioPink.TabStop = true;
            this.radioPink.Text = "Рожевий";
            this.radioPink.UseVisualStyleBackColor = true;
            // 
            // radioYellow
            // 
            this.radioYellow.AutoSize = true;
            this.radioYellow.Location = new System.Drawing.Point(9, 48);
            this.radioYellow.Name = "radioYellow";
            this.radioYellow.Size = new System.Drawing.Size(65, 17);
            this.radioYellow.TabIndex = 7;
            this.radioYellow.TabStop = true;
            this.radioYellow.Text = "Жовтий";
            this.radioYellow.UseVisualStyleBackColor = true;
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Location = new System.Drawing.Point(9, 25);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(68, 17);
            this.radioGreen.TabIndex = 6;
            this.radioGreen.TabStop = true;
            this.radioGreen.Text = "Зелений";
            this.radioGreen.UseVisualStyleBackColor = true;
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDetails.Location = new System.Drawing.Point(21, 249);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(123, 13);
            this.lbDetails.TabIndex = 7;
            this.lbDetails.Text = "Деталі замовлення";
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(134, 357);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(90, 38);
            this.btOrder.TabIndex = 8;
            this.btOrder.Text = "Підтвердити замовлення";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // checkedBoxRadioOptions
            // 
            this.checkedBoxRadioOptions.FormattingEnabled = true;
            this.checkedBoxRadioOptions.Items.AddRange(new object[] {
            "Фронтальна АС",
            "8-канальний звук",
            "CD-програвач",
            "Касетний програвач",
            "Тилова АС",
            "Ультра-бас (сабвуфер)"});
            this.checkedBoxRadioOptions.Location = new System.Drawing.Point(15, 150);
            this.checkedBoxRadioOptions.Name = "checkedBoxRadioOptions";
            this.checkedBoxRadioOptions.Size = new System.Drawing.Size(209, 94);
            this.checkedBoxRadioOptions.TabIndex = 9;
            // 
            // lbSound
            // 
            this.lbSound.AutoSize = true;
            this.lbSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSound.Location = new System.Drawing.Point(17, 133);
            this.lbSound.Name = "lbSound";
            this.lbSound.Size = new System.Drawing.Size(147, 13);
            this.lbSound.TabIndex = 10;
            this.lbSound.Text = "Опції звукової системи";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 405);
            this.Controls.Add(this.lbSound);
            this.Controls.Add(this.checkedBoxRadioOptions);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.lbDetails);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.chFloorMats);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Купівля нового авто";
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chFloorMats;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.RadioButton radioPink;
        private System.Windows.Forms.RadioButton radioYellow;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.CheckedListBox checkedBoxRadioOptions;
        private System.Windows.Forms.Label lbSound;
    }
}

