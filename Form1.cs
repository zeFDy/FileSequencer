using System.Diagnostics;

namespace FileSequencer
{
    public partial class Form1 : Form
    {
        private List<string>        zeFiles;


        public Form1()
        {
            InitializeComponent();
        }

        private void cbfDragDropCopyToB(object sender, DragEventArgs e)
        {
            Debug.WriteLine("cbfDragDropCopyToB");
            string[] destList = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (destList != null)
            {
                foreach (string destFile in destList)
                {
                    foreach(string srcFile in zeFiles)
                    {
                        Debug.Write("Copy ");
                        Debug.Write(srcFile);
                        Debug.Write(" To ");
                        Debug.WriteLine(destFile);
                    }
                }
            }
        }

        private void cbfDragEnterCopyToB(object sender, DragEventArgs e)
        {
            Debug.WriteLine("cbfDragEnterCopyToB");
            string[] destList = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (destList != null)
            {
                // check if only one item selected
                if (destList.Length > 1)
                {
                    e.Effect = DragDropEffects.None;
                    return;
                }

                // check if this item is a directory 
                FileInfo thisFileInfo = new FileInfo(destList[0]);
                if (thisFileInfo.Attributes == FileAttributes.Directory)
                {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                    return;
                }
            }
        }

        private void cbfDragDropMoveToB(object sender, DragEventArgs e)
        {
            Debug.WriteLine("cbfDragDropMoveToB");
            string[] destList = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (destList != null)
            {
                foreach (string file in destList)
                {
                    Debug.WriteLine(file); 
                }
            }
        }

        private void cbfDragEnterMoveToB(object sender, DragEventArgs e)
        {
            Debug.WriteLine("cbfDragEnterMoveToB");
            string[] destList = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (destList != null)
            {
                // check if only one item selected
                if(destList.Length > 1)
                {
                    e.Effect = DragDropEffects.None;
                    return;
                }

                // check if this item is a directory 
                FileInfo thisFileInfo = new FileInfo(destList[0]);
                if(thisFileInfo.Attributes == FileAttributes.Directory)
                {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                    return; 
                }
            }
        }

        private void cbfDragDropFromA(object sender, DragEventArgs e)
        {
            Debug.WriteLine("cbfDragDropFromA");
            string[] localFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            //localFiles.CopyTo(zeFiles, 0);
            //zeFiles = new List<string>();
            zeFiles = localFiles.ToList();

            if (localFiles != null)
            {
                foreach (string file in localFiles)
                {
                    Debug.WriteLine(file); 
                }
            }
        }

        private void cbfDragEnterFromA(object sender, DragEventArgs e)
        {
            Debug.WriteLine("cbfDragEnterFromA");
            string[] sFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (sFiles != null)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

    }
}
