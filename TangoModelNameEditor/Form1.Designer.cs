namespace TangoModelNameEditor {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.open_button = new System.Windows.Forms.Button();
            this.file_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.save_name_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // open_button
            // 
            this.open_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.open_button.Location = new System.Drawing.Point(13, 13);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(259, 23);
            this.open_button.TabIndex = 0;
            this.open_button.Text = "Open Model Bin";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // file_label
            // 
            this.file_label.AutoSize = true;
            this.file_label.Location = new System.Drawing.Point(13, 43);
            this.file_label.Name = "file_label";
            this.file_label.Size = new System.Drawing.Size(35, 13);
            this.file_label.TabIndex = 1;
            this.file_label.Text = "label1";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(13, 60);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 2;
            // 
            // save_name_button
            // 
            this.save_name_button.Location = new System.Drawing.Point(119, 58);
            this.save_name_button.Name = "save_name_button";
            this.save_name_button.Size = new System.Drawing.Size(75, 23);
            this.save_name_button.TabIndex = 3;
            this.save_name_button.Text = "Save Name";
            this.save_name_button.UseVisualStyleBackColor = true;
            this.save_name_button.Click += new System.EventHandler(this.save_name_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.save_name_button);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.file_label);
            this.Controls.Add(this.open_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Label file_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button save_name_button;
    }
}

