<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RobertsDatabase.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    .centre {
    margin: 0;
    
    position: absolute;
    top: 50%;
    left: 50%;
    margin-right: -50%;
    transform: translate(-50%, -50%) }
}
        </style>
     <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="centre">
            <h1>Roberts Login</h1>
              <table>
                <tr>
                    <th>Username</th>
                    <td><asp:TextBox ID="txtUser" runat="server" /></td>
                </tr>
                <tr>
                    <th>Password</th>
                    <td><asp:TextBox ID="txtPass" runat="server" TextMode="Password" /></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
                    
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
