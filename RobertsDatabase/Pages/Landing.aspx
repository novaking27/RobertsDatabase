<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Landing.aspx.cs" Inherits="RobertsDatabase.Landing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://code.jquery.com/mobile/1.4.5/jquery.mobile-1.4.5.min.css">
    <script src="https://code.jquery.com/jquery-1.11.3.min.js"></script>
    <script src="https://code.jquery.com/mobile/1.4.5/jquery.mobile-1.4.5.min.js"></script>

   <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
        th {
            border-bottom: 1px solid #d6d6d6;
        }

        tr:nth-child(even) {
            background: #e9e9e9;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%-- <div class="row">
                <div class="col-sm-12">

                    <asp:Button ID="btnlogout" runat="server" Text="Logout" OnClick="btnlogout_Click" />
                </div>
            </div>--%>
            <div class="row">
                <div class="col-sm-12">

                    <asp:TextBox ID="txtSearch" placeholder="Search" runat="server" Width="100%"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" Width="100%" />
                </div>
            </div>
            <div class="table-responsive">
                <table class="table">
                      <tbody>
                    <tr>
                        <td>
                            <asp:GridView ID="gvList" AutoGenerateColumns="false" runat="server" OnSelectedIndexChanged="gvList_SelectedIndexChanged" owStyle-Wrap="false" Width="100%">
                            <Columns>
                                <asp:CommandField ShowSelectButton="true" />
                                <asp:BoundField  DataField="Trade" HeaderText="Trade" />
	                            <asp:BoundField  DataField="Class" HeaderText="Class" />
                                <asp:BoundField  DataField="Description" HeaderText="Description" />
                                <asp:BoundField  DataField="Project" HeaderText="Project" />
                                <asp:BoundField  DataField="Ref" HeaderText="Ref" />
                                <asp:BoundField  DataField="Rate" HeaderText="Rate" />
                                <asp:BoundField  DataField="UoM" HeaderText="UOM" />
                            </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                          </tbody>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
