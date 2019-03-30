using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing.Domain.Entities.Infrastructure.Helpers
{
    public static class DataGridHelper
    {
        public static DataGridViewCell GetCellFromColumnHeader(this DataGridViewCellCollection CellCollection, string HeaderText)
        {
            return CellCollection.Cast<DataGridViewCell>().FirstOrDefault(c => c.OwningColumn.HeaderText == HeaderText);
        }
        public static DataGridViewCell GetCellFromColumnTag(this DataGridViewCellCollection CellCollection, string TagText)
        {
            return CellCollection.Cast<DataGridViewCell>().FirstOrDefault(c => c.OwningColumn.Tag.ToString() == TagText);
        }
    }
}
