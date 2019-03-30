using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing.Domain.Entities.Enums;

namespace Testing.Views.Helpers
{
    public class ListViewAllColumnComparer : IComparer
    {
        private SortOrder SortOrder;
        public ListViewAllColumnComparer(SortOrder SortOrder)
        {
            this.SortOrder = SortOrder;
        }
        public int Compare(object x, object y)
        {
            ListViewItem itemX = x as ListViewItem;
            ListViewItem itemY = y as ListViewItem;
            for (int i = 0; i < itemX.SubItems.Count; i++ )
            {
                if (itemY.SubItems.Count <= i) return 1;

                string stringX = itemX.SubItems[i].Text;
                string stringY = itemY.SubItems[i].Text;
                int result = CompareValues(stringX, stringY);
                if (result != 0) return result;
            }
            return 0;
        }

        private int CompareValues(string stringX, string stringY)
        {
            int result;
            
            double doubleX, doubleY;
            if (double.TryParse(stringX, out doubleX) && double.TryParse(stringY, out doubleY))
            {
                result = doubleX.CompareTo(doubleY);
            }
            
            else
            {
                DateTime dateX, dateY;
                if (DateTime.TryParse(stringX, out dateX) &&
                    DateTime.TryParse(stringY, out dateY))
                {
                    // Treat as a date.
                    result = dateX.CompareTo(dateY);
                }
                else
                {
                    DaysEnum daysEnumX, daysEnumY;
                    if (Enum.TryParse(stringX, out daysEnumX) && Enum.TryParse(stringY, out daysEnumY))
                    {
                        // Treat as enum.
                        result = stringY.CompareTo(stringX);
                    }
                    else
                    {
                        // Treat as a string.
                        result = stringX.CompareTo(stringY);
                    }
                }
            }

            // Return the correct result depending on whether
            // we're sorting ascending or descending.
            if (SortOrder == SortOrder.Ascending)
            {
                return result;
            }
            else
            {
                return -result;
            }

        }
    }
}
