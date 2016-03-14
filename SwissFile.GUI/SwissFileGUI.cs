using SwissFile.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissFile.GUI
{
    public partial class SwissFileGUI : Form
    {
        public SwissFileGUI()
        {
            InitializeComponent();

            // Setup extra copy form event handlers
            txt_Copy_SrcFile.TextChanged += Copy_UpdateStartButtonEnabledStatus;
            txt_Copy_DestFolder.TextChanged += Copy_UpdateStartButtonEnabledStatus;

            // Setup extra split form event handlers
            txt_Split_SrcFile.TextChanged += Split_UpdateStartButtonEnabledStatus;
        }

        #region Copy form

        private void Copy_UpdateStartButtonEnabledStatus(object sender, EventArgs e)
        {
            Copy_SetSubmitButtonStatus(!string.IsNullOrWhiteSpace(txt_Copy_DestFolder.Text) && !String.IsNullOrWhiteSpace(txt_Copy_SrcFile.Text));
        }

        private void btn_Copy_SrcFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
                Multiselect = false
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_Copy_SrcFile.Text = fileDialog.FileName;
            }
        }

        private void btn_Copy_DestFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog()
            {
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true
            };
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txt_Copy_DestFolder.Text = folderDialog.SelectedPath;
            }
        }

        private void btn_Copy_Start_Click(object sender, EventArgs e)
        {
            Copy_SetSubmitButtonStatus(false);
            string destinationFilePath = GetDestinationFilePath();
            var task = new CopyFileTask(new FileInfo(txt_Copy_SrcFile.Text), new FileInfo(destinationFilePath))
            {
                OverwriteDestinationFile = chk_Copy_OverwriteDest.Checked,
                DeleteSourceFileAfterCopy = chk_Copy_DeletSrcAfterCopy.Checked
            };
            task.ExecutionCompleted += (result) =>
            {
                if (result.Exception != null)
                {
                    MessageBox.Show(result.Exception.Message, "Error copying file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (chk_Copy_CloseOnSuccess.Checked)
                {
                    Application.Exit();
                }

                Copy_SetSubmitButtonStatus(true);
                MessageBox.Show("Success");
            };
            task.ExecuteAsync();
        }

        private void Copy_SetSubmitButtonStatus(bool enabled)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(delegate ()
                {
                    // re-call this method on the correct thread
                    Copy_SetSubmitButtonStatus(enabled);
                }));
            }
            else
            {
                btn_Copy_Start.Enabled = enabled;
            }
        }

        private string GetDestinationFilePath()
        {
            string fileName = String.IsNullOrWhiteSpace(txt_Copy_FnOverride.Text) ? Path.GetFileName(txt_Copy_SrcFile.Text) : txt_Copy_FnOverride.Text;
            return Path.Combine(txt_Copy_DestFolder.Text, fileName);
        }

        #endregion

        #region Split form

        private void Split_UpdateStartButtonEnabledStatus(object sender, EventArgs e)
        {
            Split_SetSubmitButtonStatus(!string.IsNullOrWhiteSpace(txt_Split_SrcFile.Text));
        }

        private void btn_Split_SelectSrcFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_Split_SrcFile.Text = fileDialog.FileName;
            }
        }

        private void btn_Split_SelectDestFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog()
            {
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true
            };
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txt_Split_DestFolder.Text = folderDialog.SelectedPath;
            }
        }

        private void btn_Split_Start_Click(object sender, EventArgs e)
        {
            Split_SetSubmitButtonStatus(false);

            // Get the destination folder path
            string destFolder = string.IsNullOrWhiteSpace(txt_Split_DestFolder.Text) ?
                Path.Combine(Path.GetDirectoryName(txt_Split_SrcFile.Text), Path.GetFileNameWithoutExtension(txt_Split_SrcFile.Text) + "_split")
                : txt_Split_DestFolder.Text;

            // Create the task
            var task = new SplitFileTask(new FileInfo(txt_Split_SrcFile.Text), new DirectoryInfo(destFolder))
            {
                PreserveTextLines = chk_Split_PreserveTextLines.Checked
            };
            if (!string.IsNullOrWhiteSpace(txt_Split_ExtOverride.Text))
            {
                task.FileExtension = txt_Split_ExtOverride.Text;
            }
            if (num_Split_MaxBytes.Value > 0)
            {
                task.MaxOutputFileByteSize = (long)num_Split_MaxBytes.Value;
            }
            task.ExecutionCompleted += (result) =>
            {
                if (result.Exception != null)
                {
                    MessageBox.Show(result.Exception.Message, "Error splitting file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (chk_Copy_CloseOnSuccess.Checked)
                {
                    Application.Exit();
                }

                Split_SetSubmitButtonStatus(true);
                MessageBox.Show("Success");
            };
            task.ExecuteAsync();
        }

        private void Split_SetSubmitButtonStatus(bool enabled)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(delegate ()
                {
                    // re-call this method on the correct thread
                    Split_SetSubmitButtonStatus(enabled);
                }));
            }
            else
            {
                btn_Split_Start.Enabled = enabled;
            }
        }

        #endregion
    }
}
