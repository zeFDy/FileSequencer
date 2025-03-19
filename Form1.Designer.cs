namespace FileSequencer
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
            listBox1 = new ListBox();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            groupBoxACopy = new GroupBox();
            groupBoxAMove = new GroupBox();
            groupBoxToB = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(457, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(668, 349);
            listBox1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(150, 100);
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Size = new Size(150, 100);
            splitContainer2.TabIndex = 0;
            // 
            // groupBoxACopy
            // 
            groupBoxACopy.Location = new Point(236, 12);
            groupBoxACopy.Name = "groupBoxBCopy";
            groupBoxACopy.Size = new Size(200, 165);
            groupBoxACopy.TabIndex = 1;
            groupBoxACopy.TabStop = false;
            groupBoxACopy.Text = "Copy to B";
            groupBoxACopy.AllowDrop = true;
            groupBoxACopy.DragDrop += cbfDragDropCopyToB;
            groupBoxACopy.DragEnter += cbfDragEnterCopyOrMoveToB;
            // 
            // groupBoxAMove
            // 
            groupBoxAMove.Location = new Point(236, 196);
            groupBoxAMove.Name = "groupBoxBMove";
            groupBoxAMove.Size = new Size(200, 165);
            groupBoxAMove.TabIndex = 2;
            groupBoxAMove.TabStop = false;
            groupBoxAMove.Text = "Move to B";
            groupBoxAMove.AllowDrop = true;
            groupBoxAMove.DragDrop += cbfDragDropMoveToB;
            groupBoxAMove.DragEnter += cbfDragEnterCopyOrMoveToB;
            // 
            // groupBoxToB
            // 
            groupBoxToB.Location = new Point(12, 12);
            groupBoxToB.Name = "groupBoxFromA";
            groupBoxToB.Size = new Size(200, 349);
            groupBoxToB.TabIndex = 3;
            groupBoxToB.TabStop = false;
            groupBoxToB.Text = "From A";
            groupBoxToB.AllowDrop = true;
            groupBoxToB.DragDrop += cbfDragDropFromA;
            groupBoxToB.DragEnter += cbfDragEnterFromA;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 375);
            Controls.Add(groupBoxToB);
            Controls.Add(groupBoxAMove);
            Controls.Add(groupBoxACopy);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private GroupBox groupBoxACopy;
        private GroupBox groupBoxAMove;
        private GroupBox groupBoxToB;
    }
}
