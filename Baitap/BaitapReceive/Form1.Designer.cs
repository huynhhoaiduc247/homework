namespace BaitapReceive
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            this.lwvds = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btngoikham = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmaso = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.richTextBoxdiachi = new System.Windows.Forms.RichTextBox();
            this.richTextBoxnoidung = new System.Windows.Forms.RichTextBox();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnloadlst = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lwvds
            // 
            this.lwvds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lwvds.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.lwvds.Location = new System.Drawing.Point(12, 34);
            this.lwvds.Name = "lwvds";
            this.lwvds.Size = new System.Drawing.Size(196, 294);
            this.lwvds.TabIndex = 0;
            this.lwvds.UseCompatibleStateImageBehavior = false;
            this.lwvds.View = System.Windows.Forms.View.Details;
            this.lwvds.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lwvds_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách bệnh nhân";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btngoikham
            // 
            this.btngoikham.Location = new System.Drawing.Point(12, 387);
            this.btngoikham.Name = "btngoikham";
            this.btngoikham.Size = new System.Drawing.Size(89, 40);
            this.btngoikham.TabIndex = 2;
            this.btngoikham.Text = "Gọi khám";
            this.btngoikham.UseVisualStyleBackColor = true;
            this.btngoikham.Click += new System.EventHandler(this.btngoikham_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin bệnh nhân";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ tên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "CMND";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã số";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nội dung khám";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtmaso
            // 
            this.txtmaso.Location = new System.Drawing.Point(428, 37);
            this.txtmaso.Name = "txtmaso";
            this.txtmaso.Size = new System.Drawing.Size(240, 20);
            this.txtmaso.TabIndex = 9;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(428, 110);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(240, 20);
            this.txthoten.TabIndex = 10;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(428, 72);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(240, 20);
            this.txtcmnd.TabIndex = 11;
            // 
            // richTextBoxdiachi
            // 
            this.richTextBoxdiachi.Location = new System.Drawing.Point(428, 152);
            this.richTextBoxdiachi.Name = "richTextBoxdiachi";
            this.richTextBoxdiachi.Size = new System.Drawing.Size(318, 82);
            this.richTextBoxdiachi.TabIndex = 12;
            this.richTextBoxdiachi.Text = "";
            // 
            // richTextBoxnoidung
            // 
            this.richTextBoxnoidung.Location = new System.Drawing.Point(262, 263);
            this.richTextBoxnoidung.Name = "richTextBoxnoidung";
            this.richTextBoxnoidung.Size = new System.Drawing.Size(484, 119);
            this.richTextBoxnoidung.TabIndex = 13;
            this.richTextBoxnoidung.Text = "";
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(397, 405);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(196, 40);
            this.btncapnhat.TabIndex = 14;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnloadlst
            // 
            this.btnloadlst.Location = new System.Drawing.Point(115, 387);
            this.btnloadlst.Name = "btnloadlst";
            this.btnloadlst.Size = new System.Drawing.Size(93, 40);
            this.btnloadlst.TabIndex = 15;
            this.btnloadlst.Text = "Cập nhật danh sách";
            this.btnloadlst.UseVisualStyleBackColor = true;
            this.btnloadlst.Click += new System.EventHandler(this.btnloadlst_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(12, 331);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(196, 39);
            this.lblstatus.TabIndex = 16;
            this.lblstatus.Text = "-------";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 457);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnloadlst);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.richTextBoxnoidung);
            this.Controls.Add(this.richTextBoxdiachi);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmaso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngoikham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lwvds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwvds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngoikham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmaso;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.RichTextBox richTextBoxdiachi;
        private System.Windows.Forms.RichTextBox richTextBoxnoidung;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnloadlst;
        private System.Windows.Forms.Label lblstatus;
    }
}

