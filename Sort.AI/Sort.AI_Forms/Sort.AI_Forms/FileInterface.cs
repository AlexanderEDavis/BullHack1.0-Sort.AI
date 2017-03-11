using System;
using System.IO;
using System.Windows.Forms;

public class FileInterface
{
    private void PopulateFromFolder(DirectoryInfo di, String basePath)
    {
        //Iterate through files in directory 'di'
        foreach (FileInfo file in di.GetFiles())
        {

        }
        //Recursively call PopulateFromFolder on each directory in root directory
        foreach (DirectoryInfo dir in di.GetDirectories())
        {
            PopulateFromFolder(dir, basePath);
        }
    }

    private void ProgramFolder(string path)
    {
        try
        {
            //Check if directory already exists
            if (Directory.Exists(path))
            {
                return;
            }
            //Create directory at path
            DirectoryInfo di = Directory.CreateDirectory(path);
        }
        //Catch errors and display message box with error message
        catch (Exception e)
        {
            MessageBox.Show(String.Format("The process failed: {0}", e.ToString()), "Folder creation failed");
        }
        finally { }
    }

    private void FileReader(FileInfo file)
    {

    }
}

