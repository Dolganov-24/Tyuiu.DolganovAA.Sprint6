namespace Tyuiu.DolganovAA.Sprint6.Task0.V27
{
    partial class FormMain
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
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxVarX = new GroupBox();
            textBoxVarX = new TextBox();
            groupBoxResult = new GroupBox();
            buttonQuestion = new Button();
            buttonOk = new Button();
            textBoxResult = new TextBox();
            pictureBoxFormula = new PictureBox();
            groupBoxTask.SuspendLayout();
            groupBoxVarX.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(9, 7);
            groupBoxTask.Margin = new Padding(3, 2, 3, 2);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Padding = new Padding(3, 2, 3, 2);
            groupBoxTask.Size = new Size(594, 142);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(0, 15);
            textBoxTask.Margin = new Padding(3, 2, 3, 2);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(312, 129);
            textBoxTask.TabIndex = 2;
            textBoxTask.Text = "Вычислить по формуле";
            // 
            // groupBoxVarX
            // 
            groupBoxVarX.Controls.Add(textBoxVarX);
            groupBoxVarX.Location = new Point(10, 218);
            groupBoxVarX.Margin = new Padding(3, 2, 3, 2);
            groupBoxVarX.Name = "groupBoxVarX";
            groupBoxVarX.Padding = new Padding(3, 2, 3, 2);
            groupBoxVarX.Size = new Size(294, 94);
            groupBoxVarX.TabIndex = 0;
            groupBoxVarX.TabStop = false;
            groupBoxVarX.Text = "Ввод данных:";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(12, 22);
            textBoxVarX.Margin = new Padding(3, 2, 3, 2);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(97, 23);
            textBoxVarX.TabIndex = 2;
            textBoxVarX.TextChanged += textBoxVarX_TextChanged;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(buttonQuestion);
            groupBoxResult.Controls.Add(buttonOk);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(390, 218);
            groupBoxResult.Margin = new Padding(3, 2, 3, 2);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Padding = new Padding(3, 2, 3, 2);
            groupBoxResult.Size = new Size(282, 94);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // buttonQuestion
            // 
            buttonQuestion.Location = new Point(18, 56);
            buttonQuestion.Margin = new Padding(3, 2, 3, 2);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(110, 34);
            buttonQuestion.TabIndex = 5;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(173, 56);
            buttonOk.Margin = new Padding(3, 2, 3, 2);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(92, 34);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "Выполнить";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(18, 20);
            textBoxResult.Margin = new Padding(3, 2, 3, 2);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(110, 23);
            textBoxResult.TabIndex = 3;
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Location = new Point(325, 21);
            pictureBoxFormula.Margin = new Padding(3, 2, 3, 2);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(271, 128);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBoxFormula);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxVarX);
            Controls.Add(groupBoxTask);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 27 | Тимонин И.А";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxVarX.ResumeLayout(false);
            groupBoxVarX.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxVarX;
        private GroupBox groupBoxResult;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxVarX;
        private Button buttonQuestion;
        private Button buttonOk;
        private TextBox textBoxResult;
    }
}