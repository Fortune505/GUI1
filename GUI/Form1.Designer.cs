namespace GUI
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
            textBoxSquare = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxCircle = new TextBox();
            buttonCompare = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // textBoxSquare
            // 
            textBoxSquare.Location = new Point(12, 37);
            textBoxSquare.Name = "textBoxSquare";
            textBoxSquare.Size = new Size(183, 27);
            textBoxSquare.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 1;
            label1.Text = "Ведите сторону квадрата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 2;
            label2.Text = "Ведите радиус круга";
            // 
            // textBoxCircle
            // 
            textBoxCircle.Location = new Point(12, 100);
            textBoxCircle.Name = "textBoxCircle";
            textBoxCircle.Size = new Size(183, 27);
            textBoxCircle.TabIndex = 3;
            // 
            // buttonCompare
            // 
            buttonCompare.Location = new Point(12, 146);
            buttonCompare.Name = "buttonCompare";
            buttonCompare.Size = new Size(183, 59);
            buttonCompare.TabIndex = 4;
            buttonCompare.Text = "Нажми на кнопку получишь результат";
            buttonCompare.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(12, 217);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 5;
            labelResult.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 319);
            Controls.Add(labelResult);
            Controls.Add(buttonCompare);
            Controls.Add(textBoxCircle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSquare);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSquare;
        private Label label1;
        private Label label2;
        private TextBox textBoxCircle;
        private Button buttonCompare;
        private Label labelResult;
    }
}
