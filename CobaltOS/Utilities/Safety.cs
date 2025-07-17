using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CobaltOS
{
    public static class Safety
    {

        public static void SearchForDuplicateFiles()
        {
            HashSet<string> HashSets = new HashSet<string>();
            bool duplicates = false;
            try
            {
                string[] files = Directory.GetFiles(@"C:\", "*.txt", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    using (var md5 = MD5.Create())
                    {
                        using (var stream = File.OpenRead(file!))
                        {
                            bool added = HashSets.Add(BitConverter.ToString(md5.ComputeHash(stream)));
                            if (!added)
                                duplicates = true;
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Debug.WriteLine("Acsess denied to file");
            }

            if (duplicates)
            {
                MessageBox.Show("Finished, dupes r here");
            }
            else
            {
                MessageBox.Show("Finished, no dupes");
            }
        }
    }
}