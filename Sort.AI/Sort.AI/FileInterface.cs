using System;
using System.IO;
using System.Windows.Forms;
using Google.Cloud.Language.V1;
using System.Collections.Generic;
using Google.Api;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;

namespace Sort.AI
{
    public class FileInterface
    {
        public void PopulateFromFolder(DirectoryInfo di, String basePath)
        {
            //Iterate through files in directory 'di'
            foreach (FileInfo file in di.GetFiles())
            {
                //Read text from given file
                SortAISettings.ReadFiles(file.Name, file.FullName);
                //HTTP POST Request
                Analyze.AnalyzeEntitiesFromText(SortAISettings.fileRead);
            }
            //Recursively call PopulateFromFolder on each directory in root directory
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                PopulateFromFolder(dir, basePath);
            }
        }

        public void ProgramFolder(string path)
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
            finally
            {
            }
        }
    }

        public class Analyze
        {
            // [START analyze_entities_from_string]
            public static void AnalyzeEntitiesFromText(string text)
            {
                var client = LanguageServiceClient.Create();
                var response = client.AnalyzeEntities(new Document()
                {
                    Content = text,
                    Type = Document.Types.Type.PlainText
                });
                WriteEntities(response.Entities);
            }

        // [START analyze_entities_from_file]
        public static string WriteEntities(IEnumerable<Entity> entities)
        {
            string maxMentionsName = "";
            int maxMentionsNum = 0;
            if (entities != null)
            {
                //Console.WriteLine("Entities:");
                foreach (var entity in entities)
                {
                    int numMentions = 0;
                    if (numMentions < maxMentionsNum)
                    {
                        maxMentionsName = entity.Name;
                        maxMentionsNum = numMentions;
                    }
                    //Console.WriteLine($"\tName: {entity.Name}");
                    //Console.WriteLine($"\tType: {entity.Type}");
                    //Console.WriteLine($"\tSalience: {entity.Salience}");
                    //Console.WriteLine("\tMentions:");
                    foreach (var mention in entity.Mentions)
                    {
                        numMentions++;
                        //Console.WriteLine($"\t\t{mention.Text.BeginOffset}: {mention.Text.Content}");
                        //Console.WriteLine("\tMetadata:");
                        //foreach (var keyval in entity.Metadata)
                        //{
                        //    Console.WriteLine($"\t\t{keyval.Key}: {keyval.Value}");
                        //}
                    }
                }
            }
            return maxMentionsName;
        }
            // [END analyze_entities_from_file]
            // [END analyze_entities_from_string]
            
            public static void Main(string[] args)
            {
                if (args.Length < 2)
                {
                    Console.Write(Usage.Descriptor);
                    return;
                }
                string command = args[0].ToLower();
                string text = string.Join(" ",
                    new ArraySegment<string>(args, 1, args.Length - 1));
                string gcsUri = args[1].ToLower().StartsWith("gs://") ? args[1] : null;
                switch (command)
                {
                    case "entities":
                        if (null == gcsUri)
                            AnalyzeEntitiesFromText(text);
                        break;
                    default:
                        Console.Write(Usage.Descriptor);
                        return;
                }
            }
        }
    }