﻿namespace Hangerd.Mvc.Extensions
{
	using Hangerd.Utility;
	using System.Web.Mvc;

	public static class HtmlExtention
	{
		public static MvcHtmlString IsSelected(this HtmlHelper helper, bool isSelected)
		{
			if (isSelected)
			{
				return new MvcHtmlString("selected='selected'");
			}

			return null;
		}

		public static MvcHtmlString IsChecked(this HtmlHelper helper, bool isChecked)
		{
			if (isChecked)
			{
				return new MvcHtmlString("checked='checked'");
			}

			return null;
		}

		public static MvcHtmlString IsVisible(this HtmlHelper helper, bool isVisible)
		{
			if (!isVisible)
			{
				return new MvcHtmlString("style='display:none;'");
			}

			return null;
		}

		public static string CutString(this HtmlHelper helper, string input, int limitLength, string suffix)
		{
			return CommonTools.CutString(input, limitLength, suffix);
		}
	}
}