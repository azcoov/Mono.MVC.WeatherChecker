<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<% using( Html.BeginForm() ) { %>
		Enter zip code: <%= Html.TextBox("zip") %>
		<input type="submit" title="submit" value="submit">
	<% } %>
</body>