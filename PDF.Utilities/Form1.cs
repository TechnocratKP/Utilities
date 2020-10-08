using System.Windows.Forms;

namespace PDFMergerProtector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pdfInputFiles_Click(object sender, System.EventArgs e)
        {
            pdfInputFilesDialog.ShowDialog();
        }

        private void btnMerge_Click(object sender, System.EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "pdf";
            saveDialog.Title = "Merge File Name";
            var result = saveDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                PDFMerger pdfMerger = new PDFMerger();
                pdfMerger.MergePDFs(saveDialog.FileName, pdfInputFilesDialog.FileNames);
            }
        }

        private void btnMergeProtect_Click(object sender, System.EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "pdf";
            saveDialog.Title = "Merge File Name";
            var result = saveDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                PDFMerger pdfMerger = new PDFMerger();
                PDFProtector pdfProtector = new PDFProtector();

                pdfMerger.MergePDFs(saveDialog.FileName, pdfInputFilesDialog.FileNames);
                pdfProtector.Protect(saveDialog.FileName, txtPassword.Text);
            }
        }
    }
}