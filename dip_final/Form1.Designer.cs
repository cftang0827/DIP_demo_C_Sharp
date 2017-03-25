namespace DIP_final
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.loadImage = new System.Windows.Forms.Button();
            this.camera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainImage2 = new System.Windows.Forms.PictureBox();
            this.maskDraw = new System.Windows.Forms.Button();
            this.inpaintStart = new System.Windows.Forms.Button();
            this.equalization = new System.Windows.Forms.Button();
            this.SeamlessStart = new System.Windows.Forms.Button();
            this.gammaCorrect = new System.Windows.Forms.Button();
            this.gammaNum = new System.Windows.Forms.NumericUpDown();
            this.cloneLocate = new System.Windows.Forms.Button();
            this.cloneImg = new System.Windows.Forms.PictureBox();
            this.mail = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.friendMailAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ownMailAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.greeting = new System.Windows.Forms.RichTextBox();
            this.showMail = new System.Windows.Forms.Label();
            this.median = new System.Windows.Forms.Button();
            this.medianNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianNum)).BeginInit();
            this.SuspendLayout();
            // 
            // loadImage
            // 
            this.loadImage.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loadImage.Location = new System.Drawing.Point(549, 28);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(99, 33);
            this.loadImage.TabIndex = 3;
            this.loadImage.Text = "Load image";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // camera
            // 
            this.camera.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.camera.Location = new System.Drawing.Point(549, 83);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(118, 32);
            this.camera.TabIndex = 4;
            this.camera.Text = "Open the camera";
            this.camera.UseVisualStyleBackColor = true;
            this.camera.Click += new System.EventHandler(this.camera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(545, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "狀態";
            // 
            // mainImage2
            // 
            this.mainImage2.Location = new System.Drawing.Point(29, 28);
            this.mainImage2.Name = "mainImage2";
            this.mainImage2.Size = new System.Drawing.Size(480, 640);
            this.mainImage2.TabIndex = 6;
            this.mainImage2.TabStop = false;
            this.mainImage2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainImage_MouseMove);
            // 
            // maskDraw
            // 
            this.maskDraw.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.maskDraw.Location = new System.Drawing.Point(549, 378);
            this.maskDraw.Name = "maskDraw";
            this.maskDraw.Size = new System.Drawing.Size(449, 132);
            this.maskDraw.TabIndex = 8;
            this.maskDraw.Text = "Mask";
            this.maskDraw.UseVisualStyleBackColor = true;
            this.maskDraw.Click += new System.EventHandler(this.drawMask);
            // 
            // inpaintStart
            // 
            this.inpaintStart.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.inpaintStart.Location = new System.Drawing.Point(549, 182);
            this.inpaintStart.Name = "inpaintStart";
            this.inpaintStart.Size = new System.Drawing.Size(99, 28);
            this.inpaintStart.TabIndex = 9;
            this.inpaintStart.Text = "Inpaint";
            this.inpaintStart.UseVisualStyleBackColor = true;
            this.inpaintStart.Click += new System.EventHandler(this.inpaintStart_Click);
            // 
            // equalization
            // 
            this.equalization.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.equalization.Location = new System.Drawing.Point(550, 225);
            this.equalization.Name = "equalization";
            this.equalization.Size = new System.Drawing.Size(99, 28);
            this.equalization.TabIndex = 12;
            this.equalization.Text = "Equalization";
            this.equalization.UseVisualStyleBackColor = true;
            this.equalization.Click += new System.EventHandler(this.equalization_Click);
            // 
            // SeamlessStart
            // 
            this.SeamlessStart.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SeamlessStart.Location = new System.Drawing.Point(549, 135);
            this.SeamlessStart.Name = "SeamlessStart";
            this.SeamlessStart.Size = new System.Drawing.Size(99, 28);
            this.SeamlessStart.TabIndex = 13;
            this.SeamlessStart.Text = "Seamless Cloning";
            this.SeamlessStart.UseVisualStyleBackColor = true;
            this.SeamlessStart.Click += new System.EventHandler(this.SeamlessStart_Click);
            // 
            // gammaCorrect
            // 
            this.gammaCorrect.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gammaCorrect.Location = new System.Drawing.Point(550, 269);
            this.gammaCorrect.Name = "gammaCorrect";
            this.gammaCorrect.Size = new System.Drawing.Size(99, 44);
            this.gammaCorrect.TabIndex = 14;
            this.gammaCorrect.Text = "Gamma correction";
            this.gammaCorrect.UseVisualStyleBackColor = true;
            this.gammaCorrect.Click += new System.EventHandler(this.gammaCorrect_Click);
            // 
            // gammaNum
            // 
            this.gammaNum.Location = new System.Drawing.Point(655, 269);
            this.gammaNum.Name = "gammaNum";
            this.gammaNum.Size = new System.Drawing.Size(44, 22);
            this.gammaNum.TabIndex = 15;
            // 
            // cloneLocate
            // 
            this.cloneLocate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cloneLocate.Location = new System.Drawing.Point(654, 134);
            this.cloneLocate.Name = "cloneLocate";
            this.cloneLocate.Size = new System.Drawing.Size(56, 28);
            this.cloneLocate.TabIndex = 18;
            this.cloneLocate.Text = "locate";
            this.cloneLocate.UseVisualStyleBackColor = true;
            this.cloneLocate.Click += new System.EventHandler(this.cloneLocate_Click);
            // 
            // cloneImg
            // 
            this.cloneImg.Location = new System.Drawing.Point(716, 28);
            this.cloneImg.Name = "cloneImg";
            this.cloneImg.Size = new System.Drawing.Size(282, 285);
            this.cloneImg.TabIndex = 19;
            this.cloneImg.TabStop = false;
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mail.Location = new System.Drawing.Point(1019, 322);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(75, 23);
            this.mail.TabIndex = 20;
            this.mail.Text = "發送信件";
            this.mail.UseVisualStyleBackColor = true;
            this.mail.Click += new System.EventHandler(this.mail_Click);
            // 
            // saveImage
            // 
            this.saveImage.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saveImage.Location = new System.Drawing.Point(1014, 28);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(75, 23);
            this.saveImage.TabIndex = 21;
            this.saveImage.Text = "存圖";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(1017, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "朋友的email: ";
            // 
            // friendMailAddress
            // 
            this.friendMailAddress.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendMailAddress.Location = new System.Drawing.Point(1095, 60);
            this.friendMailAddress.Name = "friendMailAddress";
            this.friendMailAddress.Size = new System.Drawing.Size(213, 23);
            this.friendMailAddress.TabIndex = 23;
            this.friendMailAddress.Text = "b00404017@ntu.edu.tw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(1017, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "自己的email: ";
            // 
            // ownMailAddress
            // 
            this.ownMailAddress.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ownMailAddress.Location = new System.Drawing.Point(1095, 100);
            this.ownMailAddress.Name = "ownMailAddress";
            this.ownMailAddress.Size = new System.Drawing.Size(213, 23);
            this.ownMailAddress.TabIndex = 25;
            this.ownMailAddress.Text = "cftang0827@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1057, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "大名:";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameBox.Location = new System.Drawing.Point(1095, 143);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(213, 23);
            this.nameBox.TabIndex = 27;
            this.nameBox.Text = "新垣結衣";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(1033, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "祝福的話:";
            // 
            // greeting
            // 
            this.greeting.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.greeting.Location = new System.Drawing.Point(1095, 193);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(213, 123);
            this.greeting.TabIndex = 29;
            this.greeting.Text = "我們剛剛才在微笑四方相遇，這是我資訊唷~希望能夠變成朋友";
            // 
            // showMail
            // 
            this.showMail.AutoSize = true;
            this.showMail.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showMail.Location = new System.Drawing.Point(1019, 378);
            this.showMail.Name = "showMail";
            this.showMail.Size = new System.Drawing.Size(149, 27);
            this.showMail.TabIndex = 30;
            this.showMail.Text = "尚未寄出email";
            // 
            // median
            // 
            this.median.Location = new System.Drawing.Point(550, 321);
            this.median.Name = "median";
            this.median.Size = new System.Drawing.Size(98, 37);
            this.median.TabIndex = 31;
            this.median.Text = "Median";
            this.median.UseVisualStyleBackColor = true;
            this.median.Click += new System.EventHandler(this.median_Click);
            // 
            // medianNum
            // 
            this.medianNum.Location = new System.Drawing.Point(655, 322);
            this.medianNum.Name = "medianNum";
            this.medianNum.Size = new System.Drawing.Size(44, 22);
            this.medianNum.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 686);
            this.Controls.Add(this.medianNum);
            this.Controls.Add(this.median);
            this.Controls.Add(this.showMail);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ownMailAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.friendMailAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.cloneImg);
            this.Controls.Add(this.cloneLocate);
            this.Controls.Add(this.gammaNum);
            this.Controls.Add(this.gammaCorrect);
            this.Controls.Add(this.SeamlessStart);
            this.Controls.Add(this.equalization);
            this.Controls.Add(this.inpaintStart);
            this.Controls.Add(this.maskDraw);
            this.Controls.Add(this.mainImage2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.camera);
            this.Controls.Add(this.loadImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Button camera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mainImage2;
        private System.Windows.Forms.Button maskDraw;
        private System.Windows.Forms.Button inpaintStart;
        private System.Windows.Forms.Button equalization;
        private System.Windows.Forms.Button SeamlessStart;
        private System.Windows.Forms.Button gammaCorrect;
        private System.Windows.Forms.NumericUpDown gammaNum;
        private System.Windows.Forms.Button cloneLocate;
        private System.Windows.Forms.PictureBox cloneImg;
        private System.Windows.Forms.Button mail;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox friendMailAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ownMailAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox greeting;
        private System.Windows.Forms.Label showMail;
        private System.Windows.Forms.Button median;
        private System.Windows.Forms.NumericUpDown medianNum;
    }
}

