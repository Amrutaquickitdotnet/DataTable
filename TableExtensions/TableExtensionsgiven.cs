using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable.TableExtensions
{
	public class TableExtensionsgiven
	{
		public static Dictionary<string, string> ToDictionary(Table table)
		{
			var dictionary = new Dictionary<string, string>();

			foreach (var row in table.Rows)
			{

				dictionary.Add(row[0], row[1]);
			}
			return dictionary;
		}
	}
}
