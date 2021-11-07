using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ActiveLearn_DL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.description = new System.Windows.Forms.Label();
            this.descriptionL2 = new System.Windows.Forms.Label();
            this.tutorial = new System.Windows.Forms.LinkLabel();
            this.baseUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.bookName = new System.Windows.Forms.TextBox();
            this.bookLabel = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.ListBox();
            this.conv = new System.Windows.Forms.CheckBox();
            this.convertLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.rmTemp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.Transparent;
            this.description.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(13, 14);
            this.description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(648, 26);
            this.description.TabIndex = 0;
            this.description.Text = "Welcome to ActiveLearn-DL. This tool allows you to download books from Pearson Ac" + "tiveLearn.";
            this.description.Click += new System.EventHandler(this.label1_Click);
            // 
            // descriptionL2
            // 
            this.descriptionL2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionL2.ForeColor = System.Drawing.Color.White;
            this.descriptionL2.Location = new System.Drawing.Point(13, 40);
            this.descriptionL2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionL2.Name = "descriptionL2";
            this.descriptionL2.Size = new System.Drawing.Size(609, 17);
            this.descriptionL2.TabIndex = 1;
            this.descriptionL2.Text = "Please note that we are in no way, shape, or form endorsed by Pearson. This tool " + "is for educational purposes only.";
            this.descriptionL2.Click += new System.EventHandler(this.descriptionL2_Click);
            // 
            // tutorial
            // 
            this.tutorial.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.tutorial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.tutorial.Location = new System.Drawing.Point(13, 57);
            this.tutorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tutorial.Name = "tutorial";
            this.tutorial.Size = new System.Drawing.Size(320, 20);
            this.tutorial.TabIndex = 2;
            this.tutorial.TabStop = true;
            this.tutorial.Text = "How to obtain base URL";
            this.tutorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // baseUrl
            // 
            this.baseUrl.Location = new System.Drawing.Point(121, 79);
            this.baseUrl.Name = "baseUrl";
            this.baseUrl.Size = new System.Drawing.Size(530, 27);
            this.baseUrl.TabIndex = 3;
            this.baseUrl.Text = "https://pearsonactivelearn.com/123456789";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base URL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save location:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(121, 112);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(530, 27);
            this.saveLocation.TabIndex = 6;
            this.saveLocation.Text = "C:\\Users\\Ryder\\Desktop";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(13, 276);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(105, 30);
            this.start.TabIndex = 7;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(121, 145);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(530, 27);
            this.bookName.TabIndex = 8;
            // 
            // bookLabel
            // 
            this.bookLabel.ForeColor = System.Drawing.Color.White;
            this.bookLabel.Location = new System.Drawing.Point(13, 148);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(101, 25);
            this.bookLabel.TabIndex = 9;
            this.bookLabel.Text = "Book name:";
            // 
            // console
            // 
            this.console.FormattingEnabled = true;
            this.console.HorizontalScrollbar = true;
            this.console.ItemHeight = 20;
            this.console.Location = new System.Drawing.Point(13, 326);
            this.console.Name = "console";
            this.console.ScrollAlwaysVisible = true;
            this.console.Size = new System.Drawing.Size(638, 144);
            this.console.TabIndex = 10;
            // 
            // conv
            // 
            this.conv.Checked = true;
            this.conv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.conv.Location = new System.Drawing.Point(130, 208);
            this.conv.Name = "conv";
            this.conv.Size = new System.Drawing.Size(16, 35);
            this.conv.TabIndex = 11;
            this.conv.Text = "convert";
            this.conv.UseVisualStyleBackColor = true;
            this.conv.CheckedChanged += new System.EventHandler(this.conv_CheckedChanged);
            // 
            // convertLabel
            // 
            this.convertLabel.BackColor = System.Drawing.Color.Transparent;
            this.convertLabel.ForeColor = System.Drawing.Color.White;
            this.convertLabel.Location = new System.Drawing.Point(13, 214);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(111, 23);
            this.convertLabel.TabIndex = 12;
            this.convertLabel.Text = "Convert to PDF:";
            // 
            // deleteLabel
            // 
            this.deleteLabel.ForeColor = System.Drawing.Color.White;
            this.deleteLabel.Location = new System.Drawing.Point(13, 237);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(273, 25);
            this.deleteLabel.TabIndex = 13;
            this.deleteLabel.Text = "Delete temporary files after conversion:";
            // 
            // rmTemp
            // 
            this.rmTemp.Checked = true;
            this.rmTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rmTemp.Location = new System.Drawing.Point(292, 234);
            this.rmTemp.Name = "rmTemp";
            this.rmTemp.Size = new System.Drawing.Size(15, 29);
            this.rmTemp.TabIndex = 14;
            this.rmTemp.Text = "checkBox2";
            this.rmTemp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(663, 482);
            this.Controls.Add(this.rmTemp);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.convertLabel);
            this.Controls.Add(this.conv);
            this.Controls.Add(this.console);
            this.Controls.Add(this.bookLabel);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.start);
            this.Controls.Add(this.saveLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseUrl);
            this.Controls.Add(this.tutorial);
            this.Controls.Add(this.descriptionL2);
            this.Controls.Add(this.description);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActiveLearn-DL";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.LinkLabel tutorial;

        private System.Windows.Forms.CheckBox conv;

        private System.Windows.Forms.CheckBox rmTemp;

        private System.Windows.Forms.Label deleteLabel;

        private System.Windows.Forms.Label convertLabel;

        private System.Windows.Forms.Label bookLabel;

        private System.Windows.Forms.ListBox console;

        private System.Windows.Forms.TextBox bookName;

        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.TextBox baseUrl;

        private System.Windows.Forms.Button start;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label descriptionL2;

        private System.Windows.Forms.Label description;

        #endregion
        
    }
}