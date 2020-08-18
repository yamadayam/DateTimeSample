namespace DateTimeSample {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btNow = new System.Windows.Forms.Button();
            this.tbNowDisp = new System.Windows.Forms.TextBox();
            this.nudDayBeforeAfter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btBefore = new System.Windows.Forms.Button();
            this.btAfter = new System.Windows.Forms.Button();
            this.tbMonthDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMonthBeforeAfter = new System.Windows.Forms.NumericUpDown();
            this.tbUruu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btBirthdayMath = new System.Windows.Forms.Button();
            this.tbBirthdayDay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mcBirthday = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBeforeAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBeforeAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // btNow
            // 
            this.btNow.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btNow.Location = new System.Drawing.Point(44, 29);
            this.btNow.Name = "btNow";
            this.btNow.Size = new System.Drawing.Size(130, 39);
            this.btNow.TabIndex = 0;
            this.btNow.Text = "現在日時";
            this.btNow.UseVisualStyleBackColor = true;
            this.btNow.Click += new System.EventHandler(this.btNow_Click);
            // 
            // tbNowDisp
            // 
            this.tbNowDisp.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNowDisp.Location = new System.Drawing.Point(195, 29);
            this.tbNowDisp.Name = "tbNowDisp";
            this.tbNowDisp.Size = new System.Drawing.Size(362, 39);
            this.tbNowDisp.TabIndex = 1;
            // 
            // nudDayBeforeAfter
            // 
            this.nudDayBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.nudDayBeforeAfter.Location = new System.Drawing.Point(403, 98);
            this.nudDayBeforeAfter.Name = "nudDayBeforeAfter";
            this.nudDayBeforeAfter.Size = new System.Drawing.Size(101, 39);
            this.nudDayBeforeAfter.TabIndex = 2;
            this.nudDayBeforeAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label1.Location = new System.Drawing.Point(510, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "日";
            // 
            // btBefore
            // 
            this.btBefore.Enabled = false;
            this.btBefore.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btBefore.Location = new System.Drawing.Point(196, 148);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(55, 37);
            this.btBefore.TabIndex = 4;
            this.btBefore.Text = "前";
            this.btBefore.UseVisualStyleBackColor = true;
            this.btBefore.Click += new System.EventHandler(this.btBefore_Click);
            // 
            // btAfter
            // 
            this.btAfter.Enabled = false;
            this.btAfter.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btAfter.Location = new System.Drawing.Point(277, 148);
            this.btAfter.Name = "btAfter";
            this.btAfter.Size = new System.Drawing.Size(55, 37);
            this.btAfter.TabIndex = 4;
            this.btAfter.Text = "後";
            this.btAfter.UseVisualStyleBackColor = true;
            this.btAfter.Click += new System.EventHandler(this.btAfter_Click);
            // 
            // tbMonthDay
            // 
            this.tbMonthDay.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.tbMonthDay.Location = new System.Drawing.Point(196, 206);
            this.tbMonthDay.Name = "tbMonthDay";
            this.tbMonthDay.Size = new System.Drawing.Size(361, 39);
            this.tbMonthDay.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label2.Location = new System.Drawing.Point(308, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "ヵ月";
            // 
            // nudMonthBeforeAfter
            // 
            this.nudMonthBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.nudMonthBeforeAfter.Location = new System.Drawing.Point(195, 98);
            this.nudMonthBeforeAfter.Name = "nudMonthBeforeAfter";
            this.nudMonthBeforeAfter.Size = new System.Drawing.Size(101, 39);
            this.nudMonthBeforeAfter.TabIndex = 2;
            this.nudMonthBeforeAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbUruu
            // 
            this.tbUruu.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.tbUruu.Location = new System.Drawing.Point(196, 264);
            this.tbUruu.Name = "tbUruu";
            this.tbUruu.Size = new System.Drawing.Size(361, 39);
            this.tbUruu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label3.Location = new System.Drawing.Point(38, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "誕生日";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label8.Location = new System.Drawing.Point(279, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 33);
            this.label8.TabIndex = 7;
            this.label8.Text = "生まれてから";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label9.Location = new System.Drawing.Point(500, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 33);
            this.label9.TabIndex = 7;
            this.label9.Text = "日目です。";
            // 
            // btBirthdayMath
            // 
            this.btBirthdayMath.Enabled = false;
            this.btBirthdayMath.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.btBirthdayMath.Location = new System.Drawing.Point(286, 362);
            this.btBirthdayMath.Name = "btBirthdayMath";
            this.btBirthdayMath.Size = new System.Drawing.Size(154, 42);
            this.btBirthdayMath.TabIndex = 8;
            this.btBirthdayMath.Text = "日数計算";
            this.btBirthdayMath.UseVisualStyleBackColor = true;
            this.btBirthdayMath.Click += new System.EventHandler(this.btBirthdayMath_Click);
            // 
            // tbBirthdayDay
            // 
            this.tbBirthdayDay.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.tbBirthdayDay.Location = new System.Drawing.Point(286, 492);
            this.tbBirthdayDay.Name = "tbBirthdayDay";
            this.tbBirthdayDay.Size = new System.Drawing.Size(209, 39);
            this.tbBirthdayDay.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label10.Location = new System.Drawing.Point(38, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 33);
            this.label10.TabIndex = 9;
            this.label10.Text = "閏年判定";
            // 
            // mcBirthday
            // 
            this.mcBirthday.Location = new System.Drawing.Point(52, 392);
            this.mcBirthday.MaxSelectionCount = 1;
            this.mcBirthday.Name = "mcBirthday";
            this.mcBirthday.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 576);
            this.Controls.Add(this.mcBirthday);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btBirthdayMath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBirthdayDay);
            this.Controls.Add(this.tbUruu);
            this.Controls.Add(this.tbMonthDay);
            this.Controls.Add(this.btAfter);
            this.Controls.Add(this.btBefore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMonthBeforeAfter);
            this.Controls.Add(this.nudDayBeforeAfter);
            this.Controls.Add(this.tbNowDisp);
            this.Controls.Add(this.btNow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBeforeAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBeforeAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNow;
        private System.Windows.Forms.TextBox tbNowDisp;
        private System.Windows.Forms.NumericUpDown nudDayBeforeAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.Button btAfter;
        private System.Windows.Forms.TextBox tbMonthDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMonthBeforeAfter;
        private System.Windows.Forms.TextBox tbUruu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btBirthdayMath;
        private System.Windows.Forms.TextBox tbBirthdayDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar mcBirthday;
    }
}

