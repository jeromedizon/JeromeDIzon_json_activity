namespace GroceryApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnView = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();

            // 
            // btnView
            // 
            btnView.Location = new System.Drawing.Point(50, 30);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(200, 50);
            btnView.TabIndex = 0;
            btnView.Text = "View Shopping List";
            btnView.UseVisualStyleBackColor = true;
            // Event handlers attached in Form1.cs

            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(50, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(200, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Grocery Items";
            btnAdd.UseVisualStyleBackColor = true;
            // Event handlers attached in Form1.cs

            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(300, 200);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Grocery App Menu";
            ResumeLayout(false);
        }
    }
}
