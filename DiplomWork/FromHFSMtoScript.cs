using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiplomWork.UserControls;
using DiplomWork.Triggers;
using DiplomWork.Actions;
using System.Windows.Forms;
using System.IO;

namespace DiplomWork
{
    public class FromHFSMtoScript
    {
        static public string GetScript(HierarchicalFSM HFSM)
        {
            List<string> ruleNames = new List<string>();
            StringBuilder script = new StringBuilder();
            foreach(ControlHierarchicalFSM StateHFSM in HFSM)
            {
                if(StateHFSM.ruleName == null)
                {
                    MessageBox.Show("Укажите название правил", "Ошибка");
                    return null;
                }
                else if (ruleNames.Contains(StateHFSM.ruleName))
                {
                    MessageBox.Show("Название правил совпадают", "Ошибка");
                    return null;
                }
                ruleNames.Add(StateHFSM.ruleName);
                script.Append("rule \"" + StateHFSM.ruleName + "\"\n");
                script.Append("when\n\t");
                ControlStateFSM StateFSM = StateHFSM.fsm.GetFirst();
                for (int i = 0; i < StateFSM.whenBlock.Count; i++)
                {
                    if (StateFSM.whenBlock[i] is TriggerItem)
                    {
                        switch (StateFSM.whenBlock[i].idTrigger)
                        {
                            case 0:
                                script.Append($"Item {StateFSM.whenBlock[i].device} received command {StateFSM.whenBlock[i].state}");
                                break;
                            case 1:
                                script.Append($"Item {StateFSM.whenBlock[i].device} received update {StateFSM.whenBlock[i].state}");
                                break;
                            case 2:
                                script.Append($"Item {StateFSM.whenBlock[i].device} changed from {StateFSM.whenBlock[i].prevState} to {StateFSM.whenBlock[i].state}");
                                break;
                        }
                    }
                    else if (StateFSM.whenBlock[i] is TriggerThing)
                    {
                        switch (StateFSM.whenBlock[i].idTrigger)
                        {
                            case 0:
                                script.Append($"Thing {StateFSM.whenBlock[i].device} received command {StateFSM.whenBlock[i].state}");
                                break;
                            case 1:
                                script.Append($"Thing {StateFSM.whenBlock[i].device} changed from {StateFSM.whenBlock[i].prevState} to {StateFSM.whenBlock[i].state}");
                                break;
                        }
                    }
                    else if (StateFSM.whenBlock[i] is TriggerTime)
                    {
                        switch (StateFSM.whenBlock[i].idTrigger)
                        {
                            case 0:
                                script.Append($"Time cron {StateFSM.whenBlock[i].time}");
                                break;
                            case 1:
                                script.Append($"Time is {StateFSM.whenBlock[i].time}");
                                break;
                        }
                    }
                    else if (StateFSM.whenBlock[i] is TriggerSystem)
                    {
                        script.Append($"System started");
                    }

                    if (i < StateFSM.whenBlock.Count - 1)
                    {
                        script.Append(" or ");
                    }
                }
                script.Append("\nthen\n");
                for (int i = 0; i < StateFSM.thenBlock.Count; i++)
                {
                    switch (StateFSM.thenBlock[i].idTrigger)
                    {
                        case 0:
                            script.Append($"\tsendCommand({StateFSM.thenBlock[i].device}, {StateFSM.thenBlock[i].state})\n");
                            break;
                        case 1:
                            script.Append($"\tpostUpdate({StateFSM.thenBlock[i].device}, {StateFSM.thenBlock[i].state})\n");
                            break;
                    }
                }
                foreach (ControlStateFSM LinkedState in StateFSM)
                {
                    if (LinkedState.whenBlock.Count == 0 || LinkedState.thenBlock.Count == 0)
                    {
                        MessageBox.Show("Пустое второстепенное состояние", "Ошибка");
                        return null;
                    }
                    script.Append("\tif (");
                    for (int i = 0; i < LinkedState.whenBlock.Count; i++)
                    {
                        switch (LinkedState.whenBlock[i].idTrigger)
                        {
                            case 0:
                                script.Append($"{LinkedState.whenBlock[i].device}.state == {LinkedState.whenBlock[i].state}");
                                break;
                            case 1:
                                script.Append($"{LinkedState.whenBlock[i].device}.state != {LinkedState.whenBlock[i].state}");
                                break;
                            case 2:
                                script.Append($"{LinkedState.whenBlock[i].device}.state > {LinkedState.whenBlock[i].state}");
                                break;
                            case 3:
                                script.Append($"{LinkedState.whenBlock[i].device}.state >= {LinkedState.whenBlock[i].state}");
                                break;
                            case 4:
                                script.Append($"{LinkedState.whenBlock[i].device}.state < {LinkedState.whenBlock[i].state}");
                                break;
                            case 5:
                                script.Append($"{LinkedState.whenBlock[i].device}.state <= {LinkedState.whenBlock[i].state}");
                                break;
                        }
                        if (i < LinkedState.whenBlock.Count - 1)
                        {
                            script.Append(" || ");
                        }
                        else
                        {
                            script.Append(") {\n");
                        }
                    }
                    for (int i = 0; i < LinkedState.thenBlock.Count; i++)
                    {
                        switch (LinkedState.thenBlock[i].idTrigger)
                        {
                            case 0:
                                script.Append($"\t\tsendCommand({LinkedState.thenBlock[i].device}, {LinkedState.thenBlock[i].state})\n");
                                break;
                            case 1:
                                script.Append($"\t\tpostUpdate({LinkedState.thenBlock[i].device}, {LinkedState.thenBlock[i].state})\n");
                                break;
                        }
                    }
                    script.Append("}\n");
                }
                script.Append("\nend\n\n");
            }
            return script.ToString();
        }

        static public bool CheckFile(string filePath)
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

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = string.Join(" ", text[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            }

            return true;
        }
    }
}
