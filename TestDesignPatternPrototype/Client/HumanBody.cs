using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestDesignPatternPrototype.Prototype;

namespace TestDesignPatternPrototype.Client
{
    public class HumanBody
    {
        public void CreateRedCell()
        {
            Cell cell = new RedCell();
            cell.Name = "Cell";
            cell.Type = "Default";
            Cell cell2 = (RedCell)cell.Clone();
            MessageBox.Show($"{ cell.Name},{ cell.Type},{cell2.Name},{cell2.Type}");
        }
    }
}
