<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="CarritoCompra.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0,minimum-scale=1.0">
     <link rel="stylesheet" href="css/bootstrap.min.css" >
    <style type="text/css">
        .auto-style1 {
            width: 320px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table class="nav-justified">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DataList ID="DataList1" runat="server" BackColor="#CCCCFF" BorderColor="#FF5050" BorderStyle="Outset" BorderWidth="3px" CellPadding="4" ForeColor="#9292FA" GridLines="Horizontal" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" Height="217px" Width="349px" OnItemDataBound="DataList1_ItemDataBound">
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        <HeaderTemplate>
                            <table>
                                <thead>
                                    <tr>
                                        <th>Foto</th>
                                        <th>Descripcion</th>                                        
                                        <th>Precio</th>
                                    </tr>
                                </thead>
                                <tbody>
                              
                          
                        </HeaderTemplate>
                        <ItemStyle BackColor="#C0C3F0" />
                        <ItemTemplate>
                            <tr>
                                     <td style="width: 5px">
                                        <asp:Image ID="imgEmployee" ImageUrl='<%# Eval("Foto")%>' runat="server"/>
                                        
                                    </td>
                                       <td style="width: 5px">
                                            

                                <td><%#Eval("Descripcion") %></td>
                               
                                <td><%#Eval("Precio") %></td>

                            </tr>
                        </ItemTemplate>
                        <AlternatingItemStyle BackColor="#C0C3F0" BorderStyle="Double" />
                        <FooterStyle BackColor="#becefa" />
                        <FooterTemplate>
                            </tbody>
                           </table>
                        </FooterTemplate>
                      
                        <SelectedItemStyle BackColor="#C0C3F0" Font-Bold="True" ForeColor="White" />
                      
                    </asp:DataList>
                    <br />
&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="97px" />
                    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
