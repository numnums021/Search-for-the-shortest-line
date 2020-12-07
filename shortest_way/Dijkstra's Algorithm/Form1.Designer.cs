using System;

namespace Dijkstra_s_Algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxMatrix = new System.Windows.Forms.ListBox();
            this.Solve = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.buttonInc = new System.Windows.Forms.Button();
            this.buttonAdj = new System.Windows.Forms.Button();
            this.algBox = new System.Windows.Forms.ComboBox();
            this.timeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.drawEdgeButton = new System.Windows.Forms.Button();
            this.drawVertexButton = new System.Windows.Forms.Button();
            this.sheet = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMatrix
            // 
            this.listBoxMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMatrix.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxMatrix.FormattingEnabled = true;
            this.listBoxMatrix.ItemHeight = 20;
            this.listBoxMatrix.Location = new System.Drawing.Point(781, 14);
            this.listBoxMatrix.Name = "listBoxMatrix";
            this.listBoxMatrix.Size = new System.Drawing.Size(273, 344);
            this.listBoxMatrix.TabIndex = 6;
            // 
            // Solve
            // 
            this.Solve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Solve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Solve.Location = new System.Drawing.Point(12, 437);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(100, 39);
            this.Solve.TabIndex = 14;
            this.Solve.Text = "Поиск пути";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(132, 437);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(96, 39);
            this.delete.TabIndex = 15;
            this.delete.Text = "Очистить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(234, 437);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(96, 39);
            this.save.TabIndex = 16;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // buttonInc
            // 
            this.buttonInc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInc.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInc.Location = new System.Drawing.Point(781, 402);
            this.buttonInc.Name = "buttonInc";
            this.buttonInc.Size = new System.Drawing.Size(273, 31);
            this.buttonInc.TabIndex = 8;
            this.buttonInc.Text = "Инцидентности";
            this.buttonInc.UseVisualStyleBackColor = true;
            this.buttonInc.Click += new System.EventHandler(this.buttonInc_Click);
            // 
            // buttonAdj
            // 
            this.buttonAdj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdj.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdj.Location = new System.Drawing.Point(781, 364);
            this.buttonAdj.Name = "buttonAdj";
            this.buttonAdj.Size = new System.Drawing.Size(273, 31);
            this.buttonAdj.TabIndex = 7;
            this.buttonAdj.Text = "Смежности";
            this.buttonAdj.UseVisualStyleBackColor = true;
            this.buttonAdj.Click += new System.EventHandler(this.buttonAdj_Click);
            // 
            // algBox
            // 
            this.algBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.algBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.algBox.FormattingEnabled = true;
            this.algBox.Items.AddRange(new object[] {
            "Dijekstra",
            "Bellman",
            "Floyd"});
            this.algBox.Location = new System.Drawing.Point(5, 14);
            this.algBox.Name = "algBox";
            this.algBox.Size = new System.Drawing.Size(121, 31);
            this.algBox.TabIndex = 18;
            // 
            // timeTxt
            // 
            this.timeTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTxt.Location = new System.Drawing.Point(560, 445);
            this.timeTxt.Multiline = true;
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(215, 23);
            this.timeTxt.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(336, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Время работы алгоритма:";
            // 
            // selectButton
            // 
            this.selectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.selectButton.Image = global::Dijkstra_s_Algorithm.Properties.Resources._1;
            this.selectButton.Location = new System.Drawing.Point(31, 113);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(59, 59);
            this.selectButton.TabIndex = 9;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.Image = global::Dijkstra_s_Algorithm.Properties.Resources._4;
            this.deleteButton.Location = new System.Drawing.Point(31, 347);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(59, 59);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // drawEdgeButton
            // 
            this.drawEdgeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drawEdgeButton.Image = global::Dijkstra_s_Algorithm.Properties.Resources._3;
            this.drawEdgeButton.Location = new System.Drawing.Point(31, 269);
            this.drawEdgeButton.Name = "drawEdgeButton";
            this.drawEdgeButton.Size = new System.Drawing.Size(59, 59);
            this.drawEdgeButton.TabIndex = 2;
            this.drawEdgeButton.UseVisualStyleBackColor = true;
            this.drawEdgeButton.Click += new System.EventHandler(this.drawEdgeButton_Click);
            // 
            // drawVertexButton
            // 
            this.drawVertexButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.drawVertexButton.Image = global::Dijkstra_s_Algorithm.Properties.Resources._2;
            this.drawVertexButton.Location = new System.Drawing.Point(31, 191);
            this.drawVertexButton.Name = "drawVertexButton";
            this.drawVertexButton.Size = new System.Drawing.Size(59, 59);
            this.drawVertexButton.TabIndex = 1;
            this.drawVertexButton.UseVisualStyleBackColor = true;
            this.drawVertexButton.Click += new System.EventHandler(this.drawVertexButton_Click);
            // 
            // sheet
            // 
            this.sheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sheet.BackColor = System.Drawing.SystemColors.Window;
            this.sheet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sheet.Location = new System.Drawing.Point(132, 12);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(643, 421);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dijkstra_s_Algorithm.Properties.Resources.panel;
            this.pictureBox1.Location = new System.Drawing.Point(12, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 355);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1057, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.algBox);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.drawEdgeButton);
            this.Controls.Add(this.drawVertexButton);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.buttonInc);
            this.Controls.Add(this.buttonAdj);
            this.Controls.Add(this.listBoxMatrix);
            this.Controls.Add(this.sheet);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button drawVertexButton;
        private System.Windows.Forms.Button drawEdgeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox listBoxMatrix;
        private System.Windows.Forms.Button buttonAdj;
        private System.Windows.Forms.Button buttonInc;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox algBox;
        private System.Windows.Forms.TextBox timeTxt;
        private System.Windows.Forms.Label label1;
    }
}

