using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TransLionApp.Controls
{
	public class ItemDataTemplateSelector : DataTemplateSelector
	{
		public DataTemplate NormalTemplate { get; set; }

		public DataTemplate SubTemplate { get; set; }

		//public DataTemplate SpaceTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			if (item is ShellItem && ((ShellItem)item).Route.Contains("header"))
			{
				return NormalTemplate;
			}
			else
			{
				//if (item is ShellItem && ((ShellItem)item).Route.Contains("space"))
				//{
				//	return SpaceTemplate;
				//}
				//else
				//{
				//	return SubTemplate;
				//}
				return SubTemplate;
			}
		}
	}
}
