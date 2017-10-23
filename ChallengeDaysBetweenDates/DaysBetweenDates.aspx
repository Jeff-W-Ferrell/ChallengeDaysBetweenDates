<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DaysBetweenDates.aspx.cs" Inherits="ChallengeDaysBetweenDates.DaysBetweenDates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        How many days have elapsed?<br />
        <br />
        Choose one date:<asp:Calendar ID="firstDateCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        Choose second date:<asp:Calendar ID="secondDateCalendar" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="timeSpanLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
