
namespace CasoEstudio2
{
    partial class Calculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMOD = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btmMultiply = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDeleteNumber = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnMemoryRecall = new System.Windows.Forms.Button();
            this.btnMemoryStorage = new System.Windows.Forms.Button();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.btnSumMemory = new System.Windows.Forms.Button();
            this.btnSubtractMemory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Control;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(9, 24);
            this.txtResultado.MaxLength = 12;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(321, 66);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(7, 360);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(7, 426);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(126, 60);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnMOD
            // 
            this.btnMOD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMOD.Location = new System.Drawing.Point(274, 294);
            this.btnMOD.Name = "btnMOD";
            this.btnMOD.Size = new System.Drawing.Size(60, 60);
            this.btnMOD.TabIndex = 3;
            this.btnMOD.Text = "MOD";
            this.btnMOD.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtract.Location = new System.Drawing.Point(202, 360);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(60, 60);
            this.btnSubtract.TabIndex = 4;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.clickOption);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(139, 360);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(73, 360);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btmMultiply
            // 
            this.btmMultiply.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btmMultiply.Location = new System.Drawing.Point(205, 294);
            this.btmMultiply.Name = "btmMultiply";
            this.btmMultiply.Size = new System.Drawing.Size(60, 60);
            this.btmMultiply.TabIndex = 7;
            this.btmMultiply.Text = "x";
            this.btmMultiply.UseVisualStyleBackColor = true;
            this.btmMultiply.Click += new System.EventHandler(this.clickOption);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSum.Location = new System.Drawing.Point(205, 426);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(60, 60);
            this.btnSum.TabIndex = 8;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.clickOption);
            // 
            // btnComma
            // 
            this.btnComma.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComma.Location = new System.Drawing.Point(139, 426);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(60, 60);
            this.btnComma.TabIndex = 9;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = true;
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTotal.Location = new System.Drawing.Point(274, 360);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(60, 126);
            this.btnTotal.TabIndex = 10;
            this.btnTotal.Text = "=";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(73, 294);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 60);
            this.button11.TabIndex = 13;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(139, 294);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 60);
            this.button12.TabIndex = 12;
            this.button12.Text = "6";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(7, 294);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(73, 228);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(60, 60);
            this.button14.TabIndex = 18;
            this.button14.Text = "8";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(139, 229);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(60, 60);
            this.button15.TabIndex = 17;
            this.button15.Text = "9";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button16.Location = new System.Drawing.Point(7, 228);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(60, 60);
            this.button16.TabIndex = 16;
            this.button16.Text = "7";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(205, 228);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 60);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.clickOption);
            // 
            // btnDeleteNumber
            // 
            this.btnDeleteNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteNumber.Location = new System.Drawing.Point(73, 162);
            this.btnDeleteNumber.Name = "btnDeleteNumber";
            this.btnDeleteNumber.Size = new System.Drawing.Size(60, 60);
            this.btnDeleteNumber.TabIndex = 23;
            this.btnDeleteNumber.Text = "CE";
            this.btnDeleteNumber.UseVisualStyleBackColor = true;
            this.btnDeleteNumber.Click += new System.EventHandler(this.btnDeleteNumber_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarTodo.Location = new System.Drawing.Point(139, 162);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(60, 60);
            this.btnEliminarTodo.TabIndex = 22;
            this.btnEliminarTodo.Text = "C";
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.Location = new System.Drawing.Point(7, 162);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(60, 60);
            this.btnQuit.TabIndex = 21;
            this.btnQuit.Text = "←";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChange.Location = new System.Drawing.Point(275, 229);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(60, 60);
            this.btnChange.TabIndex = 20;
            this.btnChange.Text = "±";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnMemoryRecall
            // 
            this.btnMemoryRecall.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMemoryRecall.Location = new System.Drawing.Point(73, 96);
            this.btnMemoryRecall.Name = "btnMemoryRecall";
            this.btnMemoryRecall.Size = new System.Drawing.Size(60, 60);
            this.btnMemoryRecall.TabIndex = 28;
            this.btnMemoryRecall.Text = "MR";
            this.btnMemoryRecall.UseVisualStyleBackColor = true;
            this.btnMemoryRecall.Click += new System.EventHandler(this.btnMemoryRecall_Click);
            // 
            // btnMemoryStorage
            // 
            this.btnMemoryStorage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMemoryStorage.Location = new System.Drawing.Point(139, 96);
            this.btnMemoryStorage.Name = "btnMemoryStorage";
            this.btnMemoryStorage.Size = new System.Drawing.Size(60, 60);
            this.btnMemoryStorage.TabIndex = 27;
            this.btnMemoryStorage.Text = "MS";
            this.btnMemoryStorage.UseVisualStyleBackColor = true;
            this.btnMemoryStorage.Click += new System.EventHandler(this.btnMemoryStorage_Click);
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMemoryClear.Location = new System.Drawing.Point(7, 96);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(60, 60);
            this.btnMemoryClear.TabIndex = 26;
            this.btnMemoryClear.Text = "MC";
            this.btnMemoryClear.UseVisualStyleBackColor = true;
            this.btnMemoryClear.Click += new System.EventHandler(this.btnMemoryClear_Click);
            // 
            // btnSumMemory
            // 
            this.btnSumMemory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSumMemory.Location = new System.Drawing.Point(205, 96);
            this.btnSumMemory.Name = "btnSumMemory";
            this.btnSumMemory.Size = new System.Drawing.Size(60, 60);
            this.btnSumMemory.TabIndex = 25;
            this.btnSumMemory.Text = "M+";
            this.btnSumMemory.UseVisualStyleBackColor = true;
            this.btnSumMemory.Click += new System.EventHandler(this.btnSumMemory_Click);
            // 
            // btnSubtractMemory
            // 
            this.btnSubtractMemory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtractMemory.Location = new System.Drawing.Point(275, 96);
            this.btnSubtractMemory.Name = "btnSubtractMemory";
            this.btnSubtractMemory.Size = new System.Drawing.Size(60, 60);
            this.btnSubtractMemory.TabIndex = 24;
            this.btnSubtractMemory.Text = "M-";
            this.btnSubtractMemory.UseVisualStyleBackColor = true;
            this.btnSubtractMemory.Click += new System.EventHandler(this.btnSubtractMemory_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 489);
            this.Controls.Add(this.btnMemoryRecall);
            this.Controls.Add(this.btnMemoryStorage);
            this.Controls.Add(this.btnMemoryClear);
            this.Controls.Add(this.btnSumMemory);
            this.Controls.Add(this.btnSubtractMemory);
            this.Controls.Add(this.btnDeleteNumber);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btmMultiply);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMOD);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtResultado);
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMOD;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btmMultiply;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnDeleteNumber;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnMemoryRecall;
        private System.Windows.Forms.Button btnMemoryStorage;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button btnSumMemory;
        private System.Windows.Forms.Button btnSubtractMemory;
    }
}

