namespace Conscript
{
    partial class MainForm
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
            this.toolBarContainer = new System.Windows.Forms.SplitContainer();
            this.encodeDecodeSwitch = new System.Windows.Forms.Button();
            this.mainFormSplitContainer = new System.Windows.Forms.SplitContainer();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.inputBoxLabel = new System.Windows.Forms.Label();
            this.outputBoxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarContainer)).BeginInit();
            this.toolBarContainer.Panel1.SuspendLayout();
            this.toolBarContainer.Panel2.SuspendLayout();
            this.toolBarContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormSplitContainer)).BeginInit();
            this.mainFormSplitContainer.Panel1.SuspendLayout();
            this.mainFormSplitContainer.Panel2.SuspendLayout();
            this.mainFormSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBarContainer
            // 
            this.toolBarContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBarContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.toolBarContainer.IsSplitterFixed = true;
            this.toolBarContainer.Location = new System.Drawing.Point(0, 0);
            this.toolBarContainer.Name = "toolBarContainer";
            this.toolBarContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // toolBarContainer.Panel1
            // 
            this.toolBarContainer.Panel1.Controls.Add(this.outputBoxLabel);
            this.toolBarContainer.Panel1.Controls.Add(this.inputBoxLabel);
            this.toolBarContainer.Panel1.Controls.Add(this.encodeDecodeSwitch);
            // 
            // toolBarContainer.Panel2
            // 
            this.toolBarContainer.Panel2.Controls.Add(this.mainFormSplitContainer);
            this.toolBarContainer.Size = new System.Drawing.Size(1184, 473);
            this.toolBarContainer.SplitterDistance = 30;
            this.toolBarContainer.TabIndex = 1;
            // 
            // encodeDecodeSwitch
            // 
            this.encodeDecodeSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.encodeDecodeSwitch.Location = new System.Drawing.Point(552, 2);
            this.encodeDecodeSwitch.Name = "encodeDecodeSwitch";
            this.encodeDecodeSwitch.Size = new System.Drawing.Size(75, 25);
            this.encodeDecodeSwitch.TabIndex = 0;
            this.encodeDecodeSwitch.Text = "< === >";
            this.encodeDecodeSwitch.UseVisualStyleBackColor = true;
            this.encodeDecodeSwitch.Click += new System.EventHandler(this.encodeDecodeSwitch_Click);
            // 
            // mainFormSplitContainer
            // 
            this.mainFormSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormSplitContainer.IsSplitterFixed = true;
            this.mainFormSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainFormSplitContainer.Name = "mainFormSplitContainer";
            // 
            // mainFormSplitContainer.Panel1
            // 
            this.mainFormSplitContainer.Panel1.Controls.Add(this.inputTextBox);
            // 
            // mainFormSplitContainer.Panel2
            // 
            this.mainFormSplitContainer.Panel2.Controls.Add(this.outputTextBox);
            this.mainFormSplitContainer.Size = new System.Drawing.Size(1184, 439);
            this.mainFormSplitContainer.SplitterDistance = 586;
            this.mainFormSplitContainer.TabIndex = 1;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.inputTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(586, 439);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "";
            this.inputTextBox.TextChanged += new System.EventHandler(this.InputTextChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(0, 0);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(594, 439);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.Text = "";
            this.outputTextBox.WordWrap = false;
            // 
            // inputBoxLabel
            // 
            this.inputBoxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.inputBoxLabel.AutoSize = true;
            this.inputBoxLabel.Location = new System.Drawing.Point(460, 9);
            this.inputBoxLabel.Name = "inputBoxLabel";
            this.inputBoxLabel.Size = new System.Drawing.Size(41, 13);
            this.inputBoxLabel.TabIndex = 1;
            this.inputBoxLabel.Text = "English";
            // 
            // outputBoxLabel
            // 
            this.outputBoxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.outputBoxLabel.AutoSize = true;
            this.outputBoxLabel.Location = new System.Drawing.Point(664, 9);
            this.outputBoxLabel.Name = "outputBoxLabel";
            this.outputBoxLabel.Size = new System.Drawing.Size(63, 13);
            this.outputBoxLabel.TabIndex = 2;
            this.outputBoxLabel.Text = "Borderscript";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 473);
            this.Controls.Add(this.toolBarContainer);
            this.Name = "MainForm";
            this.Text = "Border Conscript";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolBarContainer.Panel1.ResumeLayout(false);
            this.toolBarContainer.Panel1.PerformLayout();
            this.toolBarContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolBarContainer)).EndInit();
            this.toolBarContainer.ResumeLayout(false);
            this.mainFormSplitContainer.Panel1.ResumeLayout(false);
            this.mainFormSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormSplitContainer)).EndInit();
            this.mainFormSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer toolBarContainer;
        private System.Windows.Forms.SplitContainer mainFormSplitContainer;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button encodeDecodeSwitch;
        private System.Windows.Forms.Label outputBoxLabel;
        private System.Windows.Forms.Label inputBoxLabel;
    }
}

