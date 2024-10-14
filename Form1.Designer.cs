namespace m5_1
{
    partial class Form1
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
            this.canvas = new System.Windows.Forms.Panel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(2, 2);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(799, 449);
            this.canvas.TabIndex = 0;
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(23, 385);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(111, 41);
            this.btnLine.TabIndex = 1;
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(169, 385);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(111, 41);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "Круг";
            this.btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(316, 385);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(111, 40);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "Квадрат";
            this.btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(677, 386);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Рисовалка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnClear;
    }
}

