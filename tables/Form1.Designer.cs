namespace tables
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.left = new System.Windows.Forms.ComboBox();
            this.door = new System.Windows.Forms.ComboBox();
            this.right = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.left.FormattingEnabled = true;
            this.left.Items.AddRange(new object[] {
            "true",
            "false"});
            this.left.Location = new System.Drawing.Point(13, 13);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(62, 21);
            this.left.TabIndex = 0;
            // 
            // door
            // 
            this.door.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.door.FormattingEnabled = true;
            this.door.Items.AddRange(new object[] {
            "and",
            "or",
            "no",
            "nand",
            "nor",
            "xor",
            "xnor"});
            this.door.Location = new System.Drawing.Point(81, 13);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(104, 21);
            this.door.TabIndex = 1;
            // 
            // right
            // 
            this.right.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.right.FormattingEnabled = true;
            this.right.Items.AddRange(new object[] {
            "true",
            "false"});
            this.right.Location = new System.Drawing.Point(191, 12);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(62, 21);
            this.right.TabIndex = 2;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(260, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 3;
            this.button.Text = "OK";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 53);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 88);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button);
            this.Controls.Add(this.right);
            this.Controls.Add(this.door);
            this.Controls.Add(this.left);
            this.Name = "Form1";
            this.Text = "Tables de vérité";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox left;
        private System.Windows.Forms.ComboBox door;
        private System.Windows.Forms.ComboBox right;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label;

    }
}

