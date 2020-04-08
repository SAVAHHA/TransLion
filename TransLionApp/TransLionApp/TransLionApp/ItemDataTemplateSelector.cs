using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TransLionApp
{
	public class ItemDataTemplateSelector : DataTemplateSelector
	{
		public DataTemplate NormalTemplate { get; set; }

		public DataTemplate SubTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			if (item is ShellItem && ((ShellItem)item).Route.Contains("header"))
			{
				return NormalTemplate;
			}
			else
			{
				return SubTemplate;
			}
		}
	}
}
