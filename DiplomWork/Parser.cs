using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DiplomWork
{
    class Parser
    {
        static public List<string> Parse(string filePath)
        {
            string[] text = new string[] { };
            //List<string> text = new List<string> { };
            Task read = Task.Run(() =>
            {
                try
                {
                    text = File.ReadAllLines(filePath);
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            });
            read.Wait();

            for(int i = 0; i < text.Length; i++)
            {
                text[i] = string.Join(" ", text[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            }
            //string[] res = new string[text.Length];
            List<string> res = new List<string> { };
            int index = 1;
            for(int i = 0; i < text.Length; i++)
            {
                index = 1;
                if (text[i].Split(' ', '\t').Length == 1)
                    continue;
                if (text[i].Split(' ', '\t')[0].Equals("Group:Contact:OR(OPEN,") ||
                    text[i].Split(' ', '\t')[0].Equals("Group:Switch:OR(ON,") ||
                    text[i].Split(' ', '\t')[0].Equals("Group:Rollershutter:OR(UP,"))
                    index++;
                try
                {
                    //res[i] = text[i].Split(' ', '\t')[1];
                    res.Add(text[i].Split(' ', '\t')[index]);
                }
                catch(IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                    return res;
                }
                
            }
            return res;
        }
    }
}
