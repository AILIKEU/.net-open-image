namespace OpenPhoto
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showPicBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showPicBox
            // 
            this.showPicBox.Location = new System.Drawing.Point(-2, 112);
            this.showPicBox.Name = "showPicBox";
            this.showPicBox.Size = new System.Drawing.Size(707, 449);
            this.showPicBox.TabIndex = 0;
            this.showPicBox.TabStop = false;
            this.showPicBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(245, 40);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(200, 30);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "打开图片";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.showPicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "打开图片";
            ((System.ComponentModel.ISupportInitialize)(this.showPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox showPicBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openBtn;
    }
}

