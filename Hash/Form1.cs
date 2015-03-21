using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Hash
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
            
            worker.DoWork += new DoWorkEventHandler(myWorker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myWorker_RunWorkerCompleted);
            worker.ProgressChanged += new ProgressChangedEventHandler(myWorker_ProgressChanged);
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
           
        }

        private void doCek() {
            OpenFileDialog d = new OpenFileDialog();
            DialogResult dres = d.ShowDialog();
            if (dres == DialogResult.OK)
            {
                string e = Utils.buatHash(d.FileName).ToUpper();
                Console.WriteLine(d.FileName + ": " + e);

            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) )
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            String[] data = (String[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var item in data)
            {
         
                String namafile = Path.GetFileName(item);
                ListViewItem it = new ListViewItem(namafile);
                it.SubItems.Add(item);
                listView1.Items.Add(it);

            }
        }
        private void cleanlayout() {
            flowlayout.SuspendLayout();

            if (flowlayout.Controls.Count > 0)
            {
                for (int i = (flowlayout.Controls.Count - 1); i >= 0; i--)
                {
                    Control c = flowlayout.Controls[i];                   
                    c.Dispose();
                }
                GC.Collect();
            }

            flowlayout.ResumeLayout();
        }
        class HashData {
            public string title, hash;
            public Boolean isdir;
        }
        private HashData doShit(ITEMDATA txt)
        {

                string file = txt.path;
                string hash;
                Boolean isdir = File.GetAttributes(file).HasFlag(FileAttributes.Directory);
                if (isdir)
                    hash = "Tidak bisa mencek hash folder";
                else
                {
                    try
                    {
                        Console.WriteLine(file);
                        hash = Utils.buatHash(file).ToUpper();
                    }
                    catch (Exception ex)
                    {
                        isdir = true;
                        hash = "Terjadi kesalahan";
                    }

                }
                Console.WriteLine("GetHashData");
                HashData h = new HashData();
                h.hash = hash;
                h.title = txt.nama;
                h.isdir = isdir;
            



                return h;

            
        }

        protected void myWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<ITEMDATA> coll = (List<ITEMDATA>)e.Argument;
            List<HashData> d = new List<HashData>();
            foreach (ITEMDATA item in coll)
            {
                HashData hd = new HashData();
                hd = doShit(item);
                d.Add(hd);
                worker.ReportProgress(0, hd);
           }
            e.Result = d;

        }
        protected void myWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
             isloading(false);
        }
        protected void myWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            HashData d = (HashData)e.UserState;
            CompareTextBox c = new CompareTextBox();
            c.setTitle(d.title);
            c.setHash(d.hash);
            c.isError(d.isdir);
            flowlayout.Controls.Add(c);
        }
        class ITEMDATA {
            public string path, nama;
            
        }
        private void isloading(Boolean loading) {
            pb.Visible = loading;
            tbl.Enabled = !loading;
            listView1.Enabled = !loading;
        }
        private void tbl_Click(object sender, EventArgs e)
        {

                cleanlayout();
                isloading(true);
                List<ITEMDATA> data = new List<ITEMDATA>();
                foreach (ListViewItem item in listView1.Items)
                {
                    ITEMDATA it = new ITEMDATA();
                    it.path = item.SubItems[1].Text;
                    it.nama = item.SubItems[0].Text;
                    data.Add(it);
                }

                    if (!worker.IsBusy)
                    {
                        worker.RunWorkerAsync(data);
                    }
            
              
           

        }

        private void hapusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }
        }

      
    }
}
