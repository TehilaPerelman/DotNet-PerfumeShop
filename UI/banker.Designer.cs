namespace UI
{
    partial class banker
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
            newOrder = new Button();
            prevPage = new Button();
            SuspendLayout();
            // 
            // newOrder
            // 
            newOrder.BackColor = SystemColors.ButtonHighlight;
            newOrder.Font = new Font("Agency FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            newOrder.ForeColor = Color.CornflowerBlue;
            newOrder.Location = new Point(1028, 452);
            newOrder.Name = "newOrder";
            newOrder.Size = new Size(211, 85);
            newOrder.TabIndex = 0;
            newOrder.Tag = "";
            newOrder.Text = "לביצוע הזמנה";
            newOrder.TextImageRelation = TextImageRelation.TextBeforeImage;
            newOrder.UseVisualStyleBackColor = false;
            newOrder.Click += newOrder_Click;
            // 
            // prevPage
            // 
            prevPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prevPage.Location = new Point(1138, 701);
            prevPage.Margin = new Padding(3, 2, 3, 2);
            prevPage.Name = "prevPage";
            prevPage.Size = new Size(138, 60);
            prevPage.TabIndex = 4;
            prevPage.Text = "לעמוד הקודם";
            prevPage.UseVisualStyleBackColor = true;
            prevPage.Click += prevPage_Click;
            // 
            // banker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4P;
            ClientSize = new Size(1316, 793);
            Controls.Add(prevPage);
            Controls.Add(newOrder);
            Name = "banker";
            Text = "banker";
            Load += banker_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button newOrder;
        private Button prevPage;
    }
}