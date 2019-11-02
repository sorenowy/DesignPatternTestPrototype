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
            RedCell cell = new RedCell();
            RedCell cell2 = (RedCell)cell.Clone();
            WhiteCell cell3 = new WhiteCell();
            WhiteCell cell4 = (WhiteCell)cell3.Clone();
            MessageBox.Show($"{ cell.Name},{ cell.Type}\n{cell2.Name},{cell2.Type}\n{cell3.Type},{cell3.Name}\n{cell4.Name},{cell4.Type}");
        }
    }
}
