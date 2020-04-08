using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TransLionApp.Controls
{
    public class MenuItemDataTemplateSelector: DataTemplateSelector
    {
		public DataTemplate SpaceTemplate { get; set; }

		public DataTemplate TitleTemplate { get; set; }

		public DataTemplate SubTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			return SubTemplate;
			//if (item is ShellItem && ((ShellItem)item).Route.Contains("header"))
			//{
			//	return NormalTemplate;
			//}
			//else
			//{
			//	return SubTemplate;
			//}
			//if (item is MenuItem && ((MenuItem)item).Comman)
			//{
			//	return SpaceTemplate;
			//}
			//else
			//{
			//	if (item is ShellItem && ((ShellItem)item).Route.Contains("sub"))
			//	{
			//		return SubTemplate;
			//	}
			//	else
			//	{
			//		return TitleTemplate;
			//	}
			//}

		}
	}
}
