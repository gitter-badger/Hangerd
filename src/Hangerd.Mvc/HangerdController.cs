﻿using Hangerd.Extensions;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Hangerd.Mvc
{
	public class HangerdController : Controller
	{
		protected ActionResult AlertAndRedirect(string message, string url)
		{
			var script = new StringBuilder();

			if (!string.IsNullOrWhiteSpace(message))
				script.AppendFormat("alert('{0}');", HttpUtility.UrlDecode(message));

			if (!string.IsNullOrWhiteSpace(url))
				script.AppendFormat("window.location.href='{0}';", HttpUtility.UrlDecode(url));

			return Content(string.Format("<script type='text/javascript'>{0}</script>", script));
		}

		protected ContentResult JsonContent(object obj)
		{
			var json = obj == null ? "null" : obj.ObjectToJson();

			return Content(json, "application/json");
		}
	}
}
