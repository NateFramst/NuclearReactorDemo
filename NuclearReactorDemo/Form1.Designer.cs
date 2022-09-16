namespace NuclearReactorDemo
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactorLabel1 = new System.Windows.Forms.Label();
            this.reactorLabel2 = new System.Windows.Forms.Label();
            this.reactorStateLabel1 = new System.Windows.Forms.Label();
            this.reactorStateLabel2 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(20, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(496, 94);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "NUCLEAR REACTOR CONTROL";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // reactorLabel1
            // 
            this.reactorLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactorLabel1.Location = new System.Drawing.Point(64, 103);
            this.reactorLabel1.Name = "reactorLabel1";
            this.reactorLabel1.Size = new System.Drawing.Size(100, 23);
            this.reactorLabel1.TabIndex = 1;
            this.reactorLabel1.Text = "Reactor 1";
            this.reactorLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reactorLabel2
            // 
            this.reactorLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactorLabel2.Location = new System.Drawing.Point(363, 103);
            this.reactorLabel2.Name = "reactorLabel2";
            this.reactorLabel2.Size = new System.Drawing.Size(100, 23);
            this.reactorLabel2.TabIndex = 2;
            this.reactorLabel2.Text = "Reactor 2";
            this.reactorLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reactorStateLabel1
            // 
            this.reactorStateLabel1.BackColor = System.Drawing.Color.Lime;
            this.reactorStateLabel1.Location = new System.Drawing.Point(349, 143);
            this.reactorStateLabel1.Name = "reactorStateLabel1";
            this.reactorStateLabel1.Size = new System.Drawing.Size(125, 68);
            this.reactorStateLabel1.TabIndex = 3;
            // 
            // reactorStateLabel2
            // 
            this.reactorStateLabel2.BackColor = System.Drawing.Color.Lime;
            this.reactorStateLabel2.Location = new System.Drawing.Point(53, 143);
            this.reactorStateLabel2.Name = "reactorStateLabel2";
            this.reactorStateLabel2.Size = new System.Drawing.Size(126, 68);
            this.reactorStateLabel2.TabIndex = 4;
            this.reactorStateLabel2.Click += new System.EventHandler(this.reactorStateLabel2_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(39, 286);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(453, 40);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Reactor Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Red;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.startButton.Location = new System.Drawing.Point(188, 227);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(139, 35);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start Reactors";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(528, 349);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactorStateLabel2);
            this.Controls.Add(this.reactorStateLabel1);
            this.Controls.Add(this.reactorLabel2);
            this.Controls.Add(this.reactorLabel1);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Nuclear Power Plant";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactorLabel1;
        private System.Windows.Forms.Label reactorLabel2;
        private System.Windows.Forms.Label reactorStateLabel1;
        private System.Windows.Forms.Label reactorStateLabel2;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button startButton;
    }
}

