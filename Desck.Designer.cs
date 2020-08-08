namespace PlayingCards
{
    partial class Desck
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desck));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LoadCards = new System.Windows.Forms.ToolStripButton();
            this.StackCards = new System.Windows.Forms.ToolStripButton();
            this.DeckCards = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadCards,
            this.StackCards,
            this.DeckCards});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LoadCards
            // 
            this.LoadCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoadCards.Image = ((System.Drawing.Image)(resources.GetObject("LoadCards.Image")));
            this.LoadCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadCards.Name = "LoadCards";
            this.LoadCards.Size = new System.Drawing.Size(87, 28);
            this.LoadCards.Text = "Load Cards";
            this.LoadCards.Click += new System.EventHandler(this.LoadCards_Click);
            // 
            // StackCards
            // 
            this.StackCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StackCards.Image = ((System.Drawing.Image)(resources.GetObject("StackCards.Image")));
            this.StackCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StackCards.Name = "StackCards";
            this.StackCards.Size = new System.Drawing.Size(48, 28);
            this.StackCards.Text = "Stack";
            this.StackCards.Click += new System.EventHandler(this.StackCards_Click);
            // 
            // DeckCards
            // 
            this.DeckCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeckCards.Image = ((System.Drawing.Image)(resources.GetObject("DeckCards.Image")));
            this.DeckCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeckCards.Name = "DeckCards";
            this.DeckCards.Size = new System.Drawing.Size(46, 28);
            this.DeckCards.Text = "Deck";
            this.DeckCards.Click += new System.EventHandler(this.DeckCards_Click);
            // 
            // Desck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 554);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Desck";
            this.Text = "Desck";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton LoadCards;
        private System.Windows.Forms.ToolStripButton StackCards;
        private System.Windows.Forms.ToolStripButton DeckCards;
    }
}

