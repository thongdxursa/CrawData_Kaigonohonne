using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CrawData_Kaigonohonne.Controller
{
    public static class Libraries
    {
        public static string pathOrg = Path.Combine(@"C:/Users/" + Environment.UserName + "/Documents/", "Project/");
        public static string pathRoot = Path.Combine(pathOrg, "Data_Export_Craw_Kaigonohonne");
        public static string UrlRoot = "https://www.kaigonohonne.com/";
        public static int SkipCount = 30;
        private static Random random = new Random();
        public static string RandomString(int length = 20)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string str = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            str = str.ToLower();
            return str;
        }
        public static void ExportToJson(string path, object data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(path, json);

        }
        public static T FileToObjectJson<T>(string path)
        {
            try
            {
                string json = File.ReadAllText(path);
                var obj = JsonConvert.DeserializeObject<T>(json);
                return obj;
            }
            catch (Exception er)
            {

            }
            return default(T);
        }
        public static string CreateMD5HashFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return "";
            }
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }

            }
        }
        public static string GetLast(this string source, int tail_length)
        {
            if (tail_length >= source.Length)
                return source;
            return source.Substring(source.Length - tail_length);
        }
        public static String StripUnicodeCharactersFromFileName(this string inputValue)
        {
            String output = inputValue.ToLower().Trim();
            output = output.Replace('đ', 'd');
            StringBuilder newStringBuilder = new StringBuilder();
            newStringBuilder.Append(output.Normalize(NormalizationForm.FormKD).Where(x => x < 128).ToArray());
            output = newStringBuilder.ToString();
            output = output.Replace(" ", "_");

            output = Regex.Replace(output, "[^a-zA-Z0-9_.]", "");
            return output;
        }
        public static void openFileDialog(string title, string filter, string initPath, Action<string> actionOK)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = title;
            if (initPath != null && initPath.Length > 0)
            {
                fdlg.InitialDirectory = initPath;
            }
            fdlg.Filter = filter;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string path = fdlg.FileName;
                if (actionOK != null)
                {
                    actionOK(path);
                }
            }
        }
        public static void openFolderDialog(Action<string> actionOK)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //string[] files = Directory.GetFiles(fbd.SelectedPath);

                    string path = fbd.SelectedPath;
                    if (actionOK != null)
                    {
                        actionOK(path);
                    }
                }
            }
        }
        public static void AddResultListBox(string str, ListBox lbResults)
        {

            if (lbResults.InvokeRequired)
            {
                lbResults.Invoke(new Action(() =>
                {
                    if (str == null)
                    {
                        lbResults.Items.Clear();
                        return;
                    }
                    lbResults.Items.Add(str);
                }));
            }
            else
            {
                if (str == null)
                {
                    lbResults.Items.Clear();
                    return;
                }
                lbResults.Items.Add(str);
            }

        }

        public static string CheckExistFolderSave(string foldername)
        {
            if (!Directory.Exists(pathRoot))
            {
                Directory.CreateDirectory(pathRoot);
            }
            var folderpath = Path.Combine(pathRoot, foldername);
            if (!Directory.Exists(folderpath))
            {
                Directory.CreateDirectory(folderpath);
            }
            folderpath = folderpath.Replace(@"\\", @"\");
            return folderpath;
        }

        public static string FormatString(string text)
        {
            if (text == null)
            {
                return "";
            }
            text = text.Trim();
            text = text.Replace("\n", "");

            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            text = regex.Replace(text, " ");
            
            return text;
        }
        
    }
   
}
