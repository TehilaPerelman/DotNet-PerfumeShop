namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            manager = new Button();
            banker = new Button();
            SuspendLayout();
            // 
            // manager
            // 
            manager.BackColor = SystemColors.ControlLight;
            manager.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            manager.ForeColor = Color.DeepPink;
            manager.Location = new Point(203, 686);
            manager.Name = "manager";
            manager.Size = new Size(147, 74);
            manager.TabIndex = 0;
            manager.Text = "מנהל";
            manager.UseVisualStyleBackColor = false;
            manager.Click += button1_Click;
            // 
            // banker
            // 
            banker.BackColor = Color.Gainsboro;
            banker.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            banker.ForeColor = Color.DeepPink;
            banker.Location = new Point(50, 686);
            banker.Name = "banker";
            banker.Size = new Size(147, 74);
            banker.TabIndex = 1;
            banker.Text = "קופאי";
            banker.UseVisualStyleBackColor = false;
            banker.Click += banker_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1324, 831);
            Controls.Add(banker);
            Controls.Add(manager);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button manager;
        private Button banker;
    }
}
