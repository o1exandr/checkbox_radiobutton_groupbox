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
            this.groupBoxColor.Size = new System.Drawing.Size(263, 125);
            this.groupBoxColor.TabIndex = 6;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = " Колір автомобіля ";
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Location = new System.Drawing.Point(9, 94);
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
            this.radioPink.Location = new System.Drawing.Point(9, 71);
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
            this.lbDetails.Location = new System.Drawing.Point(18, 177);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(106, 13);
            this.lbDetails.TabIndex = 7;
            this.lbDetails.Text = "Деталі замовлення";
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(188, 177);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(90, 38);
            this.btOrder.TabIndex = 8;
            this.btOrder.Text = "Підтвердити замовлення";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 329);
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
    }
}

